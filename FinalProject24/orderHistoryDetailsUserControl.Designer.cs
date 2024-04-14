namespace FinalProject24
{
    partial class orderHistoryDetailsUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            orderNumber = new Label();
            dateLabel = new Label();
            statusLabel = new Label();
            statusText = new Label();
            dateText = new Label();
            displayDetailText = new Label();
            orderNumberText = new Label();
            SuspendLayout();
            // 
            // orderNumber
            // 
            orderNumber.AutoSize = true;
            orderNumber.Font = new Font("Segoe UI Semibold", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            orderNumber.Location = new Point(26, 65);
            orderNumber.Name = "orderNumber";
            orderNumber.Size = new Size(118, 40);
            orderNumber.TabIndex = 0;
            orderNumber.Text = "Order #";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Font = new Font("Segoe UI Semibold", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateLabel.Location = new Point(510, 65);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(85, 40);
            dateLabel.TabIndex = 1;
            dateLabel.Text = "Date:";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            statusLabel.Location = new Point(34, 157);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(87, 32);
            statusLabel.TabIndex = 2;
            statusLabel.Text = "Status:";
            // 
            // statusText
            // 
            statusText.AutoSize = true;
            statusText.Location = new Point(127, 157);
            statusText.Name = "statusText";
            statusText.Size = new Size(85, 32);
            statusText.TabIndex = 3;
            statusText.Text = "Cancel";
            // 
            // dateText
            // 
            dateText.AutoSize = true;
            dateText.Location = new Point(587, 73);
            dateText.Name = "dateText";
            dateText.Size = new Size(150, 32);
            dateText.TabIndex = 4;
            dateText.Text = "Feb 21, 2019";
            // 
            // displayDetailText
            // 
            displayDetailText.BackColor = SystemColors.ControlLightLight;
            displayDetailText.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            displayDetailText.Location = new Point(46, 257);
            displayDetailText.Name = "displayDetailText";
            displayDetailText.Size = new Size(691, 649);
            displayDetailText.TabIndex = 5;
            // 
            // orderNumberText
            // 
            orderNumberText.AutoSize = true;
            orderNumberText.Location = new Point(150, 71);
            orderNumberText.Name = "orderNumberText";
            orderNumberText.Size = new Size(92, 32);
            orderNumberText.TabIndex = 6;
            orderNumberText.Text = "101010";
            // 
            // orderHistoryDetailsUserControl
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(orderNumberText);
            Controls.Add(displayDetailText);
            Controls.Add(dateText);
            Controls.Add(statusText);
            Controls.Add(statusLabel);
            Controls.Add(dateLabel);
            Controls.Add(orderNumber);
            Name = "orderHistoryDetailsUserControl";
            Size = new Size(804, 978);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label orderNumber;
        private Label dateLabel;
        private Label statusLabel;
        private Label statusText;
        private Label dateText;
        private Label orderNumberText;
        public Label displayDetailText;
    }
}
