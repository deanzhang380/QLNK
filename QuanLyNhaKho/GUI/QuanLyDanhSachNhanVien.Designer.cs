namespace QuanLyNhaKho
{
    partial class QuanLyDanhSachNhanVien
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.maNhanVienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNhanVienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taiKhoanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matKhauDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maTrangThaiNhanVienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maChucVuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soDienThoaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nHANVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new QuanLyNhaKho.DataSet1();
            this.nHANVIENTableAdapter = new QuanLyNhaKho.DataSet1TableAdapters.NHANVIENTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tb_MaNV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_TenNV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_Sdt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_TK = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_MK = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_TrangThai = new System.Windows.Forms.ComboBox();
            this.tRANGTHAINHANVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cHUCVUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cHUCVUTableAdapter = new QuanLyNhaKho.DataSet1TableAdapters.CHUCVUTableAdapter();
            this.tRANGTHAINHANVIENTableAdapter = new QuanLyNhaKho.DataSet1TableAdapters.TRANGTHAINHANVIENTableAdapter();
            this.cb_CV = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRANGTHAINHANVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHUCVUBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(394, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách nhân viên";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maNhanVienDataGridViewTextBoxColumn,
            this.tenNhanVienDataGridViewTextBoxColumn,
            this.taiKhoanDataGridViewTextBoxColumn,
            this.matKhauDataGridViewTextBoxColumn,
            this.maTrangThaiNhanVienDataGridViewTextBoxColumn,
            this.maChucVuDataGridViewTextBoxColumn,
            this.soDienThoaiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.nHANVIENBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1082, 261);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // maNhanVienDataGridViewTextBoxColumn
            // 
            this.maNhanVienDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.maNhanVienDataGridViewTextBoxColumn.DataPropertyName = "MaNhanVien";
            this.maNhanVienDataGridViewTextBoxColumn.HeaderText = "MaNhanVien";
            this.maNhanVienDataGridViewTextBoxColumn.Name = "maNhanVienDataGridViewTextBoxColumn";
            this.maNhanVienDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenNhanVienDataGridViewTextBoxColumn
            // 
            this.tenNhanVienDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenNhanVienDataGridViewTextBoxColumn.DataPropertyName = "TenNhanVien";
            this.tenNhanVienDataGridViewTextBoxColumn.HeaderText = "TenNhanVien";
            this.tenNhanVienDataGridViewTextBoxColumn.Name = "tenNhanVienDataGridViewTextBoxColumn";
            this.tenNhanVienDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // taiKhoanDataGridViewTextBoxColumn
            // 
            this.taiKhoanDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.taiKhoanDataGridViewTextBoxColumn.DataPropertyName = "TaiKhoan";
            this.taiKhoanDataGridViewTextBoxColumn.HeaderText = "TaiKhoan";
            this.taiKhoanDataGridViewTextBoxColumn.Name = "taiKhoanDataGridViewTextBoxColumn";
            this.taiKhoanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // matKhauDataGridViewTextBoxColumn
            // 
            this.matKhauDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.matKhauDataGridViewTextBoxColumn.DataPropertyName = "MatKhau";
            this.matKhauDataGridViewTextBoxColumn.HeaderText = "MatKhau";
            this.matKhauDataGridViewTextBoxColumn.Name = "matKhauDataGridViewTextBoxColumn";
            this.matKhauDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maTrangThaiNhanVienDataGridViewTextBoxColumn
            // 
            this.maTrangThaiNhanVienDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.maTrangThaiNhanVienDataGridViewTextBoxColumn.DataPropertyName = "MaTrangThaiNhanVien";
            this.maTrangThaiNhanVienDataGridViewTextBoxColumn.HeaderText = "MaTrangThaiNhanVien";
            this.maTrangThaiNhanVienDataGridViewTextBoxColumn.Name = "maTrangThaiNhanVienDataGridViewTextBoxColumn";
            this.maTrangThaiNhanVienDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maChucVuDataGridViewTextBoxColumn
            // 
            this.maChucVuDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.maChucVuDataGridViewTextBoxColumn.DataPropertyName = "MaChucVu";
            this.maChucVuDataGridViewTextBoxColumn.HeaderText = "MaChucVu";
            this.maChucVuDataGridViewTextBoxColumn.Name = "maChucVuDataGridViewTextBoxColumn";
            this.maChucVuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // soDienThoaiDataGridViewTextBoxColumn
            // 
            this.soDienThoaiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.soDienThoaiDataGridViewTextBoxColumn.DataPropertyName = "SoDienThoai";
            this.soDienThoaiDataGridViewTextBoxColumn.HeaderText = "SoDienThoai";
            this.soDienThoaiDataGridViewTextBoxColumn.Name = "soDienThoaiDataGridViewTextBoxColumn";
            this.soDienThoaiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nHANVIENBindingSource
            // 
            this.nHANVIENBindingSource.DataMember = "NHANVIEN";
            this.nHANVIENBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nHANVIENTableAdapter
            // 
            this.nHANVIENTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(79, 608);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(247, 53);
            this.button1.TabIndex = 2;
            this.button1.Text = "Chỉnh sửa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(428, 608);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(247, 53);
            this.button2.TabIndex = 3;
            this.button2.Text = "Xóa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(769, 608);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(247, 53);
            this.button3.TabIndex = 4;
            this.button3.Text = "Đóng";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // tb_MaNV
            // 
            this.tb_MaNV.Enabled = false;
            this.tb_MaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_MaNV.Location = new System.Drawing.Point(152, 342);
            this.tb_MaNV.Name = "tb_MaNV";
            this.tb_MaNV.Size = new System.Drawing.Size(132, 30);
            this.tb_MaNV.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 342);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mã Nhân Viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 402);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tên Nhân Viên";
            // 
            // tb_TenNV
            // 
            this.tb_TenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_TenNV.Location = new System.Drawing.Point(152, 399);
            this.tb_TenNV.Name = "tb_TenNV";
            this.tb_TenNV.Size = new System.Drawing.Size(289, 30);
            this.tb_TenNV.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(467, 402);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Số điện thoại";
            // 
            // tb_Sdt
            // 
            this.tb_Sdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Sdt.Location = new System.Drawing.Point(612, 399);
            this.tb_Sdt.Name = "tb_Sdt";
            this.tb_Sdt.Size = new System.Drawing.Size(289, 30);
            this.tb_Sdt.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 466);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Tài Khoản";
            // 
            // tb_TK
            // 
            this.tb_TK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_TK.Location = new System.Drawing.Point(152, 463);
            this.tb_TK.Name = "tb_TK";
            this.tb_TK.Size = new System.Drawing.Size(289, 30);
            this.tb_TK.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(467, 466);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Mật Khẩu";
            // 
            // tb_MK
            // 
            this.tb_MK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_MK.Location = new System.Drawing.Point(612, 463);
            this.tb_MK.Name = "tb_MK";
            this.tb_MK.Size = new System.Drawing.Size(289, 30);
            this.tb_MK.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 527);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "Trạng Thái";
            // 
            // cb_TrangThai
            // 
            this.cb_TrangThai.DataSource = this.tRANGTHAINHANVIENBindingSource;
            this.cb_TrangThai.DisplayMember = "TenTrangThaiNhaVien";
            this.cb_TrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_TrangThai.FormattingEnabled = true;
            this.cb_TrangThai.Location = new System.Drawing.Point(152, 527);
            this.cb_TrangThai.Name = "cb_TrangThai";
            this.cb_TrangThai.Size = new System.Drawing.Size(132, 33);
            this.cb_TrangThai.TabIndex = 17;
            this.cb_TrangThai.ValueMember = "MaTrangThaiNhanVien";
            // 
            // tRANGTHAINHANVIENBindingSource
            // 
            this.tRANGTHAINHANVIENBindingSource.DataMember = "TRANGTHAINHANVIEN";
            this.tRANGTHAINHANVIENBindingSource.DataSource = this.dataSet1;
            // 
            // cHUCVUBindingSource
            // 
            this.cHUCVUBindingSource.DataMember = "CHUCVU";
            this.cHUCVUBindingSource.DataSource = this.dataSet1;
            // 
            // cHUCVUTableAdapter
            // 
            this.cHUCVUTableAdapter.ClearBeforeFill = true;
            // 
            // tRANGTHAINHANVIENTableAdapter
            // 
            this.tRANGTHAINHANVIENTableAdapter.ClearBeforeFill = true;
            // 
            // cb_CV
            // 
            this.cb_CV.DataSource = this.cHUCVUBindingSource;
            this.cb_CV.DisplayMember = "TenChucVu";
            this.cb_CV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_CV.FormattingEnabled = true;
            this.cb_CV.Location = new System.Drawing.Point(612, 530);
            this.cb_CV.Name = "cb_CV";
            this.cb_CV.Size = new System.Drawing.Size(132, 33);
            this.cb_CV.TabIndex = 19;
            this.cb_CV.ValueMember = "MaChucVu";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(467, 530);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 25);
            this.label8.TabIndex = 18;
            this.label8.Text = "Chức vụ";
            // 
            // QuanLyDanhSachNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 673);
            this.Controls.Add(this.cb_CV);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cb_TrangThai);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_MK);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_TK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_Sdt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_TenNV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_MaNV);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "QuanLyDanhSachNhanVien";
            this.Text = "QuanLyDanhSachNhanVien";
            this.Load += new System.EventHandler(this.QuanLyDanhSachNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRANGTHAINHANVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHUCVUBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource nHANVIENBindingSource;
        private DataSet1TableAdapters.NHANVIENTableAdapter nHANVIENTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNhanVienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNhanVienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taiKhoanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn matKhauDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maTrangThaiNhanVienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maChucVuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soDienThoaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox tb_MaNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_TenNV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_Sdt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_TK;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_MK;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cb_TrangThai;
        private System.Windows.Forms.BindingSource cHUCVUBindingSource;
        private DataSet1TableAdapters.CHUCVUTableAdapter cHUCVUTableAdapter;
        private System.Windows.Forms.BindingSource tRANGTHAINHANVIENBindingSource;
        private DataSet1TableAdapters.TRANGTHAINHANVIENTableAdapter tRANGTHAINHANVIENTableAdapter;
        private System.Windows.Forms.ComboBox cb_CV;
        private System.Windows.Forms.Label label8;
    }
}