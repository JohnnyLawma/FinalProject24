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


    public partial class editMenuMangerUserControl : UserControl

    {
        public class MenuItem
        {
            public string MenuID { get; set; }
            public string MenuName { get; set; }
            public string MenuPrice { get; set; }
            public Image MenuPicture { get; set; }
        }

        private List<MenuItem> menuItems = new List<MenuItem>();


        public static editMenuMangerUserControl _instance;

        public static editMenuMangerUserControl Instance
        {
            get
            {
                // If the instance is null, create it
                if (_instance == null)
                {
                    _instance = new editMenuMangerUserControl();
                }
                // Return the existing or new instance
                return _instance;

            }
        }
        public editMenuMangerUserControl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.png;*.jpeg)|*.png;*.jpeg|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            string name = textBox2.Text;
            string price = textBox3.Text;

            // Validation for Menu ID
            if (string.IsNullOrWhiteSpace(id) || menuItems.Any(item => item.MenuID == id))
            {
                MessageBox.Show("Invalid or Duplicate Menu ID");
                return;
            }

            MenuItem menuItem = new MenuItem
            {
                MenuID = id,
                MenuName = name,
                MenuPrice = price,
                MenuPicture = pictureBox1.Image
            };

            menuItems.Add(menuItem);
            MessageBox.Show("Menu item saved successfully!");
        }
    }
}
