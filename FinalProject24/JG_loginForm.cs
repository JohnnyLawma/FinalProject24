﻿using System;
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (emailTextBox.Text == customerEMAIL && passwordTextBox.Text == customerPASSWORD)
            {
                MessageBox.Show("You have logged in! Welcome back Customer!");
            }
            else if (emailTextBox.Text == managerEMAIL && passwordTextBox.Text == managerPASSWORD)
            {
                MessageBox.Show("You have logged in! Welcome back Manager!");
            }
            else if (emailTextBox.Text == "Enter your email" ||  passwordTextBox.Text == "Enter your password")
            {
                MessageBox.Show("Please enter your email and password.");
            }
            else
            {
                MessageBox.Show("The email or password was entered incorrectly. Try again!");
            }
        }
    }
}
