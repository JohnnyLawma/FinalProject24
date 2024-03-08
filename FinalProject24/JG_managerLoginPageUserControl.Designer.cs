namespace FinalProject24
{
    partial class JG_managerLoginPageUserControl
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
            linkLabel1 = new LinkLabel();
            label4 = new Label();
            button1 = new Button();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 12F);
            linkLabel1.Location = new Point(276, 360);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(65, 21);
            linkLabel1.TabIndex = 18;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Sign Up";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(98, 360);
            label4.Name = "label4";
            label4.Size = new Size(171, 21);
            label4.TabIndex = 17;
            label4.Text = "Don't have an account?";
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(98, 311);
            button1.Name = "button1";
            button1.Size = new Size(262, 33);
            button1.TabIndex = 16;
            button1.Text = "Sign In";
            button1.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.ScrollBar;
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(147, 191);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(262, 29);
            textBox2.TabIndex = 15;
            textBox2.Text = "Enter your password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(41, 193);
            label3.Name = "label3";
            label3.Size = new Size(79, 21);
            label3.TabIndex = 14;
            label3.Text = "Password:";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ScrollBar;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(147, 129);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(262, 29);
            textBox1.TabIndex = 13;
            textBox1.Text = "Enter your email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(69, 131);
            label2.Name = "label2";
            label2.Size = new Size(51, 21);
            label2.TabIndex = 12;
            label2.Text = "Email:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(135, 49);
            label1.Name = "label1";
            label1.Size = new Size(196, 37);
            label1.TabIndex = 11;
            label1.Text = "Welcome Back!";
            // 
            // managerLoginPageUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            Controls.Add(linkLabel1);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "managerLoginPageUserControl";
            Size = new Size(450, 430);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linkLabel1;
        private Label label4;
        private Button button1;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
    }
}
