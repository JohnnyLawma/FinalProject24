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
    public partial class ManagerMainPageUserControl1 : UserControl
    {

        private static ManagerMainPageUserControl1 _instance;

        public ManagerMainPageUserControl1()
        {
            InitializeComponent();
            LoadStatusUserControl();
        }


        public static ManagerMainPageUserControl1 Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ManagerMainPageUserControl1();
                }
                return _instance;
            }
        }



        private void LoadStatusUserControl()
        {
            // Create an instance of StatusUserControl
            stausUserControl statusControl = new stausUserControl();

            // Configure properties of statusControl
            statusControl.GetName = "Some Name";
            statusControl.StatusButtonText = "Accept";
            statusControl.ListBoxItems = new List<string> { "Item 1", "Item 2" };

            // Subscribe to the StatusButtonClicked event
            statusControl.StatusButtonClicked += StatusControl_StatusButtonClicked;

            // Subscribe to the CancelButtonClicked event
            statusControl.CancelButtonClicked += StatusControl_CancelButtonClicked;

            // Set size and add to the pendingPanel
            statusControl.Size = new Size(495, 530);
            pendingPanel.Controls.Add(statusControl);
        }



        // Event handler for the CancelButtonClicked event
        private void StatusControl_CancelButtonClicked(object sender, EventArgs e)
        {
            var statusControl = sender as stausUserControl;
            if (statusControl != null)
            {
                MessageBox.Show("Oder has been cancel");
            }
        }




        // Event handler for the StatusButtonClicked event
        private void StatusControl_StatusButtonClicked(object sender, EventArgs e)
        {
            var statusControl = sender as stausUserControl;
            if (statusControl != null)
            {
                if (statusControl.StatusButtonText == "Accept")
                {
                    // Logic to move the status control to the accepted panel and change the button text
                    pendingPanel.Controls.Remove(statusControl);
                    acceptedPanel.Controls.Add(statusControl);
                    statusControl.StatusButtonText = "Ready";
                    // Subscribe to the new click event for the "Ready" button
                    statusControl.StatusButtonClicked -= StatusControl_StatusButtonClicked;
                    statusControl.StatusButtonClicked += StatusControl_ReadyButtonClicked;
                }
            }
        }



        private void StatusControl_ReadyButtonClicked(object sender, EventArgs e)
        {
            var statusControl = sender as stausUserControl;
            if (statusControl != null)
            {
                if (statusControl.StatusButtonText == "Ready")
                {
                    // Logic to move the status control to the ready panel
                    acceptedPanel.Controls.Remove(statusControl);
                    readyPanel.Controls.Add(statusControl);
                    statusControl.StatusButtonText = "Finished"; // Change the button text to "Finished"
                                                                 // Subscribe to the new click event for the "Finished" button
                    statusControl.StatusButtonClicked -= StatusControl_ReadyButtonClicked;
                    statusControl.StatusButtonClicked += StatusControl_FinishedButtonClicked;
                }
            }
        }

        private void StatusControl_FinishedButtonClicked(object sender, EventArgs e)
        {
            var statusControl = sender as stausUserControl;
            if (statusControl != null && statusControl.StatusButtonText == "Finished")
            {
                MessageBox.Show("Order has been finished and archived.");
                // Logic for what happens when "Finished" is clicked
                // For example, remove from the readyPanel and perform other finalization logic
                readyPanel.Controls.Remove(statusControl);

                // Optionally dispose the control if it's no longer needed
                statusControl.Dispose();

                
                
            }
        }






    }
}
