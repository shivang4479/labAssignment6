using System;
using System.Data.SqlClient;

class Fourth
{
    static void Main()
    {
        string cs = @"Data Source=.\SQLEXPRESS;
        Initial Catalog=CollegeDB;
        Integrated Security=True";

        SqlConnection con = new SqlConnection(cs);

        string query = "DELETE FROM Student WHERE StudentID=@ID";

        SqlCommand cmd = new SqlCommand(query, con);

        cmd.Parameters.AddWithValue("@ID", 2);

        con.Open();

        int result = cmd.ExecuteNonQuery();

        Console.WriteLine(result + " Record Deleted");

        con.Close();
    }
}