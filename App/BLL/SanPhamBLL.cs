using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class SanPhamBLL
    {
        DB_BANGIAYDataContext data;
        public SanPhamBLL() 
        {
            data = new DB_BANGIAYDataContext();
        }

        public List<SanPhamDTO> GetSanPhams()
        {
            var query = from sp in data.SanPhams
                        select new SanPhamDTO
                        {
                            MaSanPham = sp.MaSanPham,
                            TenSanPham = sp.TenSanPham,
                            MoTa = sp.MoTa,
                            Gia = (double)sp.Gia,
                            KichThuoc = sp.KichThuoc,
                            TenMauSac = sp.TenMauSac,
                            MaLoaiSanPham = sp.MaLoaiSanPham,
                            HinhAnh = sp.HinhAnh
                        };

            return query.ToList<SanPhamDTO>();
        }
        public SanPhamDTO GetSanPhamById(string id)
        {
            var query = from sp in data.SanPhams
                        where sp.MaSanPham == id
                        select new SanPhamDTO
                        {
                            MaSanPham = sp.MaSanPham,
                            TenSanPham = sp.TenSanPham,
                            MoTa = sp.MoTa,
                            Gia = (double)sp.Gia,
                            KichThuoc = sp.KichThuoc,
                            TenMauSac = sp.TenMauSac,
                            MaLoaiSanPham = sp.MaLoaiSanPham,
                            HinhAnh = sp.HinhAnh
                        };

            return query.FirstOrDefault(); // Sử dụng FirstOrDefault để lấy sản phẩm đầu tiên hoặc null nếu không tìm thấy.
        }
        public List<SanPhamDTO> GetSanPhamByTen(string ten)
        {
            var query = from sp in data.SanPhams
                        where sp.TenSanPham.Contains(ten)
                        select new SanPhamDTO
                        {
                            MaSanPham = sp.MaSanPham,
                            TenSanPham = sp.TenSanPham,
                            MoTa = sp.MoTa,
                            Gia = (double)sp.Gia,
                            KichThuoc = sp.KichThuoc,
                            TenMauSac = sp.TenMauSac,
                            MaLoaiSanPham = sp.MaLoaiSanPham,
                            HinhAnh = sp.HinhAnh
                        };

            return query.ToList<SanPhamDTO>();
        }
        public List<SanPhamDTO> GetSanPhamByGia(double gia)
        {
            var query = from sp in data.SanPhams
                        where sp.Gia == (decimal)gia
                        select new SanPhamDTO
                        {
                            MaSanPham = sp.MaSanPham,
                            TenSanPham = sp.TenSanPham,
                            MoTa = sp.MoTa,
                            Gia = (double)sp.Gia,
                            KichThuoc = sp.KichThuoc,
                            TenMauSac = sp.TenMauSac,
                            MaLoaiSanPham = sp.MaLoaiSanPham,
                            HinhAnh = sp.HinhAnh
                        };

            return query.ToList<SanPhamDTO>();
        }
        public List<SanPhamDTO> GetSanPhamByMauSac(string mau)
        {
            var query = from sp in data.SanPhams
                        where sp.TenMauSac.Contains(mau)
                        select new SanPhamDTO
                        {
                            MaSanPham = sp.MaSanPham,
                            TenSanPham = sp.TenSanPham,
                            MoTa = sp.MoTa,
                            Gia = (double)sp.Gia,
                            KichThuoc = sp.KichThuoc,
                            TenMauSac = sp.TenMauSac,
                            MaLoaiSanPham = sp.MaLoaiSanPham,
                            HinhAnh = sp.HinhAnh
                        };

            return query.ToList<SanPhamDTO>();
        }
        public List<SanPhamDTO> GetSanPhamByMaLoai(string ma)
        {
            var query = from sp in data.SanPhams
                        where sp.MaLoaiSanPham == ma
                        select new SanPhamDTO
                        {
                            MaSanPham = sp.MaSanPham,
                            TenSanPham = sp.TenSanPham,
                            MoTa = sp.MoTa,
                            Gia = (double)sp.Gia,
                            KichThuoc = sp.KichThuoc,
                            TenMauSac = sp.TenMauSac,
                            MaLoaiSanPham = sp.MaLoaiSanPham,
                            HinhAnh = sp.HinhAnh
                        };

            return query.ToList<SanPhamDTO>();
        }
        public void UpdateSanPham(SanPhamDTO updatedSanPham)
        {
            // Tìm sản phẩm cần cập nhật dựa vào ID
            SanPham existingSanPham = data.SanPhams.FirstOrDefault(sp => sp.MaSanPham == updatedSanPham.MaSanPham);

            if (existingSanPham != null)
            {
                // Cập nhật các trường dữ liệu của sản phẩm
                existingSanPham.TenSanPham = updatedSanPham.TenSanPham;
                existingSanPham.MoTa = updatedSanPham.MoTa;
                existingSanPham.Gia = (decimal)updatedSanPham.Gia;
                existingSanPham.KichThuoc = updatedSanPham.KichThuoc;
                existingSanPham.TenMauSac = updatedSanPham.TenMauSac;
                existingSanPham.MaLoaiSanPham = updatedSanPham.MaLoaiSanPham;
                existingSanPham.HinhAnh = updatedSanPham.HinhAnh;
                data.SubmitChanges();
            }
            else
            {
                // Xử lý khi không tìm thấy sản phẩm cần cập nhật
            }

        }
        public void XoaSanPham(string maSanPham)
        {
            //try cach khóa chính khóa ngoại
            SanPham sanpham = data.SanPhams.FirstOrDefault(sp => sp.MaSanPham == maSanPham);
            if (sanpham != null)
            {
                data.SanPhams.DeleteOnSubmit(sanpham);
                data.SubmitChanges();
            }
        }
        public void InsertSanPham(SanPhamDTO newSanPham)
        {
            // Tạo một đối tượng mới SanPham dựa trên thông tin từ newSanPham
            SanPham sanPhamToAdd = new SanPham
            {
                MaSanPham = "",
                TenSanPham = newSanPham.TenSanPham,
                MoTa = newSanPham.MoTa,
                Gia = (decimal)newSanPham.Gia,
                KichThuoc = newSanPham.KichThuoc,
                TenMauSac = newSanPham.TenMauSac,
                MaLoaiSanPham = newSanPham.MaLoaiSanPham,
                HinhAnh = newSanPham.HinhAnh
            };
            data.SanPhams.InsertOnSubmit(sanPhamToAdd);
            data.SubmitChanges();
        }


    }
}
