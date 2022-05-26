using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTTH04_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void đổiMàuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                //this.BackColor = colorDialog1.Color;
                panel1.BackColor = colorDialog1.Color;
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                this.Font = fontDialog1.Font;
            }
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(txtSoa.Text);
                int b = int.Parse(txtSob.Text);
                int c = int.Parse(txtSoc.Text);
                if (a == 0)
                {
                    lbResult.Text = "Kết Quả: X= " + (-c / b).ToString();
                }
                else
                {
                    double dental = Math.Pow(b, 2) - 4 * a * c;
                    if (dental < 0)
                    {
                        lbResult.Text = "Phương trình vô nghiệm!!";
                    }
                    else if (dental == 0)
                    {
                        lbResult.Text = "Phương trình có nghiệm duy nhất là " + (-b / 2 * a).ToString();
                    }
                    else
                    {

                        lbResult.Text = "Phương trình có 2 nghiệm phân biệt là:\n" +
                            "X1 " + (-b + Math.Sqrt(dental / 2 * a)).ToString() + " X2: " + (-b - Math.Sqrt(dental / 2 * a)).ToString();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi nhập số!!!");
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
