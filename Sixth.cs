using System;
using System.Data;
using System.Data.SqlClient;

class Sixth
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

        DataRow row = ds.Tables["Student"].NewRow();

        row["Name"] = "Suresh";
        row["Age"] = 22;
        row["Course"] = "BCA";

        ds.Tables["Student"].Rows.Add(row);

        da.Update(ds, "Student");

        Console.WriteLine("Record Inserted Successfully");
    }
}