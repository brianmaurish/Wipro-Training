class Program
{
    static void Main()
    {
        string connectionString =
            "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;"
            + "Integrated Security=true";

        string queryString =
            "SELECT Orders.OrderID, Orders.CustomerID, Orders.EmployeeID, Employees.FirstName, Employees.LastName FROM dbo.Orders JOIN dbo.Employees ON Employees.EmployeeID = Orders.EmployeeID";



        //Create and open the connection in a using block.This
        using (SqlConnection connection = new SqlConnection(connectionString))
        {

            //create the command and parameter objects.
            SqlCommand command = new SqlCommand(queryString, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                Console.WriteLine($"{"OrderID",-10} {"CustomerID",-15} {"EmployeeID",-12} {"FirstName",-15} {"LastName"}");
                Console.WriteLine("-------------------------------------------------------");
                while (reader.Read())
                {

                    string orderID = reader["OrderID"].ToString();
                    string customerID = reader["CustomerID"].ToString();
                    string employeeID = reader["EmployeeID"].ToString();
                    string firstName = reader["FirstName"].ToString();
                    string lastName = reader["LastName"].ToString();

                    Console.WriteLine($"{orderID,-10} {customerID,-15} {employeeID,-12} {firstName,-15} {lastName}");
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}