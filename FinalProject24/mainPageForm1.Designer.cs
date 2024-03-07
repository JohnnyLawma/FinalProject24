namespace FinalProject24
{
    partial class mainPageForm1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MenuSideBar = new Panel();
            profilePictureBox = new PictureBox();
            settingButton = new Button();
            paymentButton = new Button();
            orderButton = new Button();
            nameLabel = new Label();
            signOutButton = new Button();
            TopBar = new Panel();
            button1 = new Button();
            searchTextBox = new TextBox();
            mainPanel = new Panel();
            MenuSideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)profilePictureBox).BeginInit();
            TopBar.SuspendLayout();
            SuspendLayout();
            // 
            // MenuSideBar
            // 
            MenuSideBar.BackColor = Color.FromArgb(124, 172, 175);
            MenuSideBar.Controls.Add(profilePictureBox);
            MenuSideBar.Controls.Add(settingButton);
            MenuSideBar.Controls.Add(paymentButton);
            MenuSideBar.Controls.Add(orderButton);
            MenuSideBar.Controls.Add(nameLabel);
            MenuSideBar.Controls.Add(signOutButton);
            MenuSideBar.Location = new Point(2, 0);
            MenuSideBar.Margin = new Padding(4, 2, 4, 2);
            MenuSideBar.Name = "MenuSideBar";
            MenuSideBar.Size = new Size(186, 1280);
            MenuSideBar.TabIndex = 1;
            // 
            // profilePictureBox
            // 
            profilePictureBox.BackColor = Color.MintCream;
            profilePictureBox.Location = new Point(22, 64);
            profilePictureBox.Margin = new Padding(4, 2, 4, 2);
            profilePictureBox.Name = "profilePictureBox";
            profilePictureBox.Size = new Size(139, 113);
            profilePictureBox.TabIndex = 5;
            profilePictureBox.TabStop = false;
            // 
            // settingButton
            // 
            settingButton.Location = new Point(4, 437);
            settingButton.Margin = new Padding(4, 2, 4, 2);
            settingButton.Name = "settingButton";
            settingButton.Size = new Size(178, 90);
            settingButton.TabIndex = 2;
            settingButton.Text = "Setting";
            settingButton.UseVisualStyleBackColor = true;
            // 
            // paymentButton
            // 
            paymentButton.Location = new Point(4, 343);
            paymentButton.Margin = new Padding(4, 2, 4, 2);
            paymentButton.Name = "paymentButton";
            paymentButton.Size = new Size(178, 90);
            paymentButton.TabIndex = 1;
            paymentButton.Text = "Payment";
            paymentButton.UseVisualStyleBackColor = true;
            // 
            // orderButton
            // 
            orderButton.Location = new Point(4, 245);
            orderButton.Margin = new Padding(4, 2, 4, 2);
            orderButton.Name = "orderButton";
            orderButton.Size = new Size(178, 90);
            orderButton.TabIndex = 0;
            orderButton.Text = "Order";
            orderButton.UseVisualStyleBackColor = true;
            // 
            // nameLabel
            // 
            nameLabel.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameLabel.Location = new Point(22, 179);
            nameLabel.Margin = new Padding(4, 0, 4, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(139, 64);
            nameLabel.TabIndex = 4;
            nameLabel.Text = "Name";
            nameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // signOutButton
            // 
            signOutButton.Location = new Point(4, 533);
            signOutButton.Margin = new Padding(4, 2, 4, 2);
            signOutButton.Name = "signOutButton";
            signOutButton.Size = new Size(178, 90);
            signOutButton.TabIndex = 3;
            signOutButton.Text = "Sign Out";
            signOutButton.UseVisualStyleBackColor = true;
            // 
            // TopBar
            // 
            TopBar.AutoSize = true;
            TopBar.BackColor = Color.FromArgb(41, 41, 41);
            TopBar.Controls.Add(button1);
            TopBar.Controls.Add(searchTextBox);
            TopBar.Location = new Point(187, 0);
            TopBar.Name = "TopBar";
            TopBar.Size = new Size(1638, 132);
            TopBar.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(1308, 29);
            button1.Name = "button1";
            button1.Size = new Size(202, 68);
            button1.TabIndex = 1;
            button1.Text = "Carts: 0";
            button1.UseVisualStyleBackColor = true;
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(528, 29);
            searchTextBox.Multiline = true;
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(686, 68);
            searchTextBox.TabIndex = 0;
            searchTextBox.Text = "Search restaurant";
            // 
            // mainPanel
            // 
            mainPanel.AutoSize = true;
            mainPanel.Location = new Point(191, 135);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1634, 1062);
            mainPanel.TabIndex = 3;
            // 
            // mainPageForm1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1827, 1197);
            Controls.Add(mainPanel);
            Controls.Add(TopBar);
            Controls.Add(MenuSideBar);
            Margin = new Padding(6);
            Name = "mainPageForm1";
            Text = "mainPageForm1";
            MenuSideBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)profilePictureBox).EndInit();
            TopBar.ResumeLayout(false);
            TopBar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel MenuSideBar;
        private PictureBox profilePictureBox;
        private Button settingButton;
        private Button paymentButton;
        private Button orderButton;
        private Label nameLabel;
        private Button signOutButton;
        private Panel TopBar;
        private Button button1;
        private TextBox searchTextBox;
        private Panel mainPanel;
    }
}
