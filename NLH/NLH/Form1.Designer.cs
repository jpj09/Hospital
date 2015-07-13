namespace NLH
{
    partial class Form1
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
            this.UserNametextBox = new System.Windows.Forms.TextBox();
            this.PasswordtextBox = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.Exitbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UserNametextBox
            // 
            this.UserNametextBox.Location = new System.Drawing.Point(165, 105);
            this.UserNametextBox.Name = "UserNametextBox";
            this.UserNametextBox.Size = new System.Drawing.Size(100, 20);
            this.UserNametextBox.TabIndex = 0;
            this.UserNametextBox.TextChanged += new System.EventHandler(this.UserNametextBox_TextChanged);
            // 
            // PasswordtextBox
            // 
            this.PasswordtextBox.Location = new System.Drawing.Point(165, 156);
            this.PasswordtextBox.Name = "PasswordtextBox";
            this.PasswordtextBox.PasswordChar = '*';
            this.PasswordtextBox.Size = new System.Drawing.Size(100, 20);
            this.PasswordtextBox.TabIndex = 1;
            this.PasswordtextBox.TextChanged += new System.EventHandler(this.PasswordtextBox_TextChanged);
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(50, 214);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(75, 23);
            this.LoginButton.TabIndex = 2;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // Exitbutton
            // 
            this.Exitbutton.Location = new System.Drawing.Point(165, 214);
            this.Exitbutton.Name = "Exitbutton";
            this.Exitbutton.Size = new System.Drawing.Size(75, 23);
            this.Exitbutton.TabIndex = 3;
            this.Exitbutton.Text = "Exit";
            this.Exitbutton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "USERNAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "PASSWORD";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Exitbutton);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.PasswordtextBox);
            this.Controls.Add(this.UserNametextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserNametextBox;
        private System.Windows.Forms.TextBox PasswordtextBox;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Button Exitbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

