using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThietKetControl;

namespace App
{
    public partial class frm_DonHang : Form
    {
        DonHangBLL BLL = new DonHangBLL();

        public frm_DonHang()
        {
            InitializeComponent();
            tbl_DH.DataSource = BLL.LoadDonHangs();
            load();


        }

        public void load()
        {
            txt_maDonHang.Clear();
            txt_maKH.Clear();
            txt_ngayDat.Clear();
            cbo_trangThai.Text = "  ";
            cbo_Timkiem.Text = "  ";

            tbl_DH.DataSource = BLL.LoadDonHangs();

            txt_Tong.Text = BLL.TinhTongSoLuongDonHang().ToString();

            txt_dangcho.Text = BLL.TinhSoLuongDonHangTheoTrangThai("Đang chờ duyệt").ToString();
            txt_danggiao.Text = BLL.TinhSoLuongDonHangTheoTrangThai("Đang giao hàng").ToString();
            txt_thanhcong.Text = BLL.TinhSoLuongDonHangTheoTrangThai("Giao hàng thành công").ToString();
            txt_thatbai.Text = BLL.TinhSoLuongDonHangTheoTrangThai("Giao hàng thất bại").ToString();
        }

        private void frm_DonHang_Load(object sender, EventArgs e)
        {
            load();

        }

        private void btn_sửa_Click(object sender, EventArgs e)
        {


            if (txt_maDonHang.Text == null)
            {
                MessageBox.Show("Vui lòng chọn đơn hàng.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txt_maDonHang.Text) ||
                string.IsNullOrWhiteSpace(txt_maKH.Text) ||
                string.IsNullOrWhiteSpace(txt_ngayDat.Text) ||
                string.IsNullOrWhiteSpace(cbo_trangThai.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }
            else
            {


                try
                {

                    tbl_DH.DataSource = BLL.SuaTrangThaiDonHang(txt_maDonHang.Text, cbo_trangThai.SelectedItem.ToString());

                    MessageBox.Show("Cập nhật thành công");
                    load();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sửa không thành công. Lỗi: " + ex.Message);
                    return;
                }
            }

        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xoá không?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                try
                {
                    tbl_DH.DataSource = BLL.Delete(txt_maDonHang.Text);
                    MessageBox.Show("Xoá thành công");
                    load();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xoá không thành công. Lỗi: " + ex.Message);
                    return;
                }
            }
            else
            {
                return;
            }

        }

        private void btn_timLoai_Click(object sender, EventArgs e)
        {
            
            tbl_DH.DataSource = BLL.GetDonHangsByTrangThai(cbo_Timkiem.SelectedItem.ToString());
        }

        private void tbl_DH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                txt_maKH.Text = tbl_DH.Rows[e.RowIndex].Cells["MaKhachHang"].Value.ToString();
                txt_maDonHang.Text = tbl_DH.Rows[e.RowIndex].Cells["MaDonHang"].Value.ToString();
                cbo_trangThai.SelectedItem = tbl_DH.Rows[e.RowIndex].Cells["TrangThai"].Value.ToString();
                txt_ngayDat.Text = tbl_DH.Rows[e.RowIndex].Cells["NgayDatHang"].Value.ToString();

                tbl_SP.DataSource = BLL.GetChiTietDonHangByMaDonHang(txt_maDonHang.Text);
            }
            else
            {
                return;
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            load();
        }

        private void tbl_loaiSP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
