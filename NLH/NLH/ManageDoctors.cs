using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;


namespace NLH
{
    public partial class ManageDoctors : Form
    {
        Doctors dr = new Doctors();
        string _doctorID, _drFirstName, _drLastName, _specialty;


        public ManageDoctors()
        {
            InitializeComponent();
        }

        private void DoctorIDtextBox_TextChanged(object sender, EventArgs e)
        {
           _doctorID = DoctorIDtextBox.Text;
        }

        private void DoctorFirstNametextBox_TextChanged(object sender, EventArgs e)
        {
            _drFirstName = DoctorFirstNametextBox.Text;
        }

        private void DoctorLastNametextBox_TextChanged(object sender, EventArgs e)
        {
            _drLastName = DoctorLastNametextBox.Text;
        }

        private void SpecialtytextBox_TextChanged(object sender, EventArgs e)
        {
          //  _specialty = SpecialtytextBox.Text;
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {       


            dr.AddDoctor(_doctorID,_drFirstName,_drLastName,_specialty);

        }

        private void Findbutton_Click(object sender, EventArgs e)
        {
            string _querySelectDoctor = "SELECT DoctorID, LastName, FirstName, Specialty " +
                " FROM	Doctors " +
                " ORDER BY DoctorID ";
            string connectionString = "Data Source=(local);Initial Catalog=NLH;" + "Integrated Security=true";



            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand comm = new SqlCommand(_querySelectDoctor, connection);
                SqlDataAdapter sda = new SqlDataAdapter(comm);
                DataTable dt = new DataTable("Doctors");
                sda.Fill(dt);
                dataGridView1.DataSource = dt;

            }
        }

        private void Updatebutton_Click(object sender, EventArgs e)
        {
            dr.UpdateDoctor(_doctorID, _drFirstName, _drLastName, _specialty);
        }

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            dr.DeleteDoctor(_doctorID);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void ManageDoctors_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nLHDataSet.Doctors' table. You can move, or remove it, as needed.
            this.doctorsTableAdapter.Fill(this.nLHDataSet.Doctors);
            // TODO: This line of code loads data into the 'nLHDataSet.Specialties' table. You can move, or remove it, as needed.
            this.specialtiesTableAdapter.Fill(this.nLHDataSet.Specialties);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            _specialty = comboBox1.Text;
        }

        


    }
}
