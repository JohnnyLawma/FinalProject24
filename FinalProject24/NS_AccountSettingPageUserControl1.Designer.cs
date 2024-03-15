namespace FinalProject24
{
    partial class NS_AccountSettingPageUserControl1
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

        //#region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            NametextBox = new TextBox();
            EmailtextBox = new TextBox();
            PhonetextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            Applybutton = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // NametextBox
            // 
            NametextBox.Location = new Point(606, 216);
            NametextBox.Margin = new Padding(4);
            NametextBox.Multiline = true;
            NametextBox.Name = "NametextBox";
            NametextBox.Size = new Size(370, 59);
            NametextBox.TabIndex = 1;
            NametextBox.Text = "FirstName LastName";
            // 
            // EmailtextBox
            // 
            EmailtextBox.Location = new Point(606, 349);
            EmailtextBox.Margin = new Padding(4);
            EmailtextBox.Multiline = true;
            EmailtextBox.Name = "EmailtextBox";
            EmailtextBox.Size = new Size(370, 55);
            EmailtextBox.TabIndex = 2;
            EmailtextBox.Text = "Email@email.com";
            // 
            // PhonetextBox
            // 
            PhonetextBox.Location = new Point(606, 477);
            PhonetextBox.Margin = new Padding(4);
            PhonetextBox.Multiline = true;
            PhonetextBox.Name = "PhonetextBox";
            PhonetextBox.Size = new Size(370, 60);
            PhonetextBox.TabIndex = 3;
            PhonetextBox.Text = "1234567890";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(606, 100);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(273, 45);
            label1.TabIndex = 4;
            label1.Text = "Account Settings";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(606, 180);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(79, 32);
            label2.TabIndex = 5;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(606, 313);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(165, 32);
            label3.TabIndex = 6;
            label3.Text = "Email Address";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(606, 436);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(203, 37);
            label4.TabIndex = 7;
            label4.Text = "Phone Number";
            // 
            // Applybutton
            // 
            Applybutton.BackColor = SystemColors.ActiveCaptionText;
            Applybutton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Applybutton.ForeColor = SystemColors.ControlLightLight;
            Applybutton.Location = new Point(657, 580);
            Applybutton.Margin = new Padding(4);
            Applybutton.Name = "Applybutton";
            Applybutton.Size = new Size(240, 65);
            Applybutton.TabIndex = 8;
            Applybutton.Text = "Apply Changes";
            Applybutton.UseVisualStyleBackColor = false;
            Applybutton.Click += Applybutton_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Control;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(586, 662);
            textBox1.Margin = new Padding(4);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(441, 119);
            textBox1.TabIndex = 9;
            textBox1.Text = "To modify your personal information: click on any of the corresponding textboxes, edit, and click apply changes.";
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // NS_AccountSettingPageUserControl1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(textBox1);
            Controls.Add(Applybutton);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(PhonetextBox);
            Controls.Add(EmailtextBox);
            Controls.Add(NametextBox);
            Margin = new Padding(5, 6, 5, 6);
            Name = "NS_AccountSettingPageUserControl1";
            Size = new Size(1638, 1053);
            ResumeLayout(false);
            PerformLayout();
        }

        // #endregion

        private TextBox NametextBox;
        private TextBox EmailtextBox;
        private TextBox PhonetextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button Applybutton;
        private TextBox textBox1;
    }
}
