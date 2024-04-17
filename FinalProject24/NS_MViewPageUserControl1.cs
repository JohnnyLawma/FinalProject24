using static FinalProject24.NS_MEditPageUserControl1;

namespace FinalProject24
{
    public partial class NS_MViewPageUserControl1 : UserControl
    {
        public NS_MViewPageUserControl1()
        {
            InitializeComponent();
        }
        // Method to populate the panel with menu items
        public void PopulateMenuItems(List<MenuItem> menuItems)
        {
            // Clear any existing items from the panel
            panel1.Controls.Clear();

            // Iterate over each MenuItem in the menuItems list
            foreach (var menuItem in menuItems)
            {
                // Create a new instance of menuCardUserControl representing the menu item
                var menuItemControl = new menuCardUserControl();

                // Set the properties of the item control with the information from the current MenuItem
                menuItemControl.ItemName = menuItem.Name;
                menuItemControl.ItemPrice = menuItem.Price.ToString("C");
                menuItemControl.ItemImage = menuItem.ItemImage;

                // Add the item control to the panel
                panel1.Controls.Add(menuItemControl);
            }
        }
    }
}

