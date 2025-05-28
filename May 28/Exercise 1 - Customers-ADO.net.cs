using System.Data.SqlClient;

class CustomerDetails
{
    static void Main()
    {
        string connectionString =
            "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;"
            + "Integrated Security=true";

        string queryString =
            "SELECT * from dbo.Customers ";



        //Create and open the connection in a using block.This
        using (SqlConnection connection = new SqlConnection(connectionString))
        {

            //create the command and parameter objects.
            SqlCommand command = new SqlCommand(queryString, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                Console.WriteLine("CostomerID\t\tCompany Name\t\t\tCountry");
                Console.WriteLine("-------------------------------------------------------");
                while (reader.Read())
                {
                    string customerID= reader["CustomerID"].ToString();
                    string companyName = reader["CompanyName"].ToString();
                    string country = reader["Country"].ToString();



                    Console.WriteLine($"{customerID,-20} {companyName,-35} {country}");
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