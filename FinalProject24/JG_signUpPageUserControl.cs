using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace FinalProject24
{
    public partial class JG_signUpPageUserControl : UserControl 
    {

        public static JG_signUpPageUserControl _instance; // make an instance of the UC

        public static JG_signUpPageUserControl Instance
        {
            get
            {
                // If the instance is null, create it
                if (_instance == null)
                {
                    _instance = new JG_signUpPageUserControl();
                }
                // Return the existing or new instance
                return _instance;

            }
        }

        public JG_signUpPageUserControl()
        {
            InitializeComponent();
        }

        string newEmail, newPassword, newName, confirmPassword;
        bool isCustomer;

        private void createAccountButton_Click(object sender, EventArgs e)
        {
            newName = nameTextBox.Text; // save new account variables 
            newEmail = emailTextBox.Text;
            newPassword = passwordTextBox.Text;
            confirmPassword = confirmPasswordTextBox.Text;
            if (!CheckPassword()) // check if the passwords match
            {
                MessageBox.Show("Passwords do not match!!!");
            }
            else
            {
                MessageBox.Show("Your account was successfully created!");
            }
        }
        private bool CheckPassword() // bool function that determines if the passwords match
        {
            bool result = false;
            if (newPassword == confirmPassword)
            {
                result = true;
            }
            return result;
        }

        private void loginLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            JG_signUpPageUserControl.Instance.SendToBack(); // go back to the login form by hiding the UC
        }

        private void nameTextBox_Enter(object sender, EventArgs e) // more code to make the text grey and hidden while typing
        {
            if (nameTextBox.Text == "Enter your name")
            {
                nameTextBox.Text = "";
                nameTextBox.ForeColor = SystemColors.WindowText;
            }
        }

        private void nameTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameTextBox.Text))
            {
                nameTextBox.Text = "Enter your name";
                nameTextBox.ForeColor = Color.Gray;
            }
        }

        private void emailTextBox_Enter(object sender, EventArgs e)
        {
            if (emailTextBox.Text == "Enter your email")
            {
                emailTextBox.Text = "";
                emailTextBox.ForeColor = SystemColors.WindowText;
            }
        }

        private void emailTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(emailTextBox.Text))
            {
                emailTextBox.Text = "Enter your email";
                emailTextBox.ForeColor = Color.Gray;
            }
        }

        private void passwordTextBox_Enter(object sender, EventArgs e)
        {
            if (passwordTextBox.Text == "Enter your password")
            {
                passwordTextBox.Text = "";
                passwordTextBox.ForeColor = SystemColors.WindowText;
            }
        }

        private void passwordTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(passwordTextBox.Text))
            {
                passwordTextBox.Text = "Enter your password";
                passwordTextBox.ForeColor = Color.Gray;
            }
        }

        private void confirmPasswordTextBox_Enter(object sender, EventArgs e)
        {
            if (confirmPasswordTextBox.Text == "Confirm your password")
            {
                confirmPasswordTextBox.Text = "";
                confirmPasswordTextBox.ForeColor = SystemColors.WindowText;
            }
        }

        private void confirmPasswordTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(confirmPasswordTextBox.Text))
            {
                confirmPasswordTextBox.Text = "Confirm your password";
                confirmPasswordTextBox.ForeColor = Color.Gray;
            }
        }

        private void nameTextBox_KeyPress(object sender, KeyPressEventArgs e) // make the enter button move forward just like the tab button
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                customerRadioButton.Focus();
                customerRadioButton.Checked = false;
                e.Handled = true;
            }
        }

        private void emailTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                passwordTextBox.Focus();
                e.Handled = true;
            }
        }

        private void passwordTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                confirmPasswordTextBox.Focus();
                e.Handled = true;
            }
        }

        private void confirmPasswordTextBox_KeyPress(object sender, KeyPressEventArgs e) // and at the end of the form, make enter click the button
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                createAccountButton_Click(sender, e);
                e.Handled = true;
            }
        }

        private void customerRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // user is a customer
            isCustomer = true;
        }

        private void managerRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // user is a manager
            isCustomer = false;
        }
    }
}
