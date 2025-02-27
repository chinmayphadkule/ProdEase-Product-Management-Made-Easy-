namespace ProductDemo
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
            button1 = new Button();
            groupBox1 = new GroupBox();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            groupBox2 = new GroupBox();
            label2 = new Label();
            button3 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            groupBox3 = new GroupBox();
            button4 = new Button();
            textBox2 = new TextBox();
            label4 = new Label();
            groupBox4 = new GroupBox();
            textBox6 = new TextBox();
            button5 = new Button();
            label7 = new Label();
            textBox5 = new TextBox();
            label6 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            groupBox5 = new GroupBox();
            textBox7 = new TextBox();
            button6 = new Button();
            label8 = new Label();
            textBox8 = new TextBox();
            label9 = new Label();
            textBox9 = new TextBox();
            label10 = new Label();
            button7 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 0, 192);
            button1.Location = new Point(55, 31);
            button1.Name = "button1";
            button1.Size = new Size(165, 50);
            button1.TabIndex = 0;
            button1.Text = "Load Data";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(55, 117);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(498, 374);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Show Data";
            // 
            // button2
            // 
            button2.BackColor = Color.Chocolate;
            button2.Location = new Point(161, 322);
            button2.Name = "button2";
            button2.Size = new Size(134, 40);
            button2.TabIndex = 1;
            button2.Text = "Show Data";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(25, 42);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(434, 258);
            dataGridView1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(628, 65);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(321, 155);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Product Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(132, 98);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 3;
            // 
            // button3
            // 
            button3.BackColor = Color.Yellow;
            button3.Location = new Point(17, 96);
            button3.Name = "button3";
            button3.Size = new Size(109, 36);
            button3.TabIndex = 2;
            button3.Text = "Get Name";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(125, 40);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 43);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 0;
            label1.Text = "Enter pid";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button4);
            groupBox3.Controls.Add(textBox2);
            groupBox3.Controls.Add(label4);
            groupBox3.Location = new Point(1021, 65);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(314, 155);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Delete Product";
            // 
            // button4
            // 
            button4.BackColor = Color.Yellow;
            button4.Location = new Point(44, 95);
            button4.Name = "button4";
            button4.Size = new Size(122, 37);
            button4.TabIndex = 6;
            button4.Text = "Delete Product";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(149, 38);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 38);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 4;
            label4.Text = "Enter pid";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(textBox6);
            groupBox4.Controls.Add(button5);
            groupBox4.Controls.Add(label7);
            groupBox4.Controls.Add(textBox5);
            groupBox4.Controls.Add(label6);
            groupBox4.Controls.Add(textBox4);
            groupBox4.Controls.Add(label5);
            groupBox4.Controls.Add(textBox3);
            groupBox4.Controls.Add(label3);
            groupBox4.Location = new Point(632, 252);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(317, 275);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            groupBox4.Text = "Update Product";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(121, 155);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(125, 27);
            textBox6.TabIndex = 11;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(255, 255, 128);
            button5.Location = new Point(19, 216);
            button5.Name = "button5";
            button5.Size = new Size(126, 36);
            button5.TabIndex = 10;
            button5.Text = "Update Product";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(13, 158);
            label7.Name = "label7";
            label7.Size = new Size(85, 20);
            label7.TabIndex = 8;
            label7.Text = "Description";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(121, 116);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 27);
            textBox5.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 119);
            label6.Name = "label6";
            label6.Size = new Size(79, 20);
            label6.TabIndex = 6;
            label6.Text = "Enter Price";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(121, 76);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 79);
            label5.Name = "label5";
            label5.Size = new Size(87, 20);
            label5.TabIndex = 4;
            label5.Text = "Enter Name";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(121, 38);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 3;
            textBox3.Leave += textBox3_Leave;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 41);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 2;
            label3.Text = "Enter pid";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(textBox7);
            groupBox5.Controls.Add(button6);
            groupBox5.Controls.Add(label8);
            groupBox5.Controls.Add(textBox8);
            groupBox5.Controls.Add(label9);
            groupBox5.Controls.Add(textBox9);
            groupBox5.Controls.Add(label10);
            groupBox5.Location = new Point(1021, 252);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(314, 275);
            groupBox5.TabIndex = 5;
            groupBox5.TabStop = false;
            groupBox5.Text = "Add Product";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(121, 155);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(125, 27);
            textBox7.TabIndex = 11;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(255, 255, 128);
            button6.Location = new Point(19, 216);
            button6.Name = "button6";
            button6.Size = new Size(126, 36);
            button6.TabIndex = 10;
            button6.Text = "Add Product";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(13, 158);
            label8.Name = "label8";
            label8.Size = new Size(85, 20);
            label8.TabIndex = 8;
            label8.Text = "Description";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(121, 116);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(125, 27);
            textBox8.TabIndex = 7;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(13, 119);
            label9.Name = "label9";
            label9.Size = new Size(79, 20);
            label9.TabIndex = 6;
            label9.Text = "Enter Price";
            // 
            // textBox9
            // 
            textBox9.Location = new Point(121, 76);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(125, 27);
            textBox9.TabIndex = 5;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(13, 79);
            label10.Name = "label10";
            label10.Size = new Size(87, 20);
            label10.TabIndex = 4;
            label10.Text = "Enter Name";
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(255, 128, 0);
            button7.Location = new Point(352, 31);
            button7.Name = "button7";
            button7.Size = new Size(162, 50);
            button7.TabIndex = 6;
            button7.Text = "UPDATE Changes";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(1409, 539);
            Controls.Add(button7);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private GroupBox groupBox1;
        private Button button2;
        private DataGridView dataGridView1;
        private GroupBox groupBox2;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Button button3;
        private GroupBox groupBox3;
        private Button button4;
        private TextBox textBox2;
        private Label label4;
        private GroupBox groupBox4;
        private TextBox textBox3;
        private Label label3;
        private Button button5;
        private Label label7;
        private TextBox textBox5;
        private Label label6;
        private TextBox textBox4;
        private Label label5;
        private TextBox textBox6;
        private GroupBox groupBox5;
        private TextBox textBox7;
        private Button button6;
        private Label label8;
        private TextBox textBox8;
        private Label label9;
        private TextBox textBox9;
        private Label label10;
        private Button button7;
    }
}
