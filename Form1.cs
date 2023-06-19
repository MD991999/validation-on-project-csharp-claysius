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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
         
        }


    

        private void txtFirstname_Leave(object sender, EventArgs e)
        {
            string firstName = txtFirstname.Text.Trim();

            // Check if first name is empty or contains non-alphabetic characters
            if (string.IsNullOrEmpty(firstName) || !System.Text.RegularExpressions.Regex.IsMatch(firstName, @"^[A-Za-z]+$"))
            //string.IsNullOrEmpty() is a convenient way to check whether a given string is null or empty, and it is a static method of the string class, so you need to specify the class name string before calling it.

            //System.Text.RegularExpressions: This is the namespace that contains classes and methods related to regular expressions in .NET.
            //REGEX is the class within the System.Text.RegularExpressions namespace .IsMatch(): This is a static method of the Regex class. It is used to determine whether a specified input string matches a given regular expression pattern.
            {
                errorProvider1.SetError(txtFirstname, "First name should be non-empty and contain only alphabetic characters.");        
                //SetError() method, you can set the error message for a specific control and have the ErrorProvider component handle the visual representation of the error.

                return;
            }
            else
            {
                errorProvider1.SetError(txtFirstname, "");
            }
        }

      

       
        //validation for lastname
        private void txtlastname_Leave(object sender, EventArgs e)
        {
string lastname=txtlastname.Text.Trim();
            if (string.IsNullOrEmpty(lastname) || !System.Text.RegularExpressions.Regex.IsMatch(lastname, @"^[A-Za-z]+$"))
            {
                errorProvider1.SetError(txtlastname, "Lastname is required and should be alphaberts");
            }
            else
            {
                errorProvider1.SetError(txtlastname,"");
            }
        }

       

        //phone validation
        private void textBox4_Leave(object sender, EventArgs e)
        {
string phonenumber=txtphone.Text.Trim();
            if (string.IsNullOrEmpty(phonenumber) || !System.Text.RegularExpressions.Regex.IsMatch(phonenumber, @"^[0-9]{10}$"))
            {
                errorProvider1.SetError(txtphone, "Invalid phone number,10characters");
            }
            else
            {
                errorProvider1.SetError(txtphone, "");
            }
        }
        //email validation
        private void txtemail_Leave(object sender, EventArgs e)
        {
            string email=txtemail.Text.Trim();
            if (string.IsNullOrEmpty(email) || !System.Text.RegularExpressions.Regex.IsMatch(email, @"^[a-z0-9_.+-]+@[a-z0-9-]+\.[a-z0-9-.]+$")){
                errorProvider1.SetError(txtemail, "Invalid email format");
            }
            else
            {
                errorProvider1.SetError(txtemail, "");

            }
        }
      
        //username

        private void txtusername_Leave(object sender, EventArgs e)
        {
            string username = txtusername.Text.Trim();
            if (string.IsNullOrEmpty(username) || !System.Text.RegularExpressions.Regex.IsMatch(username, @"^[a-zA-Z]+$"))
            {
                errorProvider1.SetError(txtusername, "Only alphabets are applicable");
            }
            else
            {
                errorProvider1.SetError(txtusername, "");

            }
        }
        //password validation
        private void txtpassword_Leave(object sender, EventArgs e)
        {
            string password= txtpassword.Text.Trim();
            string pattern= @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$";
            string confirmpassword=txtconfirmpassword.Text.Trim(); 
            if (string.IsNullOrEmpty(password) || !System.Text.RegularExpressions.Regex.IsMatch(password,pattern))
            {
                errorProvider1.SetError(txtpassword, "Invalid password.Build  a strong password with minimum 8 characters,and must contain atleast a capital,small letter ,a number and a symbol");
            }
            else
            {
                errorProvider1.SetError(txtpassword,"");
                checkconfirmpassword();

            }
        }
        //logic for password checking
        private void txtpassword_KeyDown(object sender, KeyEventArgs e)
        {
            string password = txtpassword.Text.Trim();
            string confirmpassword = txtconfirmpassword.Text.Trim();
            checkconfirmpassword();
        }

        private void checkconfirmpassword()
        {
            string password = txtpassword.Text.Trim();
            string confirmpassword = txtconfirmpassword.Text.Trim();
            if (string.IsNullOrEmpty(confirmpassword))
            {
               
                errorProvider1.SetError(txtconfirmpassword, "Field is required");
            }
            else
            {

                errorProvider1.SetError(txtconfirmpassword, "");

            }

        }








        //address validation
        private void txtaddress_Leave(object sender, EventArgs e)
        {
            string address = txtaddress.Text.Trim();
            if (string.IsNullOrEmpty(address))
            {
                errorProvider1.SetError(txtaddress, "Please enter your address");
            }
            else
            {
                errorProvider1.SetError(txtaddress, "");

            }
        }
       
        //gender validation
        //checkedchanged-tis function is triggered when there is changes in the checked state of radio buttons

        private void radiobuttonmale_CheckedChanged(object sender, EventArgs e)
        {
            checkedgenderstate();
        }

        private void radiobuttonfemale_CheckedChanged(object sender, EventArgs e)
        {
            checkedgenderstate();

        }

        //gender validation logic
        private void checkedgenderstate()
        {
            if (!radiobuttonfemale.Checked && !radiobuttonmale.Checked)
            {
                errorProvider1.SetError(labelgender, "Please choose your gender");
            }
            else
            {
                errorProvider1.SetError(labelgender, "");

            }
        }
        //validation for state
     
        //date of birth
        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            //datetime:we use datetime in the beginning which means that the selectedDate is a variable of type DateTime, which means it can store and represent a specific date and time value.
            DateTime currentdate =DateTime.Now;
            DateTime selecteddate = dateTimePicker.Value;
            if(selecteddate > currentdate) {
                errorProvider1.SetError(dateTimePicker, "Invalid date");
                    }
            else
            {
                //age calculate
                errorProvider1.SetError(dateTimePicker, "");
                // Calculate the age based on the selected date
                //Timespan-used to measure elapsed time, durations, or intervals between two points in time.
                TimeSpan age = currentdate - selecteddate;
                //totaldays is the property of timespan,and returns the total number of days in the time span.
                int years = (int)(age.TotalDays / 365.25); // Assuming 365.25 days per year for better accuracy
                                                           // Use the calculated age as needed
                
                
                
                txtage.Text = years.ToString();




            }
        }
        //state-district relation:listing district dropdown according to state value
        private void comboboxstate_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedstate=comboboxstate.SelectedItem.ToString();
            ///list the district dropdown based on the selected state
            listdistrictofselectedstate(selectedstate);
            //comboboxdistrict.SelectedIndex = -1;
        }

        private void listdistrictofselectedstate(string selectedstate)
        {
           comboboxdistrict.Items.Clear();
            if (selectedstate == "Kerala")
            {
                comboboxdistrict.Items.Add("Thrissur");
                comboboxdistrict.Items.Add("Wayanad");
                comboboxdistrict.Items.Add("Thiruvanthapuram");
                comboboxdistrict.Items.Add("Kochi");
                comboboxdistrict.Items.Add("Kasargod");
                comboboxdistrict.Items.Add("Kannur");

            }
            else if (selectedstate == "Karnataka")
            {
                comboboxdistrict.Items.Add("Mysuru");
                comboboxdistrict.Items.Add("Kodagu");
                comboboxdistrict.Items.Add("Mandya");
                comboboxdistrict.Items.Add("Hassan");
                comboboxdistrict.Items.Add("Bengaluru");
                comboboxdistrict.Items.Add("Uduppi");

            }
            else if (selectedstate == "Tamilnadu")
            {
                comboboxdistrict.Items.Add("Chennai");
                comboboxdistrict.Items.Add("Coimbatore");
                comboboxdistrict.Items.Add("Cuddalore");
                comboboxdistrict.Items.Add("Erode");
                comboboxdistrict.Items.Add("Kanchipuram");
                comboboxdistrict.Items.Add("Madurai");

            }
        }
        //validation for state-whether the combobox is empty

        private void comboboxstate_Leave(object sender, EventArgs e)
        {
            if(comboboxstate.SelectedIndex == -1) {
                errorProvider1.SetError(comboboxstate, "Please choose from the dropdwn");
            }
            else
            {
                errorProvider1.SetError(comboboxstate, "");

            }
        }
        //validation for district-whether the combobox is empty

        private void comboboxdistrict_Leave(object sender, EventArgs e)
        {
            if (comboboxdistrict.SelectedIndex == -1)
            {
                errorProvider1.SetError(comboboxdistrict, "Please choose from the dropdwn");
            }
            else
            {
                errorProvider1.SetError(comboboxdistrict, "");

            }
        }
        //date validation
        private void dateTimePicker_Leave(object sender, EventArgs e)
        {
            if (dateTimePicker.Value.Date == DateTime.Now.Date ||dateTimePicker.Value>DateTime.Now)
            {
                errorProvider1.SetError(dateTimePicker, "Choose a valid date of birth");

            }
            else
            {
                errorProvider1.SetError(dateTimePicker, "");
            }
        }

        private void txtage_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtage.Text))
            {
                errorProvider1.SetError(txtage, "Choose a valid date of birth");
            }
            else
            {
                errorProvider1.SetError(txtage, "");
            }
        }

        private void buttonsignin_Click(object sender, EventArgs e)
        {
            this.Hide();
           loginform loginform = new loginform();
            loginform.ShowDialog();
            //showdialog = displays the form as a modal dialog box, which means it will block user interaction with other forms in the application until the dialog is closed.
            this.Show(); // Show the current form again after the login form is closed
        }
        //close tag of
        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
