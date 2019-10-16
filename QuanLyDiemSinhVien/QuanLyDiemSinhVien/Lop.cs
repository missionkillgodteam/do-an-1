using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Diagnostics;

namespace QuanLyDiemSinhVien
{
    public partial class Lop : Form
    {
        private Connect ketnoi = new Connect();
        SqlConnection conn = null;
        public Lop()
        {
            InitializeComponent();
        }

        private void Lop_Load(object sender, EventArgs e)
        {
            conn = ketnoi.Connected();
            if (conn.State == ConnectionState.Open) ;
            string sql = "select * from [QuanLyDiemSinhVien].[dbo].[Lop]";
            SqlCommand commandsql = new SqlCommand(sql, conn);
            SqlDataAdapter com = new SqlDataAdapter(commandsql);
            DataTable table = new DataTable();
            com.Fill(table);
            dgrLop.DataSource = table;
            //add du lieu vao khoa hoc
            string select = "select MaKhoa from Khoa";
            SqlCommand cmd = new SqlCommand(select, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cboKhoa.Items.Add(reader.GetString(0));
            }
            reader.Dispose();
            cmd.Dispose();
            FillDataGridView_Lop();


        }
        public void FillDataGridView_Lop()
        {
            //thuc hien truy van 
            string select = "Select * from Lop";
            SqlCommand cmd = new SqlCommand(select, conn);
            //tao doi tuong dataset
            DataSet ds = new DataSet();
            //tao doi tuong dieu hop
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            //fill du lieu tu adapter vao dataset
            adapter.Fill(ds, "SINHVIEN");
            //dua ra datagridview
            dgrLop.DataSource = ds;
            dgrLop.DataMember = "SINHVIEN";
            cmd.Dispose();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            string select1 = "Select MaKhoa from Khoa where MaKhoa='" + cboKhoa.Text + "' ";
            SqlCommand cmd1 = new SqlCommand(select1, conn);
            SqlDataReader reader1 = cmd1.ExecuteReader();
            errorProvider1.Clear();
            if (txtMaLop.Text == "")
            {
                errorProvider1.SetError(txtMaLop, "!");
                txtMaLop.Focus();
            }
            else if (txtMaLop.Text == dgrLop.CurrentRow.Cells[1].Value.ToString())
            {
                errorProvider1.SetError(txtMaLop, "!");
                MessageBox.Show("Mã lớp đã tồn tại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtMaLop.Focus();
            }
            else if (reader1.Read())
            {

                reader1.Dispose();
                cmd1.Dispose();
                // Thực hiện truy vấn
                string insert = "Insert Into Lop(MaLop,TenLop,MaKhoa)" +
                "Values('" + txtMaLop.Text + "',N'" + txtTenlop.Text + "','" + cboKhoa.Text + "')";
                SqlCommand cmd = new SqlCommand(insert, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Nhập thông tin thành công", "Thông báo!");

                // Trả tài nguyên


                cmd.Dispose();
                //Fill du lieu vao Database
                FillDataGridView_Lop();

            }
            else
            {
                MessageBox.Show("Nhập mã khoa không chính xác !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboKhoa.Focus();
                reader1.Dispose();
                cmd1.Dispose();
            }
            reader1.Dispose();
            cmd1.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Thực hiện truy vấn
            string update = "Update Lop Set MaKhoa='" + cboKhoa.Text + "',MaLop='" + txtMaLop.Text + "',TenLop='" +
                            txtTenlop.Text + "' where MaLop='" + txtMaLop.Text + "' ";
            SqlCommand cmd = new SqlCommand(update, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Cập nhật dữ liệu thành công", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //Load lai du lieu
            FillDataGridView_Lop();
            // Trả tài nguyên
            cmd.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Kiem tra 

            string select1 = "Select MaLop from SinhVien where MaLop='" + txtMaLop.Text + "' ";
            SqlCommand cmd1 = new SqlCommand(select1, conn);
            SqlDataReader reader1 = cmd1.ExecuteReader();

            if (reader1.Read())
            {
                {
                    MessageBox.Show("Bạn phải xóa Mã Lớp " + txtMaLop.Text + "từ bảng Sinh Viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

            }

            else if (MessageBox.Show("Bạn có chắc chắn muốn xóa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Thuc hien xoa du lieu
                cmd1.Dispose();
                reader1.Dispose();
                SqlCommand cmd = new SqlCommand("delete from Lop where MaLop='" + txtMaLop.Text + "'", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa dữ liệu thành công", "Thông báo!");

                // Trả tài nguyên
                cmd.Dispose();
                //Load lai du lieu
                FillDataGridView_Lop();
            }
            cmd1.Dispose();
            reader1.Dispose();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgrLop_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cboKhoa.Text = dgrLop.CurrentRow.Cells[0].Value.ToString();
            txtMaLop.Text = dgrLop.CurrentRow.Cells[1].Value.ToString();
            txtTenlop.Text = dgrLop.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
