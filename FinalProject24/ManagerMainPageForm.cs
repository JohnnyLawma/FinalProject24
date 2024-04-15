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
    public partial class ManagerMainPageForm : Form
    {
        public ManagerMainPageForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                Form oForm = Application.OpenForms[i];
                if (oForm is mainPageForm1 || oForm is JG_loginForm || oForm is ManagerMainPageForm)
                {
                    oForm.Close();
                }
            }
            this.Close();
        }

        private void signOutButton_Click(object sender, EventArgs e)
        {
            foreach (Form oForm in Application.OpenForms)
            {
                if (oForm is JG_loginForm)
                {
                    oForm.Show();
                }
            }
            this.Hide();
        }

        private void paymentButton_Click(object sender, EventArgs e)
        {
            if (!mainpanel1.Controls.Contains(JG_restaurantProfileUserControl.Instance))
            {
                mainpanel1.Controls.Add(JG_restaurantProfileUserControl.Instance);
                JG_restaurantProfileUserControl.Instance.Dock = DockStyle.Fill;
                JG_restaurantProfileUserControl.Instance.BringToFront();
            }
            else
            {
                JG_restaurantProfileUserControl.Instance.BringToFront();
            }
            mainpanel1.Visible = true;
        }
    }
}
