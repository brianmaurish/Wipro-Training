using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

class ProductInsertion
{
    static void InsertProduct()
    {
        string connectionString =
            "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;"
            + "Integrated Security=true";

        string insertQuery = "INSERT INTO Products (ProductName, SupplierID, CategoryID, UnitPrice) " +
                             "VALUES (@ProductName, @SupplierID, @CategoryID, @UnitPrice)";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            SqlCommand command = new SqlCommand(insertQuery, connection);
            command.Parameters.AddWithValue("@ProductName", "Test Product");
            command.Parameters.AddWithValue("@SupplierID", 1);
            command.Parameters.AddWithValue("@CategoryID", 1);
            command.Parameters.AddWithValue("@UnitPrice", 25);

            try
            {
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                Console.WriteLine(rowsAffected > 0 ? "Product inserted successfully!" : "Insertion failed.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }

    static void Main()
    {
        InsertProduct();
    }
}