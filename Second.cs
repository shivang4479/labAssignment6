using System;
using System.Data.SqlClient;

class Second

{
    static void Main()
    {
        string cs = @"Data Source=.\SQLEXPRESS;
        Initial Catalog=CollegeDB;
        Integrated Security=True";

        SqlConnection con = new SqlConnection(cs);

        string query = "INSERT INTO Student(Name, Age, Course) " +
                       "VALUES(@Name, @Age, @Course)";

        SqlCommand cmd = new SqlCommand(query, con);

        cmd.Parameters.AddWithValue("@Name", "Rohit");
        cmd.Parameters.AddWithValue("@Age", 22);
        cmd.Parameters.AddWithValue("@Course", "BCA");

        con.Open();

        int result = cmd.ExecuteNonQuery();

        Console.WriteLine(result + " Record Inserted");

        con.Close();
    }
}