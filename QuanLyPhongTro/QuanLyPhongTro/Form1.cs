using System.Data;

namespace QuanLyPhongTro
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txtTK.Text.Trim();
            string matKhau = txtMK.Text.Trim();

            // Giả sử bạn đã kiểm tra đăng nhập thành công
            // và có cột "VaiTro" trong bảng tài khoản

            string query = $"SELECT VaiTro FROM TaiKhoan WHERE TenDangNhap = '{tenDangNhap}' AND MatKhau = '{matKhau}'";
            DataTable dt = Modify.GetData(query);

            if (dt.Rows.Count > 0)
            {
                string vaiTro = dt.Rows[0]["VaiTro"].ToString();

                // ✅ Truyền vai trò sang FormMain
                FormMain formMain = new FormMain(vaiTro);
                this.Hide();
                formMain.Show();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!");
            }

        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát không?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
