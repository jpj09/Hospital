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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string _queryLogin = "SELECT * FROM Users WHERE Username=@User and Passwrd =@Pass ";

            string connectionString = "Data Source=(local);Initial Catalog=NLH;" + "Integrated Security=true";
            string txtuser = UserNametextBox.Text;
            string txtpass = PasswordtextBox.Text;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand comm = new SqlCommand(_queryLogin, connection);
                    comm.Parameters.AddWithValue("@User",txtuser);
                    comm.Parameters.AddWithValue("@Pass",txtpass );


                    SqlDataReader dr = comm.ExecuteReader();
                    
                    int count = 0;
                    while (dr.Read())
                    {
                        count += 1;
                    }
                    if (count == 1)
                    {
                        MessageBox.Show("OK");

                        MainMenu mm = new MainMenu();
                        mm.ShowDialog();
                        this.Hide();
                    }
                    else if (count > 0)
                    {
                        MessageBox.Show("Duplicate found");
                    }
                    else
                    {
                        MessageBox.Show("Incorrect username or password");
                    }

                }

        }

        private void UserNametextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordtextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
