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
    public partial class JG_restaurantProfileUserControl : UserControl
    {
        public static JG_restaurantProfileUserControl _instance;

        public static JG_restaurantProfileUserControl Instance
        {
            get
            {
                // If the instance is null, create it
                if (_instance == null)
                {
                    _instance = new JG_restaurantProfileUserControl();
                }
                // Return the existing or new instance
                return _instance;

            }
        }

        public JG_restaurantProfileUserControl()
        {
            InitializeComponent();

        }

        private void applyChangeButton_Click(object sender, EventArgs e)
        {
            string restaurantName = "", restaurantAddress = "", restaurantPhoneNumber = "",
                restaurantEmail = "", restaurantDescription = "";

            if (newNameTextBox.Text != "")
            {
                restaurantName = newNameTextBox.Text;
            }
            if (newAddressTextBox.Text != "")
            {
                restaurantAddress = newAddressTextBox.Text;
            }
            if (newPhoneNumberTextBox.Text != "")
            {
                restaurantPhoneNumber = newPhoneNumberTextBox.Text;
            }
            if (newEmailTextBox.Text != "")
            {
                restaurantEmail = newEmailTextBox.Text;
            }
            if (newDescriptionTextBox.Text != "")
            {
                restaurantDescription = newDescriptionTextBox.Text;
            }

            currNameLabel.Text = restaurantName;
            currAddressLabel.Text = restaurantAddress;
            currPhoneNumberLabel.Text = restaurantPhoneNumber;
            currAddressLabel.Text = restaurantAddress;
            currEmailLabel.Text = restaurantEmail;
            currDescriptionLabel.Text = restaurantDescription;


        }
    }
}
