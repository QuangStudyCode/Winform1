using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_user
{
    public partial class Form1 : Form
    {
        //khai báo form

        DataTable table = new DataTable();
        public Form1()
        {
            InitializeComponent();
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            string gt = "Nam";
            if (rdNu.Checked)
            {
                gt = "Nữ";
            }
            table.Rows.Add(txtMaSV.Text, txtHoTen.Text, dateTimePicker1.Text, gt, cbQueQuan.Text, cbLop.Text, cbKhoa.Text);
        }


        //đưa dữ liệu lên lại ô nhập
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            txtMaSV.Text = row.Cells[0].Value.ToString();
            txtHoTen.Text = row.Cells[1].Value.ToString();
            dateTimePicker1.Text = row.Cells[2].Value.ToString();
            if (row.Cells[3].Value.ToString() == "Nam")
            {
                rdNam.Checked = true;
            }
            else
            {
                rdNu.Checked = true;
            }
            cbQueQuan.Text = row.Cells[4].Value.ToString();
            cbLop.Text = row.Cells[5].Value.ToString();
            cbKhoa.Text = row.Cells[6].Value.ToString();
        }
            int index;
        private void btnSua_Click(object sender, EventArgs e)
        {
           
            DataGridViewRow newData = dataGridView1.Rows[index];
            newData.Cells[0].Value = txtMaSV.Text;
            newData.Cells[1].Value = txtHoTen.Text;
            newData.Cells[2].Value = dateTimePicker1.Text;

            if (newData.Cells[3].Value == "Nam")
            {
                rdNam.Checked = true;
            }
            else
            {
                rdNu.Checked = true;
            }
            newData.Cells[4].Value = cbQueQuan.Text;
            newData.Cells[5].Value = cbLop.Text;
            newData.Cells[6].Value = cbKhoa.Text;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
           index= dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(index);
        }
    }
}
