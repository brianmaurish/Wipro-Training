using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

class ProductInsertion
{
    static void InsertOrderWithDetails()
    {
        string connectionString =
            "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;"
            + "Integrated Security=true";

        string orderQuery = "INSERT INTO Orders (OrderID, CustomerID, EmployeeID) VALUES (@OrderID, @CustomerID, @EmployeeID)";
        string orderDetailsQuery = "INSERT INTO [Order Details] (OrderID, ProductID, UnitPrice, Quantity, Discount) VALUES (@OrderID, @ProductID, @UnitPrice, @Quantity, @Discount)";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            SqlTransaction transaction = connection.BeginTransaction();

            try
            {
                SqlCommand orderCommand = new SqlCommand(orderQuery, connection, transaction);
                orderCommand.Parameters.AddWithValue("@OrderID", 10247);
                orderCommand.Parameters.AddWithValue("@CustomerID", "VINET");
                orderCommand.Parameters.AddWithValue("@EmployeeID", 6);
                orderCommand.ExecuteNonQuery();

                SqlCommand orderDetailsCommand = new SqlCommand(orderDetailsQuery, connection, transaction);
                orderDetailsCommand.Parameters.AddWithValue("@OrderID", 10247);
                orderDetailsCommand.Parameters.AddWithValue("@ProductID", 11);
                orderDetailsCommand.Parameters.AddWithValue("@UnitPrice", 14.00);
                orderDetailsCommand.Parameters.AddWithValue("@Quantity", 10);
                orderDetailsCommand.Parameters.AddWithValue("@Discount", 0);
                orderDetailsCommand.ExecuteNonQuery();

                transaction.Commit();
                Console.WriteLine("Values Inserted");
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                Console.WriteLine("Transaction failed! Rolled back changes.");
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
    static void Main()
    {
        InsertOrderWithDetails();
    }
}