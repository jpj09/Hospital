using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace NLH
{
    public class Patients
    {
        string connectionString = "Data Source=(local);Initial Catalog=NLH;" + "Integrated Security=true";


        string _querySelectPatients = "SELECT HealthNumber, LastName, FirstName, DateOfBirth, " +
                " AddressPatient, City, Province, PostalCode, Phone, InsuranceCompany, InsuranceNumber, " +
                " NextOfKin, NextOfKinRelationship, Doctor" +
                " FROM	Patients " +
                " ORDER BY HealthNumber  ";

        string _queryUpdatePatient = "UPDATE Patients " +
                " SET LastName = @LastName, FirstName = @FirstName, " +
                " DateOfBirth = @DateOfBirth, AddressPatient = @AddressPatient, City = @City, Province = @Province, " +
                " PostalCode = @PostalCode, Phone = @Phone, InsuranceCompany = @InsuranceCompany, " +
                " InsuranceNumber = @InsuranceNumber, NextOfKin = @NextOfKin, " +
                " NextOfKinRelationship = @NextOfKinRelationship, Doctor = @Doctor" +
                " WHERE HealthNumber  = @HealthNumber  ";

        string _queryAddPatient = "INSERT INTO Patients " +
                " (LastName, FirstName, HealthNumber, " +
                " DateOfBirth, AddressPatient, City, Province, " +
                " PostalCode, Phone, InsuranceCompany, " +
                " InsuranceNumber, NextOfKin , NextOfKinRelationship, Doctor)" +
                " VALUES (@LastName, @FirstName, @HealthNumber, " +
                " @DateOfBirth, @AddressPatient, @City, @Province, " +
                " @PostalCode, @Phone, @InsuranceCompany, " +
                " @InsuranceNumber, @NextOfKin , @NextOfKinRelationship, @Doctor)";

        string _queryAdmitPatient = "INSERT INTO AdmissionRecords " +
                "(PatientID,BedNumber,SurgerySceduled,AdminDate,SurgeryDate) " +
                "VALUES (@PatientID,@BedNumber,@SurgerySceduled,@AdminDate,@SurgeryDate) ";

        public void SelectAllPatients()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand comm = new SqlCommand(_querySelectPatients , connection);
                SqlDataAdapter sda = new SqlDataAdapter(comm);
                DataTable dt = new DataTable("Patients");
                sda.Fill(dt);
              

                comm.ExecuteNonQuery();
            }
        }

        public void UpdatePatient(string LastName, string FirstName, string HealthNumber, DateTime DateOfBirth,
            string Address, string City, string Province, string PostalCode, string Phone,
            string InsuranceCompany, string InsuranceNumber, string NextOfKin, string NextOfKinRelationship,string Doctor)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand comm = new SqlCommand(_queryUpdatePatient, connection);
                comm.Parameters.AddWithValue("@LastName",LastName);
			comm.Parameters.AddWithValue("@FirstName",FirstName);
			comm.Parameters.AddWithValue("@HealthNumber",HealthNumber);
			comm.Parameters.AddWithValue("@DateOfBirth",DateOfBirth);
            comm.Parameters.AddWithValue("@AddressPatient", Address);
			comm.Parameters.AddWithValue("@City",City);
			comm.Parameters.AddWithValue("@Province",Province);
			comm.Parameters.AddWithValue("@PostalCode",PostalCode);
			comm.Parameters.AddWithValue("@Phone",Phone);
			comm.Parameters.AddWithValue("@InsuranceCompany",InsuranceCompany);
			comm.Parameters.AddWithValue("@InsuranceNumber",InsuranceNumber);
			comm.Parameters.AddWithValue("@NextOfKin",NextOfKin);
			comm.Parameters.AddWithValue("@NextOfKinRelationship",NextOfKinRelationship);
			comm.Parameters.AddWithValue("@Doctor",Doctor);
            


                comm.ExecuteNonQuery();
            }
        }

        public void AddPatient(string LastName, string FirstName, string HealthNumber, DateTime DateOfBirth,
            string Address, string City, string Province, string PostalCode, string Phone,
            string InsuranceCompany, string InsuranceNumber, string NextOfKin, string NextOfKinRelationship, string Doctor)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand comm = new SqlCommand(_queryAddPatient, connection);
                comm.Parameters.AddWithValue("@LastName", LastName);
                comm.Parameters.AddWithValue("@FirstName", FirstName);
                comm.Parameters.AddWithValue("@HealthNumber", HealthNumber);
                comm.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                comm.Parameters.AddWithValue("@AddressPatient", Address);
                comm.Parameters.AddWithValue("@City", City);
                comm.Parameters.AddWithValue("@Province", Province);
                comm.Parameters.AddWithValue("@PostalCode", PostalCode);
                comm.Parameters.AddWithValue("@Phone", Phone);
                comm.Parameters.AddWithValue("@InsuranceCompany", InsuranceCompany);
                comm.Parameters.AddWithValue("@InsuranceNumber", InsuranceNumber);
                comm.Parameters.AddWithValue("@NextOfKin", NextOfKin);
                comm.Parameters.AddWithValue("@NextOfKinRelationship", NextOfKinRelationship);
                comm.Parameters.AddWithValue("@Doctor", Doctor);
               

                comm.ExecuteNonQuery();
            }
        }
        public void AdmitPatient(string PatientID,string Room,string IsSurgeryScheduled,DateTime AdmissionDate , DateTime? DateOfSurgery )
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand comm = new SqlCommand(_queryAdmitPatient, connection);
                comm.Parameters.AddWithValue("@PatientID", PatientID);
                comm.Parameters.AddWithValue("@BedNumber", Room);
                comm.Parameters.AddWithValue("@SurgerySceduled", IsSurgeryScheduled);
                comm.Parameters.AddWithValue("@AdminDate", AdmissionDate);
                comm.Parameters.AddWithValue("@SurgeryDate", DateOfSurgery);               
                

                comm.ExecuteNonQuery();
            }
        }



    }
}
