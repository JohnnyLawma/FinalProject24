namespace FinalProject24
{
    public partial class mainPageForm1 : Form
    {
        public mainPageForm1()
        {
            InitializeComponent();
        }

        int count = 0; // To count the item


        // For handling card incremnt event
        private void Card_AddButtonClicked(object sender, EventArgs e)
        {
            count++;
            cartLabel.Text = "Cart: " + count.ToString();
            MessageBox.Show(count.ToString());
        }

  

  

        private void mainPageForm1_Load(object sender, EventArgs e)
        {
            menuPanel.Controls.Clear();

            menuPanel.AutoScroll = true; // Enable the scrollbar for the panel


            int controlSpacing = 15; // Spacing between controls
            int controlWidth = 400; // Width of the user control
            int controlHeight = 382; // Height of the user control
            int numControlsPerRow = menuPanel.Width / controlWidth; // Calculate how many controls fit per row

            

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

                card.AddButtonClicked += Card_AddButtonClicked;       // user control event click is store to these form

                menuPanel.Controls.Add(card);
            }


            

        }










        private void menuLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
