using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhongTro
{
    public partial class UC_TaiKhoan : UserControl
    {
        // Biến toàn cục để lưu chuỗi truy vấn và trạng thái thao tác
        private string query = "";
        private bool themMoi = false;

        public UC_TaiKhoan()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            // Không cần code
        }

        private void UC_TaiKhoan_Load(object sender, EventArgs e)
        {
            dgvTaiKhoan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            LoadTaiKhoan();
            SetControls(false);
        }

        private void LoadTaiKhoan()
        {
            dgvTaiKhoan.DataSource = Modify.GetData("SELECT * FROM TaiKhoan", null);
        }

        private void SetControls(bool status)
        {
            txtMaTK.Enabled = status;
            txtTenDN.Enabled = status;
            txtMK.Enabled = status;
            txtXNMK.Enabled = status;
            cbQuyen.Enabled = status;

            btLuu.Enabled = status;

            btThem.Enabled = !status;
            btSua.Enabled = !status;
            btXoa.Enabled = !status;
            btLamMoi.Enabled = !status;
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            themMoi = true;
            SetControls(true);

            txtMaTK.Clear();
            txtTenDN.Clear();
            txtMK.Clear();
            txtXNMK.Clear();
            cbQuyen.SelectedIndex = -1;

            txtMaTK.Focus();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (dgvTaiKhoan.CurrentRow == null)
            {
                MessageBox.Show("Hãy chọn tài khoản cần sửa!");
                return;
            }

            themMoi = false;
            SetControls(true);
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (dgvTaiKhoan.CurrentRow == null)
            {
                MessageBox.Show("Hãy chọn tài khoản cần xóa!");
                return;
            }

            int id = Convert.ToInt32(dgvTaiKhoan.CurrentRow.Cells["ID"].Value);

            // SỬA: Dùng SQL Parameters để XÓA an toàn
            string q = "DELETE FROM TaiKhoan WHERE ID = @ID";
            SqlParameter param = new SqlParameter("@ID", SqlDbType.Int) { Value = id };

            if (Modify.CapNhat(q, param)) // Gọi hàm CapNhat 2 tham số
            {
                MessageBox.Show("Xóa thành công!");
                LoadTaiKhoan();
            }
            else
            {
                MessageBox.Show("Xóa thất bại!");
            }
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra đầu vào
            if (string.IsNullOrWhiteSpace(txtMaTK.Text) ||
                string.IsNullOrWhiteSpace(txtTenDN.Text) ||
                string.IsNullOrWhiteSpace(txtMK.Text) ||
                string.IsNullOrWhiteSpace(txtXNMK.Text) ||
                cbQuyen.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            if (txtMK.Text != txtXNMK.Text)
            {
                MessageBox.Show("Mật khẩu không khớp!");
                return;
            }

            // Lấy mật khẩu dạng văn bản thuần
            string matKhau = txtMK.Text;

            string query = "";
            List<SqlParameter> parameters = new List<SqlParameter>();

            // Chuẩn bị các tham số chung
            parameters.Add(new SqlParameter("@ID", SqlDbType.Int) { Value = Convert.ToInt32(txtMaTK.Text) });
            parameters.Add(new SqlParameter("@TenDangNhap", SqlDbType.NVarChar, 50) { Value = txtTenDN.Text });
            parameters.Add(new SqlParameter("@MatKhau", SqlDbType.NVarChar, 50) { Value = matKhau });
            parameters.Add(new SqlParameter("@VaiTro", SqlDbType.NVarChar, 20) { Value = cbQuyen.Text });

            if (themMoi)
            {
                // Thêm mới (INSERT)
                // (Giả sử KiemTraIDTonTai đã được xóa hoặc bạn đang không dùng)
                query = "INSERT INTO TaiKhoan (ID, TenDangNhap, MatKhau, VaiTro) VALUES (@ID, @TenDangNhap, @MatKhau, @VaiTro)";
            }
            else // SỬA (UPDATE)
            {
                // Lấy ID cũ
                int idOld = Convert.ToInt32(dgvTaiKhoan.CurrentRow.Cells["ID"].Value);
                parameters.Add(new SqlParameter("@IDOld", SqlDbType.Int) { Value = idOld });

                query = @"
                UPDATE TaiKhoan SET
                    ID = @ID,
                    TenDangNhap = @TenDangNhap,
                    MatKhau = @MatKhau,
                    VaiTro = @VaiTro
                WHERE ID = @IDOld";
            }

            // Thực thi
            if (Modify.CapNhat(query, parameters.ToArray()))
            {
                MessageBox.Show("Lưu thành công!");
                LoadTaiKhoan();
                SetControls(false);
            }
            else
            {
                MessageBox.Show("Lưu thất bại! (Kiểm tra lại kết nối hoặc lỗi trùng ID)", "Lỗi Lưu");
            }
        }

        private void btLamMoi_Click(object sender, EventArgs e)
        {
            LoadTaiKhoan();
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            string key = txtTK.Text.Trim();  // lấy đúng ô tìm kiếm

            if (string.IsNullOrEmpty(key))
            {
                LoadTaiKhoan();
                return;
            }

            string query = "SELECT * FROM TaiKhoan WHERE TenDangNhap LIKE @Key";
            SqlParameter param = new SqlParameter("@Key", SqlDbType.NVarChar, 50)
            {
                Value = "%" + key + "%"
            };

            dgvTaiKhoan.DataSource = Modify.GetData(query, param);
        }

        private void dgvTaiKhoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtMaTK.Text = dgvTaiKhoan.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                txtTenDN.Text = dgvTaiKhoan.Rows[e.RowIndex].Cells["TenDangNhap"].Value.ToString();

                // Hiển thị mật khẩu đã lưu (dạng thuần văn bản)
                txtMK.Text = dgvTaiKhoan.Rows[e.RowIndex].Cells["MatKhau"].Value.ToString();
                txtXNMK.Text = txtMK.Text;

                cbQuyen.Text = dgvTaiKhoan.Rows[e.RowIndex].Cells["VaiTro"].Value.ToString();
            }
        }
    }
}