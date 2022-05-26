using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtHienThi.Text = txtHienThi.Text + "4";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            txtHienThi.Text = txtHienThi.Text + "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtHienThi.Text = txtHienThi.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtHienThi.Text = txtHienThi.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtHienThi.Text = txtHienThi.Text + "3";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtHienThi.Text = txtHienThi.Text + "5";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtHienThi.Text = txtHienThi.Text + "6";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtHienThi.Text = txtHienThi.Text + "7";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtHienThi.Text = txtHienThi.Text + "8";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            txtHienThi.Text = txtHienThi.Text + "9";
        }
        string pheptinh;
        float data1,data2;

        private void btnKetQua_Click(object sender, EventArgs e)
        {
            if (pheptinh == "cộng")
            {
                data2 = data1 + float.Parse(txtHienThi.Text);
                txtHienThi.Text = data2.ToString();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtHienThi.Text = txtHienThi.Text + "-";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            txtHienThi.Text = txtHienThi.Text + "x";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            txtHienThi.Text = txtHienThi.Text + "/";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtHienThi.Text = txtHienThi.Text + "+";
               
        }
    }
}
