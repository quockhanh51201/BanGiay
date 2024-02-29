using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThietKetControl
{
    public class txt_sdt : TextBox
    {
        public txt_sdt()
        {
            this.KeyPress += txt_sdt_KeyPress;
            this.TextChanged += txt_sdt_TextChanged;
        }

        void txt_sdt_TextChanged(object sender, EventArgs e)
        {
            // Kiểm tra độ dài của TextBox và giới hạn nó thành 10 ký tự
            if (this.Text.Length > 10)
            {
                this.Text = this.Text.Substring(0, 10);
            }
        }

       
        void txt_sdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra xem ký tự không phải là số 
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Loại bỏ ký tự không hợp lệ bằng cách ngăn sự kiện KeyPress
                e.Handled = true;
            }
        }

    }
}
