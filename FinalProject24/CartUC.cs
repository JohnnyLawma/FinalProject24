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
    public partial class CartUC : UserControl
    {

        private static CartUC _instance;

        public static CartUC Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new CartUC();
                }
                return _instance;
            }
           
        }


        public CartUC()
        {
            InitializeComponent();
        }

        // Method to load items into the CartUC
        public void LoadCartItems(IEnumerable<CartItem> items)
        {
            loadCardPanel.Controls.Clear(); // Clear previous items

            int yOffset = 0; // Start with a 0 offset from the top
            const int itemMargin = 10; // Margin between items

            foreach (var item in items)
            {
                var cartItemControl = new CartItemUC
                {
                    FoodName = item.FoodName,
                    Price = item.Price,
                    RestaurantName = item.RestaurantName,
                    Quantity = item.Quantity,
                    ImagePath = item.ImagePath,
                    Size = new Size(876, 233), // Set the size of CartItemUC
                    Location = new Point(0, yOffset) // Position CartItemUC at the current yOffset
                };

                yOffset += cartItemControl.Height + itemMargin; // Increase yOffset for the next item
                cartItemControl.LoadImage(); // Call the method to load the image after setting the ImagePath

                loadCardPanel.Controls.Add(cartItemControl);
            }
        }

        private void CartItemUC_QuantityIncreased(object sender, EventArgs e)
        {
            // Handle the quantity increased event
        }

        private void CartItemUC_QuantityDecreased(object sender, EventArgs e)
        {
            // Handle the quantity decreased event
        }

        private void CartItemUC_ItemRemoved(object sender, EventArgs e)
        {
            var cartItemUC = sender as CartItemUC;
            if (cartItemUC != null)
            {
                loadCardPanel.Controls.Remove(cartItemUC);
                cartItemUC.Dispose();
                // Update cart summary logic here
            }
        }

        // Additional methods and event handlers...
    }

    // Define the CartItem class according to your actual data structure
    public class CartItem
    {
        public string FoodName { get; set; }
        public decimal Price { get; set; }
        public string RestaurantName { get; set; }
        public int Quantity { get; set; }
        public string ImagePath { get; set; }
    }
}
