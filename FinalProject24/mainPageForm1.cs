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


        // For handling card incremnt event
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




        private void mainPageForm1_Load(object sender, EventArgs e)
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

                card.AddButtonClicked += Card_AddButtonClicked;       // user control event click is store to these form

                menuPanel.Controls.Add(card);
            }




        }




        private void menuLabel_Click(object sender, EventArgs e)
        {

        }

        private void cartButton_Click(object sender, EventArgs e)
        {
            foreach (var item in selectedItems)
            {
                // Process each item as needed
                // For example, displaying item details in a MessageBox or a list
                MessageBox.Show($"Title: {item.Title},Image Path: {item.ImagePath}");
            }
        }
    }
}
