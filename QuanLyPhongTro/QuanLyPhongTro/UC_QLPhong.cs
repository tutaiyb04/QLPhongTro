using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhongTro
{
    public partial class UC_QLPhong : UserControl
    {
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public UC_TrangChu TrangChuControl { get; set; } // tham chiếu đến UC_TrangChu
        private string selectedID = ""; // mã phòng đang chọn
        public UC_QLPhong()
        {
            InitializeComponent();
        }

        private void dgvPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvPhong.Rows[e.RowIndex];
                selectedID = row.Cells["MaPhong"].Value.ToString();
                txtMaPhong.Text = selectedID;
                txtTenPhong.Text = row.Cells["TenPhong"].Value.ToString();
                cbLoaiPhong.Text = row.Cells["LoaiPhong"].Value.ToString();
                txtGia.Text = row.Cells["GiaThue"].Value.ToString();
                cbTinhTrang.Text = row.Cells["TinhTrang"].Value.ToString();
            }
        }

        private void UC_QLPhong_Load(object sender, EventArgs e)
        {
            dgvPhong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            LoadData();
        }

        // Load danh sách phòng
        private void LoadData()
        {
            string query = "SELECT * FROM Phong";
            dgvPhong.DataSource = Modify.GetData(query);
        }

        // Làm mới
        private void ClearData()
        {
            txtMaPhong.Clear();
            txtTenPhong.Clear();
            txtGia.Clear();
            cbLoaiPhong.SelectedIndex = -1;
            cbTinhTrang.SelectedIndex = -1;
            selectedID = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ClearData();
            txtTenPhong.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (selectedID == "")
            {
                MessageBox.Show("Vui lòng chọn phòng cần sửa!");
                return;
            }

            // Lấy dữ liệu đã được chỉnh sửa từ giao diện
            string ten = txtTenPhong.Text.Trim();
            string loai = cbLoaiPhong.Text;
            string gia = txtGia.Text.Trim();
            string tinhTrang = cbTinhTrang.Text;

            // 1. Kiểm tra dữ liệu bắt buộc
            if (ten == "" || loai == "" || gia == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            // Thực hiện Cập nhật
            string query = $"UPDATE Phong SET TenPhong = N'{ten}', LoaiPhong = N'{loai}', GiaThue = {gia}, TinhTrang = N'{tinhTrang}' WHERE MaPhong = {selectedID}";

            if (Modify.Execute(query))
            {
                MessageBox.Show("Cập nhật phòng thành công!");
                LoadData();
                ClearData();
                TrangChuControl?.LoadThongKe();
            }
            else
            {
                MessageBox.Show("Cập nhật phòng thất bại!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (selectedID == "")
            {
                MessageBox.Show("Vui lòng chọn phòng cần xóa!");
                return;
            }

            DialogResult r = MessageBox.Show("Bạn có chắc muốn xóa phòng này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                string query = $"DELETE FROM Phong WHERE MaPhong = {selectedID}";
                if (Modify.Execute(query))
                {
                    MessageBox.Show("Xóa thành công!");
                    LoadData();
                    ClearData();
                    TrangChuControl?.LoadThongKe();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại!");
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ giao diện
            string ten = txtTenPhong.Text.Trim();
            string loai = cbLoaiPhong.Text;
            string gia = txtGia.Text.Trim();
            string tinhTrang = cbTinhTrang.Text;

            // 1. Kiểm tra dữ liệu bắt buộc
            if (ten == "" || loai == "" || gia == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            // Nút Lưu chỉ thực hiện Thêm mới
            if (selectedID == "") // Đảm bảo đang ở trạng thái thêm mới sau khi ClearData()
            {
                string query = $"INSERT INTO Phong (TenPhong, LoaiPhong, GiaThue, TinhTrang) VALUES (N'{ten}', N'{loai}', {gia}, N'{tinhTrang}')";

                if (Modify.Execute(query))
                {
                    MessageBox.Show("Thêm phòng thành công!");
                    LoadData();
                    ClearData();
                    TrangChuControl?.LoadThongKe();
                }
                else
                {
                    MessageBox.Show("Thêm phòng thất bại!");
                }
            }
            else
            {
                // Nếu selectedID không rỗng, người dùng đang cố gắng Lưu một phòng đã chọn
                MessageBox.Show("Vui lòng nhấn nút Sửa để cập nhật thông tin phòng đã chọn.");
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadData();
            ClearData();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim();
            string query = $"SELECT * FROM Phong WHERE TenPhong LIKE N'%{keyword}%' OR LoaiPhong LIKE N'%{keyword}%'";
            dgvPhong.DataSource = Modify.GetData(query);
        }
    }
}
