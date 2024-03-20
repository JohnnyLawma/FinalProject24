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
            selectedItems.Clear();
            selectedItems.AddRange(items);

            UpdateSummaryOrder(); // Calculate the summary order after loading items

            loadCardPanel.Controls.Clear(); // Clear previous items
            int yOffset = 0; // Start with a 0 offset from the top
            const int itemMargin = 10; // Margin between items

            foreach (var item in selectedItems)
            {
                var cartItemControl = new CartItemUC
                {
                    FoodName = item.FoodName,
                    Price = item.Price,
                    RestaurantName = item.RestaurantName,
                    Quantity = item.Quantity,
                    ImagePath = item.ImagePath,
                    // Set other properties as needed
                };

                // Position the control with the current yOffset
                cartItemControl.Location = new Point(0, yOffset);
                yOffset += cartItemControl.Height + itemMargin; // Update yOffset

                cartItemControl.LoadImage();
                loadCardPanel.Controls.Add(cartItemControl);
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
