namespace NLH
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ManageDoctorsbutton = new System.Windows.Forms.Button();
            this.BillPatientbutton = new System.Windows.Forms.Button();
            this.DischargePatientbutton = new System.Windows.Forms.Button();
            this.SurgeryReportbutton = new System.Windows.Forms.Button();
            this.PatientListbutton = new System.Windows.Forms.Button();
            this.SurgeryReportNursebutton = new System.Windows.Forms.Button();
            this.Exitbutton = new System.Windows.Forms.Button();
            this.DischargetextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ManageDoctorsbutton
            // 
            this.ManageDoctorsbutton.Location = new System.Drawing.Point(28, 101);
            this.ManageDoctorsbutton.Name = "ManageDoctorsbutton";
            this.ManageDoctorsbutton.Size = new System.Drawing.Size(112, 23);
            this.ManageDoctorsbutton.TabIndex = 0;
            this.ManageDoctorsbutton.Text = "Manage Doctors";
            this.ManageDoctorsbutton.UseVisualStyleBackColor = true;
            this.ManageDoctorsbutton.Click += new System.EventHandler(this.ManageDoctorsbutton_Click);
            // 
            // BillPatientbutton
            // 
            this.BillPatientbutton.Location = new System.Drawing.Point(175, 101);
            this.BillPatientbutton.Name = "BillPatientbutton";
            this.BillPatientbutton.Size = new System.Drawing.Size(101, 23);
            this.BillPatientbutton.TabIndex = 1;
            this.BillPatientbutton.Text = "Bill Patient";
            this.BillPatientbutton.UseVisualStyleBackColor = true;
            // 
            // DischargePatientbutton
            // 
            this.DischargePatientbutton.Location = new System.Drawing.Point(406, 101);
            this.DischargePatientbutton.Name = "DischargePatientbutton";
            this.DischargePatientbutton.Size = new System.Drawing.Size(109, 23);
            this.DischargePatientbutton.TabIndex = 2;
            this.DischargePatientbutton.Text = "Discharge Patient";
            this.DischargePatientbutton.UseVisualStyleBackColor = true;
            this.DischargePatientbutton.Click += new System.EventHandler(this.DischargePatientbutton_Click);
            // 
            // SurgeryReportbutton
            // 
            this.SurgeryReportbutton.Location = new System.Drawing.Point(561, 101);
            this.SurgeryReportbutton.Name = "SurgeryReportbutton";
            this.SurgeryReportbutton.Size = new System.Drawing.Size(92, 23);
            this.SurgeryReportbutton.TabIndex = 3;
            this.SurgeryReportbutton.Text = "Surgery Report";
            this.SurgeryReportbutton.UseVisualStyleBackColor = true;
            this.SurgeryReportbutton.Click += new System.EventHandler(this.SurgeryReportbutton_Click);
            // 
            // PatientListbutton
            // 
            this.PatientListbutton.Location = new System.Drawing.Point(28, 232);
            this.PatientListbutton.Name = "PatientListbutton";
            this.PatientListbutton.Size = new System.Drawing.Size(112, 23);
            this.PatientListbutton.TabIndex = 4;
            this.PatientListbutton.Text = "Manage Patients";
            this.PatientListbutton.UseVisualStyleBackColor = true;
            this.PatientListbutton.Click += new System.EventHandler(this.PatientListbutton_Click);
            // 
            // SurgeryReportNursebutton
            // 
            this.SurgeryReportNursebutton.Location = new System.Drawing.Point(175, 232);
            this.SurgeryReportNursebutton.Name = "SurgeryReportNursebutton";
            this.SurgeryReportNursebutton.Size = new System.Drawing.Size(101, 23);
            this.SurgeryReportNursebutton.TabIndex = 5;
            this.SurgeryReportNursebutton.Text = "SurgeryReport";
            this.SurgeryReportNursebutton.UseVisualStyleBackColor = true;
            this.SurgeryReportNursebutton.Click += new System.EventHandler(this.SurgeryReportNursebutton_Click);
            // 
            // Exitbutton
            // 
            this.Exitbutton.Location = new System.Drawing.Point(406, 297);
            this.Exitbutton.Name = "Exitbutton";
            this.Exitbutton.Size = new System.Drawing.Size(75, 23);
            this.Exitbutton.TabIndex = 6;
            this.Exitbutton.Text = "Exit";
            this.Exitbutton.UseVisualStyleBackColor = true;
            // 
            // DischargetextBox
            // 
            this.DischargetextBox.Location = new System.Drawing.Point(406, 58);
            this.DischargetextBox.Name = "DischargetextBox";
            this.DischargetextBox.Size = new System.Drawing.Size(100, 20);
            this.DischargetextBox.TabIndex = 7;
            this.DischargetextBox.TextChanged += new System.EventHandler(this.DischargetextBox_TextChanged);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 368);
            this.Controls.Add(this.DischargetextBox);
            this.Controls.Add(this.Exitbutton);
            this.Controls.Add(this.SurgeryReportNursebutton);
            this.Controls.Add(this.PatientListbutton);
            this.Controls.Add(this.SurgeryReportbutton);
            this.Controls.Add(this.DischargePatientbutton);
            this.Controls.Add(this.BillPatientbutton);
            this.Controls.Add(this.ManageDoctorsbutton);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ManageDoctorsbutton;
        private System.Windows.Forms.Button BillPatientbutton;
        private System.Windows.Forms.Button DischargePatientbutton;
        private System.Windows.Forms.Button SurgeryReportbutton;
        private System.Windows.Forms.Button PatientListbutton;
        private System.Windows.Forms.Button SurgeryReportNursebutton;
        private System.Windows.Forms.Button Exitbutton;
        private System.Windows.Forms.TextBox DischargetextBox;
    }
}