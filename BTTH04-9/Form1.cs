using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTTH04_9
{
    public partial class Form1 : Form
    {
        DataTable table = new DataTable("table");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            table.Columns.Add("Họ Tên", Type.GetType("System.String"));
           
            table.Columns.Add("Ngày Sinh", Type.GetType("System.String"));
            table.Columns.Add("Địa Chỉ", Type.GetType("System.String"));
            table.Columns.Add("Điện thoại", Type.GetType("System.String"));

            dataGridView1.DataSource = table;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
           if(txtHoTen.Text == "")
            {
                MessageBox.Show("Họ tên không được để trống!");
                this.Focus();
            }
            table.Rows.Add(txtHoTen.Text, dateTimePicker1.Text, txtDiaChi.Text, txtDienThoai.Text);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            txtHoTen.Text = row.Cells[0].Value.ToString();
            dateTimePicker1.Text = row.Cells[1].Value.ToString();
            txtDiaChi.Text = row.Cells[2].Value.ToString();
            txtDienThoai.Text = row.Cells[3].Value.ToString();
        }
        int index;
        private void btnXoa_Click(object sender, EventArgs e)
        {
            index = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(index);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DataGridViewRow newdata = dataGridView1.Rows[index];

            newdata.Cells[0].Value = txtHoTen.Text;
            newdata.Cells[1].Value = dateTimePicker1.Text;
            newdata.Cells[3].Value = txtDienThoai.Text;
            newdata.Cells[2].Value = txtDiaChi.Text;
        }
    }
}
