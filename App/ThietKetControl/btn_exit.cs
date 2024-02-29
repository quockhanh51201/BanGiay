using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace ThietKetControl
{
    public class btn_exit : Button
    {
        public btn_exit()
        {

            this.MouseHover += btn_accept_MouseHover;
            this.MouseLeave += btn_accept_MouseLeave;

        }

        void btn_accept_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        void btn_accept_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }
    }
}
