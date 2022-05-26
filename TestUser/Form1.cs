using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestUser
{
    public partial class Form1 : Form
    {
        DataTable table = new DataTable("data");
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string sex = "Male";
            if (rdFemale.Checked)
            {
                sex = "FeMale";
            }
            table.Rows.Add(txtId.Text, txtName.Text, dateTimePicker1.Text,sex, cbProvince.Text, cbClass.Text, cbFaculy.Text);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            txtId.Text = row.Cells[0].Value.ToString();
            txtName.Text = row.Cells[1].Value.ToString();
            dateTimePicker1.Text = row.Cells[2].Value.ToString();

            if (row.Cells[3].Value.ToString() == "Male")
            {
                rdMale.Checked = true;
            }
            else
            {
                rdFemale.Checked = true;
            }
            cbProvince.Text = row.Cells[4].Value.ToString();
            cbClass.Text = row.Cells[5].Value.ToString();
            cbFaculy.Text = row.Cells[6].Value.ToString();

        }
        int index;
        private void btnChange_Click(object sender, EventArgs e)
        {
            DataGridViewRow newdata=dataGridView1.Rows[index];

            newdata.Cells[0].Value = txtId.Text;
            newdata.Cells[1].Value = txtName.Text;
            newdata.Cells[2].Value = dateTimePicker1.Text;

            if (rdMale.Checked)
            {
                newdata.Cells[4].Value = "Male";
            }
            newdata.Cells[4].Value = cbProvince.Text;
            newdata.Cells[5].Value = cbClass.Text;
            newdata.Cells[6].Value = cbFaculy.Text;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            index = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(index);
        }
    }
}
