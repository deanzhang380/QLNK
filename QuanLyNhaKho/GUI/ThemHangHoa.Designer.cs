namespace QuanLyNhaKho.GUI
{
    partial class ThemHangHoa
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
            this.btn_HuyBo = new System.Windows.Forms.Button();
            this.btn_LamLai = new System.Windows.Forms.Button();
            this.btn_TaoMoi = new System.Windows.Forms.Button();
            this.tb_MaHH = new System.Windows.Forms.TextBox();
            this.cb_Donvi = new System.Windows.Forms.ComboBox();
            this.dONVITINHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new QuanLyNhaKho.DataSet1();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_TenHH = new System.Windows.Forms.TextBox();
            this.cb_LoaiHH = new System.Windows.Forms.ComboBox();
            this.lOAIHANGHOABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tRANGTHAIHANGHOABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOAIHANGHOATableAdapter = new QuanLyNhaKho.DataSet1TableAdapters.LOAIHANGHOATableAdapter();
            this.dONVITINHTableAdapter = new QuanLyNhaKho.DataSet1TableAdapters.DONVITINHTableAdapter();
            this.tRANGTHAIHANGHOATableAdapter = new QuanLyNhaKho.DataSet1TableAdapters.TRANGTHAIHANGHOATableAdapter();
            this.cb_Nsx = new System.Windows.Forms.ComboBox();
            this.nHASANXUATBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet11 = new QuanLyNhaKho.DataSet1();
            this.label6 = new System.Windows.Forms.Label();
            this.nHASANXUATTableAdapter = new QuanLyNhaKho.DataSet1TableAdapters.NHASANXUATTableAdapter();
            this.tb_min = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_max = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dONVITINHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOAIHANGHOABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRANGTHAIHANGHOABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHASANXUATBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_HuyBo
            // 
            this.btn_HuyBo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HuyBo.Location = new System.Drawing.Point(502, 409);
            this.btn_HuyBo.Name = "btn_HuyBo";
            this.btn_HuyBo.Size = new System.Drawing.Size(125, 46);
            this.btn_HuyBo.TabIndex = 33;
            this.btn_HuyBo.Text = "Đóng";
            this.btn_HuyBo.UseVisualStyleBackColor = true;
            this.btn_HuyBo.Click += new System.EventHandler(this.btn_HuyBo_Click);
            // 
            // btn_LamLai
            // 
            this.btn_LamLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LamLai.Location = new System.Drawing.Point(318, 409);
            this.btn_LamLai.Name = "btn_LamLai";
            this.btn_LamLai.Size = new System.Drawing.Size(125, 46);
            this.btn_LamLai.TabIndex = 32;
            this.btn_LamLai.Text = "Làm lại";
            this.btn_LamLai.UseVisualStyleBackColor = true;
            this.btn_LamLai.Click += new System.EventHandler(this.btn_LamLai_Click);
            // 
            // btn_TaoMoi
            // 
            this.btn_TaoMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TaoMoi.Location = new System.Drawing.Point(133, 409);
            this.btn_TaoMoi.Name = "btn_TaoMoi";
            this.btn_TaoMoi.Size = new System.Drawing.Size(125, 46);
            this.btn_TaoMoi.TabIndex = 31;
            this.btn_TaoMoi.Text = "Tạo mới";
            this.btn_TaoMoi.UseVisualStyleBackColor = true;
            this.btn_TaoMoi.Click += new System.EventHandler(this.btn_TaoMoi_Click);
            // 
            // tb_MaHH
            // 
            this.tb_MaHH.Enabled = false;
            this.tb_MaHH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_MaHH.Location = new System.Drawing.Point(238, 74);
            this.tb_MaHH.Name = "tb_MaHH";
            this.tb_MaHH.Size = new System.Drawing.Size(169, 30);
            this.tb_MaHH.TabIndex = 27;
            // 
            // cb_Donvi
            // 
            this.cb_Donvi.DataSource = this.dONVITINHBindingSource;
            this.cb_Donvi.DisplayMember = "TenDonViTinh";
            this.cb_Donvi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Donvi.FormattingEnabled = true;
            this.cb_Donvi.Location = new System.Drawing.Point(238, 233);
            this.cb_Donvi.Name = "cb_Donvi";
            this.cb_Donvi.Size = new System.Drawing.Size(169, 33);
            this.cb_Donvi.TabIndex = 26;
            this.cb_Donvi.ValueMember = "MaDonViTinh";
            // 
            // dONVITINHBindingSource
            // 
            this.dONVITINHBindingSource.DataMember = "DONVITINH";
            this.dONVITINHBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(79, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 25);
            this.label5.TabIndex = 24;
            this.label5.Text = "Loại Hàng Hóa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(79, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 25);
            this.label4.TabIndex = 23;
            this.label4.Text = "Đơn vị";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(79, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 25);
            this.label3.TabIndex = 22;
            this.label3.Text = "Tên Mặt Hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(79, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 25);
            this.label2.TabIndex = 21;
            this.label2.Text = "Mã hàng hóa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(230, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 46);
            this.label1.TabIndex = 20;
            this.label1.Text = "Tạo hàng hóa";
            // 
            // tb_TenHH
            // 
            this.tb_TenHH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_TenHH.Location = new System.Drawing.Point(238, 128);
            this.tb_TenHH.Name = "tb_TenHH";
            this.tb_TenHH.Size = new System.Drawing.Size(330, 30);
            this.tb_TenHH.TabIndex = 28;
            // 
            // cb_LoaiHH
            // 
            this.cb_LoaiHH.DataSource = this.lOAIHANGHOABindingSource;
            this.cb_LoaiHH.DisplayMember = "TenLoaiHangHoa";
            this.cb_LoaiHH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_LoaiHH.FormattingEnabled = true;
            this.cb_LoaiHH.Location = new System.Drawing.Point(238, 179);
            this.cb_LoaiHH.Name = "cb_LoaiHH";
            this.cb_LoaiHH.Size = new System.Drawing.Size(169, 33);
            this.cb_LoaiHH.TabIndex = 39;
            this.cb_LoaiHH.ValueMember = "MaLoaiHangHoa";
            // 
            // lOAIHANGHOABindingSource
            // 
            this.lOAIHANGHOABindingSource.DataMember = "LOAIHANGHOA";
            this.lOAIHANGHOABindingSource.DataSource = this.dataSet1;
            // 
            // tRANGTHAIHANGHOABindingSource
            // 
            this.tRANGTHAIHANGHOABindingSource.DataMember = "TRANGTHAIHANGHOA";
            this.tRANGTHAIHANGHOABindingSource.DataSource = this.dataSet1;
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
            // cb_Nsx
            // 
            this.cb_Nsx.DataSource = this.nHASANXUATBindingSource;
            this.cb_Nsx.DisplayMember = "TenNhaSanXuat";
            this.cb_Nsx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Nsx.FormattingEnabled = true;
            this.cb_Nsx.Location = new System.Drawing.Point(238, 347);
            this.cb_Nsx.Name = "cb_Nsx";
            this.cb_Nsx.Size = new System.Drawing.Size(169, 33);
            this.cb_Nsx.TabIndex = 42;
            this.cb_Nsx.ValueMember = "MaNhaSanXuat";
            // 
            // nHASANXUATBindingSource
            // 
            this.nHASANXUATBindingSource.DataMember = "NHASANXUAT";
            this.nHASANXUATBindingSource.DataSource = this.dataSet11;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(79, 350);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 25);
            this.label6.TabIndex = 41;
            this.label6.Text = "Nhà sản xuất";
            // 
            // nHASANXUATTableAdapter
            // 
            this.nHASANXUATTableAdapter.ClearBeforeFill = true;
            // 
            // tb_min
            // 
            this.tb_min.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_min.Location = new System.Drawing.Point(238, 297);
            this.tb_min.Name = "tb_min";
            this.tb_min.Size = new System.Drawing.Size(108, 30);
            this.tb_min.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(79, 297);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 25);
            this.label7.TabIndex = 43;
            this.label7.Text = "Tồn Tối Thiểu";
            // 
            // tb_max
            // 
            this.tb_max.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_max.Location = new System.Drawing.Point(536, 300);
            this.tb_max.Name = "tb_max";
            this.tb_max.Size = new System.Drawing.Size(108, 30);
            this.tb_max.TabIndex = 46;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(395, 300);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 25);
            this.label8.TabIndex = 45;
            this.label8.Text = "Tồn Tối Đa";
            // 
            // ThemHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 485);
            this.Controls.Add(this.tb_max);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tb_min);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cb_Nsx);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cb_LoaiHH);
            this.Controls.Add(this.btn_HuyBo);
            this.Controls.Add(this.btn_LamLai);
            this.Controls.Add(this.btn_TaoMoi);
            this.Controls.Add(this.tb_TenHH);
            this.Controls.Add(this.tb_MaHH);
            this.Controls.Add(this.cb_Donvi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ThemHangHoa";
            this.Text = "ThemHangHoa";
            this.Load += new System.EventHandler(this.ThemHangHoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dONVITINHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOAIHANGHOABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRANGTHAIHANGHOABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHASANXUATBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_HuyBo;
        private System.Windows.Forms.Button btn_LamLai;
        private System.Windows.Forms.Button btn_TaoMoi;
        private System.Windows.Forms.TextBox tb_MaHH;
        private System.Windows.Forms.ComboBox cb_Donvi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_TenHH;
        private System.Windows.Forms.ComboBox cb_LoaiHH;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource lOAIHANGHOABindingSource;
        private DataSet1TableAdapters.LOAIHANGHOATableAdapter lOAIHANGHOATableAdapter;
        private System.Windows.Forms.BindingSource dONVITINHBindingSource;
        private DataSet1TableAdapters.DONVITINHTableAdapter dONVITINHTableAdapter;
        private System.Windows.Forms.BindingSource tRANGTHAIHANGHOABindingSource;
        private DataSet1TableAdapters.TRANGTHAIHANGHOATableAdapter tRANGTHAIHANGHOATableAdapter;
        private System.Windows.Forms.ComboBox cb_Nsx;
        private System.Windows.Forms.Label label6;
        private DataSet1 dataSet11;
        private System.Windows.Forms.BindingSource nHASANXUATBindingSource;
        private DataSet1TableAdapters.NHASANXUATTableAdapter nHASANXUATTableAdapter;
        private System.Windows.Forms.TextBox tb_min;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_max;
        private System.Windows.Forms.Label label8;
    }
}