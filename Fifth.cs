using System;
using System.Data;
using System.Data.SqlClient;

class Fifth
{
    static void Main()
    {
        string cs = @"Data Source=.\SQLEXPRESS;
        Initial Catalog=CollegeDB;
        Integrated Security=True";

        SqlConnection con = new SqlConnection(cs);

        string query = "SELECT * FROM Student";

        SqlDataAdapter da = new SqlDataAdapter(query, con);

        DataSet ds = new DataSet();

        da.Fill(ds, "Student");

        foreach (DataRow row in ds.Tables["Student"].Rows)
        {
            Console.WriteLine("ID: " + row["StudentID"]);
            Console.WriteLine("Name: " + row["Name"]);
            Console.WriteLine("Age: " + row["Age"]);
            Console.WriteLine("Course: " + row["Course"]);
            Console.WriteLine("----------------");
        }
    }
}