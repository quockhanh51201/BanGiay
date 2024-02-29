using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class frm_DanhMucSanPham : Form
    {
        //
        SanPhamBLL sanPhamBLL = new SanPhamBLL();
        //
        public frm_DanhMucSanPham()
        {
            InitializeComponent();
        }

        private void frm_DanhMucSanPham_Load(object sender, EventArgs e)
        {
            loadDanhMucSanPham();
        }
        private void loadDanhMucSanPham()
        {
            tbl_danhMuc.DataSource = sanPhamBLL.GetSanPhams();
        }

        private void btn_timDM_Click(object sender, EventArgs e)
        {
            string search = txt_timKiem.Text.Trim();
            if (search == "")
            {
                tbl_danhMuc.DataSource = null;
                loadDanhMucSanPham();
            }    
            if (radioButtonMaSP.Checked)
            {
                if (search == "")
                {
                    tbl_danhMuc.DataSource = null;
                    loadDanhMucSanPham();
                }
                else
                {
                    tbl_danhMuc.DataSource = null;
                    SanPhamDTO result = sanPhamBLL.GetSanPhamById(search);
                    List<SanPhamDTO> list = new List<SanPhamDTO> { result };
                    tbl_danhMuc.DataSource = list;
                }
            }
            if (radioButtonTenSP.Checked)
            {
                if (search == "")
                {
                    tbl_danhMuc.DataSource = null;
                    loadDanhMucSanPham();
                }
                else
                {
                    tbl_danhMuc.DataSource = null;
                    tbl_danhMuc.DataSource = sanPhamBLL.GetSanPhamByTen(search);
                }
            }
            if (radioButtonGiaSP.Checked)
            {
                // try cacth khi nhập sai dữ liệu
                if (search == "")
                {
                    tbl_danhMuc.DataSource = null;
                    loadDanhMucSanPham();
                }
                else
                {
                    tbl_danhMuc.DataSource = null;
                    tbl_danhMuc.DataSource = sanPhamBLL.GetSanPhamByGia(double.Parse(search));
                }
            }
            if (radioButtonMauSac.Checked)
            {
                if (search == "")
                {
                    tbl_danhMuc.DataSource = null;
                    loadDanhMucSanPham();
                }
                else
                {
                    tbl_danhMuc.DataSource = null;
                    tbl_danhMuc.DataSource = sanPhamBLL.GetSanPhamByMauSac(search);
                }
            }
            if (radioButtonMaLoai.Checked)
            {
                if (search == "")
                {
                    tbl_danhMuc.DataSource = null;
                    loadDanhMucSanPham();
                }
                else
                {
                    tbl_danhMuc.DataSource = null;
                    tbl_danhMuc.DataSource = sanPhamBLL.GetSanPhamByMaLoai(search);
                }
            }
        }

        private void tbl_danhMuc_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy dữ liệu từ các ô trong hàng đã chọn
                DataGridViewRow selectedRow = tbl_danhMuc.Rows[e.RowIndex];
                string maSanPham = selectedRow.Cells["MaSanPham"].Value.ToString();
                frm_SanPham frmSP = new frm_SanPham(maSanPham);
                frmSP.ShowDialog();
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            // Hiển thị hộp thoát
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Kiểm tra xem người dùng đã xác nhận thoát hay không
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            frm_SanPham frmSP = new frm_SanPham();
            frmSP.ShowDialog();
        }

        private void btn_reload_Click(object sender, EventArgs e)
        {
            tbl_danhMuc.DataSource = null;
            loadDanhMucSanPham();
        }
    }
}
