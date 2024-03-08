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
            managerRadioButton.Location = new Point(312, 284);
            managerRadioButton.Name = "managerRadioButton";
            managerRadioButton.Size = new Size(72, 19);
            managerRadioButton.TabIndex = 40;
            managerRadioButton.TabStop = true;
            managerRadioButton.Text = "Manager";
            managerRadioButton.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(18, 282);
            label7.Name = "label7";
            label7.Size = new Size(196, 21);
            label7.TabIndex = 39;
            label7.Text = "What type of user are you?";
            // 
            // customerRadioButton
            // 
            customerRadioButton.AutoSize = true;
            customerRadioButton.Location = new Point(229, 284);
            customerRadioButton.Name = "customerRadioButton";
            customerRadioButton.Size = new Size(77, 19);
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
            nameTextBox.Location = new Point(147, 100);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(262, 29);
            nameTextBox.TabIndex = 37;
            nameTextBox.Text = "Enter your name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(69, 102);
            label6.Name = "label6";
            label6.Size = new Size(55, 21);
            label6.TabIndex = 36;
            label6.Text = "Name:";
            // 
            // confirmPasswordTextBox
            // 
            confirmPasswordTextBox.BackColor = SystemColors.ScrollBar;
            confirmPasswordTextBox.BorderStyle = BorderStyle.FixedSingle;
            confirmPasswordTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            confirmPasswordTextBox.Location = new Point(147, 240);
            confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            confirmPasswordTextBox.Size = new Size(262, 29);
            confirmPasswordTextBox.TabIndex = 35;
            confirmPasswordTextBox.Text = "Confirm your password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(10, 242);
            label5.Name = "label5";
            label5.Size = new Size(131, 21);
            label5.TabIndex = 34;
            label5.Text = "Retype Password:";
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Font = new Font("Segoe UI", 12F);
            loginLabel.Location = new Point(276, 359);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(53, 21);
            loginLabel.TabIndex = 33;
            loginLabel.TabStop = true;
            loginLabel.Text = "Log In";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(84, 359);
            label4.Name = "label4";
            label4.Size = new Size(186, 21);
            label4.TabIndex = 32;
            label4.Text = "Already have an account?";
            // 
            // createAccountButton
            // 
            createAccountButton.BackColor = Color.Black;
            createAccountButton.FlatStyle = FlatStyle.Flat;
            createAccountButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createAccountButton.ForeColor = SystemColors.ButtonHighlight;
            createAccountButton.Location = new Point(98, 310);
            createAccountButton.Name = "createAccountButton";
            createAccountButton.Size = new Size(262, 33);
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
            passwordTextBox.Location = new Point(147, 194);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(262, 29);
            passwordTextBox.TabIndex = 30;
            passwordTextBox.Text = "Enter your password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(41, 196);
            label3.Name = "label3";
            label3.Size = new Size(79, 21);
            label3.TabIndex = 29;
            label3.Text = "Password:";
            // 
            // emailTextBox
            // 
            emailTextBox.BackColor = SystemColors.ScrollBar;
            emailTextBox.BorderStyle = BorderStyle.FixedSingle;
            emailTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailTextBox.Location = new Point(147, 148);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(262, 29);
            emailTextBox.TabIndex = 28;
            emailTextBox.Text = "Enter your email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(69, 150);
            label2.Name = "label2";
            label2.Size = new Size(51, 21);
            label2.TabIndex = 27;
            label2.Text = "Email:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(112, 48);
            label1.Name = "label1";
            label1.Size = new Size(229, 37);
            label1.TabIndex = 26;
            label1.Text = "Make an Account!";
            // 
            // JG_signUpPageUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
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
            Name = "JG_signUpPageUserControl";
            Size = new Size(450, 430);
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
