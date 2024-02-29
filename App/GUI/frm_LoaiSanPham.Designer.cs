namespace App
{
    partial class frm_LoaiSanPham
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_tongSoSP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_timLoai = new System.Windows.Forms.Button();
            this.txt_timKiem = new System.Windows.Forms.TextBox();
            this.tbl_loaiSP = new System.Windows.Forms.DataGridView();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sửa = new System.Windows.Forms.Button();
            this.btn_luu = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.txt_tenLoai = new System.Windows.Forms.TextBox();
            this.txt_maLoai = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ngườiDùngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phânQuyềnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tạiTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMụcMànHìnhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nghiệpVụToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýSảnPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýKháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýĐơnHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýLoạiSảnPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýDanhMụcSảnPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýĐánhGiáVàNhânXétToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lịchSửGiaoDịchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.địaChỉGiaoHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hướngDẫnSửDụngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbo_danhMuc = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_loaiSP)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_tongSoSP
            // 
            this.txt_tongSoSP.Enabled = false;
            this.txt_tongSoSP.Location = new System.Drawing.Point(142, 249);
            this.txt_tongSoSP.Name = "txt_tongSoSP";
            this.txt_tongSoSP.Size = new System.Drawing.Size(61, 20);
            this.txt_tongSoSP.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "Tổng số loại SP";
            // 
            // btn_timLoai
            // 
            this.btn_timLoai.Location = new System.Drawing.Point(653, 111);
            this.btn_timLoai.Name = "btn_timLoai";
            this.btn_timLoai.Size = new System.Drawing.Size(75, 23);
            this.btn_timLoai.TabIndex = 43;
            this.btn_timLoai.Text = "Tìm";
            this.btn_timLoai.UseVisualStyleBackColor = true;
            this.btn_timLoai.Click += new System.EventHandler(this.btn_timLoai_Click);
            // 
            // txt_timKiem
            // 
            this.txt_timKiem.Location = new System.Drawing.Point(473, 113);
            this.txt_timKiem.Name = "txt_timKiem";
            this.txt_timKiem.Size = new System.Drawing.Size(174, 20);
            this.txt_timKiem.TabIndex = 42;
            this.txt_timKiem.TextChanged += new System.EventHandler(this.txt_timKiem_TextChanged);
            // 
            // tbl_loaiSP
            // 
            this.tbl_loaiSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl_loaiSP.Location = new System.Drawing.Point(371, 157);
            this.tbl_loaiSP.Name = "tbl_loaiSP";
            this.tbl_loaiSP.Size = new System.Drawing.Size(429, 268);
            this.tbl_loaiSP.TabIndex = 41;
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(290, 369);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_xoa.TabIndex = 40;
            this.btn_xoa.Text = "Xoá";
            this.btn_xoa.UseVisualStyleBackColor = true;
            // 
            // btn_sửa
            // 
            this.btn_sửa.Location = new System.Drawing.Point(197, 369);
            this.btn_sửa.Name = "btn_sửa";
            this.btn_sửa.Size = new System.Drawing.Size(75, 23);
            this.btn_sửa.TabIndex = 39;
            this.btn_sửa.Text = "Sửa";
            this.btn_sửa.UseVisualStyleBackColor = true;
            // 
            // btn_luu
            // 
            this.btn_luu.Location = new System.Drawing.Point(103, 369);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(75, 23);
            this.btn_luu.TabIndex = 38;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.UseVisualStyleBackColor = true;
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(12, 369);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(75, 23);
            this.btn_them.TabIndex = 37;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // txt_tenLoai
            // 
            this.txt_tenLoai.Location = new System.Drawing.Point(142, 154);
            this.txt_tenLoai.Name = "txt_tenLoai";
            this.txt_tenLoai.Size = new System.Drawing.Size(142, 20);
            this.txt_tenLoai.TabIndex = 36;
            this.txt_tenLoai.TextChanged += new System.EventHandler(this.txt_tenLoai_TextChanged);
            // 
            // txt_maLoai
            // 
            this.txt_maLoai.Location = new System.Drawing.Point(142, 113);
            this.txt_maLoai.Name = "txt_maLoai";
            this.txt_maLoai.Size = new System.Drawing.Size(142, 20);
            this.txt_maLoai.TabIndex = 35;
            this.txt_maLoai.TextChanged += new System.EventHandler(this.txt_maLoai_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Tên loại";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Mã loại";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 31;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(130, 17);
            this.toolStripStatusLabel1.Text = "Xin chào người dùng ...";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.nghiệpVụToolStripMenuItem,
            this.thôngTinToolStripMenuItem,
            this.hướngDẫnSửDụngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 32;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ngườiDùngToolStripMenuItem,
            this.phânQuyềnToolStripMenuItem,
            this.tạiTàiKhoảnToolStripMenuItem,
            this.danhMụcMànHìnhToolStripMenuItem});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // ngườiDùngToolStripMenuItem
            // 
            this.ngườiDùngToolStripMenuItem.Name = "ngườiDùngToolStripMenuItem";
            this.ngườiDùngToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.ngườiDùngToolStripMenuItem.Text = "Người dùng";
            // 
            // phânQuyềnToolStripMenuItem
            // 
            this.phânQuyềnToolStripMenuItem.Name = "phânQuyềnToolStripMenuItem";
            this.phânQuyềnToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.phânQuyềnToolStripMenuItem.Text = "Phân quyền";
            // 
            // tạiTàiKhoảnToolStripMenuItem
            // 
            this.tạiTàiKhoảnToolStripMenuItem.Name = "tạiTàiKhoảnToolStripMenuItem";
            this.tạiTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.tạiTàiKhoảnToolStripMenuItem.Text = "Tạo tài khoản";
            // 
            // danhMụcMànHìnhToolStripMenuItem
            // 
            this.danhMụcMànHìnhToolStripMenuItem.Name = "danhMụcMànHìnhToolStripMenuItem";
            this.danhMụcMànHìnhToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.danhMụcMànHìnhToolStripMenuItem.Text = "Danh mục màn hình";
            // 
            // nghiệpVụToolStripMenuItem
            // 
            this.nghiệpVụToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýSảnPhẩmToolStripMenuItem,
            this.quảnLýKháchHàngToolStripMenuItem,
            this.quảnLýĐơnHàngToolStripMenuItem,
            this.quảnLýLoạiSảnPhẩmToolStripMenuItem,
            this.quảnLýDanhMụcSảnPhẩmToolStripMenuItem,
            this.quảnLýĐánhGiáVàNhânXétToolStripMenuItem,
            this.lịchSửGiaoDịchToolStripMenuItem,
            this.địaChỉGiaoHàngToolStripMenuItem});
            this.nghiệpVụToolStripMenuItem.Name = "nghiệpVụToolStripMenuItem";
            this.nghiệpVụToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.nghiệpVụToolStripMenuItem.Text = "Nghiệp vụ";
            // 
            // quảnLýSảnPhẩmToolStripMenuItem
            // 
            this.quảnLýSảnPhẩmToolStripMenuItem.Name = "quảnLýSảnPhẩmToolStripMenuItem";
            this.quảnLýSảnPhẩmToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.quảnLýSảnPhẩmToolStripMenuItem.Text = "Quản lý sản phẩm";
            // 
            // quảnLýKháchHàngToolStripMenuItem
            // 
            this.quảnLýKháchHàngToolStripMenuItem.Name = "quảnLýKháchHàngToolStripMenuItem";
            this.quảnLýKháchHàngToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.quảnLýKháchHàngToolStripMenuItem.Text = "Quản lý khách hàng";
            // 
            // quảnLýĐơnHàngToolStripMenuItem
            // 
            this.quảnLýĐơnHàngToolStripMenuItem.Name = "quảnLýĐơnHàngToolStripMenuItem";
            this.quảnLýĐơnHàngToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.quảnLýĐơnHàngToolStripMenuItem.Text = "Quản lý đơn hàng";
            // 
            // quảnLýLoạiSảnPhẩmToolStripMenuItem
            // 
            this.quảnLýLoạiSảnPhẩmToolStripMenuItem.Name = "quảnLýLoạiSảnPhẩmToolStripMenuItem";
            this.quảnLýLoạiSảnPhẩmToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.quảnLýLoạiSảnPhẩmToolStripMenuItem.Text = "Quản lý loại sản phẩm";
            // 
            // quảnLýDanhMụcSảnPhẩmToolStripMenuItem
            // 
            this.quảnLýDanhMụcSảnPhẩmToolStripMenuItem.Name = "quảnLýDanhMụcSảnPhẩmToolStripMenuItem";
            this.quảnLýDanhMụcSảnPhẩmToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.quảnLýDanhMụcSảnPhẩmToolStripMenuItem.Text = "Quản lý danh mục sản phẩm";
            // 
            // quảnLýĐánhGiáVàNhânXétToolStripMenuItem
            // 
            this.quảnLýĐánhGiáVàNhânXétToolStripMenuItem.Name = "quảnLýĐánhGiáVàNhânXétToolStripMenuItem";
            this.quảnLýĐánhGiáVàNhânXétToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.quảnLýĐánhGiáVàNhânXétToolStripMenuItem.Text = "Quản lý đánh giá và nhân xét";
            // 
            // lịchSửGiaoDịchToolStripMenuItem
            // 
            this.lịchSửGiaoDịchToolStripMenuItem.Name = "lịchSửGiaoDịchToolStripMenuItem";
            this.lịchSửGiaoDịchToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.lịchSửGiaoDịchToolStripMenuItem.Text = "Lịch sử giao dịch";
            // 
            // địaChỉGiaoHàngToolStripMenuItem
            // 
            this.địaChỉGiaoHàngToolStripMenuItem.Name = "địaChỉGiaoHàngToolStripMenuItem";
            this.địaChỉGiaoHàngToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.địaChỉGiaoHàngToolStripMenuItem.Text = "Địa chỉ giao hàng";
            // 
            // thôngTinToolStripMenuItem
            // 
            this.thôngTinToolStripMenuItem.Name = "thôngTinToolStripMenuItem";
            this.thôngTinToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.thôngTinToolStripMenuItem.Text = "Thông tin";
            // 
            // hướngDẫnSửDụngToolStripMenuItem
            // 
            this.hướngDẫnSửDụngToolStripMenuItem.Name = "hướngDẫnSửDụngToolStripMenuItem";
            this.hướngDẫnSửDụngToolStripMenuItem.Size = new System.Drawing.Size(125, 20);
            this.hướngDẫnSửDụngToolStripMenuItem.Text = "Hướng dẫn sử dụng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(267, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 45);
            this.label1.TabIndex = 30;
            this.label1.Text = "LOẠI SẢN PHẨM";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 46;
            this.label5.Text = "Danh mục";
            // 
            // cbo_danhMuc
            // 
            this.cbo_danhMuc.FormattingEnabled = true;
            this.cbo_danhMuc.Location = new System.Drawing.Point(142, 204);
            this.cbo_danhMuc.Name = "cbo_danhMuc";
            this.cbo_danhMuc.Size = new System.Drawing.Size(142, 21);
            this.cbo_danhMuc.TabIndex = 47;
            // 
            // frm_LoaiSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbo_danhMuc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_tongSoSP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_timLoai);
            this.Controls.Add(this.txt_timKiem);
            this.Controls.Add(this.tbl_loaiSP);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sửa);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.txt_tenLoai);
            this.Controls.Add(this.txt_maLoai);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.Name = "frm_LoaiSanPham";
            this.Text = "LoaiSanPham";
            this.Load += new System.EventHandler(this.frm_LoaiSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_loaiSP)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_tongSoSP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_timLoai;
        private System.Windows.Forms.TextBox txt_timKiem;
        private System.Windows.Forms.DataGridView tbl_loaiSP;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sửa;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.TextBox txt_tenLoai;
        private System.Windows.Forms.TextBox txt_maLoai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ngườiDùngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phânQuyềnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tạiTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhMụcMànHìnhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nghiệpVụToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýSảnPhẩmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýKháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýĐơnHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýLoạiSảnPhẩmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýDanhMụcSảnPhẩmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýĐánhGiáVàNhânXétToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lịchSửGiaoDịchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem địaChỉGiaoHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hướngDẫnSửDụngToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbo_danhMuc;
    }
}