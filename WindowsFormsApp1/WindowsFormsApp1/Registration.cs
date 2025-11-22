using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void linkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 login = new Form1();  //  Login form
            login.Show();
            this.Hide();  // HIDE Registration form
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(usernametxtbox.Text) ||
               string.IsNullOrWhiteSpace(passTxtbox.Text)  ||
               string.IsNullOrWhiteSpace(nameTxtbox.Text)  ||
               string.IsNullOrWhiteSpace(emailTxtbox.Text) ||
               string.IsNullOrWhiteSpace(phoneNumTxtbox.Text))
            {
                MessageBox.Show("Please fill the missing fields in order to continue", "Missing Fields",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }  


            using (var db = new HoteloDBEntities())
            {
                // change ning "UserTable" baii. Dapat same table name diha sa ssms
                UsersTable addUser = new UsersTable()
                {
                    Username = usernametxtbox.Text,
                    Password = passTxtbox.Text,
                    Fullname = nameTxtbox.Text,
                    Email = emailTxtbox.Text,
                    PhoneNumber = phoneNumTxtbox.Text
                };

                 db.UsersTables.Add(addUser); // tables lagini bai
                 db.SaveChanges();

                //Change nya ni Messagebox bai | Kay naka red highlight sa part nako 
                MessageBox.Show("Successfully created an account", "Account Created",
                                 MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                
                Form1 login = new Form1();
                login.Show();
                this.Hide();
                
            }   
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void usernametxtbox_TextChanged(object sender, EventArgs e)
        {

        }
    }//
}
