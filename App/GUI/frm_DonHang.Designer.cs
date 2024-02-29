namespace App
{
    partial class frm_DonHang
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
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_trangThai = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_timLoai = new System.Windows.Forms.Button();
            this.tbl_DH = new System.Windows.Forms.DataGridView();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sửa = new System.Windows.Forms.Button();
            this.txt_maKH = new System.Windows.Forms.TextBox();
            this.txt_maDonHang = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbl_SP = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbo_Timkiem = new System.Windows.Forms.ComboBox();
            this.txt_thanhcong = new System.Windows.Forms.TextBox();
            this.txt_thatbai = new System.Windows.Forms.TextBox();
            this.txt_danggiao = new System.Windows.Forms.TextBox();
            this.txt_dangcho = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Tong = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_ngayDat = new System.Windows.Forms.TextBox();
            this.btn_reset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_DH)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_SP)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 64;
            this.label5.Text = "Ngày đặt";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(408, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 45);
            this.label1.TabIndex = 48;
            this.label1.Text = "ĐƠN HÀNG";
            // 
            // cbo_trangThai
            // 
            this.cbo_trangThai.FormattingEnabled = true;
            this.cbo_trangThai.Items.AddRange(new object[] {
            "Đang chờ duyệt",
            "Đang giao hàng",
            "Giao hàng thành công",
            "Giao hàng thất bại"});
            this.cbo_trangThai.Location = new System.Drawing.Point(416, 144);
            this.cbo_trangThai.Name = "cbo_trangThai";
            this.cbo_trangThai.Size = new System.Drawing.Size(142, 21);
            this.cbo_trangThai.TabIndex = 65;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(314, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 62;
            this.label4.Text = "Trạng thái";
            // 
            // btn_timLoai
            // 
            this.btn_timLoai.Location = new System.Drawing.Point(275, 221);
            this.btn_timLoai.Name = "btn_timLoai";
            this.btn_timLoai.Size = new System.Drawing.Size(54, 23);
            this.btn_timLoai.TabIndex = 61;
            this.btn_timLoai.Text = "Tìm";
            this.btn_timLoai.UseVisualStyleBackColor = true;
            this.btn_timLoai.Click += new System.EventHandler(this.btn_timLoai_Click);
            // 
            // tbl_DH
            // 
            this.tbl_DH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl_DH.Location = new System.Drawing.Point(4, 265);
            this.tbl_DH.Name = "tbl_DH";
            this.tbl_DH.Size = new System.Drawing.Size(517, 293);
            this.tbl_DH.TabIndex = 59;
            this.tbl_DH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbl_DH_CellClick);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(630, 92);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(99, 48);
            this.btn_xoa.TabIndex = 58;
            this.btn_xoa.Text = "Xoá";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sửa
            // 
            this.btn_sửa.Location = new System.Drawing.Point(630, 180);
            this.btn_sửa.Name = "btn_sửa";
            this.btn_sửa.Size = new System.Drawing.Size(99, 48);
            this.btn_sửa.TabIndex = 57;
            this.btn_sửa.Text = "Cập nhật";
            this.btn_sửa.UseVisualStyleBackColor = true;
            this.btn_sửa.Click += new System.EventHandler(this.btn_sửa_Click);
            // 
            // txt_maKH
            // 
            this.txt_maKH.Enabled = false;
            this.txt_maKH.Location = new System.Drawing.Point(416, 107);
            this.txt_maKH.Name = "txt_maKH";
            this.txt_maKH.Size = new System.Drawing.Size(142, 20);
            this.txt_maKH.TabIndex = 54;
            // 
            // txt_maDonHang
            // 
            this.txt_maDonHang.Enabled = false;
            this.txt_maDonHang.Location = new System.Drawing.Point(119, 107);
            this.txt_maDonHang.Name = "txt_maDonHang";
            this.txt_maDonHang.Size = new System.Drawing.Size(142, 20);
            this.txt_maDonHang.TabIndex = 53;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(314, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 52;
            this.label3.Text = "Mã khách hàng ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 51;
            this.label2.Text = "Mã đơn hàng";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbl_SP);
            this.groupBox1.Location = new System.Drawing.Point(527, 246);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(569, 317);
            this.groupBox1.TabIndex = 67;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết đơn hàng";
            // 
            // tbl_SP
            // 
            this.tbl_SP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl_SP.Location = new System.Drawing.Point(6, 19);
            this.tbl_SP.Name = "tbl_SP";
            this.tbl_SP.Size = new System.Drawing.Size(557, 280);
            this.tbl_SP.TabIndex = 0;
            // 
            // label8
            // 
            this.groupBox2.Controls.Add(this.txt_thanhcong);
            this.groupBox2.Controls.Add(this.txt_thatbai);
            this.groupBox2.Controls.Add(this.txt_danggiao);
            this.groupBox2.Controls.Add(this.txt_dangcho);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txt_Tong);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(776, 66);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(289, 178);
            this.groupBox2.TabIndex = 68;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thống kê";
            // 
            // cbo_Timkiem
            // 
            this.cbo_Timkiem.FormattingEnabled = true;
            this.cbo_Timkiem.Items.AddRange(new object[] {
            "Đang chờ duyệt",
            "Đang giao hàng",
            "Giao hàng thành công",
            "Giao hàng thất bại"});
            this.cbo_Timkiem.Location = new System.Drawing.Point(95, 221);
            this.cbo_Timkiem.Name = "cbo_Timkiem";
            this.cbo_Timkiem.Size = new System.Drawing.Size(157, 21);
            this.cbo_Timkiem.TabIndex = 72;
            // 
            // txt_thanhcong
            // 
            this.txt_thanhcong.Enabled = false;
            this.txt_thanhcong.Location = new System.Drawing.Point(161, 114);
            this.txt_thanhcong.Name = "txt_thanhcong";
            this.txt_thanhcong.Size = new System.Drawing.Size(100, 20);
            this.txt_thanhcong.TabIndex = 9;
            // 
            // txt_thatbai
            // 
            this.txt_thatbai.Enabled = false;
            this.txt_thatbai.Location = new System.Drawing.Point(161, 144);
            this.txt_thatbai.Name = "txt_thatbai";
            this.txt_thatbai.Size = new System.Drawing.Size(100, 20);
            this.txt_thatbai.TabIndex = 8;
            // 
            // txt_danggiao
            // 
            this.txt_danggiao.Enabled = false;
            this.txt_danggiao.Location = new System.Drawing.Point(161, 86);
            this.txt_danggiao.Name = "txt_danggiao";
            this.txt_danggiao.Size = new System.Drawing.Size(100, 20);
            this.txt_danggiao.TabIndex = 7;
            // 
            // txt_dangcho
            // 
            this.txt_dangcho.Enabled = false;
            this.txt_dangcho.Location = new System.Drawing.Point(161, 56);
            this.txt_dangcho.Name = "txt_dangcho";
            this.txt_dangcho.Size = new System.Drawing.Size(100, 20);
            this.txt_dangcho.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 144);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Giao hàng thất bại";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Giao hàng thành công";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Đang giao hàng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Đang chờ duyệt";
            // 
            // txt_Tong
            // 
            this.txt_Tong.Enabled = false;
            this.txt_Tong.Location = new System.Drawing.Point(161, 28);
            this.txt_Tong.Name = "txt_Tong";
            this.txt_Tong.Size = new System.Drawing.Size(100, 20);
            this.txt_Tong.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tổng đơn hàng";
            // 
            // txt_ngayDat
            // 
            this.txt_ngayDat.Enabled = false;
            this.txt_ngayDat.Location = new System.Drawing.Point(119, 149);
            this.txt_ngayDat.Name = "txt_ngayDat";
            this.txt_ngayDat.Size = new System.Drawing.Size(143, 20);
            this.txt_ngayDat.TabIndex = 70;
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(446, 219);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 23);
            this.btn_reset.TabIndex = 73;
            this.btn_reset.Text = "Làm mới";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // frm_DonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 568);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.cbo_Timkiem);
            this.Controls.Add(this.txt_ngayDat);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbo_trangThai);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_timLoai);
            this.Controls.Add(this.tbl_DH);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sửa);
            this.Controls.Add(this.txt_maKH);
            this.Controls.Add(this.txt_maDonHang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "frm_DonHang";
            this.Text = "frm_DonHang";
            this.Load += new System.EventHandler(this.frm_DonHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_DH)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_SP)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbo_trangThai;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_timLoai;
        private System.Windows.Forms.DataGridView tbl_DH;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sửa;
        private System.Windows.Forms.TextBox txt_maKH;
        private System.Windows.Forms.TextBox txt_maDonHang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView tbl_SP;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_thanhcong;
        private System.Windows.Forms.TextBox txt_thatbai;
        private System.Windows.Forms.TextBox txt_danggiao;
        private System.Windows.Forms.TextBox txt_dangcho;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Tong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_ngayDat;
        private System.Windows.Forms.ComboBox cbo_Timkiem;
        private System.Windows.Forms.Button btn_reset;
    }
}