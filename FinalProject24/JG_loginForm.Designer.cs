namespace FinalProject24
{
    partial class JG_loginForm
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
            panel1 = new Panel();
            successOrNotLabel = new Label();
            signupLabel = new LinkLabel();
            label4 = new Label();
            signinButton = new Button();
            passwordTextBox = new TextBox();
            label3 = new Label();
            emailTextBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Controls.Add(successOrNotLabel);
            panel1.Controls.Add(signupLabel);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(signinButton);
            panel1.Controls.Add(passwordTextBox);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(emailTextBox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(477, 143);
            panel1.Margin = new Padding(6);
            panel1.Name = "panel1";
            panel1.Size = new Size(836, 917);
            panel1.TabIndex = 0;
            // 
            // successOrNotLabel
            // 
            successOrNotLabel.AutoSize = true;
            successOrNotLabel.Location = new Point(189, 635);
            successOrNotLabel.Name = "successOrNotLabel";
            successOrNotLabel.Size = new Size(0, 32);
            successOrNotLabel.TabIndex = 11;
            successOrNotLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // signupLabel
            // 
            signupLabel.AutoSize = true;
            signupLabel.Font = new Font("Segoe UI", 12F);
            signupLabel.Location = new Point(548, 794);
            signupLabel.Margin = new Padding(6, 0, 6, 0);
            signupLabel.Name = "signupLabel";
            signupLabel.Size = new Size(132, 45);
            signupLabel.TabIndex = 10;
            signupLabel.TabStop = true;
            signupLabel.Text = "Sign Up";
            signupLabel.LinkClicked += signupLabel_LinkClicked;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(193, 794);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(350, 45);
            label4.TabIndex = 9;
            label4.Text = "Don't have an account?";
            // 
            // signinButton
            // 
            signinButton.BackColor = Color.Black;
            signinButton.FlatStyle = FlatStyle.Flat;
            signinButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signinButton.ForeColor = SystemColors.ButtonHighlight;
            signinButton.Location = new Point(187, 522);
            signinButton.Margin = new Padding(6);
            signinButton.Name = "signinButton";
            signinButton.Size = new Size(487, 70);
            signinButton.TabIndex = 8;
            signinButton.Text = "Sign In";
            signinButton.UseVisualStyleBackColor = false;
            signinButton.Click += signinButton_Click;
            // 
            // passwordTextBox
            // 
            passwordTextBox.BackColor = SystemColors.ScrollBar;
            passwordTextBox.BorderStyle = BorderStyle.FixedSingle;
            passwordTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordTextBox.Location = new Point(189, 393);
            passwordTextBox.Margin = new Padding(6);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(485, 50);
            passwordTextBox.TabIndex = 6;
            passwordTextBox.Text = "Enter your password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(179, 342);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(165, 45);
            label3.TabIndex = 5;
            label3.Text = "Password:";
            // 
            // emailTextBox
            // 
            emailTextBox.BackColor = SystemColors.ScrollBar;
            emailTextBox.BorderStyle = BorderStyle.FixedSingle;
            emailTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailTextBox.Location = new Point(189, 237);
            emailTextBox.Margin = new Padding(6);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(485, 50);
            emailTextBox.TabIndex = 4;
            emailTextBox.Text = "Enter your email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(179, 186);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(106, 45);
            label2.TabIndex = 3;
            label2.Text = "Email:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(221, 73);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(391, 72);
            label1.TabIndex = 1;
            label1.Text = "Welcome Back!";
            // 
            // JG_loginForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(124, 172, 175);
            ClientSize = new Size(1827, 1197);
            Controls.Add(panel1);
            Margin = new Padding(6);
            Name = "JG_loginForm";
            Text = "loginForm2";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private LinkLabel signupLabel;
        private Label label4;
        private Button signinButton;
        private TextBox passwordTextBox;
        private Label label3;
        private TextBox emailTextBox;
        private Label label2;
        private Label label1;
        private Label successOrNotLabel;
    }
}