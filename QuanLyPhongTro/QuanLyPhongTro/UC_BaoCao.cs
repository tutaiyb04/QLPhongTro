using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace QuanLyPhongTro
{
    public partial class UC_BaoCao : UserControl
    {
        private PrintDocument printDoc = new PrintDocument();
        private PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
        private int rowsPerPage = 0;

        public UC_BaoCao()
        {
            InitializeComponent();
        }

        private void UC_BaoCao_Load(object sender, EventArgs e)
        {
            dgvBaoCao.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            LoadLoaiBaoCao();
            ClearData();
        }

        private void LoadLoaiBaoCao()
        {
            // Nạp các loại báo cáo khả dụng vào ComboBox
            cbLoaiBC.Items.Clear();
            cbLoaiBC.Items.Add("Doanh thu theo ngày");
            cbLoaiBC.Items.Add("Danh sách khách đang thuê");
            cbLoaiBC.Items.Add("Danh sách phòng còn trống");
            cbLoaiBC.SelectedIndex = 0;
        }

        private void ClearData()
        {
            dtTuNgay.Value = DateTime.Now.AddDays(-30); // Mặc định 30 ngày trước
            dtgDenNgay.Value = DateTime.Now;
            dgvBaoCao.DataSource = null;
            lbTongDT.Text = "Tổng doanh thu: 0.00 VND";
        }

        private void btThongKe_Click(object sender, EventArgs e)
        {
            ThucHienThongKe();
        }

        private void ThucHienThongKe()
        {
            string loaiBaoCao = cbLoaiBC.Text;
            string tuNgay = dtTuNgay.Value.ToString("yyyy-MM-dd");
            string denNgay = dtgDenNgay.Value.ToString("yyyy-MM-dd");
            string query = "";

            if (loaiBaoCao == "Doanh thu theo ngày")
            {
                query = $"SELECT HD.MaHD, HD.NgayLap, KT.HoTen AS TenKhach, HD.TongTien, HD.TrangThai " +
                        $"FROM HoaDon HD JOIN KhachThue KT ON HD.MaKhach = KT.MaKhach " +
                        $"WHERE HD.TrangThai = N'Đã thanh toán' AND HD.NgayLap BETWEEN '{tuNgay}' AND '{denNgay}'";

                DataTable dt = Modify.GetData(query);
                dgvBaoCao.DataSource = dt;

                // Tính tổng doanh thu
                if (dt != null && dt.Rows.Count > 0)
                {
                    decimal tongDoanhThu = dt.AsEnumerable().Sum(row => row.Field<decimal>("TongTien"));
                    lbTongDT.Text = $"Tổng doanh thu: {tongDoanhThu:N0} VND";
                }
                else
                {
                    lbTongDT.Text = "Tổng doanh thu: 0 VND";
                }
            }
            else if (loaiBaoCao == "Danh sách khách đang thuê")
            {
                query = $"SELECT KT.MaKhach, KT.HoTen, KT.SDT, P.TenPhong, P.GiaThue " +
                        $"FROM KhachThue KT JOIN Phong P ON KT.MaPhong = P.MaPhong " +
                        $"WHERE P.TinhTrang = N'Đang thuê'";
                dgvBaoCao.DataSource = Modify.GetData(query);
                lbTongDT.Text = "Tổng doanh thu: (Không áp dụng)";
            }
            else if (loaiBaoCao == "Danh sách phòng còn trống")
            {
                query = $"SELECT MaPhong, TenPhong, LoaiPhong, GiaThue " +
                        $"FROM Phong WHERE TinhTrang = N'Trống'";
                dgvBaoCao.DataSource = Modify.GetData(query);
                lbTongDT.Text = "Tổng doanh thu: (Không áp dụng)";
            }
            else
            {
                MessageBox.Show("Vui lòng chọn loại báo cáo.", "Lỗi");
            }
        }

        private void btXuatEX_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra dữ liệu
            if (dgvBaoCao.Rows.Count == 0 || dgvBaoCao.DataSource == null)
            {
                MessageBox.Show("Không có dữ liệu để xuất Excel.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // 2. Thiết lập SaveFileDialog
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Excel Files|*.xlsx",
                Title = "Lưu file Excel thống kê",
                FileName = "BaoCao_" + cbLoaiBC.Text.Replace(" ", "_") + "_" + DateTime.Now.ToString("yyyyMMdd_HHmmss")
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Excel.Application excelApp = null;
                Excel.Workbook excelWorkbook = null;
                Excel.Worksheet excelWorksheet = null;

                try
                {
                    // Khởi tạo Excel Application
                    excelApp = new Excel.Application();
                    excelWorkbook = excelApp.Workbooks.Add(Type.Missing);
                    excelWorksheet = (Excel.Worksheet)excelWorkbook.Sheets[1];
                    excelWorksheet.Name = "BaoCao";

                    // 3. Viết tiêu đề báo cáo
                    string title = "BÁO CÁO THỐNG KÊ - " + cbLoaiBC.Text.ToUpper();
                    excelWorksheet.Cells[1, 1] = title;
                    Excel.Range titleRange = excelWorksheet.Range[excelWorksheet.Cells[1, 1], excelWorksheet.Cells[1, dgvBaoCao.ColumnCount]];
                    titleRange.Merge();
                    titleRange.Font.Bold = true;
                    titleRange.Font.Size = 14;
                    titleRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                    // 4. Viết Header (Tên cột)
                    for (int i = 0; i < dgvBaoCao.ColumnCount; i++)
                    {
                        // **SỬA LỖI CS1061: Ép kiểu Range cho ô Header**
                        Excel.Range headerCell = (Excel.Range)excelWorksheet.Cells[3, i + 1];

                        headerCell.Value = dgvBaoCao.Columns[i].HeaderText;
                        headerCell.Font.Bold = true;
                        headerCell.Interior.Color = ColorTranslator.ToOle(Color.LightGray);
                        headerCell.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                    }

                    // 5. Viết dữ liệu
                    for (int i = 0; i < dgvBaoCao.RowCount; i++)
                    {
                        for (int j = 0; j < dgvBaoCao.ColumnCount; j++)
                        {
                            // **SỬA LỖI CS1061: Ép kiểu Range cho ô Dữ liệu**
                            Excel.Range dataCell = (Excel.Range)excelWorksheet.Cells[i + 4, j + 1];

                            // Cộng 4 vì có 3 dòng header/title phía trên
                            dataCell.Value = dgvBaoCao.Rows[i].Cells[j].Value?.ToString();
                            dataCell.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                        }
                    }

                    // 6. Viết dòng Tổng doanh thu (nếu có)
                    if (cbLoaiBC.Text == "Doanh thu theo ngày")
                    {
                        int lastRow = dgvBaoCao.RowCount + 4; // Dòng cuối cùng của dữ liệu + 1

                        // **SỬA LỖI CS1061: Ép kiểu Range cho ô Tổng kết**
                        Excel.Range totalLabelCell = (Excel.Range)excelWorksheet.Cells[lastRow, 1];
                        Excel.Range totalValueCell = (Excel.Range)excelWorksheet.Cells[lastRow, dgvBaoCao.ColumnCount];

                        totalLabelCell.Value = "Tổng doanh thu:";
                        totalValueCell.Value = lbTongDT.Text.Replace("Tổng doanh thu: ", "");

                        totalLabelCell.Font.Bold = true;
                        totalValueCell.Font.Bold = true;
                    }

                    // 7. AutoFit cột và lưu file
                    Excel.Range dataRange = excelWorksheet.UsedRange;
                    dataRange.Columns.AutoFit();

                    excelWorkbook.SaveAs(saveFileDialog.FileName, Excel.XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing, false, false, Excel.XlSaveAsAccessMode.xlNoChange, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                    excelWorkbook.Close(true, Type.Missing, Type.Missing);
                    excelApp.Quit();

                    MessageBox.Show("Xuất file Excel thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xuất Excel: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    // Giải phóng các đối tượng COM
                    if (excelWorkbook != null) System.Runtime.InteropServices.Marshal.ReleaseComObject(excelWorkbook);
                    if (excelApp != null) System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);
                }
            }
        }

        private void InBC_Click(object sender, EventArgs e)
        {
            if (dgvBaoCao.Rows.Count == 0 || dgvBaoCao.DataSource == null)
            {
                MessageBox.Show("Không có dữ liệu để in báo cáo.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Thiết lập đối tượng in
            printDoc.DefaultPageSettings.Landscape = true; // Đặt khổ ngang
            printDoc.PrintPage += new PrintPageEventHandler(PrintDoc_PrintPage);
            rowsPerPage = 0; // Đặt lại bộ đếm hàng

            // Hiển thị hộp thoại xem trước in
            printPreviewDialog.Document = printDoc;
            printPreviewDialog.ShowDialog();
        }

        private void PrintDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            int pageHeight = e.PageSettings.PaperSize.Height - e.PageSettings.Margins.Top - e.PageSettings.Margins.Bottom;
            int pageWidth = e.PageSettings.PaperSize.Width - e.PageSettings.Margins.Left - e.PageSettings.Margins.Right;

            Font fontHeader = new Font("Arial", 14, FontStyle.Bold);
            Font fontData = new Font("Arial", 10);
            int yPos = e.MarginBounds.Top;
            int xPos = e.MarginBounds.Left;
            int lineHeight = (int)fontData.GetHeight(g) + 5;

            // TIÊU ĐỀ BÁO CÁO
            string title = "BÁO CÁO THỐNG KÊ - " + cbLoaiBC.Text.ToUpper();
            g.DrawString(title, fontHeader, Brushes.Black, xPos, yPos);
            yPos += lineHeight * 2;

            // VẼ CÁC CỘT
            int startY = yPos;
            int totalWidth = 0;

            // Tính tổng chiều rộng của các cột
            for (int i = 0; i < dgvBaoCao.ColumnCount; i++)
            {
                totalWidth += dgvBaoCao.Columns[i].Width;
            }

            // VẼ HEADER VÀ TÍNH ĐỘ RỘNG CỘT
            int currentX = xPos;
            int columnWidth;

            for (int i = 0; i < dgvBaoCao.ColumnCount; i++)
            {
                // Điều chỉnh độ rộng cột theo tỷ lệ của DataGridView
                columnWidth = (int)(((float)dgvBaoCao.Columns[i].Width / totalWidth) * pageWidth);

                // Vẽ đường viền Header
                g.DrawRectangle(Pens.Black, currentX, startY, columnWidth, lineHeight);

                // Vẽ Text Header
                g.DrawString(dgvBaoCao.Columns[i].HeaderText, fontData, Brushes.Black,
                             currentX + 2, startY + 2);

                currentX += columnWidth;
            }
            yPos = startY + lineHeight; // Di chuyển xuống hàng dữ liệu đầu tiên

            // VẼ DỮ LIỆU CỦA DATAGRIDVIEW
            while (rowsPerPage < dgvBaoCao.RowCount)
            {
                DataGridViewRow row = dgvBaoCao.Rows[rowsPerPage];
                currentX = xPos;

                // Kiểm tra xem dòng dữ liệu có vượt quá chiều cao trang không
                if (yPos + lineHeight > e.MarginBounds.Bottom)
                {
                    e.HasMorePages = true;
                    return; // Dừng lại để in trang hiện tại
                }

                // Vẽ dữ liệu từng ô
                for (int i = 0; i < dgvBaoCao.ColumnCount; i++)
                {
                    columnWidth = (int)(((float)dgvBaoCao.Columns[i].Width / totalWidth) * pageWidth);

                    // Vẽ đường viền ô
                    g.DrawRectangle(Pens.Black, currentX, yPos, columnWidth, lineHeight);

                    // Vẽ Text dữ liệu
                    string cellValue = row.Cells[i].Value?.ToString() ?? "";
                    g.DrawString(cellValue, fontData, Brushes.Black, currentX + 2, yPos + 2);

                    currentX += columnWidth;
                }

                yPos += lineHeight;
                rowsPerPage++;
            }

            // Nếu thoát vòng lặp, tức là đã in hết dữ liệu
            e.HasMorePages = false;
            rowsPerPage = 0; // Đặt lại cho lần in tiếp theo
        }

        private void btLamMoi_Click(object sender, EventArgs e)
        {
            ClearData();
            LoadLoaiBaoCao();
        }
    }
}
