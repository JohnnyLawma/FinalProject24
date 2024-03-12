namespace FinalProject24
{
    partial class MyCartUserControl1
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
            components = new System.ComponentModel.Container();
            flowLayoutPanel1 = new FlowLayoutPanel();
            cartItemUserControl1 = new CartItemUserControl();
            cartItemUserControl2 = new CartItemUserControl();
            cartItemUserControl3 = new CartItemUserControl();
            cartItemUserControl4 = new CartItemUserControl();
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            button1 = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            toolTip1 = new ToolTip(components);
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(cartItemUserControl1);
            flowLayoutPanel1.Controls.Add(cartItemUserControl2);
            flowLayoutPanel1.Controls.Add(cartItemUserControl3);
            flowLayoutPanel1.Controls.Add(cartItemUserControl4);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(57, 133);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(515, 380);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // cartItemUserControl1
            // 
            cartItemUserControl1.BorderStyle = BorderStyle.FixedSingle;
            cartItemUserControl1.Location = new Point(3, 10);
            cartItemUserControl1.Margin = new Padding(3, 10, 3, 3);
            cartItemUserControl1.Name = "cartItemUserControl1";
            cartItemUserControl1.Size = new Size(509, 111);
            cartItemUserControl1.TabIndex = 0;
            // 
            // cartItemUserControl2
            // 
            cartItemUserControl2.BorderStyle = BorderStyle.FixedSingle;
            cartItemUserControl2.Location = new Point(3, 134);
            cartItemUserControl2.Margin = new Padding(3, 10, 3, 3);
            cartItemUserControl2.Name = "cartItemUserControl2";
            cartItemUserControl2.Size = new Size(509, 111);
            cartItemUserControl2.TabIndex = 1;
            // 
            // cartItemUserControl3
            // 
            cartItemUserControl3.BorderStyle = BorderStyle.FixedSingle;
            cartItemUserControl3.Location = new Point(3, 258);
            cartItemUserControl3.Margin = new Padding(3, 10, 3, 3);
            cartItemUserControl3.Name = "cartItemUserControl3";
            cartItemUserControl3.Size = new Size(509, 111);
            cartItemUserControl3.TabIndex = 2;
            // 
            // cartItemUserControl4
            // 
            cartItemUserControl4.BorderStyle = BorderStyle.FixedSingle;
            cartItemUserControl4.Location = new Point(518, 10);
            cartItemUserControl4.Margin = new Padding(3, 10, 3, 3);
            cartItemUserControl4.Name = "cartItemUserControl4";
            cartItemUserControl4.Size = new Size(509, 111);
            cartItemUserControl4.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(57, 45);
            label1.Name = "label1";
            label1.Size = new Size(52, 21);
            label1.TabIndex = 1;
            label1.Text = "Home";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(53, 76);
            label2.Name = "label2";
            label2.Size = new Size(120, 37);
            label2.TabIndex = 2;
            label2.Text = "My Cart";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ScrollBar;
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(632, 143);
            panel1.Name = "panel1";
            panel1.Size = new Size(249, 206);
            panel1.TabIndex = 3;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label9.Location = new Point(163, 106);
            label9.Name = "label9";
            label9.Size = new Size(45, 15);
            label9.TabIndex = 7;
            label9.Text = "$10.90";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.Location = new Point(163, 82);
            label8.Name = "label8";
            label8.Size = new Size(38, 15);
            label8.TabIndex = 6;
            label8.Text = "$2.50";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(163, 56);
            label7.Name = "label7";
            label7.Size = new Size(14, 15);
            label7.TabIndex = 5;
            label7.Text = "3";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Window;
            button1.FlatAppearance.BorderSize = 0;
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(18, 142);
            button1.Name = "button1";
            button1.Size = new Size(215, 49);
            button1.TabIndex = 4;
            button1.Text = "Buy Now";
            button1.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F);
            label6.Location = new Point(19, 104);
            label6.Name = "label6";
            label6.Size = new Size(59, 17);
            label6.TabIndex = 3;
            label6.Text = "Subtotal:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F);
            label5.Location = new Point(19, 80);
            label5.Name = "label5";
            label5.Size = new Size(30, 17);
            label5.TabIndex = 2;
            label5.Text = "Tax:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F);
            label4.Location = new Point(19, 54);
            label4.Name = "label4";
            label4.Size = new Size(68, 17);
            label4.TabIndex = 1;
            label4.Text = "Total Item:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(19, 21);
            label3.Name = "label3";
            label3.Size = new Size(131, 21);
            label3.TabIndex = 0;
            label3.Text = "Summary Order";
            // 
            // toolTip1
            // 
            toolTip1.ForeColor = SystemColors.Desktop;
            // 
            // MyCartUserControl1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(flowLayoutPanel1);
            Name = "MyCartUserControl1";
            Size = new Size(900, 600);
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private Label label2;
        private CartItemUserControl cartItemUserControl1;
        private CartItemUserControl cartItemUserControl2;
        private CartItemUserControl cartItemUserControl3;
        private CartItemUserControl cartItemUserControl4;
        private Panel panel1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button button1;
        private Label label9;
        private Label label8;
        private Label label7;
        private ToolTip toolTip1;
    }
}
