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
    public partial class UC_KhachThue : UserControl
    {
        private string selectedID = "";
        public UC_KhachThue()
        {
            InitializeComponent();
        }

        private void UC_KhachThue_Load(object sender, EventArgs e)
        {
            dgvKhachThue.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            LoadData();
            LoadPhongToComboBox();
        }

        private void LoadData()
        {
            string query = "SELECT MaKhach, HoTen, CCCD, SDT, DiaChi, NgayThue, TenPhong " +
                           "FROM KhachThue KT JOIN Phong P ON KT.MaPhong = P.MaPhong";
            dgvKhachThue.DataSource = Modify.GetData(query);
        }

        // Tải danh sách các phòng đang Trống hoặc đang Thuê vào ComboBox
        private void LoadPhongToComboBox()
        {
            string query = "SELECT MaPhong, TenPhong FROM Phong";
            DataTable dt = Modify.GetData(query);

            cbPhongThue.DataSource = dt;
            cbPhongThue.DisplayMember = "TenPhong"; // Cột hiển thị
            cbPhongThue.ValueMember = "MaPhong";   // Cột giá trị
            cbPhongThue.SelectedIndex = -1;
        }

        // Làm mới các ô nhập liệu
        private void ClearData()
        {
            txtMaKhach.Clear();
            txtTenKT.Clear();
            txtCCCD.Clear();
            txtSDT.Clear();
            txtDC.Clear();
            dtpNgayThue.Value = DateTime.Now;
            cbPhongThue.SelectedIndex = -1;
            selectedID = "";
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            ClearData();
            txtTenKT.Focus();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (selectedID == "")
            {
                MessageBox.Show("Vui lòng chọn khách thuê cần sửa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy dữ liệu mới
            string hoten = txtTenKT.Text.Trim();
            string cccd = txtCCCD.Text.Trim();
            string sdt = txtSDT.Text.Trim();
            string diachi = txtDC.Text.Trim();
            string ngaythue = dtpNgayThue.Value.ToString("yyyy-MM-dd");
            string maPhong = cbPhongThue.SelectedValue?.ToString();

            // Kiểm tra Validation
            if (hoten == "" || cccd == "" || sdt == "" || diachi == "" || maPhong == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin khách thuê và chọn phòng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Thực hiện Cập nhật (UPDATE)
            string query = $"UPDATE KhachThue SET HoTen = N'{hoten}', CCCD = '{cccd}', SDT = '{sdt}', DiaChi = N'{diachi}', NgayThue = '{ngaythue}', MaPhong = {maPhong} " +
                           $"WHERE MaKhach = {selectedID}";

            if (Modify.Execute(query))
            {
                MessageBox.Show("Cập nhật khách thuê thành công!", "Thông báo");
                LoadData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Cập nhật khách thuê thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (selectedID == "")
            {
                MessageBox.Show("Vui lòng chọn khách thuê cần xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult r = MessageBox.Show("Bạn có chắc muốn xóa khách thuê này? (Phòng sẽ được giải phóng)", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {
                // Lấy MaPhong của khách thuê này để cập nhật trạng thái phòng thành 'Trống'
                string getMaPhongQuery = $"SELECT MaPhong FROM KhachThue WHERE MaKhach = {selectedID}";
                DataTable dt = Modify.GetData(getMaPhongQuery);
                string maPhongHienTai = dt.Rows[0]["MaPhong"].ToString();

                // Thực hiện Xóa Khách và Cập nhật trạng thái Phòng
                string query = $"DELETE FROM KhachThue WHERE MaKhach = {selectedID}; " +
                               $"UPDATE Phong SET TinhTrang = N'Trống' WHERE MaPhong = {maPhongHienTai}";

                if (Modify.Execute(query))
                {
                    MessageBox.Show("Xóa khách thuê thành công! Phòng đã được giải phóng.", "Thông báo");
                    LoadData();
                    ClearData();
                }
                else
                {
                    MessageBox.Show("Xóa khách thuê thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu
            string hoten = txtTenKT.Text.Trim();
            string cccd = txtCCCD.Text.Trim();
            string sdt = txtSDT.Text.Trim();
            string diachi = txtDC.Text.Trim();
            string ngaythue = dtpNgayThue.Value.ToString("yyyy-MM-dd");
            string maPhong = cbPhongThue.SelectedValue?.ToString();

            // Kiểm tra Validation
            if (hoten == "" || cccd == "" || sdt == "" || diachi == "" || maPhong == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin khách thuê và chọn phòng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query;
            if (selectedID == "") // Thêm mới (INSERT)
            {
                // Kiểm tra xem phòng đã được thuê chưa (Nếu bạn có ràng buộc này)
                // (Giả sử bạn cần cập nhật Tình Trạng phòng sang 'Đang thuê' sau khi thêm khách)
                query = $"INSERT INTO KhachThue (HoTen, CCCD, SDT, DiaChi, NgayThue, MaPhong) " +
                        $"VALUES (N'{hoten}', '{cccd}', '{sdt}', N'{diachi}', '{ngaythue}', {maPhong});" +
                        $"UPDATE Phong SET TinhTrang = N'Đang thuê' WHERE MaPhong = {maPhong}";
            }
            else // Cập nhật (UPDATE)
            {
                // Logic này không còn được dùng nếu bạn sử dụng nút Sửa cho việc Cập nhật,
                // nhưng tôi để lại như là một lỗi người dùng để nhắc nhở.
                MessageBox.Show("Vui lòng nhấn nút Sửa để cập nhật khách thuê đã chọn!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Modify.Execute(query))
            {
                MessageBox.Show("Thêm khách thuê thành công!", "Thông báo");
                LoadData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Thêm khách thuê thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btLamMoi_Click(object sender, EventArgs e)
        {
            LoadData();
            ClearData();
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            string keyword = txtTK.Text.Trim();
            string query = $"SELECT MaKhach, HoTen, CCCD, SDT, DiaChi, NgayThue, TenPhong " +
                           $"FROM KhachThue KT JOIN Phong P ON KT.MaPhong = P.MaPhong " +
                           $"WHERE HoTen LIKE N'%{keyword}%' OR CCCD LIKE N'%{keyword}%' OR TenPhong LIKE N'%{keyword}%'";
            dgvKhachThue.DataSource = Modify.GetData(query);
        }

        private void dgvKhachThue_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvKhachThue.Rows[e.RowIndex];
                selectedID = row.Cells["MaKhach"].Value.ToString();
                txtMaKhach.Text = selectedID;
                txtTenKT.Text = row.Cells["HoTen"].Value.ToString();
                txtCCCD.Text = row.Cells["CCCD"].Value.ToString();
                txtSDT.Text = row.Cells["SDT"].Value.ToString();
                txtDC.Text = row.Cells["DiaChi"].Value.ToString();
                dtpNgayThue.Value = Convert.ToDateTime(row.Cells["NgayThue"].Value);
                cbPhongThue.Text = row.Cells["TenPhong"].Value.ToString();
            }
        }
    }
}
