using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongTro
{
    internal class TaiKhoan
    {
        public int ID { get; set; }
        public string TenDangNhap { get; set; } = string.Empty;
        public string MatKhau { get; set; } = string.Empty;
        public string VaiTro { get; set; } = string.Empty;

        public TaiKhoan()
        {

        }
        public TaiKhoan(int iD, string tenDangNhap, string matKhau, string vaiTro)
        {
            ID = iD;
            TenDangNhap = tenDangNhap;
            MatKhau = matKhau;
            VaiTro = vaiTro;
        }
    }
}
