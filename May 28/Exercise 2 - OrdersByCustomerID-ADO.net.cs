using System.Data.SqlClient;

class CustomerDetails
{
    static void GetOrderByCustomer(string customerID)
    {
        string connectionString =
            "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;"
            + "Integrated Security=true";

        string queryString =
        "SELECT OrderID, OrderDate, ShippedDate, ShipCountry FROM dbo.Orders WHERE CustomerID=@customerID";



        //Create and open the connection in a using block.This
        using (SqlConnection connection = new SqlConnection(connectionString))
        {

            //create the command and parameter objects.
            SqlCommand command = new SqlCommand(queryString, connection);
            command.Parameters.AddWithValue("@customerID", customerID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                Console.WriteLine("OrderID\t\tOrderDate\tShippedDate\tShipCountry");
                Console.WriteLine("-------------------------------------------------------");
                while (reader.Read())
                {
                    string orderID= reader["OrderID"].ToString();
                    string orderDate = Convert.ToDateTime (reader["OrderDate"]).ToShortDateString();
                    string shipDate = Convert.ToDateTime(reader["ShippedDate"]).ToShortDateString();
                    string shipCountry = reader["ShipCountry"].ToString();



                    Console.WriteLine($"{orderID,-15} {orderDate,-15} {shipDate,-15} {shipCountry}");
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
    static void Main()
    {
        Console.Write("Enter Customer ID: ");
        string customerID = Console.ReadLine();
        GetOrderByCustomer(customerID);
    }
}