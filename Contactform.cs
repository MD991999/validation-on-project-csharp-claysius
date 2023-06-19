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
    public partial class Contactform : Form
    {
        public Contactform()
        {
            InitializeComponent();
        }

       

        

        
       

        
        //username validation
        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            usernamevalidation();
         
        }

        private void usernamevalidation()
        {
            string username = txtusername.Text;
            if ((string.IsNullOrEmpty(username) || !System.Text.RegularExpressions.Regex.IsMatch(username, "^[a-zA-Z]+$")))
            {
                labelusernamerror.Text = "Invalid username";
            }
            else
            {
                labelusernamerror.Text = "";

            }
        }


        //MESSAGE VALIDATION
        private void txtmessage_Validating(object sender, CancelEventArgs e)

        {
            messagevalidation();
           

        }

        private void messagevalidation()
        {
            string message = txtmessage.Text;
            if (string.IsNullOrEmpty(message) || !System.Text.RegularExpressions.Regex.IsMatch(message, "^[a-zA-Z]+$"))
            {
                labelmessageerror.Text = "Invalid password";
            }
            else
            {
                labelmessageerror.Text = "";

            }
        }

        //email validation

        private void txtemail_Validating(object sender, CancelEventArgs e)
        {
            emailvalidation();
          
        }

        private void emailvalidation()
        {
            string email = txtemail.Text;
            string pattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$"; ;
            if (string.IsNullOrEmpty(email) || !System.Text.RegularExpressions.Regex.IsMatch(email, pattern))
            {
                labemail.Text = "Invalid emailid";
            }
            else
            {
                labemail.Text = "";

            }
        }

        //mobile
        private void txtmobile_Validating(object sender, CancelEventArgs e)
        {
            mobilevalidation();
            
        }

        private void mobilevalidation()
        {
            string mobile = txtmobile.Text;
            string pattern = @"^[0-9]{10}$";
            if (string.IsNullOrEmpty(mobile) || !System.Text.RegularExpressions.Regex.IsMatch(mobile, pattern))
            {
                labelmobileerror.Text = "Invalid Mobile number";
            }
            else
            {
                labelmobileerror.Text = "";

            }
        }
        //submitting the form
        private void buttonsubmit_Click(object sender, EventArgs e)
        {
            usernamevalidation();
            messagevalidation();
            emailvalidation();
            mobilevalidation();
            if (labelmobileerror.Text != "" || labemail.Text != "" || labelmessageerror.Text != "" || labelusernamerror.Text != "")
            {
                MessageBox.Show("All fields are required!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Message submitted successfully!!", "Submit", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }


        }
        //contactform cancel button
        private void buttoncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
