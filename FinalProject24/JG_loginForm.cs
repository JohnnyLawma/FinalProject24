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

        private async void signinButton_Click(object sender, EventArgs e)
        {
            if (emailTextBox.Text == customerEMAIL && passwordTextBox.Text == customerPASSWORD)
            {
                Environment.SetEnvironmentVariable("customerEmailEnv", emailTextBox.Text);
                successOrNotLabel.ForeColor = System.Drawing.Color.Green;
                successOrNotLabel.Text = "Success! Welcome back Customer!";

                // Wait for 1 seconds to show sucess message.
                await Task.Delay(1000);

                loadMainForm.Show(); // Opening the Main Menu Form
                this.Hide(); // Hiding the Login Form

                if (emailTextBox.Text != "Enter your email") // use this as a template to get hidden text for the other textboxes
                {
                    emailTextBox.Text = "Enter your email";
                    emailTextBox.ForeColor = SystemColors.WindowText;
                }
                if (passwordTextBox.Text != "Enter your password")
                {
                    passwordTextBox.Text = "Enter your password";
                    passwordTextBox.ForeColor = SystemColors.WindowText;
                }

                successOrNotLabel.Text = "";

            }
            else if (emailTextBox.Text == managerEMAIL && passwordTextBox.Text == managerPASSWORD)
            {
                Environment.SetEnvironmentVariable("managerEmailEnv", emailTextBox.Text);
                successOrNotLabel.ForeColor = System.Drawing.Color.Green;
                successOrNotLabel.Text = "Success! Welcome back Manager!";

                // Wait for 1 seconds to show sucess message.
                await Task.Delay(1000);

                loadManagerForm.Show(); // Opening the Main Menu Form
                this.Hide(); // Hiding the Login Form

                if (emailTextBox.Text != "Enter your email")
                {
                    emailTextBox.Text = "Enter your email";
                    emailTextBox.ForeColor = SystemColors.WindowText;
                }
                if (passwordTextBox.Text != "Enter your password")
                {
                    passwordTextBox.Text = "Enter your password";
                    passwordTextBox.ForeColor = SystemColors.WindowText;
                }

                successOrNotLabel.Text = "";

            }
            else if (emailTextBox.Text == "Enter your email" || passwordTextBox.Text == "Enter your password")
            {
                successOrNotLabel.ForeColor = System.Drawing.Color.Yellow;
                successOrNotLabel.Text = "Please enter your email and password.";
                emailTextBox.Focus();

                // Wait for 1 seconds to show sucess message.
                await Task.Delay(1000);
            }
            else //
            {
                //MessageBox.Show("The email or password was entered incorrectly. Try again!");
                successOrNotLabel.ForeColor = System.Drawing.Color.Red;
                successOrNotLabel.Text = "The email or password was entered incorrectly";
                emailTextBox.Focus();

                // Wait for 1 seconds to show sucess message.
                await Task.Delay(1000);
            }
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
