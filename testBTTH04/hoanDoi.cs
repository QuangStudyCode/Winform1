using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;//dùng thư viện để khai báo

namespace testBTTH04
{
    internal class hoanDoi
    {
        public static void HoanDoiab(TextBox a,TextBox b)
        {
            string tmp=a.Text;
            a.Text=b.Text;
            b.Text=tmp;
        }
    }
}
