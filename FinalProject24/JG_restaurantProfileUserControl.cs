using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FinalProject24
{
    public partial class JG_restaurantProfileUserControl : UserControl
    {
        private static JG_restaurantProfileUserControl _instance;
        private static readonly string CsvFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../../../resturantinformation/resturantInformation.csv");
        private string currentUsername;

        public static JG_restaurantProfileUserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new JG_restaurantProfileUserControl();
                }
                return _instance;
            }
        }

        public JG_restaurantProfileUserControl()
        {
            InitializeComponent();
            currentUsername = Environment.GetEnvironmentVariable("EmailEnv");
            EnsureCsvFileExists();
        }

        private void EnsureCsvFileExists()
        {
            if (!File.Exists(CsvFilePath))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(CsvFilePath));  // Create directory if it doesn't exist
                File.WriteAllText(CsvFilePath, "Username,RestaurantName,RestaurantAddress,RestaurantPhone,RestaurantEmail,RestaurantDescription\n");  // Create file with header
            }
        }

        private void applyChangeButton_Click(object sender, EventArgs e)
        {
            UpdateProfile(newNameTextBox.Text, newAddressTextBox.Text, newPhoneNumberTextBox.Text,
                          newEmailTextBox.Text, newDescriptionTextBox.Text);
            LoadProfile(currentUsername);
        }

        private void JG_restaurantProfileUserControl_Load(object sender, EventArgs e)
        {
            LoadProfile(currentUsername);
        }

        private void LoadProfile(string username)
        {
            var profiles = ReadCsvFile();
            var profile = profiles.FirstOrDefault(p => !string.IsNullOrWhiteSpace(p.Username) && p.Username.Equals(username, StringComparison.OrdinalIgnoreCase));

            if (profile == null)
            {
                DisplayProfile(new RestaurantProfile($"{username},,,,,"));
            }
            else
            {
                DisplayProfile(profile);
            }
        }

        private void UpdateProfile(string name, string address, string phone, string email, string description)
        {
            var profiles = ReadCsvFile();
            var profile = profiles.FirstOrDefault(p => p.Username == currentUsername);

            if (profile == null && IsAnyFieldNonEmpty(name, address, phone, email, description))
            {
                profile = new RestaurantProfile($"{currentUsername},n/a,n/a,n/a,n/a,n/a");
                profiles.Add(profile);
            }

            if (profile != null)
            {
                profile.RestaurantName = string.IsNullOrWhiteSpace(name) ? "n/a" : name;
                profile.RestaurantAddress = string.IsNullOrWhiteSpace(address) ? "n/a" : address;
                profile.RestaurantPhone = string.IsNullOrWhiteSpace(phone) ? "n/a" : phone;
                profile.RestaurantEmail = string.IsNullOrWhiteSpace(email) ? "n/a" : email;
                profile.RestaurantDescription = string.IsNullOrWhiteSpace(description) ? "n/a" : description;
                WriteCsvFile(profiles);
            }
        }

        private bool IsAnyFieldNonEmpty(params string[] fields)
        {
            return fields.Any(field => !string.IsNullOrWhiteSpace(field));
        }

        private void DisplayProfile(RestaurantProfile profile)
        {
            currNameLabel.Text = profile.RestaurantName;
            currAddressLabel.Text = profile.RestaurantAddress;
            currPhoneNumberLabel.Text = profile.RestaurantPhone;
            currEmailLabel.Text = profile.RestaurantEmail;
            currDescriptionLabel.Text = profile.RestaurantDescription;
        }

        private List<RestaurantProfile> ReadCsvFile()
        {
            EnsureCsvFileExists();  // Ensure file exists before reading
            var lines = File.ReadAllLines(CsvFilePath).Skip(1);
            return lines.Select(line => new RestaurantProfile(line)).ToList();
        }

        private void WriteCsvFile(List<RestaurantProfile> profiles)
        {
            try
            {
                var data = new StringBuilder("Username,RestaurantName,RestaurantAddress,RestaurantPhone,RestaurantEmail,RestaurantDescription\n");
                foreach (var profile in profiles.Where(p => IsAnyFieldNonEmpty(p.RestaurantName, p.RestaurantAddress, p.RestaurantPhone, p.RestaurantEmail, p.RestaurantDescription)))
                {
                    data.AppendLine(profile.ToString());
                }
                File.WriteAllText(CsvFilePath, data.ToString());
            }
            catch (IOException ex)
            {
                MessageBox.Show($"Failed to write to the file: {ex.Message}", "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label22_Click(object sender, EventArgs e)
        {
            // Placeholder for any additional event handling
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Placeholder for any additional event handling
        }
    }

    public class RestaurantProfile
    {
        public string Username { get; set; }
        public string RestaurantName { get; set; }
        public string RestaurantAddress { get; set; }
        public string RestaurantPhone { get; set; }
        public string RestaurantEmail { get; set; }
        public string RestaurantDescription { get; set; }

        public RestaurantProfile(string csvLine)
        {
            var values = csvLine.Split(',');
            Username = values[0];
            RestaurantName = values.Length > 1 ? values[1] : "n/a";
            RestaurantAddress = values.Length > 2 ? values[2] : "n/a";
            RestaurantPhone = values.Length > 3 ? values[3] : "n/a";
            RestaurantEmail = values.Length > 4 ? values[4] : "n/a";
            RestaurantDescription = values.Length > 5 ? values[5] : "n/a";
        }

        public override string ToString()
        {
            return $"{Username},{RestaurantName},{RestaurantAddress},{RestaurantPhone},{RestaurantEmail},{RestaurantDescription}";
        }
    }
}
