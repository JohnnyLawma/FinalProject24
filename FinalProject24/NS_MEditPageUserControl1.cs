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
    public partial class NS_MEditPageUserControl1 : UserControl
    {
        public NS_MEditPageUserControl1()
        {
            InitializeComponent();
        }
        public class MenuItem
        {
            public string ID { get; set; }
            public string Name { get; set; }
            public decimal Price { get; set; }
            public Image ItemImage { get; set; } // Add property for the image
        }
        private List<MenuItem> menuItems = new List<MenuItem>();

        private void SelectImageButton_Click(object sender, EventArgs e)
        {
            // Should open file, allow you to choose an image then it should display the image in the pic box.
            // Create and configure an OpenFileDialog instance
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select an Image";

            // Show the dialog and check if the user selected a file
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Get the selected file name and display it in a PictureBox
                    string selectedImagePath = openFileDialog.FileName;
                    pictureBox.Image = Image.FromFile(selectedImagePath);
                }
                catch (Exception ex)
                {
                    // Handle any errors that occur during file loading
                    MessageBox.Show("Error: Could not open selected image file. " + ex.Message);
                }
            }
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            // Apply the changes, so take information provided and send to the DB
            // For now, the data will instead be going into lists or a list for each one
            // my hope is that it'll be easier to connect db since we would be using similar code

            // Retrieve the text entered by the user in the TextBox
            // Retrieve the text entered by the user in the TextBoxes
            string itemID = MenuIDtextBox.Text;
            string itemName = NametextBox.Text;
            decimal itemPrice;
            if (!decimal.TryParse(PricetextBox.Text, out itemPrice))
            {
                MessageBox.Show("Please enter a valid price.");
                return;
            }

            // Create a new MenuItem object and add it to the list
            MenuItem newItem = new MenuItem
            {
                ID = itemID,
                Name = itemName,
                Price = itemPrice,
                ItemImage = pictureBox.Image // Set the image
            };
            menuItems.Add(newItem);

            // Optionally, you can display a message to confirm that the item has been added
            MessageBox.Show("Item added successfully.");

            // Optionally, you can clear the TextBoxes after adding the item
            MenuIDtextBox.Clear();
            NametextBox.Clear();
            PricetextBox.Clear();
        }
    }
    }
