using System;
using System.Data;
using System.Data.SqlClient;

class Eigth
{
    static void Main()
    {
        string cs = @"Data Source=.\SQLEXPRESS;
        Initial Catalog=CollegeDB;
        Integrated Security=True";

        SqlConnection con = new SqlConnection(cs);

        SqlDataAdapter da =
            new SqlDataAdapter("SELECT * FROM Student", con);

        SqlCommandBuilder cb = new SqlCommandBuilder(da);

        DataSet ds = new DataSet();

        da.Fill(ds, "Student");

        DataRow row = ds.Tables["Student"].Rows[0];

        row.Delete();

        da.Update(ds, "Student");

        Console.WriteLine("Record Deleted Successfully");
    }
}