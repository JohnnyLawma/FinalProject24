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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainPageForm1));
            MenuSideBar = new Panel();
            homeButton = new Button();
            profilePictureBox = new PictureBox();
            settingButton = new Button();
            paymentButton = new Button();
            orderButton = new Button();
            nameLabel = new Label();
            signOutButton = new Button();
            TopBar = new Panel();
            searchTextBox = new TextBox();
            cartButton = new Button();
            menuPanel = new Panel();
            menuLabel = new Label();
            mainPanel = new Panel();
            MenuSideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)profilePictureBox).BeginInit();
            TopBar.SuspendLayout();
            SuspendLayout();
            // 
            // MenuSideBar
            // 
            MenuSideBar.BackColor = Color.FromArgb(124, 172, 175);
            MenuSideBar.Controls.Add(homeButton);
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
            // homeButton
            // 
            homeButton.Location = new Point(4, 263);
            homeButton.Margin = new Padding(4, 2, 4, 2);
            homeButton.Name = "homeButton";
            homeButton.Size = new Size(178, 90);
            homeButton.TabIndex = 6;
            homeButton.Text = "Home";
            homeButton.UseVisualStyleBackColor = true;
            homeButton.Click += homeButton_Click;
            // 
            // profilePictureBox
            // 
            profilePictureBox.BackColor = Color.MintCream;
            profilePictureBox.BorderStyle = BorderStyle.Fixed3D;
            profilePictureBox.Image = (Image)resources.GetObject("profilePictureBox.Image");
            profilePictureBox.Location = new Point(22, 64);
            profilePictureBox.Margin = new Padding(4, 2, 4, 2);
            profilePictureBox.Name = "profilePictureBox";
            profilePictureBox.Size = new Size(139, 113);
            profilePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            profilePictureBox.TabIndex = 5;
            profilePictureBox.TabStop = false;
            // 
            // settingButton
            // 
            settingButton.Location = new Point(4, 577);
            settingButton.Margin = new Padding(4, 2, 4, 2);
            settingButton.Name = "settingButton";
            settingButton.Size = new Size(178, 90);
            settingButton.TabIndex = 2;
            settingButton.Text = "Setting";
            settingButton.UseVisualStyleBackColor = true;
            // 
            // paymentButton
            // 
            paymentButton.Location = new Point(4, 473);
            paymentButton.Margin = new Padding(4, 2, 4, 2);
            paymentButton.Name = "paymentButton";
            paymentButton.Size = new Size(178, 90);
            paymentButton.TabIndex = 1;
            paymentButton.Text = "Payment";
            paymentButton.UseVisualStyleBackColor = true;
            paymentButton.Click += paymentButton_Click;
            // 
            // orderButton
            // 
            orderButton.Location = new Point(4, 366);
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
            nameLabel.Text = "Emmly";
            nameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // signOutButton
            // 
            signOutButton.Location = new Point(4, 1047);
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
            TopBar.Controls.Add(searchTextBox);
            TopBar.Controls.Add(cartButton);
            TopBar.Location = new Point(187, 0);
            TopBar.Name = "TopBar";
            TopBar.Size = new Size(1638, 132);
            TopBar.TabIndex = 2;
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(384, 29);
            searchTextBox.Multiline = true;
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(766, 68);
            searchTextBox.TabIndex = 0;
            searchTextBox.Text = "Search restaurant";
            // 
            // cartButton
            // 
            cartButton.Location = new Point(1254, 29);
            cartButton.Name = "cartButton";
            cartButton.Size = new Size(202, 68);
            cartButton.TabIndex = 2;
            cartButton.Text = "Carts: 0";
            cartButton.UseVisualStyleBackColor = true;
            cartButton.Click += cartButton_Click;
            // 
            // menuPanel
            // 
            menuPanel.AutoScroll = true;
            menuPanel.Location = new Point(372, 228);
            menuPanel.Name = "menuPanel";
            menuPanel.Size = new Size(1290, 860);
            menuPanel.TabIndex = 0;
            // 
            // menuLabel
            // 
            menuLabel.AutoSize = true;
            menuLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuLabel.Location = new Point(359, 180);
            menuLabel.Name = "menuLabel";
            menuLabel.Size = new Size(105, 45);
            menuLabel.TabIndex = 1;
            menuLabel.Text = "Menu";
            menuLabel.Click += menuLabel_Click;
            // 
            // mainPanel
            // 
            mainPanel.Location = new Point(187, 125);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1638, 1060);
            mainPanel.TabIndex = 3;
            // 
            // mainPageForm1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1827, 1197);
            Controls.Add(menuLabel);
            Controls.Add(menuPanel);
            Controls.Add(mainPanel);
            Controls.Add(TopBar);
            Controls.Add(MenuSideBar);
            Margin = new Padding(6);
            Name = "mainPageForm1";
            Text = "mainPageForm1";
            Load += mainPageForm1_Load;
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
        private TextBox searchTextBox;
        private Button cartButton;
        private Button homeButton;
        private Panel menuPanel;
        private Label menuLabel;
        private Panel mainPanel;
    }
}
