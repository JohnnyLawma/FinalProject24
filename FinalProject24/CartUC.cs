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


        private List<CartItem> selectedItems = new List<CartItem>();

        // Method to load items into the CartUC and update the list
        public void LoadCartItems(IEnumerable<CartItem> items)
        {
            selectedItems.Clear(); // Clear any existing items from the list.

            var groupedItems = items
                .GroupBy(item => new { item.FoodName, item.Price }) // Group by unique name and price.
                .Select(group => new CartItem
                {
                    FoodName = group.Key.FoodName,
                    Price = group.Key.Price,
                    Quantity = group.Sum(g => g.Quantity), // Sum quantities of identical items.
                    ImagePath = group.First().ImagePath // Take the image path from the first item in each group.
                });

            selectedItems.AddRange(groupedItems); // Add grouped items to the list.
            UpdateSummaryOrder(); // Recalculate the summary order.

            loadCardPanel.Controls.Clear(); // Clear the panel for the new controls.

            int yOffset = 0; // Initialize Y-offset for the first item.

            foreach (var item in selectedItems) // Iterate over the grouped items.
            {
                var cartItemControl = new CartItemUC
                {
                    FoodName = item.FoodName,
                    Price = item.Price,
                    Quantity = item.Quantity,
                    ImagePath = item.ImagePath
                };

                cartItemControl.LoadImage(); // Load the item's image.

                cartItemControl.Location = new Point(0, yOffset); // Set the location with the current yOffset.
                yOffset += cartItemControl.Height + 10; // Increment yOffset for the next item.

                loadCardPanel.Controls.Add(cartItemControl); // Add the control to the panel.
            }
        }




        // Method to calculate the summary order
        public void UpdateSummaryOrder()
        {
            decimal subtotal = selectedItems.Sum(item => item.Price * item.Quantity);
            decimal tax = subtotal * 0.07m; // Example: tax rate of 10%
            decimal total = subtotal + tax;
            int totalItems = selectedItems.Sum(item => item.Quantity);

            
            totalItemNumberLabel.Text = totalItems.ToString();
            subtotalPriceLabel.Text = $"${subtotal:0.00}";
            taxPriceLabel.Text = $"${tax:0.00}";
            totalLabelText.Text = $"${total:0.00}";
        }


        private void CartItemUC_QuantityIncreased(object sender, EventArgs e)
        {
            // Handle the quantity increased event
            UpdateSummaryOrder(); // Recalculate the summary order
        }

        private void CartItemUC_QuantityDecreased(object sender, EventArgs e)
        {
            // Handle the quantity decreased event
            UpdateSummaryOrder(); // Recalculate the summary order
        }

        private void CartItemUC_ItemRemoved(object sender, EventArgs e)
        {
            var cartItemUC = sender as CartItemUC;
            if (cartItemUC != null)
            {
                loadCardPanel.Controls.Remove(cartItemUC);
                cartItemUC.Dispose();
                
            }

            UpdateSummaryOrder(); // Recalculate the summary order

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

    // Define the CartItem class items.
    public class CartItem
    {
        public string FoodName { get; set; }
        public decimal Price { get; set; }
        public string RestaurantName { get; set; }
        public int Quantity { get; set; }
        public string ImagePath { get; set; }
    }
}
