using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FinalProject24
{
    public partial class NS_AccountSettingPageUserControl1 : UserControl
    {

        private static NS_AccountSettingPageUserControl1 _instance;
        public static NS_AccountSettingPageUserControl1 Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new NS_AccountSettingPageUserControl1();
                return _instance;
            }
        }


        // Variables for dummy values, when db connected this maybe changed
        private string name = "";
        private string email = "";
        private string phoneNumber = "";

        public NS_AccountSettingPageUserControl1()
        {
            InitializeComponent();
            UpdateTextBoxes();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //whoops
        }

        private void UpdateTextBoxes()
        {
            // In theory, these textboxes will pull information from the db
            // and display for the user; but when user alters the text, it should
            // alter the db as well
            NametextBox.Text = name;
            EmailtextBox.Text = email;
            PhonetextBox.Text = phoneNumber;
        }

        private void Applybutton_Click(object sender, EventArgs e)
        {
            // When the user hits apply changes the text will be changed
            // for all three variables
            // Maybe when we have db we send the variables to db when updated?
            name = NametextBox.Text;
            email = EmailtextBox.Text;
            phoneNumber = PhonetextBox.Text;

            MessageBox.Show("Changes saved successfully!");
        
    }

    }
    }
