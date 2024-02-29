using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;
using ThietKetControl;

namespace App
{
    public partial class frm_KhachHang : Form
    {
        KhachHangBLL BLL = new KhachHangBLL();

        public frm_KhachHang()
        {
            InitializeComponent();
            tbl_KH.DataSource = BLL.LoadData();

            txt_tongSoKH.Text = BLL.Sum().ToString();

        }


        public void load()
        {
            tbl_KH.DataSource = BLL.LoadData();
            txt_tongSoKH.Text = BLL.Sum().ToString();
            txt_maKH.Clear();
            txt_tenDem.Clear();
            txt_ten.Clear();
            txt_email.Clear();
            txt_sdt.Clear();
            txt_diaChi.Clear();
            txt_thanhPho.Clear();
            txt_tinhThanh.Clear();
            txt_mabuudien.Clear();

            txt_tenDem.Focus();



        }


        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xoá không?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                try
                {
                    tbl_KH.DataSource = BLL.Delete(txt_maKH.Text);
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



        private void tbl_KH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                txt_maKH.Text = tbl_KH.Rows[e.RowIndex].Cells["MaKhachHang"].Value.ToString();
                txt_tenDem.Text = tbl_KH.Rows[e.RowIndex].Cells["HoTenDem"].Value.ToString();
                txt_ten.Text = tbl_KH.Rows[e.RowIndex].Cells["Ten"].Value.ToString();
                txt_email.Text = tbl_KH.Rows[e.RowIndex].Cells["Email"].Value.ToString();
                txt_sdt.Text = tbl_KH.Rows[e.RowIndex].Cells["SoDienThoai"].Value.ToString();
                txt_diaChi.Text = tbl_KH.Rows[e.RowIndex].Cells["DiaChi"].Value.ToString();
                txt_thanhPho.Text = tbl_KH.Rows[e.RowIndex].Cells["ThanhPho"].Value.ToString();
                txt_tinhThanh.Text = tbl_KH.Rows[e.RowIndex].Cells["TinhThanh"].Value.ToString();
                txt_mabuudien.Text = tbl_KH.Rows[e.RowIndex].Cells["MaBuuDien"].Value.ToString();

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

        private void btn_sửa_Click(object sender, EventArgs e)
        {


            if (txt_maKH.Text == null)
            {
                MessageBox.Show("Vui lòng chọn khách hàng.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txt_ten.Text) || string.IsNullOrWhiteSpace(txt_tenDem.Text) ||
                string.IsNullOrWhiteSpace(txt_thanhPho.Text) || string.IsNullOrWhiteSpace(txt_sdt.Text) ||
                string.IsNullOrWhiteSpace(txt_email.Text) || string.IsNullOrWhiteSpace(txt_mabuudien.Text) ||
                string.IsNullOrWhiteSpace(txt_diaChi.Text) || string.IsNullOrWhiteSpace(txt_tinhThanh.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }
            else
            {


                try
                {

                    tbl_KH.DataSource = BLL.Update2(txt_tenDem.Text,
                        txt_ten.Text,
                        txt_email.Text,
                        txt_sdt.Text,
                        txt_diaChi.Text,
                        txt_thanhPho.Text,
                        txt_tinhThanh.Text,
                        txt_mabuudien.Text,
                        txt_maKH.Text);

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

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_ten.Text) || string.IsNullOrWhiteSpace(txt_tenDem.Text) ||
                string.IsNullOrWhiteSpace(txt_thanhPho.Text) || string.IsNullOrWhiteSpace(txt_sdt.Text) ||
                string.IsNullOrWhiteSpace(txt_email.Text) || string.IsNullOrWhiteSpace(txt_mabuudien.Text) ||
                string.IsNullOrWhiteSpace(txt_diaChi.Text) || string.IsNullOrWhiteSpace(txt_tinhThanh.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }
            else { 
                try
            {
                    tbl_KH.DataSource = BLL.Insert(txt_maKH.Text,
                    txt_tenDem.Text,
                    txt_ten.Text,
                    txt_email.Text,
                    txt_sdt.Text,
                    txt_diaChi.Text,
                    txt_thanhPho.Text,
                    txt_tinhThanh.Text,
                    txt_mabuudien.Text);
                MessageBox.Show("Thêm thành công");
                load();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                {
                    MessageBox.Show("Mã khách hàng đã được sử dụng");
                }
                else
                {

                    MessageBox.Show("Database error: " + ex.Message);
                }
                }

           
            }
        }

        private void btn_timLoai_Click(object sender, EventArgs e)
        {
            if(txt_timKiem.Text==null)
            {
                load();
            }
            tbl_KH.DataSource = BLL.Search(txt_timKiem.Text);
        }

        private void frm_KhachHang_Load(object sender, EventArgs e)
        {
            tbl_KH.DataSource =  BLL.LoadData();
        }
    }
}
