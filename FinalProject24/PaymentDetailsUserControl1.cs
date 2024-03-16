﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject24
{
    public partial class PaymentUserControl1 : UserControl
    {

        private static PaymentUserControl1 _instance;


        private PaymentUserControl1()
        {
            InitializeComponent();
        }


        public static PaymentUserControl1 Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new PaymentUserControl1();
                }
                return _instance;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Validate Address (not empty)
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Address cannot be empty.");
                return;
            }

            // Validate Card Number (not empty and valid format)
            if (!IsValidCardNumber(textBox2.Text))
            {
                MessageBox.Show("Invalid card number.");
                return;
            }

            // Validate Card Holder's Name (not empty)
            if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Card holder's name cannot be empty.");
                return;
            }

            // Validate CVV (3 or 4 digits)
            if (!IsValidCVV(textBox4.Text))
            {
                MessageBox.Show("Invalid CVV number. It must be 3 or 4 digits.");
                return;
            }

            // Validate Expiry Date (MM/yy format and not past)
            if (!IsValidExpiryDate(textBox5.Text))
            {
                MessageBox.Show("Invalid or past expiry date.");
                return;
            }

            MessageBox.Show("Payment details saved successfully.");
        }
        // Helper method to validate card number with Luhn's Algorithm
        private bool IsValidCardNumber(string cardNumber)
        {
            int sum = 0;
            bool alternate = false;

            // Reverse the card number
            char[] nums = cardNumber.Reverse().ToArray();

            for (int i = 0; i < nums.Length; i++)
            {
                if (!char.IsDigit(nums[i]))
                    return false; // Not a numeric digit

                // Parse to integer to calculate sum
                int num = int.Parse(nums[i].ToString());

                if (alternate)
                {
                    num *= 2;
                    if (num > 9)
                    {
                        num = (num % 10) + 1;
                    }
                }

                sum += num;
                alternate = !alternate;
            }

            // Valid if sum is a multiple of 10
            return (sum % 10 == 0);
        }

        // Helper method to validate CVV without regex
        private bool IsValidCVV(string cvv)
        {
            int cvvNum;
            return (cvv.Length == 3 || cvv.Length == 4) && int.TryParse(cvv, out cvvNum);
        }

        // Helper method to validate expiry date without regex
        private bool IsValidExpiryDate(string expiryDate)
        {
            if (expiryDate.Length != 5 || expiryDate[2] != '/')
            {
                return false;
            }

            if (!int.TryParse(expiryDate.Substring(0, 2), out int month) ||
                !int.TryParse(expiryDate.Substring(3, 2), out int year))
            {
                return false;
            }

            if (month < 1 || month > 12)
            {
                return false;
            }

            int currentYear = DateTime.Now.Year % 100; // Get last two digits of the year
            int currentMonth = DateTime.Now.Month;

            // Check if the year is valid (00 to 99) and not in the past
            if (year < currentYear || (year == currentYear && month < currentMonth))
            {
                return false;
            }

            return true;
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "123 Street Name, City, State")
            {
                textBox1.Text = "";
                textBox1.ForeColor = SystemColors.WindowText;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.Text = "123 Street Name, City, State";
                textBox1.ForeColor = Color.Gray;
            }
        }

        private void textBox6_Enter(object sender, EventArgs e)
        {
            if (textBox6.Text == "Zip Code")
            {
                textBox6.Text = "";
                textBox6.ForeColor = SystemColors.WindowText;
            }
        }

        private void textBox6_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox6.Text))
            {
                textBox6.Text = "Zip Code";
                textBox6.ForeColor = Color.Gray;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "6037-9973-2234-7221")
            {
                textBox2.Text = "";
                textBox2.ForeColor = SystemColors.WindowText;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                textBox2.Text = "6037-9973-2234-7221";
                textBox2.ForeColor = Color.Gray;
            }
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (textBox4.Text == "CV")
            {
                textBox4.Text = "";
                textBox4.ForeColor = SystemColors.WindowText;
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox4.Text))
            {
                textBox4.Text = "CV";
                textBox4.ForeColor = Color.Gray;
            }
        }

        private void textBox5_Enter(object sender, EventArgs e)
        {
            if (textBox5.Text == "MM/YY")
            {
                textBox5.Text = "";
                textBox5.ForeColor = SystemColors.WindowText;
            }
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox5.Text))
            {
                textBox5.Text = "MM/YY";
                textBox5.ForeColor = Color.Gray;
            }
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox5.Text == "Full Name")
            {
                textBox5.Text = "";
                textBox5.ForeColor = SystemColors.WindowText;
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox5.Text))
            {
                textBox5.Text = "Full Name";
                textBox5.ForeColor = Color.Gray;
            }
        }
     
    }
}
