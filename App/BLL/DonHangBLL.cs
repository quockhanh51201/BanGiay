using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DonHangBLL
    {

        public DonHangBLL() { }

        private DB_BANGIAYDataContext db = new DB_BANGIAYDataContext();

        public List<DonHang> LoadDonHangs()
        {
            return db.DonHangs.Select(dh => dh).ToList<DonHang>();
        }

        public List<DonHang> Insert(string maDonHang, string maKhachHang, DateTime ngayDatHang, string trangThai)
        {
            DonHang donHang = new DonHang
            {
                MaDonHang = maDonHang,
                MaKhachHang = maKhachHang,
                NgayDatHang = ngayDatHang,
                TrangThai = trangThai
            };

            db.DonHangs.InsertOnSubmit(donHang);
            db.SubmitChanges();
            return db.DonHangs.ToList();
        }

        public List<DonHang> Update(string maDonHang, string maKhachHang, DateTime ngayDatHang, string trangThai)
        {
            DonHang donHang = db.DonHangs.FirstOrDefault(d => d.MaDonHang == maDonHang);
            if (donHang != null)
            {
                donHang.MaKhachHang = maKhachHang;
                donHang.NgayDatHang = ngayDatHang;
                donHang.TrangThai = trangThai;

                db.SubmitChanges();
            }
            return db.DonHangs.ToList();
        }

        public List<DonHang> Delete(string maDonHang)
        {
            DonHang donHang = db.DonHangs.FirstOrDefault(d => d.MaDonHang == maDonHang);
            if (donHang != null)
            {
                db.DonHangs.DeleteOnSubmit(donHang);
                db.SubmitChanges();
            }
            return db.DonHangs.ToList();
        }

        public List<ChiTietDonHang> GetChiTietDonHangByMaDonHang(string maDonHang)
        {
            var query = from chiTietDonHang in db.ChiTietDonHangs
                        where chiTietDonHang.MaDonHang == maDonHang
                        select chiTietDonHang;

            return query.ToList();
        }
        public List<DonHang> GetDonHangsByTrangThai(string trangThai)
        {
            var query = from donHang in db.DonHangs
                        where donHang.TrangThai == trangThai
                        select donHang;

            return query.ToList();
        }

        public int TinhTongSoLuongDonHang()
        {
            int tongSoLuongDonHang = db.DonHangs.Count();
            return tongSoLuongDonHang;
     
        
        }

        public int TinhSoLuongDonHangTheoTrangThai(string trangThai)
        {
            int soLuongDonHang = db.DonHangs.Count(dh => dh.TrangThai == trangThai);
            return soLuongDonHang;
        }

        public List<DonHang> SuaTrangThaiDonHang(string maDonHang, string trangThaiMoi)
        {
            DonHang donHang = db.DonHangs.FirstOrDefault(dh => dh.MaDonHang == maDonHang);
            if (donHang != null)
            {
                donHang.TrangThai = trangThaiMoi;
                db.SubmitChanges();
            }
            return db.DonHangs.ToList();
        }
    }
}
