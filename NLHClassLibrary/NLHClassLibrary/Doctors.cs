using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace NLH
{
    public class Doctors
    {
        string connectionString = "Data Source=(local);Initial Catalog=NLH;" + "Integrated Security=true";

        string _querySelectDoctor = "SELECT DoctorID, LastName, FirstName, Specialty " +
                " FROM	Doctors " +
                " ORDER BY DoctorID ";

        string _queryUpdateDoctor = "UPDATE Doctors " +
                " SET LastName = @LastName, FirstName = @FirstName, Specialty = @Specialty " +
                " WHERE DoctorID = @DoctorID ";

        string _queryAddDoctor = "INSERT INTO Doctors " +
                " (LastName, FirstName, Specialty, DoctorID)" +
                " VALUES (@LastName, @FirstName, @Specialty, @DoctorID)";

        string _queryDeleteDoctor = "DELETE Doctors " +
                " WHERE DoctorID = @DoctorID ";


        public void AddDoctor(string DoctorID,string FirstName, string LastName,string Specialty)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand comm = new SqlCommand(_queryAddDoctor, connection);
                comm.Parameters.AddWithValue("@DoctorID", DoctorID);
                comm.Parameters.AddWithValue("@FirstName", FirstName);
                comm.Parameters.AddWithValue("@LastName", LastName);
                comm.Parameters.AddWithValue("@Specialty", Specialty);                
                comm.ExecuteNonQuery();

            }

        }
            public void UpdateDoctor(string DoctorID,string FirstName, string LastName,string Specialty)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand comm = new SqlCommand(_queryUpdateDoctor , connection);
                    comm.Parameters.AddWithValue("@DoctorID", DoctorID);
                    comm.Parameters.AddWithValue("@FirstName", FirstName);
                    comm.Parameters.AddWithValue("@LastName", LastName);
                    comm.Parameters.AddWithValue("@Specialty", Specialty);
                    comm.ExecuteNonQuery();
                }
            }
            public void DeleteDoctor(string DoctorID)
            { 
            using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand comm = new SqlCommand(_queryDeleteDoctor , connection);
                    comm.Parameters.AddWithValue("@DoctorID", DoctorID);
                    comm.ExecuteNonQuery();
                }
            }

            public void SelectAllDoctors()
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand comm = new SqlCommand(_querySelectDoctor , connection);
                    SqlDataAdapter sda = new SqlDataAdapter(comm);
                    DataTable dt = new DataTable("Doctors");
                    sda.Fill(dt);                    
                 
                    comm.ExecuteNonQuery();                    
                }
                
            }







    }
}
