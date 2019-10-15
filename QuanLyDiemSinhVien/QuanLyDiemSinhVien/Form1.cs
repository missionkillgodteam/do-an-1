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

        private void mnuQuanlinguoidung_Click(object sender, EventArgs e)
        {

        }
    }
}
