﻿using System;
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
    public partial class Login : Form
    {
        //khai bao cac doi tuong commonconnect
        private Connect ketnoi = new Connect();
        //khai bao đối tượng kết nối.
        private SqlConnection conn = null;
        public Login()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string select = "Select * From LOGIN where TenDangNhap='" + txtTenDN.Text + "' and Matkhau='" + txtMatKhau.Text + "' and Quyen='Admin'";
            SqlCommand cmd = new SqlCommand(select, conn);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                MessageBox.Show("Đăng nhập vào hệ thống !", "Thông báo !");
                Form1 frm = new Form1();
                frm.Show();
               // frm.mnuDN.Enabled = false;
                this.Hide();

                cmd.Dispose();
                reader.Close();
                reader.Dispose();
            }

            else
            {
                cmd.Dispose();
                reader.Close();
                reader.Dispose();
                string select1 = "Select * From LOGIN where TenDangNhap='" + txtTenDN.Text + "' and MatKhau='" + txtMatKhau.Text + "' and Quyen='Member'";
                SqlCommand cmd1 = new SqlCommand(select1, conn);
                SqlDataReader reader1;
                reader1 = cmd1.ExecuteReader();

                if (reader1.Read())
                {
                    MessageBox.Show("Đăng nhập vào hệ thống !", "Thông báo !");

                    //Form1 frm = new Form1();
                    //frm.Show();
                    //frm.mnuDN.Enabled = false;
                    //frm.MnuItemDanhMuc.Enabled = false;
                    //frm.mnuItemQuanli.Enabled = false;
                    //this.Hide();

                    //frm.mnuQuanlinguoidung.Enabled = false;

                    //frm.menuBarToolStripMenuItem.Enabled = false;
                    //frm.menuBarToolStripMenuItem.Checked = true;

                    //frm.pictureBox2.Hide();
                    //frm.btl1.Hide();
                    //frm.btl2.Hide();
                    //frm.btl3.Hide();
                    //frm.btl4.Hide();
                    //frm.btl5.Hide();
                    //frm.btl6.Hide();

                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu sai !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                }
                cmd1.Dispose();
                reader1.Close();
                reader1.Dispose();

            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            // Mở kết nối
            conn = ketnoi.Connected();
            if (conn.State == ConnectionState.Open)
                cboName.Items.Add(SystemInformation.UserDomainName.ToString() + "\\SQLServer");
            cboName.Text = cboName.Items[0].ToString();
            string select = "select*from sys.servers";
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnDangNhap.PerformClick();
            this.AcceptButton = btnDangNhap;
        }
    }
}