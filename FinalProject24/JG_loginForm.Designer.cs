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
            panel1.Location = new Point(367, 112);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(643, 717);
            panel1.TabIndex = 0;
            // 
            // successOrNotLabel
            // 
            successOrNotLabel.Location = new Point(146, 497);
            successOrNotLabel.Name = "successOrNotLabel";
            successOrNotLabel.Size = new Size(373, 42);
            successOrNotLabel.TabIndex = 11;
            successOrNotLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // signupLabel
            // 
            signupLabel.AutoSize = true;
            signupLabel.Font = new Font("Segoe UI", 12F);
            signupLabel.Location = new Point(421, 620);
            signupLabel.Margin = new Padding(4, 0, 4, 0);
            signupLabel.Name = "signupLabel";
            signupLabel.Size = new Size(98, 32);
            signupLabel.TabIndex = 3;
            signupLabel.TabStop = true;
            signupLabel.Text = "Sign Up";
            signupLabel.LinkClicked += signupLabel_LinkClicked;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(149, 620);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(266, 32);
            label4.TabIndex = 9;
            label4.Text = "Don't have an account?";
            // 
            // signinButton
            // 
            signinButton.BackColor = Color.Black;
            signinButton.FlatStyle = FlatStyle.Flat;
            signinButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signinButton.ForeColor = SystemColors.ButtonHighlight;
            signinButton.Location = new Point(144, 408);
            signinButton.Margin = new Padding(4, 5, 4, 5);
            signinButton.Name = "signinButton";
            signinButton.Size = new Size(374, 55);
            signinButton.TabIndex = 2;
            signinButton.Text = "Sign In";
            signinButton.UseVisualStyleBackColor = false;
            signinButton.Click += signinButton_Click;
            signinButton.KeyPress += signinButton_KeyPress;
            // 
            // passwordTextBox
            // 
            passwordTextBox.BackColor = SystemColors.ScrollBar;
            passwordTextBox.BorderStyle = BorderStyle.FixedSingle;
            passwordTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordTextBox.ForeColor = Color.Gray;
            passwordTextBox.Location = new Point(146, 307);
            passwordTextBox.Margin = new Padding(4, 5, 4, 5);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(373, 39);
            passwordTextBox.TabIndex = 1;
            passwordTextBox.Text = "Enter your password";
            passwordTextBox.Enter += passwordTextBox_Enter;
            passwordTextBox.KeyPress += passwordTextBox_KeyPress;
            passwordTextBox.Leave += passwordTextBox_Leave;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(137, 267);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(121, 32);
            label3.TabIndex = 5;
            label3.Text = "Password:";
            // 
            // emailTextBox
            // 
            emailTextBox.BackColor = SystemColors.ScrollBar;
            emailTextBox.BorderStyle = BorderStyle.FixedSingle;
            emailTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailTextBox.ForeColor = Color.Gray;
            emailTextBox.Location = new Point(146, 185);
            emailTextBox.Margin = new Padding(4, 5, 4, 5);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(373, 39);
            emailTextBox.TabIndex = 0;
            emailTextBox.Text = "Enter your email";
            emailTextBox.Enter += emailTextBox_Enter;
            emailTextBox.KeyPress += emailTextBox_KeyPress;
            emailTextBox.Leave += emailTextBox_Leave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(137, 145);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(78, 32);
            label2.TabIndex = 3;
            label2.Text = "Email:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(170, 57);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(297, 55);
            label1.TabIndex = 1;
            label1.Text = "Welcome Back!";
            // 
            // JG_loginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(124, 172, 175);
            ClientSize = new Size(1406, 935);
            Controls.Add(panel1);
            Margin = new Padding(4, 5, 4, 5);
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