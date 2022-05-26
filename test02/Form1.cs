using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtSoA.Clear();
            txtSoB.Clear();
        }

        private void btnDung_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //HoanDoi hd1 = new HoanDoi();
        private void btnHoanDoi_Click(object sender, EventArgs e)
        {
            HoanDoi.HoanDoiSo(txtSoA, txtSoB);
        }
    }
}
