using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace validationform_task4
{
    public partial class loginform : Form
    {
        public loginform()
        {
            InitializeComponent();
        }

        private void buttonsignin_Click(object sender, EventArgs e)
        {
            validateuserusername();
            validateuserpassword();
            if (label1.Text != "" || labelpswd.Text != "")
            {
                MessageBox.Show("Invalid form.Please sign in again!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Login Successfull", "Login Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
             //   Form form = new Form();
               // form.Hide();
               Contactform contactform = new Contactform();
                contactform.ShowDialog();
                //this.Show();
            }

        }

        private void txtusername_Validating(object sender, CancelEventArgs e)
        {
            validateuserusername();

        }

        private void validateuserusername()
        {
            string username = txtusername.Text.Trim();
            if (string.IsNullOrEmpty(username))
            {
                label1.Text = "Field is required";
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(username, "^[a-zA-Z]+$"))
            {
                label1.Text = "Username should have alphabets only";
            }
            else
            {
                label1.Text = "";
            }
        }
        private void txtpassword_Validating(object sender, CancelEventArgs e)
        {
            validateuserpassword();

        }

        private void validateuserpassword()
        {
            string password = txtpassword.Text.Trim();
            string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$";

            if (string.IsNullOrEmpty(password))
            {
                labelpswd.Text = "Field is required";
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(password, pattern))
            {
                labelpswd.Text = "Minimum 8 characters with atleast One capital letter,small letter,number,symbol";
            }
            else
            {
                labelpswd.Text = "";
            }
        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {
          
        }
        //to go to sign in option
        private void buttonsignup_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
