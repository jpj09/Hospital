namespace NLH
{
    partial class PatientsList
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
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox4 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox5 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox6 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox7 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox8 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox9 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox10 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox11 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox12 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox13 = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.AddPatientbutton = new System.Windows.Forms.Button();
            this.Updatebutton = new System.Windows.Forms.Button();
            this.maskedTextBox14 = new System.Windows.Forms.MaskedTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.Exitbutton = new System.Windows.Forms.Button();
            this.nLHDataSet = new NLH.NLHDataSet();
            this.nLHDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bedsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bedsTableAdapter = new NLH.NLHDataSetTableAdapters.BedsTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.bedsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label15 = new System.Windows.Forms.Label();
            this.ListPatientbutton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.AdmitPatientIDtextBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nLHDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nLHDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bedsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bedsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(47, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(651, 93);
            this.dataGridView1.TabIndex = 0;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(187, 151);
            this.maskedTextBox1.Mask = "AAA-AAA-AAA";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 1;
            this.maskedTextBox1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(187, 190);
            this.maskedTextBox2.Mask = "00/00/0000";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox2.TabIndex = 2;
            this.maskedTextBox2.ValidatingType = typeof(System.DateTime);
            this.maskedTextBox2.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox2_MaskInputRejected);
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.Location = new System.Drawing.Point(187, 231);
            this.maskedTextBox3.Mask = "L????????????????????";
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox3.TabIndex = 3;
            this.maskedTextBox3.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox3_MaskInputRejected);
            // 
            // maskedTextBox4
            // 
            this.maskedTextBox4.Location = new System.Drawing.Point(187, 273);
            this.maskedTextBox4.Mask = "L????????????????????????";
            this.maskedTextBox4.Name = "maskedTextBox4";
            this.maskedTextBox4.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox4.TabIndex = 4;
            this.maskedTextBox4.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox4_MaskInputRejected);
            // 
            // maskedTextBox5
            // 
            this.maskedTextBox5.Location = new System.Drawing.Point(187, 313);
            this.maskedTextBox5.Mask = "AAAAAAAAAAAAAAAAAAAA";
            this.maskedTextBox5.Name = "maskedTextBox5";
            this.maskedTextBox5.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox5.TabIndex = 5;
            this.maskedTextBox5.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox5_MaskInputRejected);
            // 
            // maskedTextBox6
            // 
            this.maskedTextBox6.Location = new System.Drawing.Point(187, 343);
            this.maskedTextBox6.Mask = "L?????????????????????";
            this.maskedTextBox6.Name = "maskedTextBox6";
            this.maskedTextBox6.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox6.TabIndex = 6;
            this.maskedTextBox6.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox6_MaskInputRejected);
            // 
            // maskedTextBox7
            // 
            this.maskedTextBox7.Location = new System.Drawing.Point(494, 150);
            this.maskedTextBox7.Mask = "LL";
            this.maskedTextBox7.Name = "maskedTextBox7";
            this.maskedTextBox7.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox7.TabIndex = 7;
            this.maskedTextBox7.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox7_MaskInputRejected);
            // 
            // maskedTextBox8
            // 
            this.maskedTextBox8.Location = new System.Drawing.Point(494, 190);
            this.maskedTextBox8.Mask = "L0L-0L0";
            this.maskedTextBox8.Name = "maskedTextBox8";
            this.maskedTextBox8.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox8.TabIndex = 8;
            this.maskedTextBox8.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox8_MaskInputRejected);
            // 
            // maskedTextBox9
            // 
            this.maskedTextBox9.Location = new System.Drawing.Point(494, 231);
            this.maskedTextBox9.Mask = "A?????????????????????????";
            this.maskedTextBox9.Name = "maskedTextBox9";
            this.maskedTextBox9.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox9.TabIndex = 9;
            this.maskedTextBox9.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox9_MaskInputRejected);
            // 
            // maskedTextBox10
            // 
            this.maskedTextBox10.Location = new System.Drawing.Point(494, 273);
            this.maskedTextBox10.Mask = "0999999999999999999";
            this.maskedTextBox10.Name = "maskedTextBox10";
            this.maskedTextBox10.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox10.TabIndex = 10;
            this.maskedTextBox10.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox10_MaskInputRejected);
            // 
            // maskedTextBox11
            // 
            this.maskedTextBox11.Location = new System.Drawing.Point(494, 313);
            this.maskedTextBox11.Mask = "L?????????????????????";
            this.maskedTextBox11.Name = "maskedTextBox11";
            this.maskedTextBox11.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox11.TabIndex = 11;
            this.maskedTextBox11.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox11_MaskInputRejected);
            // 
            // maskedTextBox12
            // 
            this.maskedTextBox12.Location = new System.Drawing.Point(494, 343);
            this.maskedTextBox12.Mask = "L???????????????????????";
            this.maskedTextBox12.Name = "maskedTextBox12";
            this.maskedTextBox12.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox12.TabIndex = 12;
            this.maskedTextBox12.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox12_MaskInputRejected);
            // 
            // maskedTextBox13
            // 
            this.maskedTextBox13.Location = new System.Drawing.Point(494, 384);
            this.maskedTextBox13.Name = "maskedTextBox13";
            this.maskedTextBox13.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox13.TabIndex = 13;
            this.maskedTextBox13.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox13_MaskInputRejected);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Health Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "DoB";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "First Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Last Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 349);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "City";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(325, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Province";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(328, 190);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Postal Code";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(328, 231);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Insurance Company";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(328, 273);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Insurance Number";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(328, 313);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Next of Kin";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(328, 343);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(114, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Next of Kin Relatioship";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(328, 384);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "Doctor";
            // 
            // AddPatientbutton
            // 
            this.AddPatientbutton.Location = new System.Drawing.Point(618, 186);
            this.AddPatientbutton.Name = "AddPatientbutton";
            this.AddPatientbutton.Size = new System.Drawing.Size(75, 23);
            this.AddPatientbutton.TabIndex = 27;
            this.AddPatientbutton.Text = "Add";
            this.AddPatientbutton.UseVisualStyleBackColor = true;
            this.AddPatientbutton.Click += new System.EventHandler(this.AddPatientbutton_Click);
            // 
            // Updatebutton
            // 
            this.Updatebutton.Location = new System.Drawing.Point(618, 237);
            this.Updatebutton.Name = "Updatebutton";
            this.Updatebutton.Size = new System.Drawing.Size(75, 23);
            this.Updatebutton.TabIndex = 28;
            this.Updatebutton.Text = "Update";
            this.Updatebutton.UseVisualStyleBackColor = true;
            this.Updatebutton.Click += new System.EventHandler(this.Updatebutton_Click);
            // 
            // maskedTextBox14
            // 
            this.maskedTextBox14.Location = new System.Drawing.Point(187, 376);
            this.maskedTextBox14.Name = "maskedTextBox14";
            this.maskedTextBox14.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox14.TabIndex = 30;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(47, 376);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 13);
            this.label14.TabIndex = 31;
            this.label14.Text = "Phone";
            // 
            // Exitbutton
            // 
            this.Exitbutton.Location = new System.Drawing.Point(618, 343);
            this.Exitbutton.Name = "Exitbutton";
            this.Exitbutton.Size = new System.Drawing.Size(75, 23);
            this.Exitbutton.TabIndex = 32;
            this.Exitbutton.Text = "Exit";
            this.Exitbutton.UseVisualStyleBackColor = true;
            this.Exitbutton.Click += new System.EventHandler(this.Exitbutton_Click);
            // 
            // nLHDataSet
            // 
            this.nLHDataSet.DataSetName = "NLHDataSet";
            this.nLHDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nLHDataSetBindingSource
            // 
            this.nLHDataSetBindingSource.DataSource = this.nLHDataSet;
            this.nLHDataSetBindingSource.Position = 0;
            // 
            // bedsBindingSource
            // 
            this.bedsBindingSource.DataMember = "Beds";
            this.bedsBindingSource.DataSource = this.nLHDataSet;
            // 
            // bedsTableAdapter
            // 
            this.bedsTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.bedsBindingSource1;
            this.comboBox1.DisplayMember = "BedNumber";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(821, 373);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 33;
            this.comboBox1.ValueMember = "BedNumber";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // bedsBindingSource1
            // 
            this.bedsBindingSource1.DataMember = "Beds";
            this.bedsBindingSource1.DataSource = this.nLHDataSet;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(821, 348);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 13);
            this.label15.TabIndex = 34;
            this.label15.Text = "Room";
            // 
            // ListPatientbutton
            // 
            this.ListPatientbutton.Location = new System.Drawing.Point(618, 292);
            this.ListPatientbutton.Name = "ListPatientbutton";
            this.ListPatientbutton.Size = new System.Drawing.Size(75, 23);
            this.ListPatientbutton.TabIndex = 35;
            this.ListPatientbutton.Text = "List Patients";
            this.ListPatientbutton.UseVisualStyleBackColor = true;
            this.ListPatientbutton.Click += new System.EventHandler(this.ListPatientbutton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(821, 439);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 36;
            this.button1.Text = "Admit Patient";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(102, 196);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(79, 13);
            this.label16.TabIndex = 37;
            this.label16.Text = "DD/MM/YYYY";
            // 
            // AdmitPatientIDtextBox
            // 
            this.AdmitPatientIDtextBox.Location = new System.Drawing.Point(821, 228);
            this.AdmitPatientIDtextBox.Name = "AdmitPatientIDtextBox";
            this.AdmitPatientIDtextBox.Size = new System.Drawing.Size(100, 20);
            this.AdmitPatientIDtextBox.TabIndex = 38;
            this.AdmitPatientIDtextBox.TextChanged += new System.EventHandler(this.AdmitPatientIDtextBox_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(821, 319);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 39;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(821, 189);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(82, 13);
            this.label17.TabIndex = 40;
            this.label17.Text = "Enter Patient ID";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(818, 280);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(158, 13);
            this.label18.TabIndex = 41;
            this.label18.Text = "Select a Surgery Date if needed";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(818, 406);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(220, 13);
            this.label19.TabIndex = 42;
            this.label19.Text = "Make sure you ADD patient before admission";
            // 
            // PatientsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 505);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.AdmitPatientIDtextBox);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ListPatientbutton);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Exitbutton);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.maskedTextBox14);
            this.Controls.Add(this.Updatebutton);
            this.Controls.Add(this.AddPatientbutton);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maskedTextBox13);
            this.Controls.Add(this.maskedTextBox12);
            this.Controls.Add(this.maskedTextBox11);
            this.Controls.Add(this.maskedTextBox10);
            this.Controls.Add(this.maskedTextBox9);
            this.Controls.Add(this.maskedTextBox8);
            this.Controls.Add(this.maskedTextBox7);
            this.Controls.Add(this.maskedTextBox6);
            this.Controls.Add(this.maskedTextBox5);
            this.Controls.Add(this.maskedTextBox4);
            this.Controls.Add(this.maskedTextBox3);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PatientsList";
            this.Text = "PatientsList";
            this.Load += new System.EventHandler(this.PatientsList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nLHDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nLHDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bedsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bedsBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox4;
        private System.Windows.Forms.MaskedTextBox maskedTextBox5;
        private System.Windows.Forms.MaskedTextBox maskedTextBox6;
        private System.Windows.Forms.MaskedTextBox maskedTextBox7;
        private System.Windows.Forms.MaskedTextBox maskedTextBox8;
        private System.Windows.Forms.MaskedTextBox maskedTextBox9;
        private System.Windows.Forms.MaskedTextBox maskedTextBox10;
        private System.Windows.Forms.MaskedTextBox maskedTextBox11;
        private System.Windows.Forms.MaskedTextBox maskedTextBox12;
        private System.Windows.Forms.MaskedTextBox maskedTextBox13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button AddPatientbutton;
        private System.Windows.Forms.Button Updatebutton;
        private System.Windows.Forms.MaskedTextBox maskedTextBox14;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button Exitbutton;
        private System.Windows.Forms.BindingSource nLHDataSetBindingSource;
        private NLHDataSet nLHDataSet;
        private System.Windows.Forms.BindingSource bedsBindingSource;
        private NLHDataSetTableAdapters.BedsTableAdapter bedsTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource bedsBindingSource1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button ListPatientbutton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox AdmitPatientIDtextBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
    }
}