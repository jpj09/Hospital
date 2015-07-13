using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NLH
{
    public partial class MainMenu : Form
    {

        string _DischargeID;

        public MainMenu()
        {
            InitializeComponent();
        }

        private void ManageDoctorsbutton_Click(object sender, EventArgs e)
        {
            ManageDoctors md = new ManageDoctors();
            md.ShowDialog();
        }

        private void PatientListbutton_Click(object sender, EventArgs e)
        {
            PatientsList pl = new PatientsList();
            pl.ShowDialog();

        }

        private void DischargePatientbutton_Click(object sender, EventArgs e)
        {
            DischargePatient dp = new DischargePatient();
            dp.DischargePatients(_DischargeID);
            DischargetextBox.Clear();

        }

        private void DischargetextBox_TextChanged(object sender, EventArgs e)
        {
            _DischargeID = DischargetextBox.Text;
        }

        private void SurgeryReportNursebutton_Click(object sender, EventArgs e)
        {
            SurgeryReport sr = new SurgeryReport();
            sr.Show();
        }

        private void SurgeryReportbutton_Click(object sender, EventArgs e)
        {
            SurgeryReport sr = new SurgeryReport();
            sr.Show();
        }
    }
}
