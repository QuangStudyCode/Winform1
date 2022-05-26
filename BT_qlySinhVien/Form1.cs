using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT_qlySinhVien
{
    public partial class Form1 : Form
    {
        DataTable table = new DataTable("table");
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            table.Columns.Add("Mã SV", Type.GetType("System.String"));
            table.Columns.Add("Họ Tên", Type.GetType("System.String"));
            table.Columns.Add("Ngày Sinh", Type.GetType("System.String"));
            table.Columns.Add("Giới Tính", Type.GetType("System.String"));
            table.Columns.Add("Quê Quán", Type.GetType("System.String"));
            table.Columns.Add("Lớp", Type.GetType("System.String"));
            table.Columns.Add("Khoa", Type.GetType("System.String"));
            dataGridView1.DataSource = table;
        }

        //đưa thông tin từ bàn phím vào data table
        private void button2_Click(object sender, EventArgs e)
        {
            string gt = "Nam";
            if (rdNu.Checked)
            {
                gt = "Nữ";
            }
            table.Rows.Add(txtMaSV.Text, txtHoTen.Text, txtNgaySinh.Text,gt , cbQueQuan.Text, cbLop.Text, cbKhoa.Text);

        }

        //đưa data từ gribview lên lại ô nhập
        int index;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataGridViewRow row=dataGridView1.Rows[e.RowIndex];
            txtMaSV.Text = row.Cells[0].Value.ToString();
            txtHoTen.Text = row.Cells[1].Value.ToString();
            txtNgaySinh.Text = row.Cells[2].Value.ToString();
            if (row.Cells[3].Value.ToString() == "Nam") {
                    rdNam.Checked = true;
            } else
            {
                rdNu.Checked = true;
            }

            cbQueQuan.Text = row.Cells[4].Value.ToString();
            cbLop.Text = row.Cells[5].Value.ToString();
            cbKhoa.Text = row.Cells[6].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            DataGridViewRow newdata = dataGridView1.Rows[index];

            newdata.Cells[0].Value = txtMaSV.Text;
            newdata.Cells[1].Value = txtHoTen.Text;
            newdata.Cells[2].Value=txtNgaySinh.Text;

            if (newdata.Cells[3].Value.ToString() == "Nam")
            {
                rdNam.Checked = true;
            }
            else
            {
                rdNu.Checked = true;
            }

            newdata.Cells[4].Value = cbQueQuan.Text;
            newdata.Cells[5].Value = cbLop.Text;
            newdata.Cells[6].Value = cbKhoa.Text;

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            index = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(index);
        }

    }
}
