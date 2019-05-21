namespace QuanLyNhaKho
{
    partial class TaoMoiNhanVien
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_ChucVu = new System.Windows.Forms.ComboBox();
            this.cHUCVUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new QuanLyNhaKho.DataSet1();
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cHUCVUTableAdapter = new QuanLyNhaKho.DataSet1TableAdapters.CHUCVUTableAdapter();
            this.tb_MaNV = new System.Windows.Forms.TextBox();
            this.tb_TenNhanVien = new System.Windows.Forms.TextBox();
            this.tb_TaiKhoan = new System.Windows.Forms.TextBox();
            this.tb_MatKhau = new System.Windows.Forms.TextBox();
            this.btn_TaoMoi = new System.Windows.Forms.Button();
            this.btn_LamLai = new System.Windows.Forms.Button();
            this.btn_HuyBo = new System.Windows.Forms.Button();
            this.nhanvienTableAdapter1 = new QuanLyNhaKho.DataSet1TableAdapters.NHANVIENTableAdapter();
            this.cb_TrangThai = new System.Windows.Forms.ComboBox();
            this.tRANGTHAINHANVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.cHUCVUBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tRANGTHAINHANVIENTableAdapter = new QuanLyNhaKho.DataSet1TableAdapters.TRANGTHAINHANVIENTableAdapter();
            this.tb_MatKhau2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_sdt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cHUCVUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRANGTHAINHANVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHUCVUBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(298, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tạo Tài Khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã nhân viên (auto)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên Nhân viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Chức vụ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tài Khoản";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 345);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Mật Khẩu";
            // 
            // cb_ChucVu
            // 
            this.cb_ChucVu.DataSource = this.cHUCVUBindingSource;
            this.cb_ChucVu.DisplayMember = "TenChucVu";
            this.cb_ChucVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_ChucVu.FormattingEnabled = true;
            this.cb_ChucVu.Location = new System.Drawing.Point(234, 235);
            this.cb_ChucVu.Name = "cb_ChucVu";
            this.cb_ChucVu.Size = new System.Drawing.Size(169, 33);
            this.cb_ChucVu.TabIndex = 6;
            this.cb_ChucVu.ValueMember = "MaChucVu";
            // 
            // cHUCVUBindingSource
            // 
            this.cHUCVUBindingSource.DataMember = "CHUCVU";
            this.cHUCVUBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // cHUCVUTableAdapter
            // 
            this.cHUCVUTableAdapter.ClearBeforeFill = true;
            // 
            // tb_MaNV
            // 
            this.tb_MaNV.Enabled = false;
            this.tb_MaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_MaNV.Location = new System.Drawing.Point(234, 73);
            this.tb_MaNV.Name = "tb_MaNV";
            this.tb_MaNV.Size = new System.Drawing.Size(169, 30);
            this.tb_MaNV.TabIndex = 7;
            // 
            // tb_TenNhanVien
            // 
            this.tb_TenNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_TenNhanVien.Location = new System.Drawing.Point(234, 127);
            this.tb_TenNhanVien.Name = "tb_TenNhanVien";
            this.tb_TenNhanVien.Size = new System.Drawing.Size(330, 30);
            this.tb_TenNhanVien.TabIndex = 8;
            // 
            // tb_TaiKhoan
            // 
            this.tb_TaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_TaiKhoan.Location = new System.Drawing.Point(234, 288);
            this.tb_TaiKhoan.Name = "tb_TaiKhoan";
            this.tb_TaiKhoan.Size = new System.Drawing.Size(330, 30);
            this.tb_TaiKhoan.TabIndex = 9;
            // 
            // tb_MatKhau
            // 
            this.tb_MatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_MatKhau.Location = new System.Drawing.Point(234, 340);
            this.tb_MatKhau.Name = "tb_MatKhau";
            this.tb_MatKhau.Size = new System.Drawing.Size(330, 30);
            this.tb_MatKhau.TabIndex = 10;
            this.tb_MatKhau.UseSystemPasswordChar = true;
            // 
            // btn_TaoMoi
            // 
            this.btn_TaoMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TaoMoi.Location = new System.Drawing.Point(147, 495);
            this.btn_TaoMoi.Name = "btn_TaoMoi";
            this.btn_TaoMoi.Size = new System.Drawing.Size(125, 46);
            this.btn_TaoMoi.TabIndex = 11;
            this.btn_TaoMoi.Text = "Tạo mới";
            this.btn_TaoMoi.UseVisualStyleBackColor = true;
            this.btn_TaoMoi.Click += new System.EventHandler(this.btn_TaoMoi_Click);
            // 
            // btn_LamLai
            // 
            this.btn_LamLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LamLai.Location = new System.Drawing.Point(332, 495);
            this.btn_LamLai.Name = "btn_LamLai";
            this.btn_LamLai.Size = new System.Drawing.Size(125, 46);
            this.btn_LamLai.TabIndex = 12;
            this.btn_LamLai.Text = "Làm lại";
            this.btn_LamLai.UseVisualStyleBackColor = true;
            this.btn_LamLai.Click += new System.EventHandler(this.btn_LamLai_Click);
            // 
            // btn_HuyBo
            // 
            this.btn_HuyBo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HuyBo.Location = new System.Drawing.Point(516, 495);
            this.btn_HuyBo.Name = "btn_HuyBo";
            this.btn_HuyBo.Size = new System.Drawing.Size(125, 46);
            this.btn_HuyBo.TabIndex = 13;
            this.btn_HuyBo.Text = "Hủy bỏ";
            this.btn_HuyBo.UseVisualStyleBackColor = true;
            this.btn_HuyBo.Click += new System.EventHandler(this.btn_HuyBo_Click);
            // 
            // nhanvienTableAdapter1
            // 
            this.nhanvienTableAdapter1.ClearBeforeFill = true;
            // 
            // cb_TrangThai
            // 
            this.cb_TrangThai.DataSource = this.tRANGTHAINHANVIENBindingSource;
            this.cb_TrangThai.DisplayMember = "TenTrangThaiNhaVien";
            this.cb_TrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_TrangThai.FormattingEnabled = true;
            this.cb_TrangThai.Location = new System.Drawing.Point(234, 441);
            this.cb_TrangThai.Name = "cb_TrangThai";
            this.cb_TrangThai.Size = new System.Drawing.Size(169, 33);
            this.cb_TrangThai.TabIndex = 15;
            this.cb_TrangThai.ValueMember = "MaTrangThaiNhanVien";
            // 
            // tRANGTHAINHANVIENBindingSource
            // 
            this.tRANGTHAINHANVIENBindingSource.DataMember = "TRANGTHAINHANVIEN";
            this.tRANGTHAINHANVIENBindingSource.DataSource = this.dataSet1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 449);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "Trạng Thái";
            // 
            // cHUCVUBindingSource1
            // 
            this.cHUCVUBindingSource1.DataMember = "CHUCVU";
            this.cHUCVUBindingSource1.DataSource = this.dataSet1;
            // 
            // tRANGTHAINHANVIENTableAdapter
            // 
            this.tRANGTHAINHANVIENTableAdapter.ClearBeforeFill = true;
            // 
            // tb_MatKhau2
            // 
            this.tb_MatKhau2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_MatKhau2.Location = new System.Drawing.Point(234, 391);
            this.tb_MatKhau2.Name = "tb_MatKhau2";
            this.tb_MatKhau2.Size = new System.Drawing.Size(330, 30);
            this.tb_MatKhau2.TabIndex = 17;
            this.tb_MatKhau2.UseSystemPasswordChar = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 396);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(168, 25);
            this.label8.TabIndex = 16;
            this.label8.Text = "Nhập lại mật khẩu";
            // 
            // tb_sdt
            // 
            this.tb_sdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_sdt.Location = new System.Drawing.Point(234, 178);
            this.tb_sdt.Name = "tb_sdt";
            this.tb_sdt.Size = new System.Drawing.Size(330, 30);
            this.tb_sdt.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 178);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 25);
            this.label9.TabIndex = 18;
            this.label9.Text = "Số điện thoại";
            // 
            // TaoMoiNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.tb_sdt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tb_MatKhau2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cb_TrangThai);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_HuyBo);
            this.Controls.Add(this.btn_LamLai);
            this.Controls.Add(this.btn_TaoMoi);
            this.Controls.Add(this.tb_MatKhau);
            this.Controls.Add(this.tb_TaiKhoan);
            this.Controls.Add(this.tb_TenNhanVien);
            this.Controls.Add(this.tb_MaNV);
            this.Controls.Add(this.cb_ChucVu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TaoMoiNhanVien";
            this.Text = "TaoMoiNhanVien";
            this.Load += new System.EventHandler(this.TaoMoiNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cHUCVUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRANGTHAINHANVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHUCVUBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_ChucVu;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource cHUCVUBindingSource;
        private DataSet1TableAdapters.CHUCVUTableAdapter cHUCVUTableAdapter;
        private System.Windows.Forms.TextBox tb_MaNV;
        private System.Windows.Forms.TextBox tb_TenNhanVien;
        private System.Windows.Forms.TextBox tb_TaiKhoan;
        private System.Windows.Forms.TextBox tb_MatKhau;
        private System.Windows.Forms.Button btn_TaoMoi;
        private System.Windows.Forms.Button btn_LamLai;
        private System.Windows.Forms.Button btn_HuyBo;
        private DataSet1TableAdapters.NHANVIENTableAdapter nhanvienTableAdapter1;
        private System.Windows.Forms.ComboBox cb_TrangThai;
        private System.Windows.Forms.BindingSource cHUCVUBindingSource1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.BindingSource tRANGTHAINHANVIENBindingSource;
        private DataSet1TableAdapters.TRANGTHAINHANVIENTableAdapter tRANGTHAINHANVIENTableAdapter;
        private System.Windows.Forms.TextBox tb_MatKhau2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_sdt;
        private System.Windows.Forms.Label label9;
    }
}