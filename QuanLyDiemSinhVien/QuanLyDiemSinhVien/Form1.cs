using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDiemSinhVien
{
    public partial class Form1 : Form
    {
        private int childFormNumber = 0;
       
        public Form1()
        {
            InitializeComponent();
        }
        public static bool kt1, kt2;
        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }
        private void tìmKiếmToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void mnuDoiMK_Click(object sender, EventArgs e)
        {
            DoiMatKhau frm = new DoiMatKhau();
            frm.Show();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuDN_Click(object sender, EventArgs e)
        {
            Login frm = new Login();
            frm.Show();
            this.Hide();
        }

        private void mnuDX_Click(object sender, EventArgs e)
        {
           Login frm = new Login();
            frm.Show();
            this.Hide();
            mnuDN.Enabled = true;
            //editMenu.Enabled = false;
            mnuDoiMK.Enabled = false;
            //MnuItemDanhMuc.Enabled = false;
            //mnuItemQuanli.Enabled = false;
            //mnuWindows.Enabled = false;
            //mnuItemThongKe.Enabled = false;


            //menuBarToolStripMenuItem.Checked = false;
            //pictureBox3.Hide();

            pictureBox2.Hide();
            btn1.Hide();
            btn2.Hide();
            btn3.Hide();
            btn4.Hide();
            btn5.Hide();
            //btn6.Hide();
        }

        private void mônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Form1.ActiveForm;
            foreach (Form f in frm.MdiChildren)
            {
                if (f.Name == "frmMonHoc")
                {
                    f.Activate();
                    return;
                }
            }


            MonHoc frm1 = new MonHoc();
            frm1.MdiParent = this;
            //Closeform("frmQLSV");
            frm1.Show();
            frm1.Top = 0;
            frm1.Left = 0;
        }

        private void khoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Form1.ActiveForm;
            foreach (Form f in frm.MdiChildren)
            {
                if (f.Name == "frmKhoa")
                {
                    f.Activate();
                    return;
                }
            }

            Form frmQLK = new Khoa();
            frmQLK.MdiParent = this;
            //Closeform("frmQLDiem");
            frmQLK.Show();
            frmQLK.Top = 0;
            frmQLK.Left = 0;
        }

        private void lopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Form1.ActiveForm;
            foreach (Form f in frm.MdiChildren)
            {
                if (f.Name == "frmLop")
                {
                    f.Activate();
                    return;
                }
            }

            Form frmLop = new Lop();
            frmLop.MdiParent = this;
            //Closeform("frmQLDiem");
            frmLop.Show();
            frmLop.Top = 0;
            frmLop.Left = 0;
        }

        private void btn2_Click(object sender, EventArgs e)
        {

        }

      

        private void mnuQuanlinguoidung_Click(object sender, EventArgs e)
        {

        }
    }
}
