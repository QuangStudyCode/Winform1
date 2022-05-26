using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                //this.Close();
                MessageBox.Show("Nút enter đã được nhấn!!");
                int a = int.Parse(txtSoA.Text);
                int b = int.Parse(txtSoB.Text);

                lbTong.Text = "Tổng a+b= " + (a + b).ToString();
                lbHieu.Text = "Hieu a-b=" + (a - b).ToString();
                lbTich.Text = "Tich axb=" + (a * b).ToString();
                lbThuong.Text = "Thuong a/b=" + (a / b).ToString();
            }
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnTinh_Click(object sender, EventArgs e)
        {

            try
            {
                int a = int.Parse(txtSoA.Text);
                int b = int.Parse(txtSoB.Text);

                lbTong.Text="Tổng a+b= "+(a+b).ToString();
                lbHieu.Text = "Hieu a-b=" + (a - b).ToString();
                lbTich.Text = "Tich axb=" + (a * b).ToString();
                lbThuong.Text = "Thuong a/b=" + (a / b).ToString();

            }catch(FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSoA_TextChanged(object sender, EventArgs e)
        {

           
        }

        
        private void txtSoA_Leave(object sender, EventArgs e)
        {
            
        }

        private void lbTong_Click(object sender, EventArgs e)
        {

        }
    }
}
