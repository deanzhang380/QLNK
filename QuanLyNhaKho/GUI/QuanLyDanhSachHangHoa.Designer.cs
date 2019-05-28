namespace QuanLyNhaKho.GUI
{
    partial class QuanLyDanhSachHangHoa
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
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_TenNV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_MaNV = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.maHangHoaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenHangHoaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maTrangThaiHangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maDonViTinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maNhaSanXuatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maLoaiHangHoaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hANGHOABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new QuanLyNhaKho.DataSet1();
            this.label1 = new System.Windows.Forms.Label();
            this.hANGHOATableAdapter = new QuanLyNhaKho.DataSet1TableAdapters.HANGHOATableAdapter();
            this.cb_LoaiHangHoa = new System.Windows.Forms.ComboBox();
            this.lOAIHANGHOABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cb_Nsx = new System.Windows.Forms.ComboBox();
            this.nHASANXUATBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.cb_TrangThaiHH = new System.Windows.Forms.ComboBox();
            this.tRANGTHAIHANGHOABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.cb_Donvi = new System.Windows.Forms.ComboBox();
            this.dONVITINHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.lOAIHANGHOATableAdapter = new QuanLyNhaKho.DataSet1TableAdapters.LOAIHANGHOATableAdapter();
            this.dONVITINHTableAdapter = new QuanLyNhaKho.DataSet1TableAdapters.DONVITINHTableAdapter();
            this.tRANGTHAIHANGHOATableAdapter = new QuanLyNhaKho.DataSet1TableAdapters.TRANGTHAIHANGHOATableAdapter();
            this.nHASANXUATTableAdapter = new QuanLyNhaKho.DataSet1TableAdapters.NHASANXUATTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hANGHOABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOAIHANGHOABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHASANXUATBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRANGTHAIHANGHOABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dONVITINHBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 465);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 25);
            this.label5.TabIndex = 31;
            this.label5.Text = "Loại Hàng Hóa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 401);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 25);
            this.label3.TabIndex = 27;
            this.label3.Text = "Tên Mặt Hàng";
            // 
            // tb_TenNV
            // 
            this.tb_TenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_TenNV.Location = new System.Drawing.Point(152, 398);
            this.tb_TenNV.Name = "tb_TenNV";
            this.tb_TenNV.Size = new System.Drawing.Size(289, 30);
            this.tb_TenNV.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 341);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 25);
            this.label2.TabIndex = 25;
            this.label2.Text = "Mã Hàng Hóa";
            // 
            // tb_MaNV
            // 
            this.tb_MaNV.Enabled = false;
            this.tb_MaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_MaNV.Location = new System.Drawing.Point(152, 341);
            this.tb_MaNV.Name = "tb_MaNV";
            this.tb_MaNV.Size = new System.Drawing.Size(132, 30);
            this.tb_MaNV.TabIndex = 24;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(651, 608);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(247, 53);
            this.button3.TabIndex = 23;
            this.button3.Text = "Đóng";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(236, 608);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(247, 53);
            this.button1.TabIndex = 21;
            this.button1.Text = "Chỉnh sửa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maHangHoaDataGridViewTextBoxColumn,
            this.tenHangHoaDataGridViewTextBoxColumn,
            this.maTrangThaiHangDataGridViewTextBoxColumn,
            this.maDonViTinhDataGridViewTextBoxColumn,
            this.maNhaSanXuatDataGridViewTextBoxColumn,
            this.maLoaiHangHoaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.hANGHOABindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1082, 261);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // maHangHoaDataGridViewTextBoxColumn
            // 
            this.maHangHoaDataGridViewTextBoxColumn.DataPropertyName = "MaHangHoa";
            this.maHangHoaDataGridViewTextBoxColumn.HeaderText = "MaHangHoa";
            this.maHangHoaDataGridViewTextBoxColumn.Name = "maHangHoaDataGridViewTextBoxColumn";
            this.maHangHoaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenHangHoaDataGridViewTextBoxColumn
            // 
            this.tenHangHoaDataGridViewTextBoxColumn.DataPropertyName = "TenHangHoa";
            this.tenHangHoaDataGridViewTextBoxColumn.HeaderText = "TenHangHoa";
            this.tenHangHoaDataGridViewTextBoxColumn.Name = "tenHangHoaDataGridViewTextBoxColumn";
            this.tenHangHoaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maTrangThaiHangDataGridViewTextBoxColumn
            // 
            this.maTrangThaiHangDataGridViewTextBoxColumn.DataPropertyName = "MaTrangThaiHang";
            this.maTrangThaiHangDataGridViewTextBoxColumn.HeaderText = "MaTrangThaiHang";
            this.maTrangThaiHangDataGridViewTextBoxColumn.Name = "maTrangThaiHangDataGridViewTextBoxColumn";
            this.maTrangThaiHangDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maDonViTinhDataGridViewTextBoxColumn
            // 
            this.maDonViTinhDataGridViewTextBoxColumn.DataPropertyName = "MaDonViTinh";
            this.maDonViTinhDataGridViewTextBoxColumn.HeaderText = "MaDonViTinh";
            this.maDonViTinhDataGridViewTextBoxColumn.Name = "maDonViTinhDataGridViewTextBoxColumn";
            this.maDonViTinhDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maNhaSanXuatDataGridViewTextBoxColumn
            // 
            this.maNhaSanXuatDataGridViewTextBoxColumn.DataPropertyName = "MaNhaSanXuat";
            this.maNhaSanXuatDataGridViewTextBoxColumn.HeaderText = "MaNhaSanXuat";
            this.maNhaSanXuatDataGridViewTextBoxColumn.Name = "maNhaSanXuatDataGridViewTextBoxColumn";
            this.maNhaSanXuatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maLoaiHangHoaDataGridViewTextBoxColumn
            // 
            this.maLoaiHangHoaDataGridViewTextBoxColumn.DataPropertyName = "MaLoaiHangHoa";
            this.maLoaiHangHoaDataGridViewTextBoxColumn.HeaderText = "MaLoaiHangHoa";
            this.maLoaiHangHoaDataGridViewTextBoxColumn.Name = "maLoaiHangHoaDataGridViewTextBoxColumn";
            this.maLoaiHangHoaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hANGHOABindingSource
            // 
            this.hANGHOABindingSource.DataMember = "HANGHOA";
            this.hANGHOABindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(394, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 32);
            this.label1.TabIndex = 38;
            this.label1.Text = "Danh sách hàng hóa";
            // 
            // hANGHOATableAdapter
            // 
            this.hANGHOATableAdapter.ClearBeforeFill = true;
            // 
            // cb_LoaiHangHoa
            // 
            this.cb_LoaiHangHoa.DataSource = this.lOAIHANGHOABindingSource;
            this.cb_LoaiHangHoa.DisplayMember = "TenLoaiHangHoa";
            this.cb_LoaiHangHoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_LoaiHangHoa.FormattingEnabled = true;
            this.cb_LoaiHangHoa.Location = new System.Drawing.Point(152, 462);
            this.cb_LoaiHangHoa.Name = "cb_LoaiHangHoa";
            this.cb_LoaiHangHoa.Size = new System.Drawing.Size(169, 33);
            this.cb_LoaiHangHoa.TabIndex = 39;
            this.cb_LoaiHangHoa.ValueMember = "MaLoaiHangHoa";
            // 
            // lOAIHANGHOABindingSource
            // 
            this.lOAIHANGHOABindingSource.DataMember = "LOAIHANGHOA";
            this.lOAIHANGHOABindingSource.DataSource = this.dataSet1;
            // 
            // cb_Nsx
            // 
            this.cb_Nsx.DataSource = this.nHASANXUATBindingSource;
            this.cb_Nsx.DisplayMember = "TenNhaSanXuat";
            this.cb_Nsx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Nsx.FormattingEnabled = true;
            this.cb_Nsx.Location = new System.Drawing.Point(672, 524);
            this.cb_Nsx.Name = "cb_Nsx";
            this.cb_Nsx.Size = new System.Drawing.Size(169, 33);
            this.cb_Nsx.TabIndex = 48;
            this.cb_Nsx.ValueMember = "MaNhaSanXuat";
            // 
            // nHASANXUATBindingSource
            // 
            this.nHASANXUATBindingSource.DataMember = "NHASANXUAT";
            this.nHASANXUATBindingSource.DataSource = this.dataSet1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(454, 527);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 25);
            this.label6.TabIndex = 47;
            this.label6.Text = "Nhà sản xuất";
            // 
            // cb_TrangThaiHH
            // 
            this.cb_TrangThaiHH.DataSource = this.tRANGTHAIHANGHOABindingSource;
            this.cb_TrangThaiHH.DisplayMember = "TenTrangTHaiHang";
            this.cb_TrangThaiHH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_TrangThaiHH.FormattingEnabled = true;
            this.cb_TrangThaiHH.Location = new System.Drawing.Point(672, 462);
            this.cb_TrangThaiHH.Name = "cb_TrangThaiHH";
            this.cb_TrangThaiHH.Size = new System.Drawing.Size(169, 33);
            this.cb_TrangThaiHH.TabIndex = 46;
            this.cb_TrangThaiHH.ValueMember = "MaTrangThaiHang";
            // 
            // tRANGTHAIHANGHOABindingSource
            // 
            this.tRANGTHAIHANGHOABindingSource.DataMember = "TRANGTHAIHANGHOA";
            this.tRANGTHAIHANGHOABindingSource.DataSource = this.dataSet1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(454, 465);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(160, 25);
            this.label9.TabIndex = 45;
            this.label9.Text = "Trạng Thái Hàng";
            // 
            // cb_Donvi
            // 
            this.cb_Donvi.DataSource = this.dONVITINHBindingSource;
            this.cb_Donvi.DisplayMember = "TenDonViTinh";
            this.cb_Donvi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Donvi.FormattingEnabled = true;
            this.cb_Donvi.Location = new System.Drawing.Point(152, 524);
            this.cb_Donvi.Name = "cb_Donvi";
            this.cb_Donvi.Size = new System.Drawing.Size(169, 33);
            this.cb_Donvi.TabIndex = 44;
            this.cb_Donvi.ValueMember = "MaDonViTinh";
            // 
            // dONVITINHBindingSource
            // 
            this.dONVITINHBindingSource.DataMember = "DONVITINH";
            this.dONVITINHBindingSource.DataSource = this.dataSet1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 527);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 25);
            this.label4.TabIndex = 43;
            this.label4.Text = "Đơn vị";
            // 
            // lOAIHANGHOATableAdapter
            // 
            this.lOAIHANGHOATableAdapter.ClearBeforeFill = true;
            // 
            // dONVITINHTableAdapter
            // 
            this.dONVITINHTableAdapter.ClearBeforeFill = true;
            // 
            // tRANGTHAIHANGHOATableAdapter
            // 
            this.tRANGTHAIHANGHOATableAdapter.ClearBeforeFill = true;
            // 
            // nHASANXUATTableAdapter
            // 
            this.nHASANXUATTableAdapter.ClearBeforeFill = true;
            // 
            // QuanLyDanhSachHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1106, 673);
            this.Controls.Add(this.cb_Nsx);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cb_TrangThaiHH);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cb_Donvi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_LoaiHangHoa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_TenNV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_MaNV);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QuanLyDanhSachHangHoa";
            this.Text = "QuanLyDanhSachHangHoa";
            this.Load += new System.EventHandler(this.QuanLyDanhSachHangHoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hANGHOABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOAIHANGHOABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHASANXUATBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRANGTHAIHANGHOABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dONVITINHBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_TenNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_MaNV;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource hANGHOABindingSource;
        private DataSet1TableAdapters.HANGHOATableAdapter hANGHOATableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHangHoaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenHangHoaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maTrangThaiHangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDonViTinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNhaSanXuatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLoaiHangHoaDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox cb_LoaiHangHoa;
        private System.Windows.Forms.ComboBox cb_Nsx;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_TrangThaiHH;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cb_Donvi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource lOAIHANGHOABindingSource;
        private DataSet1TableAdapters.LOAIHANGHOATableAdapter lOAIHANGHOATableAdapter;
        private System.Windows.Forms.BindingSource dONVITINHBindingSource;
        private DataSet1TableAdapters.DONVITINHTableAdapter dONVITINHTableAdapter;
        private System.Windows.Forms.BindingSource tRANGTHAIHANGHOABindingSource;
        private DataSet1TableAdapters.TRANGTHAIHANGHOATableAdapter tRANGTHAIHANGHOATableAdapter;
        private System.Windows.Forms.BindingSource nHASANXUATBindingSource;
        private DataSet1TableAdapters.NHASANXUATTableAdapter nHASANXUATTableAdapter;
    }
}