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

        private const string CsvFilePath = @"../../../../resturantinformation/resturantinfo.csv";
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
        }

        private void applyChangeButton_Click(object sender, EventArgs e)
        {
            currentUsername = Environment.GetEnvironmentVariable("EmailEnv");
            UpdateProfile(newNameTextBox.Text, newAddressTextBox.Text, newPhoneNumberTextBox.Text,
                          newEmailTextBox.Text, newDescriptionTextBox.Text);
            LoadProfile(currentUsername); // Refresh display after update
        }

        private void JG_restaurantProfileUserControl_Load(object sender, EventArgs e)
        {
            LoadProfile(currentUsername);
        }

        private void LoadProfile(string username)
        {
            currentUsername = Environment.GetEnvironmentVariable("EmailEnv");
            var profiles = ReadCsvFile();
            var profile = profiles.FirstOrDefault(p => p.Username == username);
            if (profile == null)
            {
                profile = CreateDefaultProfile(username);
                profiles.Add(profile);
                WriteCsvFile(profiles);
            }
            DisplayProfile(profile);
        }

        private void UpdateProfile(string name, string address, string phone, string email, string description)
        {
            currentUsername = Environment.GetEnvironmentVariable("EmailEnv");
            var profiles = ReadCsvFile();
            var profile = profiles.FirstOrDefault(p => p.Username == currentUsername);
            if (profile == null)
            {
                profile = CreateDefaultProfile(currentUsername);
                profiles.Add(profile);
            }
            profile.RestaurantName = name;
            profile.RestaurantAddress = address;
            profile.RestaurantPhone = phone;
            profile.RestaurantEmail = email;
            profile.RestaurantDescription = description;
            WriteCsvFile(profiles);
        }

        private RestaurantProfile CreateDefaultProfile(string username)
        {
            return new RestaurantProfile($"{username},n/a,n/a,n/a,n/a,n/a");
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
            return File.ReadAllLines(CsvFilePath)
                       .Skip(1)
                       .Where(line => !string.IsNullOrWhiteSpace(line))
                       .Select(line => new RestaurantProfile(line))
                       .ToList();
        }

        private void WriteCsvFile(List<RestaurantProfile> profiles)
        {
            var data = new StringBuilder("Username,RestaurantName,RestaurantAddress,RestaurantPhone,RestaurantEmail,RestaurantDescription\n");
            foreach (var profile in profiles)
            {
                data.AppendLine($"{profile.Username},{profile.RestaurantName},{profile.RestaurantAddress},{profile.RestaurantPhone},{profile.RestaurantEmail},{profile.RestaurantDescription}");
            }
            File.WriteAllText(CsvFilePath, data.ToString());
        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

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
            RestaurantName = values.Length > 1 ? values[1] : "";
            RestaurantAddress = values.Length > 2 ? values[2] : "";
            RestaurantPhone = values.Length > 3 ? values[3] : "";
            RestaurantEmail = values.Length > 4 ? values[4] : "";
            RestaurantDescription = values.Length > 5 ? values[5] : "";
        }
    }
}
