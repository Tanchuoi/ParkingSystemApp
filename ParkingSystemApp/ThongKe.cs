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
    public partial class ThongKe : Form
    {
        private static Form1? formNhanVien = null;
        private static QuanLyBaiXe? formBaiXe = null;

        public ThongKe()
        {
            InitializeComponent();
        }

        private void btnQuanLyNhanVien_Click(object sender, EventArgs e)
        {
            // Mở form Quản Lý Nhân Viên
            if (formNhanVien == null || formNhanVien.IsDisposed)
            {
                formNhanVien = new Form1();
            }
            this.Hide();
            formNhanVien.Show();
        }

        private void btnQuanLyBaiXe_Click(object sender, EventArgs e)
        {
            // Mở form Quản Lý Bãi Xe
            if (formBaiXe == null || formBaiXe.IsDisposed)
            {
                formBaiXe = new QuanLyBaiXe();
            }
            this.Hide();
            formBaiXe.Show();
        }
    }
}
