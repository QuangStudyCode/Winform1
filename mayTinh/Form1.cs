using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mayTinh
{
    public partial class Form1 : Form
    {

        double data1,data2;
        string ToanTu;
        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";

        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";

        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";

        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";

        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (ToanTu == "cong")
            {
                data2 = data1 + double.Parse(textBox1.Text);
                textBox2.Text = data2.ToString();
            }if(ToanTu == "tru")
            {
                data2 = data1 - double.Parse(textBox1.Text);
                textBox2.Text = data2.ToString();
            }if(ToanTu == "nhan")
            {
                data2 = data1 * double.Parse(textBox1.Text);
                textBox2.Text = data2.ToString();
            }if(ToanTu == "chia")
            {
                data2 = data1 / double.Parse(textBox1.Text);
                textBox2.Text = data2.ToString();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ToanTu = "tru";
            data1 = double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            ToanTu = "nhan";
            data1 = double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            ToanTu = "chia";
            data1 = double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                this.Font = fontDialog1.Font;
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                //this.BackColor = colorDialog1.Color;
                foreach (Button btn in tableLayoutPanel1.Controls)
                {
                    btn.BackColor = colorDialog1.Color;
                }

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ToanTu = "cong";
            data1 = double.Parse(textBox1.Text);
            textBox1.Clear();
        }
    }
}
