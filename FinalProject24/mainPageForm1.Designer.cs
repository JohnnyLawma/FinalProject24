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
            MenuSideBar.Location = new Point(1, 0);
            MenuSideBar.Margin = new Padding(3, 0, 3, 0);
            MenuSideBar.Name = "MenuSideBar";
            MenuSideBar.Size = new Size(143, 1000);
            MenuSideBar.TabIndex = 1;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(3, 852);
            exitButton.Margin = new Padding(3, 2, 3, 2);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(137, 70);
            exitButton.TabIndex = 8;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // roundPictureBox1
            // 
            roundPictureBox1.BorderStyle = BorderStyle.Fixed3D;
            roundPictureBox1.Image = (Image)resources.GetObject("roundPictureBox1.Image");
            roundPictureBox1.Location = new Point(13, 17);
            roundPictureBox1.Margin = new Padding(3, 2, 3, 2);
            roundPictureBox1.Name = "roundPictureBox1";
            roundPictureBox1.Size = new Size(117, 116);
            roundPictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            roundPictureBox1.TabIndex = 7;
            roundPictureBox1.TabStop = false;
            // 
            // homeButton
            // 
            homeButton.Location = new Point(3, 205);
            homeButton.Margin = new Padding(3, 2, 3, 2);
            homeButton.Name = "homeButton";
            homeButton.Size = new Size(137, 70);
            homeButton.TabIndex = 6;
            homeButton.Text = "Home";
            homeButton.UseVisualStyleBackColor = true;
            homeButton.Click += homeButton_Click;
            // 
            // settingButton
            // 
            settingButton.Location = new Point(3, 450);
            settingButton.Margin = new Padding(3, 2, 3, 2);
            settingButton.Name = "settingButton";
            settingButton.Size = new Size(137, 70);
            settingButton.TabIndex = 2;
            settingButton.Text = "Setting";
            settingButton.UseVisualStyleBackColor = true;
            settingButton.Click += settingButton_Click;
            // 
            // paymentButton
            // 
            paymentButton.Location = new Point(3, 370);
            paymentButton.Margin = new Padding(3, 2, 3, 2);
            paymentButton.Name = "paymentButton";
            paymentButton.Size = new Size(137, 70);
            paymentButton.TabIndex = 1;
            paymentButton.Text = "Payment";
            paymentButton.UseVisualStyleBackColor = true;
            paymentButton.Click += paymentButton_Click;
            // 
            // orderButton
            // 
            orderButton.Location = new Point(3, 287);
            orderButton.Margin = new Padding(3, 2, 3, 2);
            orderButton.Name = "orderButton";
            orderButton.Size = new Size(137, 70);
            orderButton.TabIndex = 0;
            orderButton.Text = "Order History";
            orderButton.UseVisualStyleBackColor = true;
            orderButton.Click += orderButton_Click;
            // 
            // nameLabel
            // 
            nameLabel.Font = new Font("Segoe UI Semibold", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nameLabel.Location = new Point(17, 133);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(107, 50);
            nameLabel.TabIndex = 4;
            nameLabel.Text = "Emily";
            nameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // signOutButton
            // 
            signOutButton.Location = new Point(3, 778);
            signOutButton.Margin = new Padding(3, 2, 3, 2);
            signOutButton.Name = "signOutButton";
            signOutButton.Size = new Size(137, 70);
            signOutButton.TabIndex = 3;
            signOutButton.Text = "Sign Out";
            signOutButton.UseVisualStyleBackColor = true;
            signOutButton.Click += signOutButton_Click;
            // 
            // mainPanel
            // 
            mainPanel.Location = new Point(144, 103);
            mainPanel.Margin = new Padding(3, 2, 3, 2);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1638, 1054);
            mainPanel.TabIndex = 3;
            // 
            // TopBar
            // 
            TopBar.AutoSize = true;
            TopBar.BackColor = Color.FromArgb(41, 41, 41);
            TopBar.Controls.Add(searchTextBox);
            TopBar.Controls.Add(cartButton);
            TopBar.Location = new Point(144, 0);
            TopBar.Margin = new Padding(3, 2, 3, 2);
            TopBar.Name = "TopBar";
            TopBar.Size = new Size(1260, 103);
            TopBar.TabIndex = 2;
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(296, 23);
            searchTextBox.Margin = new Padding(3, 2, 3, 2);
            searchTextBox.Multiline = true;
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(590, 54);
            searchTextBox.TabIndex = 0;
            searchTextBox.Text = "Search restaurant";
            // 
            // cartButton
            // 
            cartButton.Location = new Point(964, 23);
            cartButton.Margin = new Padding(3, 2, 3, 2);
            cartButton.Name = "cartButton";
            cartButton.Size = new Size(156, 53);
            cartButton.TabIndex = 2;
            cartButton.Text = "Carts: 0";
            cartButton.UseVisualStyleBackColor = true;
            cartButton.Click += cartButton_Click;
            // 
            // menuPanel
            // 
            menuPanel.AutoScroll = true;
            menuPanel.Location = new Point(284, 177);
            menuPanel.Margin = new Padding(3, 2, 3, 2);
            menuPanel.Name = "menuPanel";
            menuPanel.Size = new Size(1291, 860);
            menuPanel.TabIndex = 0;
            // 
            // menuLabel
            // 
            menuLabel.AutoSize = true;
            menuLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuLabel.Location = new Point(276, 140);
            menuLabel.Name = "menuLabel";
            menuLabel.Size = new Size(77, 32);
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
            orderHistoryPanel.Location = new Point(144, 108);
            orderHistoryPanel.Margin = new Padding(3, 2, 3, 2);
            orderHistoryPanel.Name = "orderHistoryPanel";
            orderHistoryPanel.Size = new Size(1260, 818);
            orderHistoryPanel.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(559, 18);
            label1.Name = "label1";
            label1.Size = new Size(150, 30);
            label1.TabIndex = 3;
            label1.Text = "Order Details:";
            // 
            // orderHistoryLabel
            // 
            orderHistoryLabel.AutoSize = true;
            orderHistoryLabel.Font = new Font("Segoe UI Semibold", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            orderHistoryLabel.Location = new Point(56, 18);
            orderHistoryLabel.Name = "orderHistoryLabel";
            orderHistoryLabel.Size = new Size(154, 30);
            orderHistoryLabel.TabIndex = 2;
            orderHistoryLabel.Text = "Order History:";
            // 
            // orderSummaryPanel
            // 
            orderSummaryPanel.BorderStyle = BorderStyle.FixedSingle;
            orderSummaryPanel.Location = new Point(559, 52);
            orderSummaryPanel.Margin = new Padding(3, 2, 3, 2);
            orderSummaryPanel.Name = "orderSummaryPanel";
            orderSummaryPanel.Size = new Size(619, 765);
            orderSummaryPanel.TabIndex = 1;
            // 
            // orderListPanel
            // 
            orderListPanel.BorderStyle = BorderStyle.FixedSingle;
            orderListPanel.Location = new Point(56, 52);
            orderListPanel.Margin = new Padding(3, 2, 3, 2);
            orderListPanel.Name = "orderListPanel";
            orderListPanel.Size = new Size(471, 764);
            orderListPanel.TabIndex = 0;
            // 
            // mainPageForm1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1378, 944);
            Controls.Add(orderHistoryPanel);
            Controls.Add(mainPanel);
            Controls.Add(menuLabel);
            Controls.Add(menuPanel);
            Controls.Add(TopBar);
            Controls.Add(MenuSideBar);
            Margin = new Padding(4, 5, 4, 5);
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
