using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SanPhamDTO
    {
        public string MaSanPham { get; set; }
        public string TenSanPham { get; set; }
        public string MoTa { get; set; }
        public double Gia { get; set; }
        public string KichThuoc { get; set; }
        public string TenMauSac { get; set; }
        public string HinhAnh { get; set; }
        public string MaLoaiSanPham { get; set; }
        //

        public SanPhamDTO() { }

        public SanPhamDTO(string maSanPham, string tenSanPham, string moTa, double gia, string kichThuoc, string tenMauSac, string hinhAnh, string maLoaiSanPham)
        {
            MaSanPham = maSanPham;
            TenSanPham = tenSanPham;
            MoTa = moTa;
            Gia = gia;
            KichThuoc = kichThuoc;
            TenMauSac = tenMauSac;
            HinhAnh = hinhAnh;
            MaLoaiSanPham = maLoaiSanPham;
        }
    }
}
