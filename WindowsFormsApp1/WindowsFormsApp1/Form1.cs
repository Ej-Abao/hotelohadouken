using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        string connString = "Server=LAPTOP-FEBN0K9O\\MSSQLSERVER02;Database=HoteloDB;Trusted_Connection=True;";

        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void usernameTxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passTxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            string username = usernameTxtbox.Text;
            string password = passTxtbox.Text;

            if (username == "" || password == "")
            {
                MessageBox.Show("Please enter username and password.");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(connString))
                {
                    con.Open();

                    string query = "SELECT COUNT(*) FROM UsersData WHERE Username=@u AND Password=@p";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@u", username);
                    cmd.Parameters.AddWithValue("@p", password);

                    int count = (int)cmd.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("Login Successful!");

                        
                        Menu menuForm = new Menu();
                        menuForm.Show();

                        
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection error: " + ex.Message);
            }
        }

        private void linkSignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registration reg = new Registration(); 
            reg.Show();
            this.Hide();
        }

        private void Hotelo_Click(object sender, EventArgs e)
        {

        }
    }
}