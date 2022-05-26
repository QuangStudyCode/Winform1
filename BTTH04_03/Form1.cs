using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTTH04_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int c;
            if (textBox1.Text.Length == 0)
            {
                return;
            }
            if (!int.TryParse(textBox1.Text, out c))
            {
               
                MessageBox.Show("Kí tự được nhập vào phải là số!");
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
                textBox1.Focus();//phương thức forcus dùng để đặt con trỏ chuột tại vị trí có Forcus
                //textBox1.SelectionStart = textBox1.Text.Length;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            int a = int .Parse(textBox1.Text);
            if(a<0 || a > 1000)
            {
                MessageBox.Show("Số nhập phải nằm trong khoảng từ 0<a<1000");
            }
        }

     

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);

            List<int> soNguyenTo = new List<int>();//khai báo một danh sách kiểu số nguyên
            List<int> SoChinhPhuong = new List<int>();
            List<int> SoHoanHao = new List<int>();
            for(int i = 1; i < a; i++)
            {
                if (Class1.LaSoNguyenTo(i))
                {
                    soNguyenTo.Add(i);
                }
                if (Class1.laSoChinhPhuong(i)) {
                    SoChinhPhuong.Add(i);
                }
                if (Class1.laSoHoanHao(i))
                {
                    SoHoanHao.Add(i);
                }
            }
            lbSoNguyenTo.Text ="Số nguyên tố nhỏ hơn n:"+ String.Join(" ", soNguyenTo.ToArray());
            lbSoChinhPhuong.Text = "Số chính phương nhỏ hơn n:" + String.Join(" ", SoChinhPhuong.ToArray());
            lbSoHoanChinh.Text = "Số hoàn chỉnh nhỏ hơn n: " + String.Join(" ", SoHoanHao.ToArray());
        }
    }
}
