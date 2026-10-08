namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void nameSoLuong_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTinhtien_Click(object sender, EventArgs e)
        {
            // Lấy giá trị từ Đơn giá
            bool isDonGiaValid = double.TryParse(txtDonGia.Text, out double donGia);

            // Đã đổi txtSoLuong -> nameSoLuong cho đúng với tên Control trên giao diện của bạn
            bool isSoLuongValid = int.TryParse(nameSoLuong.Text, out int soLuong);

            // Lấy giá trị Giảm giá (Cho phép để trống, nếu trống mặc định = 0)
            double giamGia = 0;
            bool isGiamGiaValid = true;
            if (!string.IsNullOrWhiteSpace(txtGiamGia.Text))
            {
                isGiamGiaValid = double.TryParse(txtGiamGia.Text, out giamGia);
            }

            // Báo lỗi nếu nhập sai số hoặc nhập chữ
            if (!isDonGiaValid || !isSoLuongValid || !isGiamGiaValid)
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ vào các ô!\nKhông được để trống hoặc nhập chữ.", "Báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tính tổng tiền
            double tongTien = (donGia * soLuong) * ((100.0 - giamGia) / 100.0);

            // Tìm và hiển thị kết quả lên Label (sử dụng Controls.Find để tự tìm Label bất kể bạn đặt tên là gì)
            Control[] labels = this.Controls.Find("lblTongTien", true);
            if (labels.Length > 0)
            {
                labels[0].Text = "Tổng tiền thanh toán: " + tongTien.ToString("N0") + " VNĐ";
            }
            else
            {
                // Nếu không tìm thấy tên lblTongTien, tự động gán vào Label hiển thị kết quả phía dưới
                foreach (Control c in this.Controls)
                {
                    if (c is Label && c.Text.Contains("tong so tien"))
                    {
                        c.Text = "tong so tien: " + tongTien.ToString("N0") + "VND";
                        break;
                    }
                }
            }
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            // Xóa trắng các ô nhập
            txtDonGia.Clear();
            nameSoLuong.Clear(); // Đổi txtSoLuong -> nameSoLuong
            txtGiamGia.Clear();

            // Trả label về mặc định
            foreach (Control c in this.Controls)
            {
                if (c is Label && (c.Name == "lblTongTien" || c.Text.Contains("tong so tien")))
                {
                    c.Text = "tong so tien: 0VND";
                    break;
                }
            }

            // Đưa con trỏ chuột nhấp nháy lại ở ô Đơn giá
            txtDonGia.Focus();
        }
    }
}