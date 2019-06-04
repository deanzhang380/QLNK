namespace QuanLyNhaKho.GUI
{
    partial class Report_BaoCaoTon
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.dataSet11 = new QuanLyNhaKho.DataSet1();
            this.hanghoaTableAdapter1 = new QuanLyNhaKho.DataSet1TableAdapters.HANGHOATableAdapter();
            this.loaihanghoaTableAdapter1 = new QuanLyNhaKho.DataSet1TableAdapters.LOAIHANGHOATableAdapter();
            this.donvitinhTableAdapter1 = new QuanLyNhaKho.DataSet1TableAdapters.DONVITINHTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.DisplayStatusBar = false;
            this.crystalReportViewer1.Location = new System.Drawing.Point(12, 44);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1082, 617);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(411, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 32);
            this.label1.TabIndex = 21;
            this.label1.Text = "Báo Cáo Tồn Kho";
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hanghoaTableAdapter1
            // 
            this.hanghoaTableAdapter1.ClearBeforeFill = true;
            // 
            // loaihanghoaTableAdapter1
            // 
            this.loaihanghoaTableAdapter1.ClearBeforeFill = true;
            // 
            // donvitinhTableAdapter1
            // 
            this.donvitinhTableAdapter1.ClearBeforeFill = true;
            // 
            // Report_BaoCaoTon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 673);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.crystalReportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Report_BaoCaoTon";
            this.Text = "Report_BaoCaoTon";
            this.Load += new System.EventHandler(this.Report_BaoCaoTon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Label label1;
        private DataSet1 dataSet11;
        private DataSet1TableAdapters.HANGHOATableAdapter hanghoaTableAdapter1;
        private DataSet1TableAdapters.LOAIHANGHOATableAdapter loaihanghoaTableAdapter1;
        private DataSet1TableAdapters.DONVITINHTableAdapter donvitinhTableAdapter1;
    }
}