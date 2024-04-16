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
            roundPictureBox1 = new RoundPictureBox();
            settingButton = new Button();
            paymentButton = new Button();
            orderButton = new Button();
            nameLabel = new Label();
            signOutButton = new Button();
            mainpanel1 = new Panel();
            MenuSideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)roundPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // MenuSideBar
            // 
            MenuSideBar.BackColor = Color.FromArgb(124, 172, 175);
            MenuSideBar.Controls.Add(exitButton);
            MenuSideBar.Controls.Add(roundPictureBox1);
            MenuSideBar.Controls.Add(settingButton);
            MenuSideBar.Controls.Add(paymentButton);
            MenuSideBar.Controls.Add(orderButton);
            MenuSideBar.Controls.Add(nameLabel);
            MenuSideBar.Controls.Add(signOutButton);
            MenuSideBar.Location = new Point(2, 0);
            MenuSideBar.Margin = new Padding(4, 0, 4, 0);
            MenuSideBar.Name = "MenuSideBar";
            MenuSideBar.Size = new Size(186, 1205);
            MenuSideBar.TabIndex = 2;
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
            // settingButton
            // 
            settingButton.Location = new Point(4, 467);
            settingButton.Margin = new Padding(4, 2, 4, 2);
            settingButton.Name = "settingButton";
            settingButton.Size = new Size(178, 90);
            settingButton.TabIndex = 2;
            settingButton.Text = "Setting";
            settingButton.UseVisualStyleBackColor = true;
            // 
            // paymentButton
            // 
            paymentButton.Location = new Point(4, 365);
            paymentButton.Margin = new Padding(4, 2, 4, 2);
            paymentButton.Name = "paymentButton";
            paymentButton.Size = new Size(178, 90);
            paymentButton.TabIndex = 1;
            paymentButton.Text = "Resturant Profile";
            paymentButton.UseVisualStyleBackColor = true;
            paymentButton.Click += paymentButton_Click;
            // 
            // orderButton
            // 
            orderButton.Location = new Point(4, 258);
            orderButton.Margin = new Padding(4, 2, 4, 2);
            orderButton.Name = "orderButton";
            orderButton.Size = new Size(178, 90);
            orderButton.TabIndex = 0;
            orderButton.Text = "Edit Menu";
            orderButton.UseVisualStyleBackColor = true;
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
            // mainpanel1
            // 
            mainpanel1.AutoSize = true;
            mainpanel1.Location = new Point(194, 0);
            mainpanel1.Margin = new Padding(6, 6, 6, 6);
            mainpanel1.Name = "mainpanel1";
            mainpanel1.Size = new Size(1633, 1199);
            mainpanel1.TabIndex = 3;
            // 
            // ManagerMainPageForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1827, 1197);
            Controls.Add(mainpanel1);
            Controls.Add(MenuSideBar);
            Margin = new Padding(6, 6, 6, 6);
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
        private Button paymentButton;
        private Button orderButton;
        private Label nameLabel;
        private Button signOutButton;
        private Panel mainpanel1;
    }
}