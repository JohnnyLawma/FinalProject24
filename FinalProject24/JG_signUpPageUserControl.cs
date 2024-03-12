using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject24
{
    public partial class JG_signUpPageUserControl : UserControl
    {

        private static JG_signUpPageUserControl _instance;

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

        private void createAccountButton_Click(object sender, EventArgs e)
        {
            newName = nameTextBox.Text;
            newEmail = emailTextBox.Text;
            newPassword = passwordTextBox.Text;
            confirmPassword = confirmPasswordTextBox.Text;
            if (!CheckPassword())
            {
                MessageBox.Show("Passwords do not match!!!");
            }
        }
        private bool CheckPassword()
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
            JG_signUpPageUserControl.Instance.SendToBack();
        }
    }
}
