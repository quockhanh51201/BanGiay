using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ThietKetControl
{
   public class txt_Chu : TextBox
    {
        public txt_Chu()
       {
           this.KeyPress += txt_Chu_KeyPress;
       }

        void txt_Chu_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra xem ký tự không phải là ký tự chữ (A-Z, a-z) hoặc không phải phím điều hướng (mũi tên, Backspace)
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != 8)
            {
                // Ngăn người dùng nhập ký tự không hợp lệ bằng cách loại bỏ nó
                e.Handled = true;
            }
        }
    }
}
