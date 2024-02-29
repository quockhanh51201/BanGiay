namespace ThuVienControl
{
    partial class ctr_DangNhap
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.chckBox_hienThiMatKhau = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_DangNhap = new ThietKetControl.btnDoiMau();
            this.txt_user = new ThietKetControl.txt_KoCoKyTuDatBiet();
            this.txt_pass = new ThietKetControl.txt_password();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên đăng nhập ";
            // 
            // chckBox_hienThiMatKhau
            // 
            this.chckBox_hienThiMatKhau.AutoSize = true;
            this.chckBox_hienThiMatKhau.Location = new System.Drawing.Point(25, 98);
            this.chckBox_hienThiMatKhau.Name = "chckBox_hienThiMatKhau";
            this.chckBox_hienThiMatKhau.Size = new System.Drawing.Size(52, 13);
            this.chckBox_hienThiMatKhau.TabIndex = 2;
            this.chckBox_hienThiMatKhau.Text = "Mật khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "ĐĂNG NHẬP";
            // 
            // btn_DangNhap
            // 
            this.btn_DangNhap.Location = new System.Drawing.Point(117, 176);
            this.btn_DangNhap.Name = "btn_DangNhap";
            this.btn_DangNhap.Size = new System.Drawing.Size(75, 28);
            this.btn_DangNhap.TabIndex = 3;
            this.btn_DangNhap.Text = "Đăng nhập";
            this.btn_DangNhap.UseVisualStyleBackColor = true;
            // 
            // txt_user
            // 
            this.txt_user.Location = new System.Drawing.Point(45, 67);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(147, 20);
            this.txt_user.TabIndex = 0;
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(45, 114);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '•';
            this.txt_pass.Size = new System.Drawing.Size(147, 20);
            this.txt_pass.TabIndex = 5;
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(28, 176);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(66, 28);
            this.btn_thoat.TabIndex = 6;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(28, 140);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(109, 17);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Hiển thị mật khẩu";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // ctr_DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_DangNhap);
            this.Controls.Add(this.chckBox_hienThiMatKhau);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_user);
            this.Name = "ctr_DangNhap";
            this.Size = new System.Drawing.Size(236, 243);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ThietKetControl.txt_KoCoKyTuDatBiet txt_user;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label chckBox_hienThiMatKhau;
        private ThietKetControl.btnDoiMau btn_DangNhap;
        private System.Windows.Forms.Label label3;
        private ThietKetControl.txt_password txt_pass;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}
