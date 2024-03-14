using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace FinalProject24
{
    public partial class menuCardUserControl : UserControl
    {

        // Declare the event for + and - button
        public event EventHandler AddButtonClicked;
        public event EventHandler<MenuItemEventArgs> RemoveButtonClicked;


        public string ItemName
        {
            get { return itemNameLabel.Text; }
            set { itemNameLabel.Text = value; }
        }

        // Property for the item price
        public string ItemPrice
        {
            get { return priceLabel.Text; }
            set { priceLabel.Text = value; }
        }


        // You may have a data structure for menu items like this
        /*public class MenuItemData
        {
            public string Name { get; set; }
            public decimal Price { get; set; }
            // public Image Image { get; set; } // If you have images for menu items
        }

        */

        public Image ItemImage
        {
            get { return menuPictureBox.Image; }
            set { menuPictureBox.Image = value; }

        }

        public string ImagePath { get; set; }


        public class MenuItemEventArgs : EventArgs
        {
            public string ItemName { get; set; }
            // Add other properties if needed
        }



        // Method to load data into the control
        /*public void LoadData(MenuItemData data)
        {
            ItemName = data.Name;
            ItemPrice = data.Price.ToString("C"); // Format as currency
                                                  // Set the image if you have an image control
                                                  // itemPictureBox.Image = data.Image;
        }
        */

        // This for when user click add button, the cart will be increment
        public menuCardUserControl()
        {
            InitializeComponent();
            // Set the PictureBox SizeMode to StretchImage
            menuPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            //addButton.Click += addButton_Click; // Ensure this handler is wired up to the '+' button's Click event
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            // When the button is clicked, raise the event
            AddButtonClicked?.Invoke(this, EventArgs.Empty);
        }






        private void removeButton_Click(object sender, EventArgs e)
        {
            var args = new MenuItemEventArgs
            {
                ItemName = this.ItemName
                
            };

            // When the remove button is clicked, raise the event
            RemoveButtonClicked?.Invoke(this, args);
        }
    }
}
