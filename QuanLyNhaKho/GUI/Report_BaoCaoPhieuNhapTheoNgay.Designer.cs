namespace QuanLyNhaKho.GUI
{
    partial class Report_BaoCaoPhieuNhapTheoNgay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report_BaoCaoPhieuNhapTheoNgay));
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.dataSet11 = new QuanLyNhaKho.DataSet1();
            this.phieunhapTableAdapter1 = new QuanLyNhaKho.DataSet1TableAdapters.PHIEUNHAPTableAdapter();
            this.nhanvienTableAdapter1 = new QuanLyNhaKho.DataSet1TableAdapters.NHANVIENTableAdapter();
            this.trangthainhapxuatTableAdapter1 = new QuanLyNhaKho.DataSet1TableAdapters.TRANGTHAINHAPXUATTableAdapter();
            this.loaiphieuxuatnhapTableAdapter1 = new QuanLyNhaKho.DataSet1TableAdapters.LOAIPHIEUXUATNHAPTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(321, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(426, 32);
            this.label1.TabIndex = 22;
            this.label1.Text = "Báo Cáo Phiếu Nhập Theo Ngày";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(327, 58);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(420, 34);
            this.dateTimePicker1.TabIndex = 23;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(768, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(41, 34);
            this.button1.TabIndex = 24;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.DisplayStatusBar = false;
            this.crystalReportViewer1.Location = new System.Drawing.Point(12, 97);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1082, 570);
            this.crystalReportViewer1.TabIndex = 25;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // phieunhapTableAdapter1
            // 
            this.phieunhapTableAdapter1.ClearBeforeFill = true;
            // 
            // nhanvienTableAdapter1
            // 
            this.nhanvienTableAdapter1.ClearBeforeFill = true;
            // 
            // trangthainhapxuatTableAdapter1
            // 
            this.trangthainhapxuatTableAdapter1.ClearBeforeFill = true;
            // 
            // loaiphieuxuatnhapTableAdapter1
            // 
            this.loaiphieuxuatnhapTableAdapter1.ClearBeforeFill = true;
            // 
            // Report_BaoCaoPhieuNhapTheoNgay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 673);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Report_BaoCaoPhieuNhapTheoNgay";
            this.Text = "Report_BaoCaoPhieuNhapTheoNgay";
            this.Load += new System.EventHandler(this.Report_BaoCaoPhieuNhapTheoNgay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private DataSet1 dataSet11;
        private DataSet1TableAdapters.PHIEUNHAPTableAdapter phieunhapTableAdapter1;
        private DataSet1TableAdapters.NHANVIENTableAdapter nhanvienTableAdapter1;
        private DataSet1TableAdapters.TRANGTHAINHAPXUATTableAdapter trangthainhapxuatTableAdapter1;
        private DataSet1TableAdapters.LOAIPHIEUXUATNHAPTableAdapter loaiphieuxuatnhapTableAdapter1;
    }
}