namespace NLH
{
    partial class ManageDoctors
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DoctorIDtextBox = new System.Windows.Forms.TextBox();
            this.DoctorFirstNametextBox = new System.Windows.Forms.TextBox();
            this.DoctorLastNametextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Addbutton = new System.Windows.Forms.Button();
            this.Findbutton = new System.Windows.Forms.Button();
            this.Updatebutton = new System.Windows.Forms.Button();
            this.Deletebutton = new System.Windows.Forms.Button();
            this.Exitbutton = new System.Windows.Forms.Button();
            this.nLHDataSet = new NLH.NLHDataSet();
            this.specialtiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.specialtiesTableAdapter = new NLH.NLHDataSetTableAdapters.SpecialtiesTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.fKDoctorsSpecial286302ECBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doctorsTableAdapter = new NLH.NLHDataSetTableAdapters.DoctorsTableAdapter();
            this.specialtiesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nLHDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialtiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKDoctorsSpecial286302ECBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialtiesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(39, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(499, 149);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // DoctorIDtextBox
            // 
            this.DoctorIDtextBox.Location = new System.Drawing.Point(215, 189);
            this.DoctorIDtextBox.Name = "DoctorIDtextBox";
            this.DoctorIDtextBox.Size = new System.Drawing.Size(100, 20);
            this.DoctorIDtextBox.TabIndex = 1;
            this.DoctorIDtextBox.TextChanged += new System.EventHandler(this.DoctorIDtextBox_TextChanged);
            // 
            // DoctorFirstNametextBox
            // 
            this.DoctorFirstNametextBox.Location = new System.Drawing.Point(215, 244);
            this.DoctorFirstNametextBox.Name = "DoctorFirstNametextBox";
            this.DoctorFirstNametextBox.Size = new System.Drawing.Size(100, 20);
            this.DoctorFirstNametextBox.TabIndex = 2;
            this.DoctorFirstNametextBox.TextChanged += new System.EventHandler(this.DoctorFirstNametextBox_TextChanged);
            // 
            // DoctorLastNametextBox
            // 
            this.DoctorLastNametextBox.Location = new System.Drawing.Point(215, 284);
            this.DoctorLastNametextBox.Name = "DoctorLastNametextBox";
            this.DoctorLastNametextBox.Size = new System.Drawing.Size(100, 20);
            this.DoctorLastNametextBox.TabIndex = 3;
            this.DoctorLastNametextBox.TextChanged += new System.EventHandler(this.DoctorLastNametextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "DoctorID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Doctor First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Doctor Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Specialty";
            // 
            // Addbutton
            // 
            this.Addbutton.Location = new System.Drawing.Point(375, 209);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(75, 23);
            this.Addbutton.TabIndex = 9;
            this.Addbutton.Text = "Add";
            this.Addbutton.UseVisualStyleBackColor = true;
            this.Addbutton.Click += new System.EventHandler(this.Addbutton_Click);
            // 
            // Findbutton
            // 
            this.Findbutton.Location = new System.Drawing.Point(375, 244);
            this.Findbutton.Name = "Findbutton";
            this.Findbutton.Size = new System.Drawing.Size(75, 23);
            this.Findbutton.TabIndex = 10;
            this.Findbutton.Text = "Find";
            this.Findbutton.UseVisualStyleBackColor = true;
            this.Findbutton.Click += new System.EventHandler(this.Findbutton_Click);
            // 
            // Updatebutton
            // 
            this.Updatebutton.Location = new System.Drawing.Point(375, 287);
            this.Updatebutton.Name = "Updatebutton";
            this.Updatebutton.Size = new System.Drawing.Size(75, 23);
            this.Updatebutton.TabIndex = 11;
            this.Updatebutton.Text = "Update";
            this.Updatebutton.UseVisualStyleBackColor = true;
            this.Updatebutton.Click += new System.EventHandler(this.Updatebutton_Click);
            // 
            // Deletebutton
            // 
            this.Deletebutton.Location = new System.Drawing.Point(375, 317);
            this.Deletebutton.Name = "Deletebutton";
            this.Deletebutton.Size = new System.Drawing.Size(75, 23);
            this.Deletebutton.TabIndex = 12;
            this.Deletebutton.Text = "Delete";
            this.Deletebutton.UseVisualStyleBackColor = true;
            this.Deletebutton.Click += new System.EventHandler(this.Deletebutton_Click);
            // 
            // Exitbutton
            // 
            this.Exitbutton.Location = new System.Drawing.Point(479, 317);
            this.Exitbutton.Name = "Exitbutton";
            this.Exitbutton.Size = new System.Drawing.Size(75, 23);
            this.Exitbutton.TabIndex = 13;
            this.Exitbutton.Text = "Exit";
            this.Exitbutton.UseVisualStyleBackColor = true;
            this.Exitbutton.Click += new System.EventHandler(this.Exitbutton_Click);
            // 
            // nLHDataSet
            // 
            this.nLHDataSet.DataSetName = "NLHDataSet";
            this.nLHDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // specialtiesBindingSource
            // 
            this.specialtiesBindingSource.DataMember = "Specialties";
            this.specialtiesBindingSource.DataSource = this.nLHDataSet;
            // 
            // specialtiesTableAdapter
            // 
            this.specialtiesTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.specialtiesBindingSource, "SpecialtyName", true));
            this.comboBox1.DataSource = this.specialtiesBindingSource1;
            this.comboBox1.DisplayMember = "SpecialtyName";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(215, 318);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 15;
            this.comboBox1.ValueMember = "SpecialtyName";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // fKDoctorsSpecial286302ECBindingSource
            // 
            this.fKDoctorsSpecial286302ECBindingSource.DataMember = "FK__Doctors__Special__286302EC";
            this.fKDoctorsSpecial286302ECBindingSource.DataSource = this.specialtiesBindingSource;
            // 
            // doctorsTableAdapter
            // 
            this.doctorsTableAdapter.ClearBeforeFill = true;
            // 
            // specialtiesBindingSource1
            // 
            this.specialtiesBindingSource1.DataMember = "Specialties";
            this.specialtiesBindingSource1.DataSource = this.nLHDataSet;
            // 
            // ManageDoctors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 360);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Exitbutton);
            this.Controls.Add(this.Deletebutton);
            this.Controls.Add(this.Updatebutton);
            this.Controls.Add(this.Findbutton);
            this.Controls.Add(this.Addbutton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DoctorLastNametextBox);
            this.Controls.Add(this.DoctorFirstNametextBox);
            this.Controls.Add(this.DoctorIDtextBox);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ManageDoctors";
            this.Text = "ManageDoctors";
            this.Load += new System.EventHandler(this.ManageDoctors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nLHDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialtiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKDoctorsSpecial286302ECBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialtiesBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox DoctorIDtextBox;
        private System.Windows.Forms.TextBox DoctorFirstNametextBox;
        private System.Windows.Forms.TextBox DoctorLastNametextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Addbutton;
        private System.Windows.Forms.Button Findbutton;
        private System.Windows.Forms.Button Updatebutton;
        private System.Windows.Forms.Button Deletebutton;
        private System.Windows.Forms.Button Exitbutton;
        private NLHDataSet nLHDataSet;
        private System.Windows.Forms.BindingSource specialtiesBindingSource;
        private NLHDataSetTableAdapters.SpecialtiesTableAdapter specialtiesTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource fKDoctorsSpecial286302ECBindingSource;
        private NLHDataSetTableAdapters.DoctorsTableAdapter doctorsTableAdapter;
        private System.Windows.Forms.BindingSource specialtiesBindingSource1;
    }
}