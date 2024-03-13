namespace NF0203TH
{
    partial class Bank
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
            button1 = new Button();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            button5 = new Button();
            textBox1 = new TextBox();
            label4 = new Label();
            button4 = new Button();
            panel2 = new Panel();
            button6 = new Button();
            textBox2 = new TextBox();
            label5 = new Label();
            listBox1 = new ListBox();
            pictureBox2 = new PictureBox();
            label6 = new Label();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe Print", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(12, 102);
            button1.Name = "button1";
            button1.Size = new Size(143, 46);
            button1.TabIndex = 0;
            button1.Text = "Deposit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe Print", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(161, 102);
            button2.Name = "button2";
            button2.Size = new Size(143, 46);
            button2.TabIndex = 1;
            button2.Text = "Withdraw";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.SizeNESW;
            pictureBox1.Image = Properties.Resources._312_3120045_png_gyari_astolfo;
            pictureBox1.Location = new Point(569, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(65, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(640, 28);
            label1.Name = "label1";
            label1.Size = new Size(113, 35);
            label1.TabIndex = 3;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(42, 176);
            label2.Name = "label2";
            label2.Size = new Size(107, 35);
            label2.TabIndex = 4;
            label2.Text = "Balance :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(42, 228);
            label3.Name = "label3";
            label3.Size = new Size(109, 35);
            label3.TabIndex = 5;
            label3.Text = "\"Balance\"";
            // 
            // panel1
            // 
            panel1.Controls.Add(button5);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(42, 176);
            panel1.Name = "panel1";
            panel1.Size = new Size(448, 125);
            panel1.TabIndex = 7;
            panel1.Visible = false;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(40, 80);
            button5.Name = "button5";
            button5.Size = new Size(143, 40);
            button5.TabIndex = 10;
            button5.Text = "Deposit";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 47);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(201, 27);
            textBox1.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe Print", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 14);
            label4.Name = "label4";
            label4.Size = new Size(221, 30);
            label4.TabIndex = 8;
            label4.Text = "Input Deposit Ammount";
            // 
            // button4
            // 
            button4.Font = new Font("Segoe Print", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(710, 407);
            button4.Name = "button4";
            button4.Size = new Size(78, 31);
            button4.TabIndex = 9;
            button4.Text = "Log Out";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(button6);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(42, 313);
            panel2.Name = "panel2";
            panel2.Size = new Size(448, 125);
            panel2.TabIndex = 10;
            panel2.Visible = false;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.Location = new Point(40, 80);
            button6.Name = "button6";
            button6.Size = new Size(143, 40);
            button6.TabIndex = 10;
            button6.Text = "Withdraw";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 47);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(201, 27);
            textBox2.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe Print", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(3, 14);
            label5.Name = "label5";
            label5.Size = new Size(244, 30);
            label5.TabIndex = 8;
            label5.Text = "Input Withdraw Ammount";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(569, 97);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(214, 284);
            listBox1.TabIndex = 11;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.LOGO_UC_PANJANG_FIX_SEP_2021_01;
            pictureBox2.Location = new Point(24, 14);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(78, 70);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe Print", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(108, 25);
            label6.Name = "label6";
            label6.Size = new Size(178, 61);
            label6.TabIndex = 13;
            label6.Text = "UC Bank";
            // 
            // button3
            // 
            button3.Font = new Font("Segoe Print", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(310, 102);
            button3.Name = "button3";
            button3.Size = new Size(143, 46);
            button3.TabIndex = 6;
            button3.Text = "Convert";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Bank
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(pictureBox2);
            Controls.Add(listBox1);
            Controls.Add(panel2);
            Controls.Add(button4);
            Controls.Add(panel1);
            Controls.Add(button3);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Bank";
            Text = "Bank";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Panel panel1;
        private TextBox textBox1;
        private Label label4;
        private Button button4;
        private Button button5;
        private Panel panel2;
        private Button button6;
        private TextBox textBox2;
        private Label label5;
        private ListBox listBox1;
        private PictureBox pictureBox2;
        private Label label6;
        private Button button3;
    }
}