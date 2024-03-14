namespace FinalProject24
{
    partial class JG_signUpPageUserControl
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
            managerRadioButton = new RadioButton();
            label7 = new Label();
            customerRadioButton = new RadioButton();
            nameTextBox = new TextBox();
            label6 = new Label();
            confirmPasswordTextBox = new TextBox();
            label5 = new Label();
            loginLabel = new LinkLabel();
            label4 = new Label();
            createAccountButton = new Button();
            passwordTextBox = new TextBox();
            label3 = new Label();
            emailTextBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // managerRadioButton
            // 
            managerRadioButton.AutoSize = true;
            managerRadioButton.Location = new Point(392, 685);
            managerRadioButton.Margin = new Padding(6);
            managerRadioButton.Name = "managerRadioButton";
            managerRadioButton.Size = new Size(140, 36);
            managerRadioButton.TabIndex = 40;
            managerRadioButton.TabStop = true;
            managerRadioButton.Text = "Manager";
            managerRadioButton.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(164, 634);
            label7.Margin = new Padding(6, 0, 6, 0);
            label7.Name = "label7";
            label7.Size = new Size(413, 45);
            label7.TabIndex = 39;
            label7.Text = "What type of user are you?";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // customerRadioButton
            // 
            customerRadioButton.AutoSize = true;
            customerRadioButton.Location = new Point(176, 685);
            customerRadioButton.Margin = new Padding(6);
            customerRadioButton.Name = "customerRadioButton";
            customerRadioButton.Size = new Size(148, 36);
            customerRadioButton.TabIndex = 38;
            customerRadioButton.TabStop = true;
            customerRadioButton.Text = "Customer";
            customerRadioButton.UseVisualStyleBackColor = true;
            // 
            // nameTextBox
            // 
            nameTextBox.BackColor = SystemColors.ScrollBar;
            nameTextBox.BorderStyle = BorderStyle.FixedSingle;
            nameTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameTextBox.Location = new Point(176, 168);
            nameTextBox.Margin = new Padding(6);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(485, 50);
            nameTextBox.TabIndex = 37;
            nameTextBox.Text = "Enter your name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(165, 117);
            label6.Margin = new Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new Size(115, 45);
            label6.TabIndex = 36;
            label6.Text = "Name:";
            // 
            // confirmPasswordTextBox
            // 
            confirmPasswordTextBox.BackColor = SystemColors.ScrollBar;
            confirmPasswordTextBox.BorderStyle = BorderStyle.FixedSingle;
            confirmPasswordTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            confirmPasswordTextBox.Location = new Point(176, 556);
            confirmPasswordTextBox.Margin = new Padding(6);
            confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            confirmPasswordTextBox.Size = new Size(485, 50);
            confirmPasswordTextBox.TabIndex = 35;
            confirmPasswordTextBox.Text = "Confirm your password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(165, 496);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(274, 45);
            label5.TabIndex = 34;
            label5.Text = "Retype Password:";
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Font = new Font("Segoe UI", 12F);
            loginLabel.Location = new Point(552, 838);
            loginLabel.Margin = new Padding(6, 0, 6, 0);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(109, 45);
            loginLabel.TabIndex = 33;
            loginLabel.TabStop = true;
            loginLabel.Text = "Log In";
            loginLabel.LinkClicked += loginLabel_LinkClicked;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(160, 838);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(380, 45);
            label4.TabIndex = 32;
            label4.Text = "Already have an account?";
            // 
            // createAccountButton
            // 
            createAccountButton.BackColor = Color.Black;
            createAccountButton.FlatStyle = FlatStyle.Flat;
            createAccountButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createAccountButton.ForeColor = SystemColors.ButtonHighlight;
            createAccountButton.Location = new Point(174, 742);
            createAccountButton.Margin = new Padding(6);
            createAccountButton.Name = "createAccountButton";
            createAccountButton.Size = new Size(487, 70);
            createAccountButton.TabIndex = 31;
            createAccountButton.Text = "Create Account";
            createAccountButton.UseVisualStyleBackColor = false;
            createAccountButton.Click += createAccountButton_Click;
            // 
            // passwordTextBox
            // 
            passwordTextBox.BackColor = SystemColors.ScrollBar;
            passwordTextBox.BorderStyle = BorderStyle.FixedSingle;
            passwordTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordTextBox.Location = new Point(176, 421);
            passwordTextBox.Margin = new Padding(6);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(485, 50);
            passwordTextBox.TabIndex = 30;
            passwordTextBox.Text = "Enter your password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(165, 370);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(165, 45);
            label3.TabIndex = 29;
            label3.Text = "Password:";
            // 
            // emailTextBox
            // 
            emailTextBox.BackColor = SystemColors.ScrollBar;
            emailTextBox.BorderStyle = BorderStyle.FixedSingle;
            emailTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailTextBox.Location = new Point(176, 288);
            emailTextBox.Margin = new Padding(6);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(485, 50);
            emailTextBox.TabIndex = 28;
            emailTextBox.Text = "Enter your email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(165, 237);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(106, 45);
            label2.TabIndex = 27;
            label2.Text = "Email:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(187, 32);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(460, 72);
            label1.TabIndex = 26;
            label1.Text = "Make an Account!";
            // 
            // JG_signUpPageUserControl
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            Controls.Add(managerRadioButton);
            Controls.Add(label7);
            Controls.Add(customerRadioButton);
            Controls.Add(nameTextBox);
            Controls.Add(label6);
            Controls.Add(confirmPasswordTextBox);
            Controls.Add(label5);
            Controls.Add(loginLabel);
            Controls.Add(label4);
            Controls.Add(createAccountButton);
            Controls.Add(passwordTextBox);
            Controls.Add(label3);
            Controls.Add(emailTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(6);
            Name = "JG_signUpPageUserControl";
            Size = new Size(836, 917);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton managerRadioButton;
        private Label label7;
        private RadioButton customerRadioButton;
        private TextBox nameTextBox;
        private Label label6;
        private TextBox confirmPasswordTextBox;
        private Label label5;
        private LinkLabel loginLabel;
        private Label label4;
        private Button createAccountButton;
        private TextBox passwordTextBox;
        private Label label3;
        private TextBox emailTextBox;
        private Label label2;
        private Label label1;
    }
}
