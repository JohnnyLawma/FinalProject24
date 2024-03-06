namespace FinalProject24
{
    partial class Form1
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
            panel1 = new Panel();
            profilePictureBox = new PictureBox();
            nameLabel = new Label();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)profilePictureBox).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkCyan;
            panel1.Controls.Add(profilePictureBox);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(nameLabel);
            panel1.Controls.Add(button4);
            panel1.Location = new Point(-1, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(320, 707);
            panel1.TabIndex = 0;
            // 
            // profilePictureBox
            // 
            profilePictureBox.BackColor = Color.MintCream;
            profilePictureBox.Location = new Point(43, 10);
            profilePictureBox.Name = "profilePictureBox";
            profilePictureBox.Size = new Size(156, 114);
            profilePictureBox.TabIndex = 5;
            profilePictureBox.TabStop = false;
            // 
            // nameLabel
            // 
            nameLabel.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameLabel.Location = new Point(43, 127);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(156, 64);
            nameLabel.TabIndex = 4;
            nameLabel.Text = "Name";
            nameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button4
            // 
            button4.Location = new Point(-3, 482);
            button4.Name = "button4";
            button4.Size = new Size(325, 90);
            button4.TabIndex = 3;
            button4.Text = "Sign Out";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(0, 386);
            button3.Name = "button3";
            button3.Size = new Size(322, 90);
            button3.TabIndex = 2;
            button3.Text = "Setting";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(-3, 290);
            button2.Name = "button2";
            button2.Size = new Size(320, 90);
            button2.TabIndex = 1;
            button2.Text = "Payment";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(0, 194);
            button1.Name = "button1";
            button1.Size = new Size(320, 90);
            button1.TabIndex = 0;
            button1.Text = "Order";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(974, 529);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)profilePictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Button button4;
        private Button button3;
        private Button button2;
        private PictureBox profilePictureBox;
        private Label nameLabel;
    }
}
