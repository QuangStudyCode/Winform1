using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testB4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtSoA_TextChanged(object sender, EventArgs e)
        {
            if (txtSoA.Text == "")
            {
                return;
            }if(!int.TryParse(txtSoA.Text,out int nummber))
            {
                MessageBox.Show("Không phải là số!!");
            }
        }

        private void txtSoA_Leave(object sender, EventArgs e)
        {
            int a = int.Parse(txtSoA.Text);
            if(a<0 || a > 100)
            {
                MessageBox.Show("Số nhập phải nằm trong khoảng từ 0<a<1000");
            }
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {

            int a = int.Parse(txtSoA.Text);
            List<int> lNguyenTo = new List<int>();
            List<int> lChinhPhuong = new List<int>();
            List<int> lHoanChinh = new List<int>();


            for(int i = 1; i < a; i++)
            {
                if (Class1.laSoNguyenTo(i))
                {
                    lNguyenTo.Add(i);
                }
                if (Class1.laSoChinhPhuong(i))
                {
                    lChinhPhuong.Add(i);
                }
                if (Class1.laSoHoanChinh(i))
                {
                    lHoanChinh.Add(i);
                }
            }

            lbSoNguyenTo.Text = "Số nguyên tố nhỏ hơn n: "+String.Join(" ", lNguyenTo.ToArray());
            lbSoChinhPhuong.Text = "So chính phương nhỏ hơn n: " + String.Join(" ", lChinhPhuong.ToArray());
            lbSoHoanChinh.Text = "Số hoàn chỉnh nhỏ hơn n: " + String.Join(" ", lHoanChinh.ToArray());
        }
    }
}
