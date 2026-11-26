using System;
using System.Data.SqlClient;

class Third
{
    static void Main()
    {
        string cs = @"Data Source=.\SQLEXPRESS;
        Initial Catalog=CollegeDB;
        Integrated Security=True";

        SqlConnection con = new SqlConnection(cs);

        string query = "UPDATE Student SET Name=@Name, " +
                       "Age=@Age, Course=@Course " +
                       "WHERE StudentID=@ID";

        SqlCommand cmd = new SqlCommand(query, con);

        cmd.Parameters.AddWithValue("@Name", "Ravi");
        cmd.Parameters.AddWithValue("@Age", 23);
        cmd.Parameters.AddWithValue("@Course", "MCA");
        cmd.Parameters.AddWithValue("@ID", 1);

        con.Open();

        int result = cmd.ExecuteNonQuery();

        Console.WriteLine(result + " Record Updated");

        con.Close();
    }
}