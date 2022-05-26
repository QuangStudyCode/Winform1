using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;//dùng thư viện để khai báo

namespace BTTH04_2
{
    internal class Class1
    {
        public static void HoanDoi(TextBox tb1, TextBox tb2)
        {
            string t = tb1.Text;
            tb1.Text = tb2.Text;
            tb2.Text = t;
        }
    }
}
