using System;
using System.Data.SqlClient;

class Ninth
{
    static string cs = @"Data Source=.\SQLEXPRESS;
    Initial Catalog=CollegeDB;
    Integrated Security=True";

    static void Main()
    {
        InsertStudent();
        DisplayStudents();
        UpdateStudent();
        DeleteStudent();
    }

    static void InsertStudent()
    {
        using (SqlConnection con = new SqlConnection(cs))
        {
            string q = "INSERT INTO Student(Name,Age,Course) " +
                       "VALUES(@N,@A,@C)";

            SqlCommand cmd = new SqlCommand(q, con);

            cmd.Parameters.AddWithValue("@N", "Rohit");
            cmd.Parameters.AddWithValue("@A", 22);
            cmd.Parameters.AddWithValue("@C", "BCA");

            con.Open();
            cmd.ExecuteNonQuery();

            Console.WriteLine("Record Inserted");
        }
    }

    static void DisplayStudents()
    {
        using (SqlConnection con = new SqlConnection(cs))
        {
            SqlCommand cmd = new SqlCommand(
                "SELECT * FROM Student", con);

            con.Open();

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Console.WriteLine(
                    dr["StudentID"] + " " +
                    dr["Name"] + " " +
                    dr["Age"] + " " +
                    dr["Course"]);
            }
        }
    }

    static void UpdateStudent()
    {
        using (SqlConnection con = new SqlConnection(cs))
        {
            string q = "UPDATE Student SET Age=@A " +
                       "WHERE StudentID=@ID";

            SqlCommand cmd = new SqlCommand(q, con);

            cmd.Parameters.AddWithValue("@A", 25);
            cmd.Parameters.AddWithValue("@ID", 1);

            con.Open();
            cmd.ExecuteNonQuery();

            Console.WriteLine("Record Updated");
        }
    }

    static void DeleteStudent()
    {
        using (SqlConnection con = new SqlConnection(cs))
        {
            string q = "DELETE FROM Student " +
                       "WHERE StudentID=@ID";

            SqlCommand cmd = new SqlCommand(q, con);

            cmd.Parameters.AddWithValue("@ID", 3);

            con.Open();
            cmd.ExecuteNonQuery();

            Console.WriteLine("Record Deleted");
        }
    }
}