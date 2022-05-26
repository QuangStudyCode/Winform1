using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
               

                try{
                    int a = int.Parse(txtSoA.Text);
                    int b = int.Parse(txtSoB.Text);

                    lbTong.Text = "Tong: " + (a + b).ToString();
                    lbHieu.Text = "Hieu: " + (a - b).ToString();
                    lbTich.Text = "Tích: " + (a * b).ToString();
                    lbThuong.Text = "Thuong: " + (a / b).ToString();
                }catch(FormatException ex)
                {
                    MessageBox.Show(ex.Message);
                }

        
            }if(e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
            }
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(txtSoA.Text);
                int b = int.Parse(txtSoB.Text);

                lbTong.Text = "Tong: " + (a + b).ToString();
                lbHieu.Text = "Hieu: " + (a - b).ToString();
                lbTich.Text = "Tích: " + (a * b).ToString();
                lbThuong.Text = "Thuong: " + (a / b).ToString();
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
