using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTTH04_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDung_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtSoa.Clear();
            txtSob.Clear();

        }
         
        Class1 c = new Class1();
        private void btnHoanDoi_Click(object sender, EventArgs e)
        {
            
            Class1.HoanDoi(txtSoa, txtSob);
        }
    }
}
