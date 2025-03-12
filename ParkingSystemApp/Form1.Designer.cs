namespace ParkingSystemApp
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
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            panel10 = new Panel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            panel9 = new Panel();
            btnQuanLyBaiXe = new Button();
            btnThongKe = new Button();
            button5 = new Button();
            panel8 = new Panel();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            panel7 = new Panel();
            comboBox2 = new ComboBox();
            label6 = new Label();
            panel6 = new Panel();
            comboBox1 = new ComboBox();
            label5 = new Label();
            panel5 = new Panel();
            textBox3 = new TextBox();
            label4 = new Label();
            panel4 = new Panel();
            textBox2 = new TextBox();
            label3 = new Label();
            panel3 = new Panel();
            textBox1 = new TextBox();
            label2 = new Label();
            panel2 = new Panel();
            txbMaNhanVien = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel10.SuspendLayout();
            panel9.SuspendLayout();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(panel10);
            panel1.Controls.Add(panel9);
            panel1.Controls.Add(panel8);
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(772, 430);
            panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(241, 280);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(470, 146);
            dataGridView1.TabIndex = 14;
            // 
            // panel10
            // 
            panel10.Controls.Add(button1);
            panel10.Controls.Add(button2);
            panel10.Controls.Add(button3);
            panel10.Location = new Point(241, 233);
            panel10.Name = "panel10";
            panel10.Size = new Size(470, 42);
            panel10.TabIndex = 13;
            // 
            // button1
            // 
            button1.Location = new Point(3, 4);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(156, 4);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 7;
            button2.Text = "Sửa";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(317, 4);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 8;
            button3.Text = "Xóa";
            button3.UseVisualStyleBackColor = true;
            // 
            // panel9
            // 
            panel9.Controls.Add(btnQuanLyBaiXe);
            panel9.Controls.Add(btnThongKe);
            panel9.Controls.Add(button5);
            panel9.Location = new Point(238, 3);
            panel9.Name = "panel9";
            panel9.Size = new Size(473, 49);
            panel9.TabIndex = 12;
            // 
            // btnQuanLyBaiXe
            // 
            btnQuanLyBaiXe.Location = new Point(3, 14);
            btnQuanLyBaiXe.Name = "btnQuanLyBaiXe";
            btnQuanLyBaiXe.Size = new Size(111, 23);
            btnQuanLyBaiXe.TabIndex = 9;
            btnQuanLyBaiXe.Text = "Quản Lý Bãi Xe";
            btnQuanLyBaiXe.UseVisualStyleBackColor = true;
            btnQuanLyBaiXe.Click += btnQuanLyBaiXe_Click;
            // 
            // btnThongKe
            // 
            btnThongKe.Location = new Point(320, 14);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Size = new Size(75, 23);
            btnThongKe.TabIndex = 11;
            btnThongKe.Text = "Thống Kê";
            btnThongKe.UseVisualStyleBackColor = true;
            btnThongKe.Click += btnThongKe_Click;
            // 
            // button5
            // 
            button5.Location = new Point(159, 14);
            button5.Name = "button5";
            button5.Size = new Size(118, 23);
            button5.TabIndex = 10;
            button5.Text = "Quản Lý Nhân Viên";
            button5.UseVisualStyleBackColor = true;
            // 
            // panel8
            // 
            panel8.Controls.Add(label9);
            panel8.Controls.Add(label8);
            panel8.Controls.Add(label7);
            panel8.Location = new Point(3, 286);
            panel8.Name = "panel8";
            panel8.Size = new Size(172, 140);
            panel8.TabIndex = 5;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.HotTrack;
            label9.Location = new Point(7, 103);
            label9.Name = "label9";
            label9.Size = new Size(157, 18);
            label9.TabIndex = 8;
            label9.Text = "Ca 3: Từ 17:30 - 23:00";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.HotTrack;
            label8.Location = new Point(7, 59);
            label8.Name = "label8";
            label8.Size = new Size(157, 18);
            label8.TabIndex = 7;
            label8.Text = "Ca 2: Từ 12:00 - 17:30";
            label8.Click += label8_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.HotTrack;
            label7.Location = new Point(9, 20);
            label7.Name = "label7";
            label7.Size = new Size(149, 18);
            label7.TabIndex = 6;
            label7.Text = "Ca 1: Từ 6:00 - 12:00";
            // 
            // panel7
            // 
            panel7.Controls.Add(comboBox2);
            panel7.Controls.Add(label6);
            panel7.Location = new Point(397, 193);
            panel7.Name = "panel7";
            panel7.Size = new Size(304, 34);
            panel7.TabIndex = 2;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Ca 1", "Ca 2", "Ca 3" });
            comboBox2.Location = new Point(123, 4);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(178, 23);
            comboBox2.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 9);
            label6.Name = "label6";
            label6.Size = new Size(94, 18);
            label6.TabIndex = 1;
            label6.Text = "Ca Làm Việc";
            label6.Click += label6_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(comboBox1);
            panel6.Controls.Add(label5);
            panel6.Location = new Point(397, 142);
            panel6.Name = "panel6";
            panel6.Size = new Size(304, 34);
            panel6.TabIndex = 4;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Nam", "Nữ" });
            comboBox1.Location = new Point(123, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(178, 23);
            comboBox1.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 9);
            label5.Name = "label5";
            label5.Size = new Size(75, 18);
            label5.TabIndex = 1;
            label5.Text = "Giới Tính";
            // 
            // panel5
            // 
            panel5.Controls.Add(textBox3);
            panel5.Controls.Add(label4);
            panel5.Location = new Point(397, 81);
            panel5.Name = "panel5";
            panel5.Size = new Size(304, 34);
            panel5.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(123, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(178, 23);
            textBox3.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 9);
            label4.Name = "label4";
            label4.Size = new Size(56, 18);
            label4.TabIndex = 1;
            label4.Text = "CCCD:";
            label4.Click += label4_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(textBox2);
            panel4.Controls.Add(label3);
            panel4.Location = new Point(12, 193);
            panel4.Name = "panel4";
            panel4.Size = new Size(304, 34);
            panel4.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(123, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(178, 23);
            textBox2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(7, 9);
            label3.Name = "label3";
            label3.Size = new Size(84, 18);
            label3.TabIndex = 1;
            label3.Text = "Quê Quán:";
            label3.Click += label3_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(12, 142);
            panel3.Name = "panel3";
            panel3.Size = new Size(304, 34);
            panel3.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(123, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(178, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(64, 18);
            label2.TabIndex = 1;
            label2.Text = "Họ Tên:";
            // 
            // panel2
            // 
            panel2.Controls.Add(txbMaNhanVien);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(12, 81);
            panel2.Name = "panel2";
            panel2.Size = new Size(304, 34);
            panel2.TabIndex = 0;
            // 
            // txbMaNhanVien
            // 
            txbMaNhanVien.Location = new Point(123, 4);
            txbMaNhanVien.Name = "txbMaNhanVien";
            txbMaNhanVien.Size = new Size(178, 23);
            txbMaNhanVien.TabIndex = 1;
            txbMaNhanVien.TextChanged += txbMaNhanVien_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(109, 18);
            label1.TabIndex = 1;
            label1.Text = "Mã Nhân Viên:";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "FormNhanVien";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel10.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Panel panel7;
        private Label label6;
        private Panel panel6;
        private Label label5;
        private Panel panel5;
        private TextBox textBox3;
        private Label label4;
        private Panel panel4;
        private TextBox textBox2;
        private Label label3;
        private Panel panel3;
        private TextBox textBox1;
        private Label label2;
        private TextBox txbMaNhanVien;
        private Panel panel8;
        private Label label9;
        private Label label8;
        private Label label7;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button btnThongKe;
        private Button button5;
        private Button btnQuanLyBaiXe;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Panel panel9;
        private Panel panel10;
        private DataGridView dataGridView1;
    }
}
