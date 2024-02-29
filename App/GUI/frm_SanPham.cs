using BLL;
using DTO;
using GUI.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class frm_SanPham : Form
    {
        SanPhamBLL sanPhamBLL = new SanPhamBLL();
        LoaiSanPhamBLL loaiSanPhamBLL = new LoaiSanPhamBLL();
        //
        private string maSanPham;
        //
        public frm_SanPham()
        {
            InitializeComponent();
        }
        public frm_SanPham(string masp)
        {
            InitializeComponent();
            maSanPham = masp;
        }
        private void frm_SanPham_Load(object sender, EventArgs e)
        {
            if (maSanPham != null)
            {
                LoadSanPham(maSanPham);
                readOnly();
            }
            else
            {
                readOnly();
                ThemSanPham();
            }
            
        }

        private void ThemSanPham()
        {
            Console.WriteLine("a");
            txt_Gia.ReadOnly = false;
            txt_kichThuoc.ReadOnly = false;
            txt_tenSP.ReadOnly = false;
            txt_mau.ReadOnly = false;
            txt_moTa.ReadOnly = false;

            cbo_loaiSP.DataSource = null;

            cbo_loaiSP.DataSource = loaiSanPhamBLL.GetLoaiSanPhams();
            cbo_loaiSP.DisplayMember = "MaLoaiSanPham";

            //
            btn_ChonHinh.Enabled = true;
        }

        private void loadAnh(string path)
        {
            try
            {
                string fullPath =  Path.Combine(Application.StartupPath, "Resources", path); // Đường dẫn đầy đủ tới tệp hình ảnh
                Image image = Image.FromFile(fullPath);
                pic_SanPham.Image = image;
            }
            catch (Exception ex)
            {
                // Xử lý lỗi (ví dụ: hiển thị thông báo lỗi)
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        private void LoadSanPham(string ma)
        {
            SanPhamDTO sanpham =  sanPhamBLL.GetSanPhamById(ma);
            txt_maSP.Text = sanpham.MaSanPham;
            txt_tenSP.Text = sanpham.TenSanPham;
            txt_Gia.Text = sanpham.Gia.ToString();
            txt_kichThuoc.Text = sanpham.KichThuoc;
            txt_mau.Text = sanpham.TenMauSac;
            txt_moTa.Text =sanpham.MoTa;
            cbo_loaiSP.Text = sanpham.MaLoaiSanPham;
            txt_tenanh.Text = sanpham.HinhAnh;
            loadAnh(sanpham.HinhAnh);

        }
        private void readOnly()
        {
            txt_Gia.ReadOnly = true;
            txt_kichThuoc.ReadOnly = true;
            txt_maSP.ReadOnly = true;
            txt_tenSP.ReadOnly = true;
            txt_mau.ReadOnly = true;
            txt_moTa.ReadOnly = true;
            txt_tenanh.ReadOnly = true;
            //
            cbo_loaiSP.DataSource = null;
            //
            btn_ChonHinh.Enabled = false;
        }

        private void btn_sửa_Click(object sender, EventArgs e)
        {
            txt_Gia.ReadOnly = false;
            txt_kichThuoc.ReadOnly = false;
            txt_tenSP.ReadOnly = false;
            txt_mau.ReadOnly = false;
            txt_moTa.ReadOnly = false;

            cbo_loaiSP.DataSource = null;   

            cbo_loaiSP.DataSource = loaiSanPhamBLL.GetLoaiSanPhams();
            cbo_loaiSP.DisplayMember = "MaLoaiSanPham";

            //
            btn_ChonHinh.Enabled = true;

        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (maSanPham != null)
            {
                DialogResult result = MessageBox.Show("Bạn có muốn lưu thay đổi không?", "Xác nhận lưu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    SanPhamDTO sanpham = new SanPhamDTO();
                    sanpham.MaSanPham = txt_maSP.Text;
                    sanpham.TenSanPham = txt_tenSP.Text;
                    sanpham.MoTa = txt_moTa.Text;
                    sanpham.TenMauSac = txt_mau.Text;
                    sanpham.MaLoaiSanPham = cbo_loaiSP.Text;
                    sanpham.KichThuoc = txt_kichThuoc.Text;
                    sanpham.Gia = double.Parse(txt_Gia.Text);
                    sanpham.HinhAnh = txt_tenanh.Text;
                    sanPhamBLL.UpdateSanPham(sanpham);
                    readOnly();

                    LoadSanPham(sanpham.MaSanPham);
                }
            }
            else // thêm
            {
                DialogResult result = MessageBox.Show("Bạn có muốn thêm không?", "Xác nhận thêm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    SanPhamDTO sanpham = new SanPhamDTO();
                    sanpham.MaSanPham = txt_maSP.Text;
                    sanpham.TenSanPham = txt_tenSP.Text;
                    sanpham.MoTa = txt_moTa.Text;
                    sanpham.TenMauSac = txt_mau.Text;
                    sanpham.MaLoaiSanPham = cbo_loaiSP.Text;
                    sanpham.KichThuoc = txt_kichThuoc.Text;
                    sanpham.Gia = double.Parse(txt_Gia.Text);
                    sanpham.HinhAnh = txt_tenanh.Text;
                    sanPhamBLL.InsertSanPham(sanpham);
                    readOnly();
                }
            }
            
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            // Hiển thị hộp thoát
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Kiểm tra xem người dùng đã xác nhận thoát hay không
            if (result == DialogResult.Yes)
            {
                this.Close();
            } 
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xóa sản phẩm không", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                sanPhamBLL.XoaSanPham(txt_maSP.Text);
            }
        }

        private void btn_ChonHinh_Click(object sender, EventArgs e)
        {
            // nếu chọn 2 hình có cùng tên thì sao khi mà lưu vào trong resource lỗi
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Hình Ảnh (*.jpg; *.jpeg; *.png; *.gif)|*.jpg;*.jpeg;*.png;*.gif",
                Title = "Chọn Hình Ảnh",
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFileName = openFileDialog.FileName;
                int lastIndex = selectedFileName.LastIndexOf('\\');

                if (lastIndex >= 0)
                {
                    string fileName = selectedFileName.Substring(lastIndex + 1);
                    txt_tenanh.Text = fileName;
                    // Hiển thị hình ảnh trong PictureBox
                    pic_SanPham.Image = new System.Drawing.Bitmap(selectedFileName);
                    string fullPath = Path.Combine(Application.StartupPath, "Resources"); // Đường dẫn đầy đủ tới tệp hình ảnh
                    AddImageToResources(selectedFileName, fullPath);
                }


            }
        }

        private void AddImageToResources(string imagePath, string resourceFolder)
        {
            // Đảm bảo rằng thư mục tài nguyên tồn tại
            if (!Directory.Exists(resourceFolder))
            {
                Directory.CreateDirectory(resourceFolder);
            }

            // Tạo đường dẫn đầy đủ cho tệp tài nguyên
            string resourcePath = Path.Combine(resourceFolder, Path.GetFileName(imagePath));

            // Copy hình ảnh đến thư mục tài nguyên
            File.Copy(imagePath, resourcePath);

            // Nếu bạn muốn thêm hình ảnh vào tài nguyên bằng cách sử dụng ResXResourceWriter, bạn cần sử dụng phương pháp tương ứng.
        }
    }
}
