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

        // Declare the event using EventHandler, no need for a custom delegate
        public event EventHandler AddButtonClicked;

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
        public class MenuItemData
        {
            public string Name { get; set; }
            public decimal Price { get; set; }
            // public Image Image { get; set; } // If you have images for menu items
        }


      



        // Method to load data into the control
        public void LoadData(MenuItemData data)
        {
            ItemName = data.Name;
            ItemPrice = data.Price.ToString("C"); // Format as currency
                                                  // Set the image if you have an image control
                                                  // itemPictureBox.Image = data.Image;
        }


        // This for when user click add button, the cart will be increment
        public menuCardUserControl()
        {
            InitializeComponent();
            addButton.Click += addButton_Click; // Ensure this handler is wired up to the '+' button's Click event
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            // When the button is clicked, raise the event
            AddButtonClicked?.Invoke(this, EventArgs.Empty);
        }




    }
}
