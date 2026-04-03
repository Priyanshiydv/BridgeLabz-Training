using System;
using System.IO;
using System.Data.SqlClient;

class GenerateCSVFromDB
{
    static void Main()
    {
        string connStr = "your_connection_string_here";

        using (SqlConnection conn = new SqlConnection(connStr))
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Employees", conn);
            SqlDataReader reader = cmd.ExecuteReader();

            using (StreamWriter writer = new StreamWriter("employees_report.csv"))
            {
                writer.WriteLine("Employee ID,Name,Department,Salary");

                while (reader.Read())
                {
                    writer.WriteLine($"{reader[0]},{reader[1]},{reader[2]},{reader[3]}");
                }
            }
        }

        Console.WriteLine("CSV report generated!");
    }
}
