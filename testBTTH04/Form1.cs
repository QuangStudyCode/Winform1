using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testBTTH04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        hoanDoi hd=new hoanDoi();
        private void btnHoanDoi_Click(object sender, EventArgs e)
        {
            hoanDoi.HoanDoiab(txtSoa, txtSob);
        }
    }
}
