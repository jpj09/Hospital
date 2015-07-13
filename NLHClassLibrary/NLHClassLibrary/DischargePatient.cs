using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace NLH
{
    public class DischargePatient
    {               
        string connectionString = "Data Source=(local);Initial Catalog=NLH;" + "Integrated Security=true";

        string _queryDischargePatient = "UPDATE AdmissionRecords "
            + "SET DischargedDate = @DateDischarged "
            + "WHERE PatientID = @PatientId ";

        public void DischargePatients(string PatientID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {               
                connection.Open();
                SqlCommand comm = new SqlCommand(_queryDischargePatient, connection);
                comm.Parameters.AddWithValue("@DateDischarged",DateTime.Today );
                comm.Parameters.AddWithValue("@PatientId",PatientID);
                comm.ExecuteNonQuery();
            }
        }
    }
}
