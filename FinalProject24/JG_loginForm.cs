using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FinalProject24
{
    public partial class JG_loginForm : Form
    {
        public JG_loginForm()
        {
            InitializeComponent();
        }

        // before implementation of a csv for email and password, use these 
        const string customerEMAIL = "123";
        const string customerPASSWORD = "123";
        const string managerEMAIL = "456";
        const string managerPASSWORD = "456";


        // Loading the main form and the manager main form in memory
        mainPageForm1 loadMainForm = new mainPageForm1();
        ManagerMainPageForm loadManagerForm = new ManagerMainPageForm();


        //
        private async void signinButton_Click(object sender, EventArgs e)
        {
            string inputEmail = emailTextBox.Text.Trim(); // Trim input values
            string inputPassword = passwordTextBox.Text.Trim();

            // Clear any previous error messages
            successOrNotLabel.Text = "";

            if (string.IsNullOrWhiteSpace(inputEmail) || string.IsNullOrWhiteSpace(inputPassword))
            {
                successOrNotLabel.Text = "Please enter both an email and a password.";
                return;
            }

            // Check manager credentials first
            if (inputEmail == managerEMAIL && inputPassword == managerPASSWORD)
            {
                // Logic for successful manager login
                successOrNotLabel.ForeColor = System.Drawing.Color.Green;
                successOrNotLabel.Text = "Success! Welcome, Manager!";
                await Task.Delay(1000); // Wait for 1 second to show success message

                loadManagerForm.Show(); // Open the manager main form
                ResetTextFields();
                this.Hide(); // Hide the Login Form
            }
            else
            {
                // Check customer credentials
                string userRole;
                if (AccountExists(inputEmail, inputPassword, out userRole))
                {
                    // Logic for successful customer login
                    successOrNotLabel.ForeColor = System.Drawing.Color.Green;
                    successOrNotLabel.Text = "Success! Welcome back, Customer!";
                    await Task.Delay(1000); // Wait for 1 second to show success message

                    loadMainForm.Show(); // Open the customer main form
                    ResetTextFields();
                    this.Hide(); // Hide the Login Form
                }
                else
                {
                    // Logic for failed login
                    successOrNotLabel.ForeColor = System.Drawing.Color.Red;
                    successOrNotLabel.Text = "The email or password was incorrectly.";
                    await Task.Delay(1000); // Wait for 1 second to show the error message
                }
            }
        }





        private void ResetTextFields()
        {
            emailTextBox.Text = "Enter your email";
            emailTextBox.ForeColor = SystemColors.WindowText;
            passwordTextBox.Text = "Enter your password";
            passwordTextBox.ForeColor = SystemColors.WindowText;
            successOrNotLabel.Text = "";
        }



        //
        private bool AccountExists(string email, string password, out string userRole)
        {
            // Define the directory where the user folders are stored
            string relativePath = @"..\..\..\..\CustomerUserFolder\"; // Adjust this path as needed
            string directoryPath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativePath));

            if (!Directory.Exists(directoryPath))
            {
                Debug.WriteLine("Directory not found: " + directoryPath);
                userRole = null;
                return false;
            }

            foreach (string userIDFolder in Directory.GetDirectories(directoryPath))
            {
                string userID = Path.GetFileName(userIDFolder);
                string passwordFilePath = Path.Combine(userIDFolder, "password.txt");

                if (File.Exists(passwordFilePath))
                {
                    string storedHashedPassword = File.ReadAllText(passwordFilePath).Trim(); // Trim whitespace
                    string inputHashedPassword = SecurityHelper.HashPassword(password.Trim()); // Trim whitespace

                    Debug.WriteLine($"User ID: {userID}");
                    Debug.WriteLine($"Stored hashed password: {storedHashedPassword}");
                    Debug.WriteLine($"Input hashed password: {inputHashedPassword}");

                    if (inputHashedPassword.Equals(storedHashedPassword, StringComparison.OrdinalIgnoreCase))
                    {
                        string profileFilePath = Path.Combine(userIDFolder, "profile.csv");

                        if (File.Exists(profileFilePath))
                        {
                            string[] profileData = File.ReadAllLines(profileFilePath);
                            if (profileData.Length >= 2)
                            {
                                string[] profileFields = profileData[1].Split(',');
                                if (profileFields.Length >= 3)
                                {
                                    userRole = profileFields[2].Trim(); // Assuming role is in the 3rd position
                                    return true;
                                }
                            }
                        }
                    }
                }
            }

            userRole = null;
            return false;
        }






        private void signupLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!panel1.Controls.Contains(JG_signUpPageUserControl.Instance))
            { // check if there is an instance of the user control, and if not then add the instance
                panel1.Controls.Add(JG_signUpPageUserControl.Instance);
                panel1.Controls.Add(JG_blankPageUserControl.Instance);
                JG_signUpPageUserControl.Instance.Dock = DockStyle.Fill;
                JG_signUpPageUserControl.Instance.BringToFront();
                JG_blankPageUserControl.Instance.SendToBack(); // change ordering of the user controls
            }
            else
            {
                JG_signUpPageUserControl.Instance.BringToFront();
            }
        }

        private void emailTextBox_Enter(object sender, EventArgs e)
        {
            // also use these as a template to hide the text
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


        private void signinButton_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) // map the enter key to do the same as clicking the button
            {
                signinButton_Click(sender, e);
                e.Handled = true;
            }
        }

        private void passwordTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                signinButton_Click(sender, e);
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

        private void JG_loginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
