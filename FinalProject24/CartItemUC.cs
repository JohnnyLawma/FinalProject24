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
    public partial class CartItemUC : UserControl
    {
        // Events to signal when the quantity changes or an item is removed
        public event EventHandler QuantityIncreased;
        public event EventHandler QuantityDecreased;
        public event EventHandler ItemRemoved;


        public event Action<CartItemUC, int> QuantityChanged;


        // Properties for the food name, price, restaurant name, and quantity
        public string FoodName
        {
            get { return myCartFoodNameLabel.Text; }
            set { myCartFoodNameLabel.Text = value; }
        }

        public decimal Price
        {
            get { return decimal.Parse(myCartPriceLabel.Text.Substring(1)); } 
            set { myCartPriceLabel.Text = $"${value:0.00}"; }
        }

        public string RestaurantName
        {
            get { return myCartRestaurantLabel.Text; }
            set { myCartRestaurantLabel.Text = value; }
        }

        public int Quantity
        {
            get { return int.Parse(myCartTotalItemLabel.Text); }
            set { myCartTotalItemLabel.Text = value.ToString(); }
        }

        public string ImagePath { get; set; } // Property to store the image path
        public void LoadImage()
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(ImagePath))
                {
                    
                    myCartPictureBox.Image = Image.FromFile(ImagePath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load image. Error: {ex.Message}");
            }
        }

        public CartItemUC()
        {
            InitializeComponent();

            // Attach event handlers to the buttons
            //myCartAddButton.Click += myCartAddButton_Click;
            //myCartRemoveButton.Click += myCartRemoveButton_Click;
            //myCartDeleteButton.Click += myCartDeleteButton_Click;

        }

        public CartItem GetCartItem()
        {
            return new CartItem
            {
                FoodName = this.FoodName,
                Price = this.Price,
                RestaurantName = this.RestaurantName,
                Quantity = this.Quantity
            };
        }


        private void myCartAddButton_Click(object sender, EventArgs e)
        {
            Quantity++; // Increase the quantity
            QuantityIncreased?.Invoke(this, EventArgs.Empty);

            QuantityChanged?.Invoke(this, 1);

            CartUC.Instance.UpdateSummaryOrder();
        }

        private void myCartRemoveButton_Click(object sender, EventArgs e)
        {
            if (Quantity > 1)
            {
                Quantity--; // Decrease the quantity but not less than 1
                QuantityDecreased?.Invoke(this, EventArgs.Empty);
                QuantityChanged?.Invoke(this, -1);
                CartUC.Instance.UpdateSummaryOrder();
            }
        }

        private void myCartDeleteButton_Click(object sender, EventArgs e)
        {
            ItemRemoved?.Invoke(this, EventArgs.Empty); // Remove the item entirely
            CartUC.Instance.UpdateSummaryOrder();
        }


    }
}
