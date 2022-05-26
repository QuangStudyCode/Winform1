using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B2_TH7
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        //btn nhập hàng
        private void button1_Click(object sender, EventArgs e)
        {
            int total_money = 0;
            if (checkBox1.Checked)
            {
                total_money += 100000;
            }
            if (checkBox2.Checked)
            {
                total_money += 1200000;
            }
            if (checkBox3.Checked)
            {
                total_money += 150000;
            }
            if (checkBox4.Checked)
            {
                total_money += 100000;
            }
            if (numericUpDown1.Value > 0)
            {
                total_money += 90000;
            }

            txtTongTien.Text = total_money.ToString()+"VNĐ";
        }


        //btn Thoat
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
