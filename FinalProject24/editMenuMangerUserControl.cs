using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject24
{
    public partial class editMenuMangerUserControl : UserControl
    {
        public class MenuItem
        {
            public string MenuID { get; set; }
            public string MenuName { get; set; }
            public string MenuPrice { get; set; }
            public string ImagePath { get; set; }
            public bool Status { get; set; } // Added to reflect the CSV structure
        }

        private string csvFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\..\MenuItemsUpdated.csv");
        private string imagesFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\..\Images");
        private string selectedImageFileName;

        public static editMenuMangerUserControl _instance;

        public static editMenuMangerUserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new editMenuMangerUserControl();
                }
                return _instance;
            }
        }

        public editMenuMangerUserControl()
        {
            InitializeComponent();
            Directory.CreateDirectory(imagesFolderPath);
        }

        private List<MenuItem> LoadMenuItems()
        {
            var items = new List<MenuItem>();
            if (File.Exists(csvFilePath))
            {
                string[] lines = File.ReadAllLines(csvFilePath);
                foreach (var line in lines.Skip(1)) // Skip the header
                {
                    var columns = line.Split(',');
                    if (columns.Length >= 5) // Ensure there are enough columns
                    {
                        items.Add(new MenuItem
                        {
                            MenuName = columns[0].Trim(),
                            MenuPrice = columns[1].Trim(),
                            MenuID = columns[2].Trim(),
                            ImagePath = columns[3].Trim(),
                            Status = columns[4].Trim().Equals("TRUE", StringComparison.OrdinalIgnoreCase) // Parse the status as a boolean
                        });
                    }
                }
            }
            else
            {
                MessageBox.Show("The CSV file does not exist.");
            }
            return items;
        }

        private void SaveMenuItems(List<MenuItem> items)
        {
            using (StreamWriter writer = new StreamWriter(csvFilePath, false))
            {
                writer.WriteLine("Food Name,Price,ID,Image Path,Status"); // Correct the header to match CSV
                foreach (var item in items)
                {
                    writer.WriteLine($"{item.MenuName},{item.MenuPrice},{item.MenuID},{item.ImagePath},{item.Status}");
                }
            }
        }

        private void SelectImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.png;*.jpeg;*.jpg)|*.png;*.jpeg;*.jpg|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
                selectedImageFileName = Path.GetFileName(openFileDialog.FileName);
            }
        }

        private void ApplyChangeButton_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            string name = textBox2.Text;
            string price = textBox3.Text;

            if (string.IsNullOrWhiteSpace(id))
            {
                MessageBox.Show("Menu ID cannot be empty.");
                return;
            }

            List<MenuItem> items = LoadMenuItems();
            var existingItem = items.FirstOrDefault(i => i.MenuID == id);
            if (existingItem == null)
            {
                MessageBox.Show("The provided ID does not match any existing menu items.");
                return;
            }

            existingItem.MenuName = name;
            existingItem.MenuPrice = price;
            existingItem.Status = true; // Assuming you want to set this to true for an updated item

            if (!string.IsNullOrWhiteSpace(selectedImageFileName))
            {
                existingItem.ImagePath = selectedImageFileName;
                string filePath = Path.Combine(imagesFolderPath, selectedImageFileName);
                pictureBox1.Image.Save(filePath);
            }

            SaveMenuItems(items);

            MessageBox.Show("The menu item has been updated successfully.");
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            pictureBox1.Image = null;
            selectedImageFileName = null;
        }
    }
}