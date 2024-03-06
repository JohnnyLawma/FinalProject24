namespace FinalProject24
{
    partial class ProductDetailUserControl1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductDetailUserControl1));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox5 = new CheckBox();
            checkBox6 = new CheckBox();
            button1 = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            groupBox1 = new GroupBox();
            button2 = new Button();
            button3 = new Button();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(110, 69);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(416, 277);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(551, 53);
            label1.Name = "label1";
            label1.Size = new Size(202, 37);
            label1.TabIndex = 12;
            label1.Text = "Product Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.25F, FontStyle.Bold);
            label2.Location = new Point(551, 161);
            label2.Name = "label2";
            label2.Size = new Size(127, 30);
            label2.TabIndex = 13;
            label2.Text = "Spice Level";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.25F, FontStyle.Bold);
            label3.Location = new Point(551, 341);
            label3.Name = "label3";
            label3.Size = new Size(197, 30);
            label3.TabIndex = 14;
            label3.Text = "Extra Condiments";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 11.25F);
            checkBox1.Location = new Point(556, 210);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(83, 24);
            checkBox1.TabIndex = 15;
            checkBox1.Text = "Medium";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Segoe UI", 11.25F);
            checkBox2.Location = new Point(556, 247);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(53, 24);
            checkBox2.TabIndex = 16;
            checkBox2.Text = "Hot";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += this.checkBox2_CheckedChanged;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Font = new Font("Segoe UI", 11.25F);
            checkBox3.Location = new Point(556, 289);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(111, 24);
            checkBox3.TabIndex = 17;
            checkBox3.Text = "Extreme Hot";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += this.checkBox3_CheckedChanged;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Font = new Font("Segoe UI", 11.25F);
            checkBox4.Location = new Point(556, 383);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(71, 24);
            checkBox4.TabIndex = 18;
            checkBox4.Text = "Honey";
            checkBox4.UseVisualStyleBackColor = true;
            checkBox4.CheckedChanged += this.checkBox4_CheckedChanged;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Font = new Font("Segoe UI", 11.25F);
            checkBox5.Location = new Point(556, 422);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(129, 24);
            checkBox5.TabIndex = 19;
            checkBox5.Text = "Honey Mustard";
            checkBox5.UseVisualStyleBackColor = true;
            checkBox5.CheckedChanged += this.checkBox5_CheckedChanged;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Font = new Font("Segoe UI", 11.25F);
            checkBox6.Location = new Point(556, 463);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(95, 24);
            checkBox6.TabIndex = 20;
            checkBox6.Text = "Hot Sause";
            checkBox6.UseVisualStyleBackColor = true;
            checkBox6.CheckedChanged += this.checkBox6_CheckedChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(551, 530);
            button1.Name = "button1";
            button1.Size = new Size(319, 41);
            button1.TabIndex = 21;
            button1.Text = "Add To Card";
            button1.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(558, 96);
            label4.Name = "label4";
            label4.Size = new Size(56, 25);
            label4.TabIndex = 22;
            label4.Text = "$6.99";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(105, 369);
            label5.Name = "label5";
            label5.Size = new Size(108, 25);
            label5.TabIndex = 23;
            label5.Text = "Description";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(4, 10);
            label6.Name = "label6";
            label6.Size = new Size(406, 80);
            label6.TabIndex = 24;
            label6.Text = resources.GetString("label6.Text");
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Location = new Point(110, 397);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(416, 117);
            groupBox1.TabIndex = 25;
            groupBox1.TabStop = false;
            // 
            // button2
            // 
            button2.Location = new Point(599, 501);
            button2.Name = "button2";
            button2.Size = new Size(28, 23);
            button2.TabIndex = 26;
            button2.Text = "+";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(553, 501);
            button3.Name = "button3";
            button3.Size = new Size(29, 23);
            button3.TabIndex = 27;
            button3.Text = "-";
            button3.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.ControlLight;
            label7.Location = new Point(581, 505);
            label7.Name = "label7";
            label7.Size = new Size(19, 15);
            label7.TabIndex = 28;
            label7.Text = "11";
            // 
            // ProductDetailUserControl1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label7);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(checkBox6);
            Controls.Add(checkBox5);
            Controls.Add(checkBox4);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            Name = "ProductDetailUserControl1";
            Size = new Size(900, 600);
            Load += this.ProductDetailUserControl1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private CheckBox checkBox5;
        private CheckBox checkBox6;
        private Button button1;
        private Label label4;
        private Label label5;
        private Label label6;
        private GroupBox groupBox1;
        private Button button2;
        private Button button3;
        private Label label7;
    }
}
