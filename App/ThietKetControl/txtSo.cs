using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThietKetControl
{
    public class txtSo : TextBox
    {
        public txtSo()
        {
            this.KeyPress += txtSo_KeyPress;
        }

        void txtSo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra nếu ký tự không phải là số và không phải là phím điều hướng (như mũi tên trái/phải, Delete, Backspace)
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 13 )
            {
                // Loại bỏ ký tự không hợp lệ bằng cách xóa nó
                e.Handled = true;
            }
        }
    }
}
