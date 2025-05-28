using System.Data;
using System.Data.SqlClient;

class Program
{
    static void Main()
    {
        string connectionString =
            "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;"
            + "Integrated Security=true";

        string queryString =
            "SELECT * FROM Products WHERE UnitsInStock>28";

             DataSet dataSet = new DataSet();

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(queryString, connection);            
                adapter.Fill(dataSet, "Products"); // Loads into DataSet instead of DataTable

                DataTable dataTable = dataSet.Tables["Products"];

                Console.WriteLine("{0,-10} {1,-30} {2,-15} {3,-15} {4,-10}", "ProductID", "ProductName", "SupplierID", "CategoryID", "UnitsInStock");
                Console.WriteLine("----------------------------------------------------------------------");
                foreach (DataRow row in dataTable.Rows)
                {
                    Console.WriteLine("{0,-10} {1,-30} {2,-15} {3,-15} {4,-10}",
                         row["ProductID"], row["ProductName"], row["SupplierID"], row["CategoryID"], row["UnitsInStock"]);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}