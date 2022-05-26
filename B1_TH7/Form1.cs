using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B1_TH7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        //nhaàm
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtNhapSoN_TextChanged(object sender, EventArgs e)
        {

            f(textBox1.Text.Length == 0)
            {
                return;
            }
            if (!int.TryParse(textBox1.Text, out int value))
            {
                MessageBox.Show("Kí tự được nhập vào phải là số!");
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
                textBox1.Focus();
                textBox1.SelectionStart = textBox1.Text.Length;
            }
        }

        private void txtNhapSoN_Leave(object sender, EventArgs e)
        {
            int a = int.Parse(txtNhapSoN.Text);
            if (a < 0 || a > 100)
            {
                MessageBox.Show("Số a phải nằm trong khoảng từ 0<a<100!!!");
            }
        }

        static int isPrimeNumber(int a)
        {
            // so nguyen n < 2 khong phai la so nguyen to
            if (a < 2)
            {
                return 0;
            }
            // check so nguyen to khi n >= 2
            int i;
            int squareRoot = (int)Math.Sqrt(a);
            for (i = 2; i <= squareRoot; i++)
            {
                if (a % i == 0)
                {
                    return 0;
                }
            }
            return 1;
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtNhapSoN.Text);
            //số nguyên tố
            int[] array1=new int[100];
            for (int i = 2; i < a; i += 2)
            {
                if (isPrimeNumber(i) == 1)
                {
                    i = array1[i];
                }
            }
            MessageBox.Show(array1.ToString());
        }
    }
}
