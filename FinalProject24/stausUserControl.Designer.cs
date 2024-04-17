namespace FinalProject24
{
    partial class stausUserControl
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
            nameLabel = new Label();
            statusButton = new Button();
            itemsListBox = new ListBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nameLabel.Location = new Point(25, 18);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(140, 37);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Lee James";
            // 
            // statusButton
            // 
            statusButton.BackColor = SystemColors.ActiveCaptionText;
            statusButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            statusButton.ForeColor = SystemColors.ControlLightLight;
            statusButton.Location = new Point(36, 438);
            statusButton.Name = "statusButton";
            statusButton.Size = new Size(189, 56);
            statusButton.TabIndex = 2;
            statusButton.Text = "Accept";
            statusButton.UseVisualStyleBackColor = false;
            // 
            // itemsListBox
            // 
            itemsListBox.FormattingEnabled = true;
            itemsListBox.Location = new Point(36, 58);
            itemsListBox.Name = "itemsListBox";
            itemsListBox.Size = new Size(418, 356);
            itemsListBox.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 0, 0);
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(265, 438);
            button1.Name = "button1";
            button1.Size = new Size(189, 56);
            button1.TabIndex = 3;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = false;
            // 
            // stausUserControl
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            BorderStyle = BorderStyle.Fixed3D;
            Controls.Add(button1);
            Controls.Add(itemsListBox);
            Controls.Add(statusButton);
            Controls.Add(nameLabel);
            Name = "stausUserControl";
            Size = new Size(497, 530);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nameLabel;
        private Button statusButton;
        private ListBox itemsListBox;
        private Button button1;
    }
}
