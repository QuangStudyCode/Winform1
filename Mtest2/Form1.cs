using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;//khai báo để sử dụng SQL connection;

namespace Mtest2
{
    public partial class Form1 : Form
    {
        DataTable dtSV = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        string chuoiketnoi = "Data Source = DESKTOP-30ITQPH\\SQLEXPRESS;" 
            + "Initial Catalog=QLSV;" 
            + "Integrated Security = True;";
        SqlConnection conn = null;
        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(chuoiketnoi);
            conn.Open();
            string sql = "Select * from tb_SinhVien";
            SqlDataAdapter daSV = new SqlDataAdapter(sql, conn);
            daSV.Fill(dtSV);
            dataGridView1.DataSource = dtSV;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string sql_Insert = "Insert into tb_SinhVien values ('"+txtID.Text+ "','"+txtMaSv+ "','"+txtTenSinhVien.Text+ "','"+txtLop.Text+ "','"+txtDiem.Text+ "','"+txtDiaChi.Text+"' )";
            SqlCommand cmd = new SqlCommand(sql_Insert,conn);
            cmd.ExecuteNonQuery();

            string sql = "Select * from tb_SinhVien";
            SqlDataAdapter daSV = new SqlDataAdapter(sql, conn);
            daSV.Fill(dtSV);


        }
    }
}
