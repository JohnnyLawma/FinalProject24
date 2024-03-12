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

        // before implementation of a database for email and password, use these 
        const string customerEMAIL = "abc@gmail.com";
        const string customerPASSWORD = "abcde";
        const string managerEMAIL = "abc@gmail.com";
        const string managerPASSWORD = "abcde";


        // Loading the main Form in Memeory
        mainPageForm1 loadMainForm = new mainPageForm1();


        private void signinButton_Click(object sender, EventArgs e)
        {
            if (emailTextBox.Text == customerEMAIL && passwordTextBox.Text == customerPASSWORD)
            {
                MessageBox.Show("You have logged in! Welcome back Customer!");
                this.Hide(); // Hiding the Login Form
                loadMainForm.Show(); // Opening the Main Menu Form
            }
            else if (emailTextBox.Text == managerEMAIL && passwordTextBox.Text == managerPASSWORD)
            {
                MessageBox.Show("You have logged in! Welcome back Manager!");
            }
            else if (emailTextBox.Text == "Enter your email" || passwordTextBox.Text == "Enter your password")
            {
                MessageBox.Show("Please enter your email and password.");
            }
            else
            {
                MessageBox.Show("The email or password was entered incorrectly. Try again!");
            }
        }

        private void signupLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!panel1.Controls.Contains(JG_signUpPageUserControl.Instance))
            {
                panel1.Controls.Add(JG_signUpPageUserControl.Instance);
                panel1.Controls.Add(JG_managerLoginPageUserControl.Instance);
                JG_signUpPageUserControl.Instance.Dock = DockStyle.Fill;
                JG_signUpPageUserControl.Instance.BringToFront();
                JG_managerLoginPageUserControl.Instance.SendToBack();
            }
            else
            {
                JG_signUpPageUserControl.Instance.BringToFront();
            }
        }
    }
}
