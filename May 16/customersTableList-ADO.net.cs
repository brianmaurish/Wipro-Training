class CustomerDetails
{
    static void Main()
    {
        string connectionString =
            "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;"
            + "Integrated Security=true";

        string queryString =
            "SELECT ContactName, City, CompanyName from dbo.Customers ";
    
      

        //Create and open the connection in a using block.This
        using (SqlConnection connection = new SqlConnection(connectionString))
        {

            //create the command and parameter objects.
            SqlCommand command = new SqlCommand(queryString, connection);
          
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                Console.WriteLine("Contact Name\t\tCity\t\tCompany Name");
                Console.WriteLine("-------------------------------------------------------");
                while (reader.Read())
                {

                    string contactName = reader["ContactName"].ToString();
                    string city = reader["City"].ToString();
                    string companyName = reader["CompanyName"].ToString();

                    Console.WriteLine($"{contactName,-20} {city,-15} {companyName}");
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