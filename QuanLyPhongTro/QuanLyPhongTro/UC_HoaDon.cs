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
    public partial class UC_HoaDon : UserControl
    {
        private string selectedID = ""; // Mã hóa đơn đang chọn (MaHD)
        private DataTable phongData; // Biến lưu trữ dữ liệu phòng để tra cứu
        public UC_HoaDon()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UC_HoaDon_Load(object sender, EventArgs e)
        {
            dgvHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            LoadPhongData(); // Tải dữ liệu phòng
            LoadMaKhachToComboBox(); // Tải Mã khách thuê
            LoadTrangThaiToComboBox();
            LoadData(); // Tải danh sách Hóa đơn
        }

        // Tải danh sách Hóa đơn
        private void LoadData()
        {
            // Truy vấn lấy cả Tiền phòng và Tên khách để hiển thị
            string query = "SELECT HD.MaHD, HD.NgayLap, HD.MaKhach, KT.HoTen AS TenKhach, HD.TienPhong, HD.TienDichVu, HD.TongTien, HD.TrangThai " +
                           "FROM HoaDon HD JOIN KhachThue KT ON HD.MaKhach = KT.MaKhach";
            dgvHoaDon.DataSource = Modify.GetData(query);
            ClearData();
        }

        // Tải dữ liệu phòng để tra cứu Tiền phòng
        private void LoadPhongData()
        {
            // Lấy MaPhong, GiaThue từ Phong, và MaKhach từ KhachThue để tra cứu
            string query = "SELECT P.MaPhong, P.GiaThue, KT.MaKhach " +
                           "FROM Phong P JOIN KhachThue KT ON P.MaPhong = KT.MaPhong";
            phongData = Modify.GetData(query);
        }

        // Tải danh sách Mã khách thuê vào ComboBox
        private void LoadMaKhachToComboBox()
        {
            string query = "SELECT MaKhach FROM KhachThue";
            DataTable dt = Modify.GetData(query);

            cbMaKT.DataSource = null;

            cbMaKT.DataSource = dt;
            cbMaKT.DisplayMember = "MaKhach";
            cbMaKT.ValueMember = "MaKhach";
            cbMaKT.SelectedIndex = -1;
        }

        // MỚI: Tải danh sách trạng thái
        private void LoadTrangThaiToComboBox()
        {
            cbTrangThai.Items.Clear();
            cbTrangThai.Items.Add("Chưa thanh toán");
            cbTrangThai.Items.Add("Đã thanh toán");
            cbTrangThai.SelectedIndex = 0;
        }

        // Làm mới các ô nhập liệu
        private void ClearData()
        {
            txtMaHD.Clear();
            txtTenKT.Clear();
            txtMaPhong.Clear(); // Dùng để lưu Mã phòng
            txtTienPhong.Clear(); // Ô hiển thị Tiền phòng
            txtTienDien.Clear();
            txtTienNuoc.Clear();
            txtTongTien.Clear();
            dateTimePicker1.Value = DateTime.Now;
            cbMaKT.SelectedIndex = -1;
            cbTrangThai.SelectedIndex = 0;
            selectedID = "";
        }

        // Tính tổng tiền: Tiền phòng + Tiền điện + Tiền nước
        private void CalculateTongTien()
        {
            decimal tienDien = 0, tienNuoc = 0, tienPhong = 0;

            // 1. Lấy Tiền phòng
            decimal.TryParse(txtTienPhong.Text, out tienPhong);

            // 2. Lấy Tiền điện, Tiền nước
            decimal.TryParse(txtTienDien.Text, out tienDien);
            decimal.TryParse(txtTienNuoc.Text, out tienNuoc);

            // 3. Tính Tổng tiền và hiển thị
            decimal tongTien = tienPhong + tienDien + tienNuoc;
            txtTongTien.Text = tongTien.ToString("0.00"); // Định dạng tiền tệ
        }    

        private void btThem_Click(object sender, EventArgs e)
        {
            ClearData();
            cbMaKT.Focus();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (selectedID == "")
            {
                MessageBox.Show("Vui lòng chọn hóa đơn cần sửa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy dữ liệu
            string maKhach = cbMaKT.SelectedValue?.ToString();
            string ngayLap = dateTimePicker1.Value.ToString("yyyy-MM-dd");

            decimal tienPhong = 0;
            decimal.TryParse(txtTienPhong.Text, out tienPhong);

            decimal tienDichVu = 0;
            decimal.TryParse(txtTienDien.Text, out tienDichVu);
            decimal.TryParse(txtTienNuoc.Text, out decimal tienNuoc);
            tienDichVu += tienNuoc;

            string trangThai = cbTrangThai.Text; // <--- MỚI: Lấy trạng thái

            // 1. Validation
            if (maKhach == null || tienPhong == 0 || string.IsNullOrEmpty(trangThai))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin (Khách, Tiền phòng, và Trạng thái)!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Thực hiện Cập nhật (UPDATE) - KHÔNG INCLUDE TongTien
            string query = $"UPDATE HoaDon SET NgayLap = '{ngayLap}', MaKhach = {maKhach}, TienPhong = {tienPhong}, TienDichVu = {tienDichVu}, TrangThai = N'{trangThai}' " +
                           $"WHERE MaHD = {selectedID}";

            if (Modify.Execute(query))
            {
                MessageBox.Show("Cập nhật hóa đơn thành công!", "Thông báo");
                LoadData();
            }
            else
            {
                MessageBox.Show("Cập nhật hóa đơn thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (selectedID == "")
            {
                MessageBox.Show("Vui lòng chọn hóa đơn cần xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult r = MessageBox.Show("Bạn có chắc muốn xóa hóa đơn này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {
                string query = $"DELETE FROM HoaDon WHERE MaHD = {selectedID}";

                if (Modify.Execute(query))
                {
                    MessageBox.Show("Xóa hóa đơn thành công!", "Thông báo");
                    LoadData();
                    ClearData();
                }
                else
                {
                    MessageBox.Show("Xóa hóa đơn thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu
            string maKhach = cbMaKT.SelectedValue?.ToString();
            string ngayLap = dateTimePicker1.Value.ToString("yyyy-MM-dd");

            decimal tienPhong = 0;
            decimal.TryParse(txtTienPhong.Text, out tienPhong);

            decimal tienDichVu = 0;
            decimal.TryParse(txtTienDien.Text, out tienDichVu);
            decimal.TryParse(txtTienNuoc.Text, out decimal tienNuoc);
            tienDichVu += tienNuoc;

            string trangThai = cbTrangThai.Text; // <--- MỚI: Lấy trạng thái

            // 1. Validation
            if (maKhach == null || tienPhong == 0 || string.IsNullOrEmpty(trangThai)) // Kiểm tra cả Trạng thái
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin (Khách, Tiền phòng, và Trạng thái)!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query;
            if (selectedID == "") // Thêm mới (INSERT)
            {
                // KHÔNG INCLUDE TongTien
                query = $"INSERT INTO HoaDon (NgayLap, MaKhach, TienPhong, TienDichVu, TrangThai) " +
                        $"VALUES ('{ngayLap}', {maKhach}, {tienPhong}, {tienDichVu}, N'{trangThai}')";
            }
            else
            {
                MessageBox.Show("Vui lòng sử dụng nút Sửa để cập nhật hóa đơn đã chọn.", "Cảnh báo");
                return;
            }

            if (Modify.Execute(query))
            {
                MessageBox.Show("Thêm hóa đơn thành công!", "Thông báo");
                LoadData();
            }
            else
            {
                MessageBox.Show("Thêm hóa đơn thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btLamMoi_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btTK_Click(object sender, EventArgs e)
        {
            string keyword = txtTK.Text.Trim(); // Giả định ô tìm kiếm là txtTimKiem
            string query = $"SELECT HD.MaHD, HD.NgayLap, HD.MaKhach, KT.HoTen AS TenKhach, HD.TienPhong, HD.TienDichVu, HD.TongTien, HD.TrangThai " +
                           $"FROM HoaDon HD JOIN KhachThue KT ON HD.MaKhach = KT.MaKhach " +
                           $"WHERE KT.HoTen LIKE N'%{keyword}%' OR HD.MaHD LIKE N'%{keyword}%'";
            dgvHoaDon.DataSource = Modify.GetData(query);
        }

        private void dgvHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Thêm kiểm tra hàng cuối cùng (hàng mới)
            if (e.RowIndex >= 0 && e.RowIndex < dgvHoaDon.Rows.Count - 1)
            {
                DataGridViewRow row = dgvHoaDon.Rows[e.RowIndex];

                // --- 1. Lấy MaHD và Ngày Lập (Kiểm tra DBNull cho giá trị không rỗng) ---
                if (row.Cells["MaHD"].Value != null)
                {
                    selectedID = row.Cells["MaHD"].Value.ToString();
                    txtMaHD.Text = selectedID;
                }

                // Kiểm tra DBNull cho NgayLap (Nếu NgayLap cho phép NULL trong DB)
                object ngayLapValue = row.Cells["NgayLap"].Value;
                if (ngayLapValue != DBNull.Value && ngayLapValue != null)
                {
                    dateTimePicker1.Value = Convert.ToDateTime(ngayLapValue);
                }

                // --- 2. Gán Mã khách (Kiểm tra DBNull cho object) ---
                if (row.Cells["MaKhach"].Value != null && row.Cells["MaKhach"].Value != DBNull.Value)
                {
                    cbMaKT.SelectedValue = row.Cells["MaKhach"].Value;
                }

                // --- 3. Gán giá trị tiền (BẮT BUỘC kiểm tra DBNull) ---

                // Lấy TienPhong
                object tienPhongValue = row.Cells["TienPhong"].Value;
                decimal tienPhong = (tienPhongValue != DBNull.Value) ? Convert.ToDecimal(tienPhongValue) : 0M;
                txtTienPhong.Text = tienPhong.ToString("0.00");

                // Lấy TienDichVu (Gây lỗi trước đó)
                object tienDichVuValue = row.Cells["TienDichVu"].Value;
                decimal tienDV = (tienDichVuValue != DBNull.Value) ? Convert.ToDecimal(tienDichVuValue) : 0M;

                // Chia TienDichVu
                txtTienDien.Text = (tienDV / 2).ToString("0.00");
                txtTienNuoc.Text = (tienDV / 2).ToString("0.00");

                // Lấy TongTien
                object tongTienValue = row.Cells["TongTien"].Value;
                decimal tongTien = (tongTienValue != DBNull.Value) ? Convert.ToDecimal(tongTienValue) : 0M;
                txtTongTien.Text = tongTien.ToString("0.00");

                // --- 4. Gán Trạng thái ---
                object trangThaiValue = row.Cells["TrangThai"].Value;
                if (trangThaiValue != null && trangThaiValue != DBNull.Value)
                {
                    cbTrangThai.Text = trangThaiValue.ToString();
                }
            }
        }

        // --- SỰ KIỆN TỰ ĐỘNG ĐIỀN VÀ TÍNH TOÁN ---

        // Tự động điền thông tin (Tên khách, Mã phòng, Tiền phòng) khi chọn Mã khách thuê
        private void cbMaKT_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMaKT.SelectedValue != null && cbMaKT.SelectedIndex != -1 && cbMaKT.SelectedValue is DataRowView == false)
            {
                string maKhach = cbMaKT.SelectedValue.ToString();
                string khachQuery = $"SELECT HoTen, MaPhong FROM KhachThue WHERE MaKhach = {maKhach}";
                DataTable khachDt = Modify.GetData(khachQuery);

                if (khachDt != null && khachDt.Rows.Count > 0)
                {
                    string maPhong = khachDt.Rows[0]["MaPhong"].ToString();
                    txtTenKT.Text = khachDt.Rows[0]["HoTen"].ToString();
                    txtMaPhong.Text = maPhong;

                    DataRow[] phongRow = phongData.Select($"MaKhach = {maKhach}");
                    if (phongRow.Length > 0)
                    {
                        txtTienPhong.Text = Convert.ToDecimal(phongRow[0]["GiaThue"]).ToString("0.00");
                    }
                    else
                    {
                        txtTienPhong.Text = "0.00";
                    }
                }
                CalculateTongTien();
            }
            else
            {
                txtTenKT.Clear();
                txtMaPhong.Clear();
                txtTienPhong.Clear();
                CalculateTongTien();
            }
        }

        private void txtTienDien_TextChanged(object sender, EventArgs e)
        {
            CalculateTongTien();
        }

        private void txtTienNuoc_TextChanged(object sender, EventArgs e)
        {
            CalculateTongTien();
        }
    }
}
