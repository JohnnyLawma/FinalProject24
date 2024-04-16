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
            SuspendLayout();
            // 
            // pendingPanel
            // 
            pendingPanel.AutoScroll = true;
            pendingPanel.BorderStyle = BorderStyle.FixedSingle;
            pendingPanel.Location = new Point(30, 121);
            pendingPanel.Name = "pendingPanel";
            pendingPanel.Size = new Size(501, 999);
            pendingPanel.TabIndex = 0;
            // 
            // acceptedPanel
            // 
            acceptedPanel.BorderStyle = BorderStyle.FixedSingle;
            acceptedPanel.Location = new Point(571, 119);
            acceptedPanel.Name = "acceptedPanel";
            acceptedPanel.Size = new Size(501, 1001);
            acceptedPanel.TabIndex = 1;
            // 
            // readyPanel
            // 
            readyPanel.BorderStyle = BorderStyle.FixedSingle;
            readyPanel.Location = new Point(1108, 119);
            readyPanel.Name = "readyPanel";
            readyPanel.Size = new Size(501, 1001);
            readyPanel.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(20, 73);
            label1.Name = "label1";
            label1.Size = new Size(139, 45);
            label1.TabIndex = 3;
            label1.Text = "Pending";
            // 
            // acceptedLabel
            // 
            acceptedLabel.AutoSize = true;
            acceptedLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            acceptedLabel.Location = new Point(562, 71);
            acceptedLabel.Name = "acceptedLabel";
            acceptedLabel.Size = new Size(155, 45);
            acceptedLabel.TabIndex = 4;
            acceptedLabel.Text = "Accepted";
            // 
            // readyLabel
            // 
            readyLabel.AutoSize = true;
            readyLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            readyLabel.Location = new Point(1098, 71);
            readyLabel.Name = "readyLabel";
            readyLabel.Size = new Size(108, 45);
            readyLabel.TabIndex = 5;
            readyLabel.Text = "Ready";
            // 
            // ManagerMainPageUserControl1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
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
    }
}
