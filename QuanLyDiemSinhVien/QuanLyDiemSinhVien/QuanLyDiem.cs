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
    public partial class QuanLyDiem : Form
    {
        public QuanLyDiem()
        {
            InitializeComponent();
        }

        private void QuanLyDiem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyDiemSinhVienDataSet4.KetQua' table. You can move, or remove it, as needed.
            this.ketQuaTableAdapter1.Fill(this.quanLyDiemSinhVienDataSet4.KetQua);
            // TODO: This line of code loads data into the 'quanLyDiemSinhVienDataSet3.KetQua' table. You can move, or remove it, as needed.
            this.ketQuaTableAdapter.Fill(this.quanLyDiemSinhVienDataSet3.KetQua);

        }
    }
}
