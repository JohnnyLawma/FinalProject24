using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FinalProject24
{
    public partial class NS_AccountSettingPageUserControl1 : UserControl
    {

        private static NS_AccountSettingPageUserControl1 _instance;

        public static NS_AccountSettingPageUserControl1 Instance
        {
            get
            {
                // If the instance is null, create it
                if (_instance == null)
                {
                    _instance = new NS_AccountSettingPageUserControl1();
                }
                // Return the existing or new instance
                return _instance;
            }
        }



        // Variables for dummy values, when db connected this maybe changed
        private string name = "Emly King";
        private string email = "emlyking@gmail.com";
        private string phoneNumber = "615-564-3422";
        string name2, email2, phoneNumber2;

        public NS_AccountSettingPageUserControl1()
        {
            InitializeComponent();
            // Call UpdateTextBoxes() when the form is loaded to populate the textboxes
            UpdateTextBoxes();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //whoops
        }


        // Method to validate email format
        private string ValidateEmail(string email, string currentEmail)
        {
            try
            {
                // Attempt to create a MailAddress object with the provided email string
                var addr = new System.Net.Mail.MailAddress(email);

                // If creating the MailAddress object succeeds, it means the email format is valid
                // Return the normalized email address (this removes any extra whitespace or formatting)
                return addr.Address;
            }
            catch
            {
                // If creating the MailAddress object fails, it means the email format is invalid
                // Display an error message or handle the error accordingly
                MessageBox.Show("Invalid email format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // If creating the MailAddress object fails, it means the email format is invalid
                // Return the current email (the one already in the textbox)
                return currentEmail;
            }
        }

        // Method to format phone numbers with hyphens
        private string FormatPhoneNumber(string phoneNumber)
        {
            // Check if the phone number contains any letters
            if (Regex.IsMatch(phoneNumber, "[a-zA-Z]"))
            {
                // Display an error message or handle the error accordingly
                MessageBox.Show("Phone number cannot contain letters.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return phoneNumber; // Return as is
            }

            // Check if the phone number has exactly 10 digits
            if (phoneNumber.Length != 10)
            {
                // Display an error message or handle the error accordingly
                MessageBox.Show("Phone number must contain 10 digits.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return phoneNumber; // Return as is
            }

            // Format the phone number with hyphens
            if (phoneNumber.Length == 10) // Assuming the number is 10 digits
            {
                return $"{phoneNumber.Substring(0, 3)}-{phoneNumber.Substring(3, 3)}-{phoneNumber.Substring(6)}";
            }
            else
            {
                // Handle other cases, e.g., international numbers, differently
                // You can add your custom formatting rules here
                return phoneNumber;
            }
        }

        private void UpdateTextBoxes()
        {
            // In theory, these textboxes will pull information from the db
            // and display for the user; but when user alters the text, it should
            // alter the db as well
            NametextBox.Text = name;
            EmailtextBox.Text = email;
            PhonetextBox.Text = phoneNumber;
        }


        private void Applybutton_Click(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // When the user hits apply changes the text will be changed
            // for all three variables
            // Maybe when we have db we send the variables to db when updated?
            name2 = textBox3.Text;
            email2 = textBox4.Text;
            phoneNumber2 = textBox5.Text;




            // Update NametextBox, EmailtextBox, and PhonetextBox with the new values
            NametextBox.Text = name2;
            EmailtextBox.Text = ValidateEmail(email2, email);
            PhonetextBox.Text = FormatPhoneNumber(phoneNumber2);


            MessageBox.Show("Changes saved successfully!");
        }
    }
}
