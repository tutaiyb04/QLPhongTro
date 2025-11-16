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
    public partial class FormMain : Form
    {
        private string vaitro;

        // Khai báo các UserControl
        private UC_TrangChu ucTrangChu;
        private UC_QLPhong ucQuanLyPhong;
        private UC_KhachThue ucKhachThue;
        private UC_HoaDon ucHoaDon;
        private UC_BaoCao ucBaoCao;
        private UC_TaiKhoan ucTaiKhoan;

        // Biến lưu UC hiện tại
        private UserControl currentUC;
        public FormMain(string? vaiTro)
        {
            InitializeComponent();
            this.vaitro = vaiTro;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            lbQuyen.Text = $"Quyền hiện tại: {vaitro}";

            PhanQuyenNguoiDung();

            HienThiTrangChuMacDinh();
        }

        // =================== PHÂN QUYỀN NGƯỜI DÙNG ===================
        private void PhanQuyenNguoiDung()
        {
            if (vaitro == "Admin")
            {
                btTaiKhoan.Visible = true;
                btBaoCao.Visible = true;
                return;
            }

            if (vaitro == "NhanVien")
            {
                btTaiKhoan.Visible = false;
                btBaoCao.Visible = false;
            }
        }

        // ================== HIỂN THỊ TRANG CHỦ MẶC ĐỊNH ==================
        private void HienThiTrangChuMacDinh()
        {
            if (ucTrangChu == null)
            {
                ucTrangChu = new UC_TrangChu();
                ucTrangChu.Dock = DockStyle.Fill;
            }

            HienThiUserControl(ucTrangChu);
        }
        // ================== HÀM DÙNG CHUNG HIỂN THỊ UC ==================
        private void HienThiUserControl(UserControl uc)
        {
            // Nếu UC đang hiện là UC cần mở → không làm gì
            if (currentUC == uc)
                return;

            // Xóa UC hiện tại nếu có
            panelContent.Controls.Clear();

            // Cập nhật UC hiện tại
            currentUC = uc;

            // Thêm và hiển thị UC mới
            uc.Dock = DockStyle.Fill;
            panelContent.Controls.Add(uc);
            uc.Visible = true;
        }

        // =================== HIỂN THỊ TRANG CHỦ ===================
        private void btTrangChu_Click(object sender, EventArgs e)
        {
            if (ucTrangChu == null)
            {
                ucTrangChu = new UC_TrangChu();
                ucTrangChu.Dock = DockStyle.Fill;
            }

            HienThiUserControl(ucTrangChu);
        }

        // =================== NÚT QUẢN LÝ PHÒNG ===================
        private void btQLPhong_Click(object sender, EventArgs e)
        {
            if (ucQuanLyPhong == null)
            {
                ucQuanLyPhong = new UC_QLPhong();
                ucQuanLyPhong.Dock = DockStyle.Fill;

                // GÁN UC_TrangChu CHO UC_QLPhong TẠI ĐÂY
                ucQuanLyPhong.TrangChuControl = ucTrangChu;
            }

            HienThiUserControl(ucQuanLyPhong);
        }

        private void btKhachHang_Click(object sender, EventArgs e)
        {
            if (ucKhachThue == null)
            {
                ucKhachThue = new UC_KhachThue();
                ucKhachThue.Dock = DockStyle.Fill;
            }

            HienThiUserControl(ucKhachThue);
        }

        private void btHoaDon_Click(object sender, EventArgs e)
        {
            if (ucHoaDon == null)
            {
                ucHoaDon = new UC_HoaDon();
                ucHoaDon.Dock = DockStyle.Fill;
            }

            HienThiUserControl(ucHoaDon);
        }
        private void btTaiKhoan_Click(object sender, EventArgs e)
        {
            if (ucTaiKhoan == null)
            {
                ucTaiKhoan = new UC_TaiKhoan();
                ucTaiKhoan.Dock = DockStyle.Fill;
            }

            HienThiUserControl(ucTaiKhoan);
        }

        private void btBaoCao_Click(object sender, EventArgs e)
        {
            if (ucBaoCao == null)
            {
                ucBaoCao = new UC_BaoCao();
                ucBaoCao.Dock = DockStyle.Fill;
            }

            HienThiUserControl(ucBaoCao);
        }

        private void btDangXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
        }
    }
}
