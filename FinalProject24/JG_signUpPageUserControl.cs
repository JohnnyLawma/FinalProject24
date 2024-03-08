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
    }
}
