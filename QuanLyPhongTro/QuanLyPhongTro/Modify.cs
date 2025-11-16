using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
// Đã xóa: using Microsoft.Office.Interop.Excel; // <--- XÓA DÒNG NÀY ĐỂ KHẮC PHỤC LỖI DATATABLE

namespace QuanLyPhongTro
{
    internal class Modify
    {
        // Hàm CẬP NHẬT mới, nhận cả query VÀ SQL parameters
        public static bool CapNhat(string query, params SqlParameter[] parameters) // <--- SỬA CHỮ KÝ HÀM TẠI ĐÂY
        {
            using (SqlConnection sqlConnection = Connection.GetConnection())
            {
                try
                {
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                    // Thêm các tham số vào command
                    if (parameters != null)
                    {
                        sqlCommand.Parameters.AddRange(parameters); // 'parameters' hiện đã tồn tại
                    }

                    if (sqlCommand.ExecuteNonQuery() > 0)
                    {
                        return true;
                    }
                }
                catch (SqlException ex)
                {
                    // Hiển thị lỗi SQL cụ thể
                    System.Windows.Forms.MessageBox.Show("Lỗi SQL: " + ex.Message, "Lỗi Database", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show("Lỗi: " + ex.Message, "Lỗi Hệ thống", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                }
            }
            return false;
        }

        // Hàm GetData mới, nhận cả query VÀ SQL parameters (Khắc phục lỗi CS1501 và CS0103)
        public static DataTable GetData(string query, params SqlParameter[] parameters) // <--- Chữ ký hàm đúng
        {
            using (SqlConnection conn = Connection.GetConnection())
            {
                conn.Open();

                SqlCommand command = new SqlCommand(query, conn);

                // Thêm các tham số vào command
                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters); // 'parameters' đã tồn tại
                }

                DataTable table = new DataTable(); // Lỗi DataTable đã được sửa

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    table.Load(reader);
                }

                return table;
            }
        }

        // Thêm hàm này vào Modify.cs
        public static bool KiemTraIDTonTai(string id)
        {
            // Giả sử Connection.GetConnection() đã được định nghĩa
            string query = "SELECT COUNT(*) FROM TaiKhoan WHERE ID = @ID";
            using (SqlConnection conn = Connection.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID", id);
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }

        public static bool Execute(string query)

        {

            using (SqlConnection conn = Connection.GetConnection())

            {

                conn.Open();

                SqlCommand cmd = new SqlCommand(query, conn);

                return cmd.ExecuteNonQuery() > 0;

            }
        }
    }
}