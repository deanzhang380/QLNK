﻿namespace QuanLyNhaKho.GUI
{
    partial class ChiTietPhieuNhap
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
            this.button4 = new System.Windows.Forms.Button();
            this.hANGHOABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet11 = new QuanLyNhaKho.DataSet1();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_NameNV = new System.Windows.Forms.TextBox();
            this.tb_nd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cb_trangthai = new System.Windows.Forms.ComboBox();
            this.tRANGTHAINHAPXUATBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.cb_loaiphieu = new System.Windows.Forms.ComboBox();
            this.lOAIPHIEUXUATNHAPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dt_ngaylap = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dt_ngaynhap = new System.Windows.Forms.DateTimePicker();
            this.lOAIPHIEUXUATNHAPTableAdapter = new QuanLyNhaKho.DataSet1TableAdapters.LOAIPHIEUXUATNHAPTableAdapter();
            this.tRANGTHAINHAPXUATTableAdapter = new QuanLyNhaKho.DataSet1TableAdapters.TRANGTHAINHAPXUATTableAdapter();
            this.hANGHOATableAdapter = new QuanLyNhaKho.DataSet1TableAdapters.HANGHOATableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.hANGHOABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tRANGTHAINHAPXUATBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOAIPHIEUXUATNHAPBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(916, 254);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(160, 46);
            this.button4.TabIndex = 39;
            this.button4.Text = "Đóng";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // hANGHOABindingSource
            // 
            this.hANGHOABindingSource.DataMember = "HANGHOA";
            this.hANGHOABindingSource.DataSource = this.dataSet11;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1070, 224);
            this.dataGridView1.TabIndex = 19;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(9, 282);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1088, 309);
            this.groupBox3.TabIndex = 33;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chi tiết phiếu nhập";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_NameNV);
            this.groupBox1.Controls.Add(this.tb_nd);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.cb_trangthai);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cb_loaiphieu);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tb_ID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(9, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1088, 176);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phiếu nhập";
            // 
            // tb_NameNV
            // 
            this.tb_NameNV.Enabled = false;
            this.tb_NameNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_NameNV.Location = new System.Drawing.Point(588, 24);
            this.tb_NameNV.Name = "tb_NameNV";
            this.tb_NameNV.Size = new System.Drawing.Size(251, 30);
            this.tb_NameNV.TabIndex = 28;
            // 
            // tb_nd
            // 
            this.tb_nd.Enabled = false;
            this.tb_nd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_nd.Location = new System.Drawing.Point(588, 69);
            this.tb_nd.Multiline = true;
            this.tb_nd.Name = "tb_nd";
            this.tb_nd.Size = new System.Drawing.Size(350, 98);
            this.tb_nd.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(411, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 25);
            this.label7.TabIndex = 25;
            this.label7.Text = "Nội Dung";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(411, 27);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(147, 25);
            this.label14.TabIndex = 27;
            this.label14.Text = "Người lập phiếu";
            // 
            // cb_trangthai
            // 
            this.cb_trangthai.DataSource = this.tRANGTHAINHAPXUATBindingSource;
            this.cb_trangthai.DisplayMember = "TenTrangThaiPhieu";
            this.cb_trangthai.Enabled = false;
            this.cb_trangthai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_trangthai.FormattingEnabled = true;
            this.cb_trangthai.Location = new System.Drawing.Point(175, 117);
            this.cb_trangthai.Name = "cb_trangthai";
            this.cb_trangthai.Size = new System.Drawing.Size(169, 33);
            this.cb_trangthai.TabIndex = 22;
            this.cb_trangthai.ValueMember = "MaTrangThaiPhieu";
            // 
            // tRANGTHAINHAPXUATBindingSource
            // 
            this.tRANGTHAINHAPXUATBindingSource.DataMember = "TRANGTHAINHAPXUAT";
            this.tRANGTHAINHAPXUATBindingSource.DataSource = this.dataSet11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 25);
            this.label5.TabIndex = 21;
            this.label5.Text = "Trạng Thái Phiếu";
            // 
            // cb_loaiphieu
            // 
            this.cb_loaiphieu.DataSource = this.lOAIPHIEUXUATNHAPBindingSource;
            this.cb_loaiphieu.DisplayMember = "TenLoaiPhieu";
            this.cb_loaiphieu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_loaiphieu.Enabled = false;
            this.cb_loaiphieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_loaiphieu.FormattingEnabled = true;
            this.cb_loaiphieu.Location = new System.Drawing.Point(175, 72);
            this.cb_loaiphieu.Name = "cb_loaiphieu";
            this.cb_loaiphieu.Size = new System.Drawing.Size(169, 33);
            this.cb_loaiphieu.TabIndex = 20;
            this.cb_loaiphieu.ValueMember = "MaLoaiPhieuXuatNhap";
            // 
            // lOAIPHIEUXUATNHAPBindingSource
            // 
            this.lOAIPHIEUXUATNHAPBindingSource.DataMember = "LOAIPHIEUXUATNHAP";
            this.lOAIPHIEUXUATNHAPBindingSource.DataSource = this.dataSet11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 25);
            this.label4.TabIndex = 19;
            this.label4.Text = "Loại Phiếu Nhập";
            // 
            // tb_ID
            // 
            this.tb_ID.Enabled = false;
            this.tb_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ID.Location = new System.Drawing.Point(175, 27);
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(169, 30);
            this.tb_ID.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "Mã Phiếu Nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 25);
            this.label2.TabIndex = 28;
            this.label2.Text = "Ngày Lập Phiếu";
            // 
            // dt_ngaylap
            // 
            this.dt_ngaylap.Enabled = false;
            this.dt_ngaylap.Location = new System.Drawing.Point(168, 72);
            this.dt_ngaylap.Name = "dt_ngaylap";
            this.dt_ngaylap.Size = new System.Drawing.Size(230, 22);
            this.dt_ngaylap.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(419, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 36);
            this.label1.TabIndex = 26;
            this.label1.Text = "Phiếu Nhập";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(422, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 25);
            this.label6.TabIndex = 32;
            this.label6.Text = "Ngày Nhập Hàng";
            // 
            // dt_ngaynhap
            // 
            this.dt_ngaynhap.Location = new System.Drawing.Point(597, 73);
            this.dt_ngaynhap.Name = "dt_ngaynhap";
            this.dt_ngaynhap.Size = new System.Drawing.Size(230, 22);
            this.dt_ngaynhap.TabIndex = 31;
            // 
            // lOAIPHIEUXUATNHAPTableAdapter
            // 
            this.lOAIPHIEUXUATNHAPTableAdapter.ClearBeforeFill = true;
            // 
            // tRANGTHAINHAPXUATTableAdapter
            // 
            this.tRANGTHAINHAPXUATTableAdapter.ClearBeforeFill = true;
            // 
            // hANGHOATableAdapter
            // 
            this.hANGHOATableAdapter.ClearBeforeFill = true;
            // 
            // ChiTietPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 603);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dt_ngaylap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dt_ngaynhap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ChiTietPhieuNhap";
            this.Text = "ChiTietPhieuNhap";
            this.Load += new System.EventHandler(this.ChiTietPhieuNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hANGHOABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tRANGTHAINHAPXUATBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOAIPHIEUXUATNHAPBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_NameNV;
        private System.Windows.Forms.TextBox tb_nd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cb_trangthai;
        private DataSet1 dataSet11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_loaiphieu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dt_ngaylap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dt_ngaynhap;
        private System.Windows.Forms.BindingSource lOAIPHIEUXUATNHAPBindingSource;
        private DataSet1TableAdapters.LOAIPHIEUXUATNHAPTableAdapter lOAIPHIEUXUATNHAPTableAdapter;
        private System.Windows.Forms.BindingSource tRANGTHAINHAPXUATBindingSource;
        private DataSet1TableAdapters.TRANGTHAINHAPXUATTableAdapter tRANGTHAINHAPXUATTableAdapter;
        private System.Windows.Forms.BindingSource hANGHOABindingSource;
        private DataSet1TableAdapters.HANGHOATableAdapter hANGHOATableAdapter;
    }
}