namespace FinalProject24
{
    partial class ManagerMainPageForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerMainPageForm));
            MenuSideBar = new Panel();
            exitButton = new Button();
            settingButton = new Button();
            resturantProfileButton = new Button();
            editMenu = new Button();
            nameLabel = new Label();
            signOutButton = new Button();
            mainpanel1 = new Panel();
            ordersButton = new Button();
            roundPictureBox1 = new RoundPictureBox();
            MenuSideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)roundPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // MenuSideBar
            // 
            MenuSideBar.BackColor = Color.FromArgb(124, 172, 175);
            MenuSideBar.Controls.Add(roundPictureBox1);
            MenuSideBar.Controls.Add(ordersButton);
            MenuSideBar.Controls.Add(exitButton);
            MenuSideBar.Controls.Add(settingButton);
            MenuSideBar.Controls.Add(resturantProfileButton);
            MenuSideBar.Controls.Add(editMenu);
            MenuSideBar.Controls.Add(nameLabel);
            MenuSideBar.Controls.Add(signOutButton);
            MenuSideBar.Location = new Point(1, 0);
            MenuSideBar.Margin = new Padding(2, 0, 2, 0);
            MenuSideBar.Name = "MenuSideBar";
            MenuSideBar.Size = new Size(114, 753);
            MenuSideBar.TabIndex = 2;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(2, 681);
            exitButton.Margin = new Padding(2, 1, 2, 1);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(110, 56);
            exitButton.TabIndex = 8;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // settingButton
            // 
            settingButton.Location = new Point(2, 350);
            settingButton.Margin = new Padding(2, 1, 2, 1);
            settingButton.Name = "settingButton";
            settingButton.Size = new Size(110, 56);
            settingButton.TabIndex = 2;
            settingButton.Text = "Setting";
            settingButton.UseVisualStyleBackColor = true;
            settingButton.Click += settingButton_Click;
            // 
            // resturantProfileButton
            // 
            resturantProfileButton.Location = new Point(2, 292);
            resturantProfileButton.Margin = new Padding(2, 1, 2, 1);
            resturantProfileButton.Name = "resturantProfileButton";
            resturantProfileButton.Size = new Size(110, 56);
            resturantProfileButton.TabIndex = 1;
            resturantProfileButton.Text = "Resturant Profile";
            resturantProfileButton.UseVisualStyleBackColor = true;
            resturantProfileButton.Click += resturantProfileButton_Click;
            // 
            // editMenu
            // 
            editMenu.Location = new Point(2, 234);
            editMenu.Margin = new Padding(2, 1, 2, 1);
            editMenu.Name = "editMenu";
            editMenu.Size = new Size(110, 56);
            editMenu.TabIndex = 0;
            editMenu.Text = "Edit Menu";
            editMenu.UseVisualStyleBackColor = true;
            editMenu.Click += editMenu_Click;
            // 
            // nameLabel
            // 
            nameLabel.Font = new Font("Segoe UI Semibold", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nameLabel.Location = new Point(14, 107);
            nameLabel.Margin = new Padding(2, 0, 2, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(86, 40);
            nameLabel.TabIndex = 4;
            nameLabel.Text = "Emily";
            nameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // signOutButton
            // 
            signOutButton.Location = new Point(2, 623);
            signOutButton.Margin = new Padding(2, 1, 2, 1);
            signOutButton.Name = "signOutButton";
            signOutButton.Size = new Size(110, 56);
            signOutButton.TabIndex = 3;
            signOutButton.Text = "Sign Out";
            signOutButton.UseVisualStyleBackColor = true;
            signOutButton.Click += signOutButton_Click;
            // 
            // mainpanel1
            // 
            mainpanel1.AutoSize = true;
            mainpanel1.Location = new Point(119, 0);
            mainpanel1.Margin = new Padding(3, 4, 3, 4);
            mainpanel1.Name = "mainpanel1";
            mainpanel1.Size = new Size(1005, 749);
            mainpanel1.TabIndex = 3;
            // 
            // ordersButton
            // 
            ordersButton.Location = new Point(2, 176);
            ordersButton.Margin = new Padding(2, 1, 2, 1);
            ordersButton.Name = "ordersButton";
            ordersButton.Size = new Size(110, 56);
            ordersButton.TabIndex = 9;
            ordersButton.Text = "Incoming Orders";
            ordersButton.UseVisualStyleBackColor = true;
            ordersButton.Click += ordersButton_Click;
            // 
            // roundPictureBox1
            // 
            roundPictureBox1.BorderStyle = BorderStyle.Fixed3D;
            roundPictureBox1.Image = (Image)resources.GetObject("roundPictureBox1.Image");
            roundPictureBox1.Location = new Point(10, 11);
            roundPictureBox1.Margin = new Padding(2);
            roundPictureBox1.Name = "roundPictureBox1";
            roundPictureBox1.Size = new Size(94, 94);
            roundPictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            roundPictureBox1.TabIndex = 10;
            roundPictureBox1.TabStop = false;
            // 
            // ManagerMainPageForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1125, 748);
            Controls.Add(mainpanel1);
            Controls.Add(MenuSideBar);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ManagerMainPageForm";
            Text = "ManagerMainPageForm";
            MenuSideBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)roundPictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel MenuSideBar;
        private Button exitButton;
        private RoundPictureBox roundPictureBox1;
        private Button settingButton;
        private Button resturantProfileButton;
        private Button editMenu;
        private Label nameLabel;
        private Button signOutButton;
        private Panel mainpanel1;
        private Button ordersButton;
    }
}