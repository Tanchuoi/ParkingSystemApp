using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingSystemApp
{
    public partial class QuanLyBaiXe : Form
    {
        private static Form1 formNhanVien = null;
        private static ThongKe formThongKe = null;

        public QuanLyBaiXe()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnQuanLyNhanVien_Click(object sender, EventArgs e)
        {
            if (formNhanVien == null || formNhanVien.IsDisposed)
            {
                formNhanVien = new Form1();
            }
            this.Hide();
            formNhanVien.Show();
        }

        private void btnQuanLyBaiXe_Click(object sender, EventArgs e)
        {
            // Form hiện tại đã là Form Quản Lý Bãi Xe nên không cần tạo mới
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Form hiện tại đã là Form Quản Lý Bãi Xe nên không cần tạo mới
            this.Show();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            // Mở form Thống Kê
            if (formThongKe == null || formThongKe.IsDisposed)
            {
                formThongKe = new ThongKe();
            }
            this.Hide();
            formThongKe.Show();
        }
    }
}
