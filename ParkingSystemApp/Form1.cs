namespace ParkingSystemApp
{
    public partial class Form1 : Form
    {
        private static QuanLyBaiXe formBaiXe = null;
        private static ThongKe formThongKe = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Xử lý sự kiện click cho label1
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // Xử lý sự kiện click cho label3
        }

        private void label4_Click(object sender, EventArgs e)
        {
            // Xử lý sự kiện click cho label4
        }

        private void label6_Click(object sender, EventArgs e)
        {
            // Xử lý sự kiện click cho label6
        }

        private void label8_Click(object sender, EventArgs e)
        {
            // Xử lý sự kiện click cho label8
        }

        private void btnQuanLyBaiXe_Click(object sender, EventArgs e)
        {
            if (formBaiXe == null || formBaiXe.IsDisposed)
            {
                formBaiXe = new QuanLyBaiXe();
            }
            this.Hide();
            formBaiXe.Show();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            try
            {
                // Mở form Thống Kê
                if (formThongKe == null || formThongKe.IsDisposed)
                {
                    formThongKe = new ThongKe();
                }
                this.Hide();
                formThongKe.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Form hiện tại đã là Form Quản Lý Nhân Viên nên không cần tạo mới
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Xử lý sự kiện click cho button1 (nút Thêm)
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Xử lý sự kiện khi text trong textBox1 thay đổi
        }

        private void txbMaNhanVien_TextChanged(object sender, EventArgs e)
        {
            // Xử lý sự kiện khi text trong txbMaNhanVien thay đổi
        }
    }
}
