namespace FinalProject24
{
    public partial class mainPageForm1 : Form
    {
        public mainPageForm1()
        {
            InitializeComponent();

        }

        int count = 0; // To count the item



        public struct cartArray
        {
            public string Title;
            public decimal Price;
            public string ImagePath;
        }

        private List<cartArray> selectedItems = new List<cartArray>();

        // For + button
        // For handling card incremnt event and storing selected item to a list
        private void Card_AddButtonClicked(object sender, EventArgs e)
        {
            // Cast the sender to menuCardUserControl
            menuCardUserControl card = sender as menuCardUserControl;

            // Check if the cast was successful
            if (card != null)
            {
                cartArray item = new cartArray
                {
                    Title = card.ItemName,
                    Price = Decimal.Parse(card.ItemPrice.Replace("$", "")),
                    ImagePath = card.ImagePath // Access the ImagePath property
                };

                selectedItems.Add(item); // Add to the list
                count++;
                cartButton.Text = "Carts: " + count.ToString();
            }



            //MessageBox.Show(count.ToString());
        }

        // For handling - (remove) Button
        private void Card_RemoveButtonClicked(object sender, EventArgs e)
        {
            if (sender is menuCardUserControl card)
            {
                // Initialize a variable to store the index of the item to remove
                int indexToRemove = -1;

                // Looping through the list to find the item
                for (int i = 0; i < selectedItems.Count; i++)
                {
                    if (selectedItems[i].Title == card.ItemName)
                    {
                        indexToRemove = i;
                        break; // Stop the loop once we found the item
                    }
                }

                // Checking if we found an item to remove
                if (indexToRemove != -1)
                {
                    selectedItems.RemoveAt(indexToRemove); // Remove the item from the list
                    count--; // Decrement the count
                    cartButton.Text = "Carts: " + count.ToString(); // Update the cart count display

                }
            } // If line End

        }



        private void PopulateMenuPanel()
        {
            menuPanel.Controls.Clear();

            menuPanel.AutoScroll = true; // Enable the scrollbar for the panel


            int controlSpacing = 15; // Spacing between controls
            int controlWidth = 400; // Width of the user control
            int controlHeight = 382; // Height of the user control
            int numControlsPerRow = menuPanel.Width / controlWidth; // Calculate how many controls fit per row

            string impagePaths = @"C:\Users\johnn\Downloads\foodbowl.jpg";


            // Load 9 demo menu cards
            for (int i = 0; i < 9; i++)
            {
                // Create a new instance of the menuCardUserControl
                menuCardUserControl card = new menuCardUserControl();

                // Assuming each card is 400 x 382 and we want a 15-pixel space between them
                card.Size = new Size(controlWidth, controlHeight);
                card.Location = new Point(
                    (i % numControlsPerRow) * (controlWidth + controlSpacing), // X position
                    (i / numControlsPerRow) * (controlHeight + controlSpacing) // Y position
                );

                // Set the properties for the demo
                card.ItemName = "Demo Item " + (i + 1);
                card.ItemPrice = "$" + (6.00m + i).ToString("0.00");
                card.ItemImage = Image.FromFile(impagePaths);
                card.ImagePath = impagePaths;

                card.AddButtonClicked += Card_AddButtonClicked;
                card.RemoveButtonClicked += Card_RemoveButtonClicked;


                menuPanel.Controls.Add(card);
            } // For Loop End Line
        }



        // This is load when the Form is loaded.
        private void mainPageForm1_Load(object sender, EventArgs e)
        {

            PopulateMenuPanel();

        } // mainPageForm1_Load End Line




        private void menuLabel_Click(object sender, EventArgs e)
        {

        }

        private void cartButton_Click(object sender, EventArgs e)
        {
            foreach (var item in selectedItems)
            {
                // For example, displaying item details in a MessageBox or a list
                MessageBox.Show($"Title: {item.Title},Image Path: {item.ImagePath}");
            }
        }


        private void paymentButton_Click(object sender, EventArgs e)
        {
            if (!mainPanel.Controls.Contains(PaymentUserControl1.Instance))
            {
                mainPanel.Controls.Add(PaymentUserControl1.Instance);
                PaymentUserControl1.Instance.Dock = DockStyle.Fill;
                PaymentUserControl1.Instance.BringToFront();
            }
            else
            {
                PaymentUserControl1.Instance.BringToFront();
            }

            mainPanel.Visible = true;
            menuPanel.Visible = false;
            menuLabel.Visible = false;

        }


        private void homeButton_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            //mainPanel.Visible = false; // Hide the mainPanel
            menuPanel.Visible = true; // Show the menuPanel
            menuLabel.Visible = true;

        }

        private void settingButton_Click(object sender, EventArgs e)
        {
            if (!mainPanel.Controls.Contains(NS_AccountSettingPageUserControl1.Instance))
            {
                mainPanel.Controls.Add(NS_AccountSettingPageUserControl1.Instance);
                NS_AccountSettingPageUserControl1.Instance.Dock = DockStyle.Fill;
                NS_AccountSettingPageUserControl1.Instance.BringToFront();
            }
            else
            {
                NS_AccountSettingPageUserControl1.Instance.BringToFront();
            }

            mainPanel.Visible = true;
            menuPanel.Visible = false;
            menuLabel.Visible = false;
        }
    } // mainPageForm1 End Line
}
