namespace QuanLyDiemSinhVien
{
    partial class MonHoc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MonHoc));
            this.dgrMON = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.quanLyDiemSinhVienDataSet1 = new QuanLyDiemSinhVien.QuanLyDiemSinhVienDataSet1();
            this.monBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.monTableAdapter = new QuanLyDiemSinhVien.QuanLyDiemSinhVienDataSet1TableAdapters.MonTableAdapter();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboKhoa = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHocKy = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaGV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSDVHT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenMon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaMon = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.maMonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenMonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soTCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maGVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hocKiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maKhoaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgrMON)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyDiemSinhVienDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgrMON
            // 
            this.dgrMON.AutoGenerateColumns = false;
            this.dgrMON.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgrMON.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrMON.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maMonDataGridViewTextBoxColumn,
            this.tenMonDataGridViewTextBoxColumn,
            this.soTCDataGridViewTextBoxColumn,
            this.maGVDataGridViewTextBoxColumn,
            this.hocKiDataGridViewTextBoxColumn,
            this.maKhoaDataGridViewTextBoxColumn});
            this.dgrMON.DataSource = this.monBindingSource;
            this.dgrMON.Location = new System.Drawing.Point(6, 18);
            this.dgrMON.Name = "dgrMON";
            this.dgrMON.Size = new System.Drawing.Size(481, 371);
            this.dgrMON.TabIndex = 0;
            this.dgrMON.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrMON_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgrMON);
            this.groupBox2.Location = new System.Drawing.Point(274, 50);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(493, 395);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(295, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 26);
            this.label1.TabIndex = 13;
            this.label1.Text = "Danh sách môn học";
            // 
            // quanLyDiemSinhVienDataSet1
            // 
            this.quanLyDiemSinhVienDataSet1.DataSetName = "QuanLyDiemSinhVienDataSet1";
            this.quanLyDiemSinhVienDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // monBindingSource
            // 
            this.monBindingSource.DataMember = "Mon";
            this.monBindingSource.DataSource = this.quanLyDiemSinhVienDataSet1;
            // 
            // monTableAdapter
            // 
            this.monTableAdapter.ClearBeforeFill = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(774, 300);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(92, 39);
            this.button4.TabIndex = 19;
            this.button4.Text = "Thoát ";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Default;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(774, 229);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 39);
            this.button3.TabIndex = 18;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(774, 147);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 39);
            this.button2.TabIndex = 17;
            this.button2.Text = "Sửa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(774, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 39);
            this.button1.TabIndex = 16;
            this.button1.Text = "Nhập";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::QuanLyDiemSinhVien.Properties.Resources.images__1_;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.groupBox1.Controls.Add(this.cboKhoa);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtHocKy);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtMaGV);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtSDVHT);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTenMon);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMaMon);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(7, 50);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(262, 395);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết";
            // 
            // cboKhoa
            // 
            this.cboKhoa.FormattingEnabled = true;
            this.cboKhoa.Location = new System.Drawing.Point(93, 357);
            this.cboKhoa.Name = "cboKhoa";
            this.cboKhoa.Size = new System.Drawing.Size(145, 23);
            this.cboKhoa.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 360);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 15);
            this.label6.TabIndex = 22;
            this.label6.Text = "Mã khoa";
            // 
            // txtHocKy
            // 
            this.txtHocKy.Location = new System.Drawing.Point(93, 329);
            this.txtHocKy.Name = "txtHocKy";
            this.txtHocKy.Size = new System.Drawing.Size(145, 22);
            this.txtHocKy.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 335);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 15);
            this.label5.TabIndex = 20;
            this.label5.Text = "Học kỳ";
            // 
            // txtMaGV
            // 
            this.txtMaGV.Location = new System.Drawing.Point(93, 295);
            this.txtMaGV.Name = "txtMaGV";
            this.txtMaGV.Size = new System.Drawing.Size(145, 22);
            this.txtMaGV.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 15);
            this.label4.TabIndex = 18;
            this.label4.Text = "Giảng viên";
            // 
            // txtSDVHT
            // 
            this.txtSDVHT.Location = new System.Drawing.Point(106, 80);
            this.txtSDVHT.Name = "txtSDVHT";
            this.txtSDVHT.Size = new System.Drawing.Size(145, 22);
            this.txtSDVHT.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Số Tín chỉ";
            // 
            // txtTenMon
            // 
            this.txtTenMon.Location = new System.Drawing.Point(106, 52);
            this.txtTenMon.Name = "txtTenMon";
            this.txtTenMon.Size = new System.Drawing.Size(145, 22);
            this.txtTenMon.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Tên môn";
            // 
            // txtMaMon
            // 
            this.txtMaMon.Location = new System.Drawing.Point(106, 21);
            this.txtMaMon.Name = "txtMaMon";
            this.txtMaMon.Size = new System.Drawing.Size(145, 22);
            this.txtMaMon.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Mã môn";
            // 
            // maMonDataGridViewTextBoxColumn
            // 
            this.maMonDataGridViewTextBoxColumn.DataPropertyName = "MaMon";
            this.maMonDataGridViewTextBoxColumn.HeaderText = "Mã Môn";
            this.maMonDataGridViewTextBoxColumn.Name = "maMonDataGridViewTextBoxColumn";
            // 
            // tenMonDataGridViewTextBoxColumn
            // 
            this.tenMonDataGridViewTextBoxColumn.DataPropertyName = "TenMon";
            this.tenMonDataGridViewTextBoxColumn.HeaderText = "Tên Môn";
            this.tenMonDataGridViewTextBoxColumn.Name = "tenMonDataGridViewTextBoxColumn";
            // 
            // soTCDataGridViewTextBoxColumn
            // 
            this.soTCDataGridViewTextBoxColumn.DataPropertyName = "SoTC";
            this.soTCDataGridViewTextBoxColumn.HeaderText = "Số Tín Chỉ";
            this.soTCDataGridViewTextBoxColumn.Name = "soTCDataGridViewTextBoxColumn";
            // 
            // maGVDataGridViewTextBoxColumn
            // 
            this.maGVDataGridViewTextBoxColumn.DataPropertyName = "MaGV";
            this.maGVDataGridViewTextBoxColumn.HeaderText = "Mã GV";
            this.maGVDataGridViewTextBoxColumn.Name = "maGVDataGridViewTextBoxColumn";
            // 
            // hocKiDataGridViewTextBoxColumn
            // 
            this.hocKiDataGridViewTextBoxColumn.DataPropertyName = "HocKi";
            this.hocKiDataGridViewTextBoxColumn.HeaderText = "Học Kì";
            this.hocKiDataGridViewTextBoxColumn.Name = "hocKiDataGridViewTextBoxColumn";
            // 
            // maKhoaDataGridViewTextBoxColumn
            // 
            this.maKhoaDataGridViewTextBoxColumn.DataPropertyName = "MaKhoa";
            this.maKhoaDataGridViewTextBoxColumn.HeaderText = "Mã Khoa";
            this.maKhoaDataGridViewTextBoxColumn.Name = "maKhoaDataGridViewTextBoxColumn";
            // 
            // MonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyDiemSinhVien.Properties.Resources._36413460_906810539489936_3756694274746351616_n;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(869, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "MonHoc";
            this.Text = "MonHoc";
            this.Load += new System.EventHandler(this.MonHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrMON)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyDiemSinhVienDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgrMON;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cboKhoa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtHocKy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaGV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSDVHT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenMon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaMon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label1;
        private QuanLyDiemSinhVienDataSet1 quanLyDiemSinhVienDataSet1;
        private System.Windows.Forms.BindingSource monBindingSource;
        private QuanLyDiemSinhVienDataSet1TableAdapters.MonTableAdapter monTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maMonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenMonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soTCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maGVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hocKiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKhoaDataGridViewTextBoxColumn;
    }
}