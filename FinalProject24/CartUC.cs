﻿using System;
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

        public int TotalQuantity
        {
            get { return selectedItems.Sum(item => item.Quantity); }
        }

        //....
        public event EventHandler CartItemsChanged;




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



                loadCardPanel.Controls.Add(cartItemControl);

                cartItemControl.LoadImage(); // Load the item's image.

                cartItemControl.Location = new Point(0, yOffset); // Set the location with the current yOffset.
                yOffset += cartItemControl.Height + 10; // Increment yOffset for the next item.

                SubscribeToItemEvents(cartItemControl);

                loadCardPanel.Controls.Add(cartItemControl); // Add the control to the panel.
            }
        }


        public List<CartItem> GetCartItems()
        {
            // Create a new list and add copies of each CartItem in selectedItems
            return selectedItems.Select(item => new CartItem
            {
                FoodName = item.FoodName,
                Price = item.Price,
                Quantity = item.Quantity,
                ImagePath = item.ImagePath
            }).ToList();
        }

        // Method to calculate the summary order
        public void UpdateSummaryOrder()
        {
            decimal subtotal = selectedItems.Sum(item => item.Price * item.Quantity);
            decimal tax = subtotal * 0.07m; // tax rate
            decimal total = subtotal + tax;
            int totalItems = selectedItems.Sum(item => item.Quantity);


            totalItemNumberLabel.Text = totalItems.ToString();
            subtotalPriceLabel.Text = $"${subtotal:0.00}";
            taxPriceLabel.Text = $"${tax:0.00}";
            totalLabelText.Text = $"${total:0.00}";

            CartItemsChanged?.Invoke(this, EventArgs.Empty); // Fire the event


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


        //............
        // This method sets up event listeners for the CartItemUC controls.
        private void SubscribeToItemEvents(CartItemUC cartItemControl)
        {
            // When the quantity is increased on the CartItemUC control...
            cartItemControl.QuantityIncreased += (sender, args) =>
            {
                // Find the item in the cart that matches the one being changed.
                var itemInCart = selectedItems.FirstOrDefault(item => item.FoodName == cartItemControl.FoodName && item.Price == cartItemControl.Price);

                // If we find the item...
                if (itemInCart != null)
                {
                    // Increase its quantity by one.
                    itemInCart.Quantity++;

                    // Update the order summary to reflect the new quantity.
                    UpdateSummaryOrder();
                }
            };


            // When the quantity is decreased on the CartItemUC control...
            cartItemControl.QuantityDecreased += (sender, args) =>
            {
                // Find the item in the cart that matches the one being changed.
                var itemInCart = selectedItems.FirstOrDefault(item => item.FoodName == cartItemControl.FoodName && item.Price == cartItemControl.Price);

                // If we find the item and its quantity is more than one...
                if (itemInCart != null && itemInCart.Quantity > 1)
                {
                    // Decrease its quantity by one.
                    itemInCart.Quantity--;

                    // Update the order summary to reflect the new quantity.
                    UpdateSummaryOrder();
                }
            };


            // When an item is removed from the CartItemUC control...
            cartItemControl.ItemRemoved += (sender, args) =>
            {
                // Find the item in the cart that matches the one being changed.
                var itemInCart = selectedItems.FirstOrDefault(item => item.FoodName == cartItemControl.FoodName && item.Price == cartItemControl.Price);

                // If we find the item...
                if (itemInCart != null)
                {
                    // Remove it from the cart.
                    selectedItems.Remove(itemInCart);

                    // Update the order summary since an item was removed.
                    UpdateSummaryOrder();
                }

                // Remove the control representing the item from the UI.
                loadCardPanel.Controls.Remove(cartItemControl);

                // Clean up the control to free resources.
                cartItemControl.Dispose();
            };
        }





        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void ClearCart()
        {
            // Clear the backend list
            selectedItems.Clear();

            // Clear the UI elements from the panel
            loadCardPanel.Controls.Clear();

            // Optionally, update any UI elements that reflect the cart status
            UpdateSummaryOrder();  // This would reset any totals displayed to the user



            MessageBox.Show("The cart has been cleared.");  // Optional: Notify the user
        }


        private string SaveOrderDetailsToCSV(string orderNumber, List<CartItem> items, decimal subtotal, decimal tax, decimal total)
        {
            // Define the directory where the CSV files will be saved
            string relativePath = @"..\..\..\..\receipts\";
            string directoryPath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativePath));

            // Ensure the directory exists
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            // Create the file path for the new CSV file
            string filePath = Path.Combine(directoryPath, $"{orderNumber}.csv");

            // Open a new StreamWriter to write to the CSV file
            using (StreamWriter file = new StreamWriter(filePath))
            {
                // Write the CSV headers
                file.WriteLine("Item Name,Quantity,Price,Total");

                // Write each item's details to the CSV
                foreach (var item in items)
                {
                    file.WriteLine($"{item.FoodName},{item.Quantity},${item.Price},${item.Price * item.Quantity}");
                }

                // Write the subtotal, tax, and total to the CSV
                file.WriteLine($"Subtotal,,${subtotal:0.00}");
                file.WriteLine($"Tax,,${tax:0.00}");
                file.WriteLine($"Total,,${total:0.00}");
            }

            // Return the file path in case it needs to be used (e.g., for reading or sending as an email attachment)
            return filePath;
        }

        public List<CartItem> orderBoard { get; private set; } = new List<CartItem>();

        private void buyNowButton_Click(object sender, EventArgs e)
        {
            // Clear previous orders
            orderBoard.Clear();

            // CartItemUC has properties FoodName, Price, Quantity, ImagePath
            foreach (CartItemUC itemControl in loadCardPanel.Controls.OfType<CartItemUC>())
            {
                orderBoard.Add(new CartItem
                {
                    FoodName = itemControl.FoodName,
                    Price = itemControl.Price,
                    Quantity = itemControl.Quantity,
                    ImagePath = itemControl.ImagePath
                });
            }
            string newCSVorderNum = DateTime.Now.ToString("yyyyMMddHHmmss") + "_" + new Random().Next(1000, 9999);
            decimal newCSVsubtotal = orderBoard.Sum(item => item.Price * item.Quantity);
            decimal newCSVtax = newCSVsubtotal * 0.07m;  // Assume a 7% tax rate 
            decimal newCSVtotal = newCSVsubtotal + newCSVtax;
            SaveOrderDetailsToCSV(newCSVorderNum, orderBoard, newCSVsubtotal, newCSVtax, newCSVtotal);

            // Optionally, you can notify the user that the items have been added to the order board
            MessageBox.Show("Items added to the order board.");

            ClearCart();


        }

        private void CartUC_Load(object sender, EventArgs e)
        {

        }

        private void loadCardPanel_Paint(object sender, PaintEventArgs e)
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
