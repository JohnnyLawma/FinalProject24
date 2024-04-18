﻿namespace FinalProject24
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
            exitButton = new Button();
            roundPictureBox1 = new RoundPictureBox();
            homeButton = new Button();
            settingButton = new Button();
            paymentButton = new Button();
            orderButton = new Button();
            nameLabel = new Label();
            signOutButton = new Button();
            mainPanel = new Panel();
            TopBar = new Panel();
            searchTextBox = new TextBox();
            cartButton = new Button();
            menuPanel = new Panel();
            menuLabel = new Label();
            orderHistoryPanel = new Panel();
            label1 = new Label();
            orderHistoryLabel = new Label();
            orderSummaryPanel = new Panel();
            orderListPanel = new Panel();
            MenuSideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)roundPictureBox1).BeginInit();
            TopBar.SuspendLayout();
            orderHistoryPanel.SuspendLayout();
            SuspendLayout();
            // 
            // MenuSideBar
            // 
            MenuSideBar.BackColor = Color.FromArgb(124, 172, 175);
            MenuSideBar.Controls.Add(exitButton);
            MenuSideBar.Controls.Add(roundPictureBox1);
            MenuSideBar.Controls.Add(homeButton);
            MenuSideBar.Controls.Add(settingButton);
            MenuSideBar.Controls.Add(paymentButton);
            MenuSideBar.Controls.Add(orderButton);
            MenuSideBar.Controls.Add(nameLabel);
            MenuSideBar.Controls.Add(signOutButton);
            MenuSideBar.Location = new Point(2, 0);
            MenuSideBar.Margin = new Padding(4, 0, 4, 0);
            MenuSideBar.Name = "MenuSideBar";
            MenuSideBar.Size = new Size(186, 1280);
            MenuSideBar.TabIndex = 1;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(4, 1090);
            exitButton.Margin = new Padding(4, 2, 4, 2);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(178, 90);
            exitButton.TabIndex = 8;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // roundPictureBox1
            // 
            roundPictureBox1.BorderStyle = BorderStyle.Fixed3D;
            roundPictureBox1.Image = (Image)resources.GetObject("roundPictureBox1.Image");
            roundPictureBox1.Location = new Point(17, 21);
            roundPictureBox1.Margin = new Padding(4, 2, 4, 2);
            roundPictureBox1.Name = "roundPictureBox1";
            roundPictureBox1.Size = new Size(151, 147);
            roundPictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            roundPictureBox1.TabIndex = 7;
            roundPictureBox1.TabStop = false;
            // 
            // homeButton
            // 
            homeButton.Location = new Point(4, 262);
            homeButton.Margin = new Padding(4, 2, 4, 2);
            homeButton.Name = "homeButton";
            homeButton.Size = new Size(178, 90);
            homeButton.TabIndex = 6;
            homeButton.Text = "Home";
            homeButton.UseVisualStyleBackColor = true;
            homeButton.Click += homeButton_Click;
            // 
            // settingButton
            // 
            settingButton.Location = new Point(4, 576);
            settingButton.Margin = new Padding(4, 2, 4, 2);
            settingButton.Name = "settingButton";
            settingButton.Size = new Size(178, 90);
            settingButton.TabIndex = 2;
            settingButton.Text = "Setting";
            settingButton.UseVisualStyleBackColor = true;
            settingButton.Click += settingButton_Click;
            // 
            // paymentButton
            // 
            paymentButton.Location = new Point(4, 474);
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
            orderButton.Location = new Point(4, 367);
            orderButton.Margin = new Padding(4, 2, 4, 2);
            orderButton.Name = "orderButton";
            orderButton.Size = new Size(178, 90);
            orderButton.TabIndex = 0;
            orderButton.Text = "Order History";
            orderButton.UseVisualStyleBackColor = true;
            orderButton.Click += orderButton_Click;
            // 
            // nameLabel
            // 
            nameLabel.Font = new Font("Segoe UI Semibold", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nameLabel.Location = new Point(22, 171);
            nameLabel.Margin = new Padding(4, 0, 4, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(139, 64);
            nameLabel.TabIndex = 4;
            nameLabel.Text = "Emily";
            nameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // signOutButton
            // 
            signOutButton.Location = new Point(4, 996);
            signOutButton.Margin = new Padding(4, 2, 4, 2);
            signOutButton.Name = "signOutButton";
            signOutButton.Size = new Size(178, 90);
            signOutButton.TabIndex = 3;
            signOutButton.Text = "Sign Out";
            signOutButton.UseVisualStyleBackColor = true;
            signOutButton.Click += signOutButton_Click;
            // 
            // mainPanel
            // 
            mainPanel.Location = new Point(188, 132);
            mainPanel.Margin = new Padding(4, 2, 4, 2);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(2130, 1348);
            mainPanel.TabIndex = 3;
            // 
            // TopBar
            // 
            TopBar.AutoSize = true;
            TopBar.BackColor = Color.FromArgb(41, 41, 41);
            TopBar.Controls.Add(searchTextBox);
            TopBar.Controls.Add(cartButton);
            TopBar.Location = new Point(188, 0);
            TopBar.Margin = new Padding(4, 2, 4, 2);
            TopBar.Name = "TopBar";
            TopBar.Size = new Size(1638, 132);
            TopBar.TabIndex = 2;
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(384, 30);
            searchTextBox.Margin = new Padding(4, 2, 4, 2);
            searchTextBox.Multiline = true;
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(765, 68);
            searchTextBox.TabIndex = 0;
            searchTextBox.Text = "Search restaurant";
            // 
            // cartButton
            // 
            cartButton.Location = new Point(1254, 30);
            cartButton.Margin = new Padding(4, 2, 4, 2);
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
            menuPanel.Location = new Point(280, 220);
            menuPanel.Margin = new Padding(4, 2, 4, 2);
            menuPanel.Name = "menuPanel";
            menuPanel.Size = new Size(1456, 956);
            menuPanel.TabIndex = 0;
            // 
            // menuLabel
            // 
            menuLabel.AutoSize = true;
            menuLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuLabel.Location = new Point(280, 170);
            menuLabel.Margin = new Padding(4, 0, 4, 0);
            menuLabel.Name = "menuLabel";
            menuLabel.Size = new Size(105, 45);
            menuLabel.TabIndex = 1;
            menuLabel.Text = "Menu";
            menuLabel.Click += menuLabel_Click;
            // 
            // orderHistoryPanel
            // 
            orderHistoryPanel.Controls.Add(label1);
            orderHistoryPanel.Controls.Add(orderHistoryLabel);
            orderHistoryPanel.Controls.Add(orderSummaryPanel);
            orderHistoryPanel.Controls.Add(orderListPanel);
            orderHistoryPanel.Location = new Point(188, 139);
            orderHistoryPanel.Margin = new Padding(4, 2, 4, 2);
            orderHistoryPanel.Name = "orderHistoryPanel";
            orderHistoryPanel.Size = new Size(1638, 1047);
            orderHistoryPanel.TabIndex = 0;
            orderHistoryPanel.Paint += orderHistoryPanel_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(726, 23);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(198, 40);
            label1.TabIndex = 3;
            label1.Text = "Order Details:";
            // 
            // orderHistoryLabel
            // 
            orderHistoryLabel.AutoSize = true;
            orderHistoryLabel.Font = new Font("Segoe UI Semibold", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            orderHistoryLabel.Location = new Point(72, 23);
            orderHistoryLabel.Margin = new Padding(4, 0, 4, 0);
            orderHistoryLabel.Name = "orderHistoryLabel";
            orderHistoryLabel.Size = new Size(204, 40);
            orderHistoryLabel.TabIndex = 2;
            orderHistoryLabel.Text = "Order History:";
            // 
            // orderSummaryPanel
            // 
            orderSummaryPanel.BorderStyle = BorderStyle.FixedSingle;
            orderSummaryPanel.Location = new Point(726, 66);
            orderSummaryPanel.Margin = new Padding(4, 2, 4, 2);
            orderSummaryPanel.Name = "orderSummaryPanel";
            orderSummaryPanel.Size = new Size(804, 979);
            orderSummaryPanel.TabIndex = 1;
            orderSummaryPanel.Paint += orderSummaryPanel_Paint;
            // 
            // orderListPanel
            // 
            orderListPanel.BorderStyle = BorderStyle.FixedSingle;
            orderListPanel.Location = new Point(72, 66);
            orderListPanel.Margin = new Padding(4, 2, 4, 2);
            orderListPanel.Name = "orderListPanel";
            orderListPanel.Size = new Size(609, 977);
            orderListPanel.TabIndex = 0;
            orderListPanel.Paint += orderListPanel_Paint;
            // 
            // mainPageForm1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1792, 1207);
            Controls.Add(menuLabel);
            Controls.Add(menuPanel);
            Controls.Add(orderHistoryPanel);
            Controls.Add(mainPanel);
            Controls.Add(TopBar);
            Controls.Add(MenuSideBar);
            Margin = new Padding(6, 6, 6, 6);
            Name = "mainPageForm1";
            Text = "mainPageForm1";
            Load += mainPageForm1_Load;
            MenuSideBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)roundPictureBox1).EndInit();
            TopBar.ResumeLayout(false);
            TopBar.PerformLayout();
            orderHistoryPanel.ResumeLayout(false);
            orderHistoryPanel.PerformLayout();
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
        private RoundPictureBox roundPictureBox1;
        private Button exitButton;
        private Panel orderHistoryPanel;
        private Panel orderListPanel;
        private Panel orderSummaryPanel;
        private Label orderHistoryLabel;
        private Label label1;
    }
}
