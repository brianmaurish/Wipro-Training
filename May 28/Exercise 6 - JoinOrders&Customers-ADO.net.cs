using System.Data.SqlClient;

class Program
{
    static void Main()
    {
        string connectionString =
            "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;"
            + "Integrated Security=true";

        string queryString =
            "SELECT Orders.OrderID, Customers.CompanyName, orders.OrderDate FROM dbo.Orders JOIN dbo.Customers ON Customers.CustomerID = Orders.CustomerID";


        using (SqlConnection connection = new SqlConnection(connectionString))
        {

            SqlCommand command = new SqlCommand(queryString, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                Console.WriteLine($"{"OrderID",-10} {"CompanyName",-25} {"OrderDate",-12}");
                Console.WriteLine("-------------------------------------------------------");
                while (reader.Read())
                {

                    string orderID = reader["OrderID"].ToString();
                    string companyName = reader["CompanyName"].ToString();
                    string orderDate = Convert.ToDateTime(reader["OrderDate"]).ToShortDateString();

                    Console.WriteLine($"{orderID,-10} {companyName,-25} {orderDate,-12}");
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