using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myTest1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(txtA.Text);
                int b = int.Parse(txtB.Text);
                int c = int.Parse(txtC.Text);

                double dental = Math.Pow(b, 2) - 4 * a * c;
                if (a == 0)
                {
                    lbKetQua.Text = "Kết Quả: " + (-c / a).ToString();
                }
                else
                {
                    if (dental < 0)
                    {
                        lbKetQua.Text = "Kết Quả: Phương trình vô nghiệm!";
                    }else if (dental == 0)
                    {
                        lbKetQua.Text = "Phương trình có nghiệm duy nhất : X = " + (-b / 2 * a);
                    }
                    else
                    {
                        
                        lbKetQua.Text = "Kết Quả: Phương trình có hai nghiệm phân biệt: X1 = " + ((-b + Math.Sqrt(dental)) / 2 * a) + "\n" + "X2 = " + ((-b - Math.Sqrt(dental)) / 2 * a);

                    }
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi đầu vào!!!");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            txtC.Clear();
            txtA.Focus();
        }

        private void changeFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog()==DialogResult.OK)
            {
                this.Font = fontDialog1.Font;
            }
        }

        private void changeColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                panel1.BackColor = fontDialog1.Color;
            }
        }
    }
}
