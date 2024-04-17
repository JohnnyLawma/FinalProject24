﻿using System.Diagnostics;
using System.Text;
using System.Text.RegularExpressions;
using static FinalProject24.NS_MEditPageUserControl1;

namespace FinalProject24
{
    public partial class NS_MViewPageUserControl1 : UserControl
    {

        private static NS_MViewPageUserControl1 _instance;

        public NS_MViewPageUserControl1()
        {
            InitializeComponent();

            //ShowAllMenuItems();
            LoadMenuItemsToPanel();

        }

        public static NS_MViewPageUserControl1 Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new NS_MViewPageUserControl1();
                }
                return _instance;
            }
        }


        private List<MenuItem> LoadMenuItemsFromCsv()
        {
            string filePath = @"C:\Users\johnn\Downloads\MenuItemsUpdated.csv";
            List<MenuItem> menuItems = new List<MenuItem>();

            if (!File.Exists(filePath))
            {
                MessageBox.Show($"CSV file not found at path: {filePath}");
                return menuItems;
            }

            try
            {
                var lines = File.ReadAllLines(filePath);
                if (lines.Length <= 1)
                {
                    MessageBox.Show("CSV file is empty or only contains the header.");
                    return menuItems;
                }

                // Define the regex pattern for CSV fields
                var csvPattern = new Regex("(?:^|,)(\"(?:[^\"]+|\"\")*\"|[^,]*)", RegexOptions.Compiled);

                foreach (var line in lines.Skip(1))
                {
                    var matches = csvPattern.Matches(line);
                    var columns = matches.Cast<Match>().Select(m => m.Value.TrimStart(',').Replace("\"", "").Trim()).ToArray();

                    if (columns.Length < 4)
                    {
                        MessageBox.Show($"Entry does not have enough columns: {line}");
                        continue;
                    }

                    string status = columns[4]; // Assuming status is the fourth column

                    //MessageBox.Show($"Line: {line}\nParsed Columns: {string.Join("|", columns)}\nStatus read from CSV: '{status}'");

                    if (status.Equals("TRUE", StringComparison.OrdinalIgnoreCase))
                    {
                        // Try to parse the price and add the item if successful
                        if (decimal.TryParse(columns[1].Trim(), out decimal price))
                        {
                            menuItems.Add(new MenuItem
                            {
                                FoodName = columns[0].Trim(),
                                Price = price,
                                ImagePath = columns[3].Trim(), // Correct index for Image Path
                            });
                        }
                        else
                        {
                            MessageBox.Show($"Price parsing failed for entry: {line}");
                        }
                    }
                    else
                    {
                        // For deubuging.
                        //MessageBox.Show($"Entry skipped because status is not TRUE: {line}");
                    }




                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading the CSV file: {ex.Message}");
            }

            return menuItems;
        }



        private void ShowAllMenuItems()
        {

            var menuItems = LoadMenuItemsFromCsv();

            // Check if there are any menu items to display
            if (menuItems.Count == 0)
            {
                MessageBox.Show("No menu items to display.", "Menu Items");
                return;
            }

            // Build the display message
            StringBuilder messageBuilder = new StringBuilder();
            foreach (var item in menuItems)
            {
                messageBuilder.AppendLine($"Name: {item.FoodName}, Price: ${item.Price:0.00}, Image Path: {item.ImagePath}");
            }

            // Show the message box with all menu items
            MessageBox.Show(messageBuilder.ToString(), "All Menu Items");
        }



        private void LoadMenuItemsToPanel()
        {
            var menuItems = LoadMenuItemsFromCsv();

            // Clear the panel of previous items
            loadMenuPanel.Controls.Clear();
            loadMenuPanel.AutoScroll = true;

            int controlSpacing = 15; // Spacing between controls
            int controlWidth = 400; // Width of the user control
            int controlHeight = 382; // Height of the user control
            int numControlsPerRow = loadMenuPanel.Width / controlWidth; // Calculate how many controls fit per row



            // Get the base directory of the application
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;

            // Construct the path to the images folder
            string imagesFolderPath = Path.Combine(baseDirectory, @"..\..\..\..\Images\");
            for (int i = 0; i < menuItems.Count; i++)
            {
                var menuItem = menuItems[i];
                var menuCard = new menuCardUserControl();

                

                // Set the properties of the user control
                menuCard.ItemName = menuItem.FoodName;
                menuCard.ItemPrice = menuItem.Price.ToString("C"); // Format as currency

                // Set the size of the control
                menuCard.Size = new Size(controlWidth, controlHeight);

                

                // Calculate and set the location of the control
                menuCard.Location = new Point(
                    (i % numControlsPerRow) * (controlWidth + controlSpacing), // X position
                    (i / numControlsPerRow) * (controlHeight + controlSpacing) // Y position
                );

                // Construct the full path to the image file and load the image
                try
                {
                    string imagePath = Path.Combine(imagesFolderPath, menuItem.ImagePath);
                    imagePath = Path.GetFullPath(imagePath); // Resolves to the absolute path

                    if (File.Exists(imagePath))
                    {
                        menuCard.ItemImage = Image.FromFile(imagePath);
                    }
                    else
                    {
                        // Use an empty image or a default image as a placeholder
                        menuCard.ItemImage = new Bitmap(1, 1);
                    }
                }
                catch (Exception ex)
                {
                    // Handle exceptions if image loading fails
                    MessageBox.Show($"Failed to load image: {ex.Message}");
                }

                // Hide the buttons through methods
                menuCard.HideAddButton();
                menuCard.HideRemoveButton();


                // Add the menu card to the panel
                loadMenuPanel.Controls.Add(menuCard);
            }
        }






        // MenuItem class to hold the data for each menu item
        public class MenuItem
        {
            public string FoodName { get; set; }
            public decimal Price { get; set; }
            public string ImagePath { get; set; }
        }













    }
}

