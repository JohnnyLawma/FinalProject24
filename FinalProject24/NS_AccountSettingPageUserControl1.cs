using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;

namespace FinalProject24
{
    public partial class NS_AccountSettingPageUserControl1 : UserControl
    {
        private static NS_AccountSettingPageUserControl1 _instance;
        private Dictionary<string, string> userDetails = new Dictionary<string, string>();
        private string userEmail;

        private const string CsvFilePath = @"../../../../loginInfo";

        public static NS_AccountSettingPageUserControl1 Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new NS_AccountSettingPageUserControl1();
                }
                return _instance;
            }
        }

        public NS_AccountSettingPageUserControl1()
        {
            InitializeComponent();
            userEmail = Environment.GetEnvironmentVariable("customerEmailEnv");
            LoadUserData();
            UpdateTextBoxes();
        }

        private void LoadUserData()
        {
            string[] files = Directory.GetFiles(CsvFilePath, "*.csv");
            foreach (var file in files)
            {
                var lines = File.ReadAllLines(file);
                if (lines.Length > 1) // Ensure there is more than just the header line
                {
                    var headers = lines[0].Split(',').Select(h => h.Trim()).ToList();

                    for (int j = 1; j < lines.Length; j++) // Iterate over each data line, not just the first
                    {
                        var values = lines[j].Split(',').Select(v => v.Trim()).ToList();

                        if (values.Count < headers.Count)
                        {
                            MessageBox.Show($"Data row {j} in file {file} is missing some values and has been skipped.");
                            continue;  // Skip this iteration if there aren't enough values
                        }

                        int emailIndex = headers.IndexOf("Email");

                        if (emailIndex != -1 && values[emailIndex].Equals(userEmail, StringComparison.OrdinalIgnoreCase))
                        {
                            for (int i = 0; i < headers.Count; i++)
                            {
                                userDetails[headers[i]] = values[i];
                            }
                            break; // Stop searching once the correct file is found
                        }
                    }
                }
            }

            if (userDetails.Count == 0)
            {
                MessageBox.Show("No user data file found for the provided email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void UpdateTextBoxes()
        {

            NametextBox.Text = userDetails.ContainsKey("Name") ? userDetails["Name"] : "Default Name";
            EmailtextBox.Text = userDetails.ContainsKey("Email") ? userDetails["Email"] : "Default Email";
            PhonetextBox.Text = userDetails.ContainsKey("Phone Number") ? userDetails["Phone Number"] : "Default Phone Number";
        }

        private void Applybutton_Click(object sender, EventArgs e)
        {
            // Only update name, email, and phone number. Do not update password or customer/manager status.
            string newName = textBox3.Text.Trim();
            string newEmail = textBox4.Text.Trim();
            string newPhone = textBox5.Text.Trim();

            // Retain the old email to find the correct CSV record
            string oldEmail = userEmail;

            // Update the userDetails dictionary
            userDetails["Name"] = newName;
            userDetails["Email"] = newEmail;
            userDetails["Phone Number"] = newPhone;

            // Now find the file path using the old email
            string filePath = FindCsvFilePath(oldEmail);
            if (!string.IsNullOrEmpty(filePath))
            {
                UpdateCsvFile(filePath, oldEmail);  // Pass in the oldEmail for comparison
                MessageBox.Show("Changes saved successfully!");

                // Update the global email variable and the environment variable after a successful update
                userEmail = newEmail;
                Environment.SetEnvironmentVariable("customerEmailEnv", newEmail);
                LoadUserData();
                UpdateTextBoxes();
            }
            else
            {
                MessageBox.Show("Failed to find the CSV file to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void UpdateCsvFile(string filePath, string oldEmail)
        {
            var lines = File.ReadAllLines(filePath).ToList();
            var headers = lines[0].Split(',').Select(h => h.Trim()).ToList();
            int emailIndex = headers.IndexOf("Email");
            int nameIndex = headers.IndexOf("Name");
            int phoneNumberIndex = headers.IndexOf("Phone Number");

            List<string> updatedLines = new List<string>() { lines[0] }; // Start with the headers

            bool foundAndUpdated = false;

            for (int i = 1; i < lines.Count; i++)
            {
                var fields = lines[i].Split(',').Select(f => f.Trim()).ToArray();
                if (fields.Length > emailIndex && fields[emailIndex].Equals(oldEmail, StringComparison.OrdinalIgnoreCase))
                {
                    // Update only the name, email, and phone number
                    if (nameIndex != -1) fields[nameIndex] = userDetails["Name"];
                    if (emailIndex != -1) fields[emailIndex] = userDetails["Email"];
                    if (phoneNumberIndex != -1) fields[phoneNumberIndex] = userDetails["Phone Number"];

                    updatedLines.Add(string.Join(",", fields));
                    foundAndUpdated = true;
                }
                else
                {
                    updatedLines.Add(lines[i]);  // Keep other entries unchanged
                }
            }

            if (!foundAndUpdated)
            {
                MessageBox.Show("No entry found for the original email to update.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                File.WriteAllLines(filePath, updatedLines);
            }
        }


        private string FindCsvFilePath(string email)
        {
            string directoryPath = Path.Combine(Directory.GetCurrentDirectory(), CsvFilePath);
            Console.WriteLine("Searching in directory: " + directoryPath);  // Debug output
            string[] files = Directory.GetFiles(directoryPath, "*.csv");

            foreach (string file in files)
            {
                Console.WriteLine("Checking file: " + file);  // Debug output
                var lines = File.ReadAllLines(file);
                if (lines.Length > 1)
                {
                    var headers = lines[0].Split(',').Select(h => h.Trim()).ToList();
                    int emailIndex = headers.IndexOf("Email");
                    var values = lines[1].Split(',').Select(v => v.Trim()).ToArray();
                    Console.WriteLine("Current checking email: " + values[emailIndex]); // Debug output

                    if (values.Length > emailIndex && values[emailIndex].Equals(email, StringComparison.OrdinalIgnoreCase))
                    {
                        return file;
                    }
                }
            }
            MessageBox.Show("No matching email found in any CSV files.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return null;
        }



        private string ValidateEmail(string email, string currentEmail)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address;
            }
            catch
            {
                MessageBox.Show("Invalid email format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return currentEmail;
            }
        }

        private string FormatPhoneNumber(string phoneNumber)
        {
            if (Regex.IsMatch(phoneNumber, "[a-zA-Z]"))
            {
                MessageBox.Show("Phone number cannot contain letters.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return phoneNumber;
            }

            if (phoneNumber.Length == 10)
            {
                return $"{phoneNumber.Substring(0, 3)}-{phoneNumber.Substring(3, 3)}-{phoneNumber.Substring(6)}";
            }
            else
            {
                MessageBox.Show("Phone number must contain 10 digits.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return phoneNumber;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
