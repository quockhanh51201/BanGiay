using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class KhachHangBLL
    {

         DB_BANGIAYDataContext db = new DB_BANGIAYDataContext(); 


        public List<KhachHang> LoadData()
        {
            return db.KhachHangs.Select(kh => kh).ToList<KhachHang>();
        }


       

        public List<KhachHang> Insert(string ma, string hoDem, string ten, string email, string sdt, string diachi, string thanhpho, string tinh, string mabuudien)
        {
            KhachHang kh = new KhachHang
            {
                MaKhachHang = ma,
                HoTenDem = hoDem,
                Ten = ten,
                Email = email,
                SoDienThoai = sdt,
                DiaChi = diachi,
                ThanhPho = thanhpho,
                TinhThanh = tinh,
                MaBuuDien = mabuudien
            };

            db.KhachHangs.InsertOnSubmit(kh);
            db.SubmitChanges();
            return db.KhachHangs.ToList();
        }

        public List<KhachHang> Delete(string ma)
        {
            KhachHang kh = db.KhachHangs.FirstOrDefault(k => k.MaKhachHang == ma);
            if (kh != null)
            {
                db.KhachHangs.DeleteOnSubmit(kh);
                db.SubmitChanges();
            }

            return db.KhachHangs.ToList();
        }

        //public List<KhachHang> Update(string hoDem, string ten, string email, string sdt, string diachi, string thanhpho, string tinh, string mabuudien, KhachHang_DTO kh)
        //{
        //    KhachHang khachHang = db.KhachHangs.FirstOrDefault(k => k.MaKhachHang == kh.MaKhachHang);
        //    if (khachHang != null)
        //    {
        //        khachHang.HoTenDem = hoDem;
        //        khachHang.Ten = ten;
        //        khachHang.Email = email;
        //        khachHang.SoDienThoai = sdt;
        //        khachHang.DiaChi = diachi;
        //        khachHang.ThanhPho = thanhpho;
        //        khachHang.TinhThanh = tinh;
        //        khachHang.MaBuuDien = mabuudien;

        //        db.SubmitChanges();
        //    }
        //    return db.KhachHangs.ToList();
        //}

        public int Sum()
        {
            return db.KhachHangs.Count();
        }

        public List<KhachHang> Search(string sdt)
        {
            var query = from kh in db.KhachHangs
                        where kh.SoDienThoai.Contains(sdt) 
                        select kh;

            return query.ToList();
        }
        public List<KhachHang> Update2(string hoDem, string ten, string email, string sdt, string diachi, string thanhpho, string tinh, string mabuudien, string ma)
        {
            KhachHang khachHang = db.KhachHangs.FirstOrDefault(k => k.MaKhachHang == ma);
            if (khachHang != null)
            {
                khachHang.HoTenDem = hoDem;
                khachHang.Ten = ten;
                khachHang.Email = email;
                khachHang.SoDienThoai = sdt;
                khachHang.DiaChi = diachi;
                khachHang.ThanhPho = thanhpho;
                khachHang.TinhThanh = tinh;
                khachHang.MaBuuDien = mabuudien;

                db.SubmitChanges();
            }
            return db.KhachHangs.ToList();

        }
    }
}
