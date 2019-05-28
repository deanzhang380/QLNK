namespace QuanLyNhaKho.GUI
{
    partial class TrangThaiNhanVien
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
            this.tb_Ten = new System.Windows.Forms.TextBox();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.maTrangThaiNhanVienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenTrangThaiNhaVienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tRANGTHAINHANVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new QuanLyNhaKho.DataSet1();
            this.label1 = new System.Windows.Forms.Label();
            this.tRANGTHAINHANVIENTableAdapter = new QuanLyNhaKho.DataSet1TableAdapters.TRANGTHAINHANVIENTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRANGTHAINHANVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(489, 490);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(151, 49);
            this.button4.TabIndex = 19;
            this.button4.Text = "Đóng";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tb_Ten
            // 
            this.tb_Ten.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Ten.Location = new System.Drawing.Point(489, 434);
            this.tb_Ten.Name = "tb_Ten";
            this.tb_Ten.Size = new System.Drawing.Size(218, 30);
            this.tb_Ten.TabIndex = 18;
            // 
            // tb_ID
            // 
            this.tb_ID.Enabled = false;
            this.tb_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ID.Location = new System.Drawing.Point(176, 434);
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(138, 30);
            this.tb_ID.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(335, 437);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Tên Trạng Thái";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 437);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Mã Trạng Thái";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(163, 490);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 49);
            this.button1.TabIndex = 12;
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
            this.maTrangThaiNhanVienDataGridViewTextBoxColumn,
            this.tenTrangThaiNhaVienDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tRANGTHAINHANVIENBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(708, 357);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // maTrangThaiNhanVienDataGridViewTextBoxColumn
            // 
            this.maTrangThaiNhanVienDataGridViewTextBoxColumn.DataPropertyName = "MaTrangThaiNhanVien";
            this.maTrangThaiNhanVienDataGridViewTextBoxColumn.HeaderText = "Mã Trạng Thái";
            this.maTrangThaiNhanVienDataGridViewTextBoxColumn.Name = "maTrangThaiNhanVienDataGridViewTextBoxColumn";
            this.maTrangThaiNhanVienDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenTrangThaiNhaVienDataGridViewTextBoxColumn
            // 
            this.tenTrangThaiNhaVienDataGridViewTextBoxColumn.DataPropertyName = "TenTrangThaiNhaVien";
            this.tenTrangThaiNhaVienDataGridViewTextBoxColumn.HeaderText = "Tên Trạng Thái Nhân Viên";
            this.tenTrangThaiNhaVienDataGridViewTextBoxColumn.Name = "tenTrangThaiNhaVienDataGridViewTextBoxColumn";
            this.tenTrangThaiNhaVienDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tRANGTHAINHANVIENBindingSource
            // 
            this.tRANGTHAINHANVIENBindingSource.DataMember = "TRANGTHAINHANVIEN";
            this.tRANGTHAINHANVIENBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(211, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "Quản lý trạng thái nhân viên";
            // 
            // tRANGTHAINHANVIENTableAdapter
            // 
            this.tRANGTHAINHANVIENTableAdapter.ClearBeforeFill = true;
            // 
            // TrangThaiNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 563);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.tb_Ten);
            this.Controls.Add(this.tb_ID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TrangThaiNhanVien";
            this.Text = "TrangThaiNhanVien";
            this.Load += new System.EventHandler(this.TrangThaiNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRANGTHAINHANVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox tb_Ten;
        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource tRANGTHAINHANVIENBindingSource;
        private DataSet1TableAdapters.TRANGTHAINHANVIENTableAdapter tRANGTHAINHANVIENTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maTrangThaiNhanVienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenTrangThaiNhaVienDataGridViewTextBoxColumn;
    }
}