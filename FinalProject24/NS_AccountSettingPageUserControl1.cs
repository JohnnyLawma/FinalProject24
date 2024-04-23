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

        private const string CsvFolderPath = @"../../../../CustomerUserFolder";

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

        public string UserEmail
        {
            get => userEmail;
            set
            {
                if (userEmail != value)
                {
                    userEmail = value;
                    ClearUserData();
                    LoadUserData();
                    UpdateTextBoxes();
                }
            }
        }

        public NS_AccountSettingPageUserControl1()
        {
            InitializeComponent();
            UserEmail = Environment.GetEnvironmentVariable("EmailEnv");
            LoadUserData();
            UpdateTextBoxes();
        }
        private void ClearUserData()
        {
            userDetails.Clear();  // Assuming userDetails is your Dictionary
        }
        public void LoadUserData()
        {
            string directoryPath = Path.Combine(Directory.GetCurrentDirectory(), CsvFolderPath);
            UserEmail = Environment.GetEnvironmentVariable("EmailEnv");

            // Traverse each user folder to find the correct profile.csv
            foreach (var subFolder in Directory.GetDirectories(directoryPath))
            {
                string profilePath = Path.Combine(subFolder, "profile.csv");
                if (File.Exists(profilePath))
                {
                    var lines = File.ReadAllLines(profilePath);
                    if (lines.Length > 1) // Ensure there is more than just the header line
                    {
                        var headers = lines[0].Split(',').Select(h => h.Trim()).ToList();
                        var values = lines[1].Split(',').Select(v => v.Trim()).ToList();

                        int emailIndex = headers.IndexOf("Email");
                        if (emailIndex != -1 && values[emailIndex].Equals(UserEmail, StringComparison.OrdinalIgnoreCase))
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




        public void UpdateTextBoxes()
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action(UpdateTextBoxes));
                return;
            }

            NametextBox.Text = userDetails.ContainsKey("Name") ? userDetails["Name"] : "Default Name";
            EmailtextBox.Text = userDetails.ContainsKey("Email") ? userDetails["Email"] : "Default Email";
            PhonetextBox.Text = userDetails.ContainsKey("Phone Number") ? userDetails["Phone Number"] : "Default Phone Number";
        }


        private void Applybutton_Click(object sender, EventArgs e)
        {
            UserEmail = Environment.GetEnvironmentVariable("EmailEnv");
            // Only update name, email, and phone number. Do not update password or customer/manager status.
            string newName = textBox3.Text.Trim();
            string newEmail = textBox4.Text.Trim();
            string newPhone = textBox5.Text.Trim();

            // Retain the old email to find the correct CSV record
            string oldEmail = UserEmail;

            // Update the userDetails dictionary
            userDetails["Name"] = newName;
            userDetails["Email"] = newEmail;
            userDetails["Phone Number"] = newPhone;

            // Now find the file path using the old email
            string filePath = FindCsvFilePath(oldEmail);
            if (!string.IsNullOrEmpty(filePath))
            {
                UpdateCsvFile(filePath);  // Pass in the oldEmail for comparison
                MessageBox.Show("Changes saved successfully!");

                // Update the global email variable and the environment variable after a successful update
                UserEmail = newEmail;
                Environment.SetEnvironmentVariable("EmailEnv", newEmail);
                LoadUserData();
                UpdateTextBoxes();
            }
            else
            {
                MessageBox.Show("Failed to find the CSV file to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void UpdateCsvFile(string filePath)
        {
            var lines = File.ReadAllLines(filePath).ToList();
            var headers = lines[0].Split(',').Select(h => h.Trim()).ToList();

            // Indices for columns
            int emailIndex = headers.IndexOf("Email");
            int nameIndex = headers.IndexOf("Name");
            int phoneNumberIndex = headers.IndexOf("Phone Number");

            List<string> updatedLines = new List<string> { lines[0] }; // Include header

            for (int i = 1; i < lines.Count; i++)
            {
                var fields = lines[i].Split(',').Select(f => f.Trim()).ToArray();
                if (fields.Length > emailIndex && fields[emailIndex].Equals(UserEmail, StringComparison.OrdinalIgnoreCase))
                {
                    // Update the necessary fields
                    if (nameIndex != -1) fields[nameIndex] = userDetails["Name"];
                    if (emailIndex != -1) fields[emailIndex] = userDetails["Email"];
                    if (phoneNumberIndex != -1) fields[phoneNumberIndex] = userDetails["Phone Number"];

                    updatedLines.Add(string.Join(",", fields));
                }
                else
                {
                    updatedLines.Add(lines[i]);
                }
            }

            File.WriteAllLines(filePath, updatedLines);
            MessageBox.Show("Changes saved successfully!");
        }



        private string FindCsvFilePath(string email)
        {
            string directoryPath = Path.Combine(Directory.GetCurrentDirectory(), CsvFolderPath);
            foreach (var subFolder in Directory.GetDirectories(directoryPath))
            {
                string profilePath = Path.Combine(subFolder, "profile.csv");
                if (File.Exists(profilePath))
                {
                    var lines = File.ReadAllLines(profilePath);
                    if (lines.Length > 1)
                    {
                        var headers = lines[0].Split(',').Select(h => h.Trim()).ToList();
                        int emailIndex = headers.IndexOf("Email");
                        var values = lines[1].Split(',').Select(v => v.Trim()).ToArray();

                        if (values.Length > emailIndex && values[emailIndex].Equals(email, StringComparison.OrdinalIgnoreCase))
                        {
                            return profilePath;
                        }
                    }
                }
            }
            MessageBox.Show("No matching email found in any profile CSV files.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        public void ClearTextBoxes()
        {
            // Assuming you have text boxes named NametextBox, EmailtextBox, PhonetextBox
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
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

        private void editSettingPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}