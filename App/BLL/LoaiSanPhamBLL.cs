using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class LoaiSanPhamBLL
    {
        DB_BANGIAYDataContext data;
        public LoaiSanPhamBLL() { data = new DB_BANGIAYDataContext(); }
        public List<LoaiSanPham> GetLoaiSanPhams()
        {
            return data.LoaiSanPhams.Select(loai => loai).ToList<LoaiSanPham>();
        }
    }
}
