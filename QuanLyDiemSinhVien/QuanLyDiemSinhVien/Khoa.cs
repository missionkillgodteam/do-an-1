using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Diagnostics;
using System.Data.SqlClient;


namespace QuanLyDiemSinhVien
{
    public partial class Khoa : Form
    {
        private Connect Ketnoi = new Connect();
        SqlConnection conn = null;
        public Khoa()
        {
            InitializeComponent();
        }

        private void Khoa_Load(object sender, EventArgs e)
        {
            conn = Ketnoi.Connected();
            if (conn.State == ConnectionState.Open) ;
            string sqlkhoa = "select * from [QuanLyDiemSinhVien].[dbo].[Khoa]";
            SqlCommand comand = new SqlCommand(sqlkhoa, conn);
            SqlDataAdapter sqlcom = new SqlDataAdapter(comand);
            DataTable table = new DataTable();
            sqlcom.Fill(table);
            dgrKhoa.DataSource = table;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string select1 = "select Makhoa from Khoa where Makhoa='" + txtKhoa.Text + "'";
            SqlCommand cmd1 = new SqlCommand(select1, conn);
            SqlDataReader reader1 = cmd1.ExecuteReader();
            errorProvider1.Clear();
            if (txtKhoa.Text == "")
            {
                errorProvider1.SetError(txtKhoa, "Khóa học không để trống!");
                txtTenKhoa.Focus();
            }
            else if (reader1.Read())
            {
                {
                    MessageBox.Show("Thông tin đã tồn tại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtKhoa.Focus();

                }


                //Tra tai nguyen 
                reader1.Dispose();
                cmd1.Dispose();
            }
            else
            {
                reader1.Dispose();
                cmd1.Dispose();
                // Thực hiện truy vấn
                string insert = "Insert Into Khoa(MaKhoa,TenKhoa)" +
                "Values('" + txtKhoa.Text + "',N'" + txtTenKhoa.Text + "')";
                SqlCommand cmd = new SqlCommand(insert, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Nhập thông tin thành công", "Thông báo!");

                // Trả tài nguyên


                cmd.Dispose();
                //Fill du lieu vao Database
                FillDataGridView_Khoa();

            }
        }
        public void FillDataGridView_Khoa()
        {
            // Thực hiện truy vấn
            string select = "Select * From khoa  ";
            SqlCommand cmd = new SqlCommand(select, conn);

            // Tạo đối tượng DataSet
            DataSet ds = new DataSet();

            // Tạo đối tượng điều hợp
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;

            // Fill dữ liệu từ adapter vào DataSet
            adapter.Fill(ds, "SINHVIEN");

            // Đưa ra DataGridView
            dgrKhoa.DataSource = ds;
            dgrKhoa.DataMember = "SINHVIEN";
            cmd.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Thực hiện truy vấn
            string update = "Update khoa Set TenKhoa=N'" + txtTenKhoa.Text + "' where MaKhoa='" + txtKhoa.Text + "' ";
            SqlCommand cmd = new SqlCommand(update, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Cập nhật dữ liệu thành công", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //Load lai du lieu
            FillDataGridView_Khoa();
            // Trả tài nguyên
            cmd.Dispose();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgrKhoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtKhoa.Text = dgrKhoa.CurrentRow.Cells[0].Value.ToString();
            txtTenKhoa.Text = dgrKhoa.CurrentRow.Cells[1].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Kiem tra 

            string select1 = "Select MaKhoa from Lop where MaKhoa='" + txtKhoa.Text + "' ";
            SqlCommand cmd1 = new SqlCommand(select1, conn);
            SqlDataReader reader1 = cmd1.ExecuteReader();

            if (reader1.Read())
            {
                {
                    MessageBox.Show("Bạn phải xóa Mã Khoa " + txtKhoa.Text + "từ bảng Lớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            else if (MessageBox.Show("Bạn có chắc chắn muốn xóa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Thuc hien xoa du lieu
                reader1.Dispose();
                cmd1.Dispose();
                SqlCommand cmd = new SqlCommand("delete from Khoa where MaKhoa='" + txtKhoa.Text + "'", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa dữ liệu thành công", "Thông báo!");

                // Trả tài nguyên
                cmd.Dispose();
                //Load lai du lieu
                FillDataGridView_Khoa();
            }
            reader1.Dispose();
            cmd1.Dispose();
        }
    }
}
