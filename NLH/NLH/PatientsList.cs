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

namespace NLH
{
    public partial class PatientsList : Form
    {

        Patients pa = new Patients();
        string _firstName, _lastName, _address, _city, _province, _postalCode, _phone, _insuranceCompany, _nextofKin, _nextKinRelationship, _doctor, _healthNumber, _insuranceNumber, _bed;
        DateTime _dateOfBirth, _admissionDate;
        DateTime? _dateOfSurgery = null ;
        string _patientID , _bedNumber, _isSurgeryScheduled;            



        public PatientsList()
        {            
            InitializeComponent();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

      
        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox4_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox5_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox6_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox7_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox8_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox9_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox10_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox11_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox12_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox13_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void AddPatientbutton_Click(object sender, EventArgs e)
        {
            _healthNumber = maskedTextBox1.Text;
            _dateOfBirth = Convert.ToDateTime(maskedTextBox2.Text);
            _firstName = maskedTextBox3.Text;
            _lastName = maskedTextBox4.Text;
            _address = maskedTextBox5.Text;
            _city = maskedTextBox6.Text;
            _province = maskedTextBox7.Text;
            _postalCode = maskedTextBox8.Text;
            _insuranceCompany = maskedTextBox9.Text;
            _insuranceNumber = maskedTextBox10.Text;
            _nextofKin = maskedTextBox11.Text;
            _nextKinRelationship = maskedTextBox12.Text;
            _doctor = maskedTextBox13.Text;
            _phone = maskedTextBox14.Text;

                
                pa.AddPatient(_lastName, _firstName, _healthNumber, _dateOfBirth, _address, _city, _province, _postalCode,_phone, _insuranceCompany, _insuranceNumber, _nextofKin, _nextKinRelationship,_doctor);
        }

        private void Updatebutton_Click(object sender, EventArgs e)
        {
            _healthNumber = maskedTextBox1.Text;
            _dateOfBirth = Convert.ToDateTime(maskedTextBox2.Text);
            _firstName = maskedTextBox3.Text;
            _lastName = maskedTextBox4.Text;
            _address = maskedTextBox5.Text;
            _city = maskedTextBox6.Text;
            _province = maskedTextBox7.Text;
            _postalCode = maskedTextBox8.Text;
            _insuranceCompany = maskedTextBox9.Text;
            _insuranceNumber = maskedTextBox10.Text;
            _nextofKin = maskedTextBox11.Text;
            _nextKinRelationship = maskedTextBox12.Text;
            _doctor = maskedTextBox13.Text;
            _phone = maskedTextBox14.Text;
            
           pa.UpdatePatient(_lastName, _firstName, _healthNumber, _dateOfBirth, _address, _city, _province, _postalCode,_phone, _insuranceCompany, _insuranceNumber, _nextofKin, _nextKinRelationship,_doctor);
        }

        

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PatientsList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nLHDataSet.Beds' table. You can move, or remove it, as needed.
            this.bedsTableAdapter.FillBy(this.nLHDataSet.Beds);

        }

       
        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            _bed = comboBox1.Text;

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.bedsTableAdapter.FillBy(this.nLHDataSet.Beds);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void ListPatientbutton_Click(object sender, EventArgs e)
        {
                string _querySelectPatients = "SELECT HealthNumber, LastName, FirstName, DateOfBirth, " +
                " AddressPatient, City, Province, PostalCode, Phone, InsuranceCompany, InsuranceNumber, " +
                " NextOfKin, NextOfKinRelationship, Doctor " +
                " FROM	Patients " +
                " ORDER BY HealthNumber  ";

                string connectionString = "Data Source=(local);Initial Catalog=NLH;" + "Integrated Security=true";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand comm = new SqlCommand(_querySelectPatients, connection);
                    SqlDataAdapter sda = new SqlDataAdapter(comm);
                    DataTable dt = new DataTable("Patients");
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
        }

        private void AdmitPatientIDtextBox_TextChanged(object sender, EventArgs e)
        {
            _patientID = AdmitPatientIDtextBox.Text ;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            _dateOfSurgery = dateTimePicker1.Value ;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value != null)
            {
                _isSurgeryScheduled = "1";
            }
            else { 
                _isSurgeryScheduled = "0";
                _dateOfSurgery = null;
                 }
                _admissionDate = DateTime.Today ;
                pa.AdmitPatient(_patientID, _bed,_isSurgeryScheduled,_admissionDate ,_dateOfSurgery);

            
        }
                       


    }
}
