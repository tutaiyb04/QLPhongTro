using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhongTro
{
    public partial class UC_TrangChu : UserControl
    {
        public UC_TrangChu()
        {
            InitializeComponent();
        }

        public void LoadThongKe()
        {
            try
            {
                // Tổng số phòng 
                string sqlTongPhong = "SELECT COUNT(*) FROM Phong";
                DataTable dtTongPhong = Modify.GetData(sqlTongPhong);
                lbTongPhong.Text = "Tổng số phòng: " + dtTongPhong.Rows[0][0].ToString();

                // Phòng đang thuê
                string sqlDangThue = "SELECT COUNT(*) FROM Phong WHERE TinhTrang = N'Đang Thuê'";
                DataTable dtDangThue = Modify.GetData(sqlDangThue);
                lbChoThue.Text = "Phòng đang thuê: " + dtDangThue.Rows[0][0].ToString();

                // Phòng trống
                string sqlPhongTrong = "SELECT COUNT(*) FROM Phong WHERE TinhTrang = N'Trống'";
                DataTable dtPhongTrong = Modify.GetData(sqlPhongTrong);
                lbPhongTrong.Text = "Phòng còn trống: " + dtPhongTrong.Rows[0][0].ToString();

                // Doanh thu tháng hiện tại
                string sqpDoanhThu = @"
                    SELECT ISNULL(SUM(TongTien), 0) 
                    FROM HoaDon
                    WHERE MONTH(NgayLap) = MONTH(GETDATE())
                    AND YEAR(NGayLap) = YEAR(GETDATE())";
                DataTable dtDoanhThu = Modify.GetData(sqpDoanhThu);
                lbDoanhThuThang.Text = "Doanh thu tháng:" + string.Format("{0:N0} VNĐ", dtDoanhThu.Rows[0][0]);
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi tải thống kê: " + e.Message);
            }
        }

        private void UC_TrangChu_Load(object sender, EventArgs e)
        {
            LoadThongKe();
            LoadThongBaoDong();
        }

        private void LoadThongBaoDong()
        {
            StringBuilder tb = new StringBuilder();

            tb.AppendLine("📢 THÔNG BÁO HỆ THỐNG");
            tb.AppendLine("────────────────────────────────────");
            tb.AppendLine("");

            // --- THÔNG TIN PHÒNG ---
            int tongPhong = GetInt("SELECT COUNT(*) FROM Phong");
            int phongDangThue = GetInt("SELECT COUNT(*) FROM Phong WHERE TinhTrang = N'Đang thuê'");
            int phongTrong = GetInt("SELECT COUNT(*) FROM Phong WHERE TinhTrang = N'Trống'");

            tb.AppendLine($"• Tổng số phòng: {tongPhong}");
            tb.AppendLine($"• Đang thuê: {phongDangThue}");
            tb.AppendLine($"• Còn trống: {phongTrong}");
            tb.AppendLine("");

            // --- DOANH THU ---
            int doanhThu = GetInt(@"
                SELECT ISNULL(SUM(TongTien), 0) 
                FROM HoaDon 
                WHERE MONTH(NgayLap) = MONTH(GETDATE()) 
                AND YEAR(NgayLap) = YEAR(GETDATE())");

            tb.AppendLine($"💰 Doanh thu tháng này: {doanhThu:N0} VNĐ");
            tb.AppendLine("");

            // --- HOÁ ĐƠN CHƯA THANH TOÁN ---
            DataTable noHoaDon = GetTable(
                "SELECT MaHD, MaKhach, TongTien FROM HoaDon WHERE TrangThai = N'Chưa thanh toán'");

            if (noHoaDon.Rows.Count > 0)
            {
                tb.AppendLine("🔴 Hóa đơn chưa thanh toán:");
                foreach (DataRow r in noHoaDon.Rows)
                {
                    tb.AppendLine($"   • Hóa đơn #{r["MaHD"]}, khách {r["MaKhach"]}, nợ {Convert.ToInt32(r["TongTien"]):N0} VNĐ");
                }
                tb.AppendLine("");
            }

            // --- GỢI Ý ---
            tb.AppendLine("💡 Gợi ý:");
            tb.AppendLine("• Kiểm tra danh sách phòng đang thuê.");
            tb.AppendLine("• Nhắc khách thanh toán hóa đơn.");
            tb.AppendLine("• Theo dõi báo cáo doanh thu để quản lý tốt hơn.");

            richTextBox1.Text = tb.ToString();
        }

        private int GetInt(string query)
        {
            using (SqlConnection conn = Connection.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                object result = cmd.ExecuteScalar();

                if (result == DBNull.Value || result == null)
                    return 0;

                return Convert.ToInt32(result);
            }
        }


        private DataTable GetTable(string query)
        {
            using (SqlConnection conn = Connection.GetConnection())
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

    }
}
