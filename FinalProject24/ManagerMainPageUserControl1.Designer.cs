namespace FinalProject24
{
    partial class ManagerMainPageUserControl1
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
            pendingPanel = new Panel();
            acceptedPanel = new Panel();
            readyPanel = new Panel();
            label1 = new Label();
            acceptedLabel = new Label();
            readyLabel = new Label();
            RefreshButton = new Button();
            SuspendLayout();
            // 
            // pendingPanel
            // 
            pendingPanel.AutoScroll = true;
            pendingPanel.BorderStyle = BorderStyle.FixedSingle;
            pendingPanel.Location = new Point(31, 67);
            pendingPanel.Name = "pendingPanel";
            pendingPanel.Size = new Size(501, 976);
            pendingPanel.TabIndex = 0;
            // 
            // acceptedPanel
            // 
            acceptedPanel.AutoScroll = true;
            acceptedPanel.BorderStyle = BorderStyle.FixedSingle;
            acceptedPanel.Location = new Point(572, 65);
            acceptedPanel.Name = "acceptedPanel";
            acceptedPanel.Size = new Size(501, 978);
            acceptedPanel.TabIndex = 1;
            // 
            // readyPanel
            // 
            readyPanel.AutoScroll = true;
            readyPanel.BorderStyle = BorderStyle.FixedSingle;
            readyPanel.Location = new Point(1109, 65);
            readyPanel.Name = "readyPanel";
            readyPanel.Size = new Size(501, 978);
            readyPanel.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(21, 19);
            label1.Name = "label1";
            label1.Size = new Size(139, 45);
            label1.TabIndex = 3;
            label1.Text = "Pending";
            // 
            // acceptedLabel
            // 
            acceptedLabel.AutoSize = true;
            acceptedLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            acceptedLabel.Location = new Point(563, 17);
            acceptedLabel.Name = "acceptedLabel";
            acceptedLabel.Size = new Size(155, 45);
            acceptedLabel.TabIndex = 4;
            acceptedLabel.Text = "Accepted";
            // 
            // readyLabel
            // 
            readyLabel.AutoSize = true;
            readyLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            readyLabel.Location = new Point(1099, 17);
            readyLabel.Name = "readyLabel";
            readyLabel.Size = new Size(108, 45);
            readyLabel.TabIndex = 5;
            readyLabel.Text = "Ready";
            // 
            // RefreshButton
            // 
            RefreshButton.BackColor = SystemColors.ControlText;
            RefreshButton.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RefreshButton.ForeColor = SystemColors.ControlLightLight;
            RefreshButton.Location = new Point(691, 1093);
            RefreshButton.Name = "RefreshButton";
            RefreshButton.Size = new Size(247, 73);
            RefreshButton.TabIndex = 6;
            RefreshButton.Text = "Refresh";
            RefreshButton.UseVisualStyleBackColor = false;
            RefreshButton.Click += RefreshButton_Click;
            // 
            // ManagerMainPageUserControl1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(RefreshButton);
            Controls.Add(readyLabel);
            Controls.Add(acceptedLabel);
            Controls.Add(label1);
            Controls.Add(readyPanel);
            Controls.Add(acceptedPanel);
            Controls.Add(pendingPanel);
            Margin = new Padding(6);
            Name = "ManagerMainPageUserControl1";
            Size = new Size(1645, 1199);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pendingPanel;
        private Panel acceptedPanel;
        private Panel readyPanel;
        private Label label1;
        private Label acceptedLabel;
        private Label readyLabel;
        private Button RefreshButton;
    }
}
