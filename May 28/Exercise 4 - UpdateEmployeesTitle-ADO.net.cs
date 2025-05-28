using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

class Program1
{
    static void UpdateEmployee(string employeeID, string newtitle)
    {
        string connectionString =
            "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;"
            + "Integrated Security=true";

        string deleteQuery = "UPDATE EMPLOYEES SET Title=@newtitle WHERE EmployeeID= @employeeID";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            SqlCommand command = new SqlCommand(deleteQuery, connection);
            command.Parameters.AddWithValue("@employeeID", employeeID);
            command.Parameters.AddWithValue("@newtitle", newtitle);

            try
            {
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                Console.WriteLine(rowsAffected > 0 ? "Updated successfully!" : "Updateion failed.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }

    static void Main()
    {
        Console.WriteLine("Enter the employee ID: ");
        string employeeID = Console.ReadLine();
        Console.WriteLine("Enter the title to update: ");
        string newtitle=Console.ReadLine();
        UpdateEmployee(employeeID, newtitle);
    }
}