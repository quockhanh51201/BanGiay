using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThietKetControl
{
    public class txt_password :TextBox
    {
        public txt_password ()
        {
            this.PasswordChar = '•'; // Sử dụng dấu chấm để ẩn mật khẩu
            this.KeyPress += txt_Password_KeyPress;
        }

        void txt_Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Không hiển thị ký tự người dùng nhập (ẩn mật khẩu)
            e.Handled = true;
        }
    }
}
