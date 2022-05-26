using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test02
{
    public class HoanDoi
    {
        public static void HoanDoiSo(TextBox a,TextBox b)
        {
            string t = a.Text;
            a.Text = b.Text;
            b.Text = t;
        }
    }
}
