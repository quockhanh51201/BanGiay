using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThietKetControl
{
    public class txt_KoCoKyTuDatBiet : TextBox
    {
        public txt_KoCoKyTuDatBiet ()
        {
            this.KeyPress += txt_KoCoKyTuDatBiet_KeyPress;
        }

        void txt_KoCoKyTuDatBiet_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra xem ký tự không phải là số hoặc không phải là phím điều hướng (Backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != 8)
            {
                // Ngăn người dùng nhập ký tự đặt biệt bằng cách loại bỏ nó
                e.Handled = true;
            }
        }
    }
}
