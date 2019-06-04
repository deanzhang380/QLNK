namespace QuanLyNhaKho.GUI
{
    partial class GioiHanTon
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
            this.maGioiHanTonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maHangHoaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tonToiThieuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tonToiDaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gIOIHANTONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new QuanLyNhaKho.DataSet1();
            this.button2 = new System.Windows.Forms.Button();
            this.tb_ID_GHT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cb_IDHH = new System.Windows.Forms.ComboBox();
            this.hANGHOABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gIOIHANTONTableAdapter = new QuanLyNhaKho.DataSet1TableAdapters.GIOIHANTONTableAdapter();
            this.hANGHOATableAdapter = new QuanLyNhaKho.DataSet1TableAdapters.HANGHOATableAdapter();
            this.tb_Min = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_Max = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIOIHANTONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hANGHOABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(206, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Quản lý giới hạn tồn kho";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maGioiHanTonDataGridViewTextBoxColumn,
            this.maHangHoaDataGridViewTextBoxColumn,
            this.tonToiThieuDataGridViewTextBoxColumn,
            this.tonToiDaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.gIOIHANTONBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(723, 357);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // maGioiHanTonDataGridViewTextBoxColumn
            // 
            this.maGioiHanTonDataGridViewTextBoxColumn.DataPropertyName = "MaGioiHanTon";
            this.maGioiHanTonDataGridViewTextBoxColumn.HeaderText = "Mã giới hạn tồn";
            this.maGioiHanTonDataGridViewTextBoxColumn.Name = "maGioiHanTonDataGridViewTextBoxColumn";
            this.maGioiHanTonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maHangHoaDataGridViewTextBoxColumn
            // 
            this.maHangHoaDataGridViewTextBoxColumn.DataPropertyName = "MaHangHoa";
            this.maHangHoaDataGridViewTextBoxColumn.HeaderText = "Mã Hàng Hóa";
            this.maHangHoaDataGridViewTextBoxColumn.Name = "maHangHoaDataGridViewTextBoxColumn";
            this.maHangHoaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tonToiThieuDataGridViewTextBoxColumn
            // 
            this.tonToiThieuDataGridViewTextBoxColumn.DataPropertyName = "TonToiThieu";
            this.tonToiThieuDataGridViewTextBoxColumn.HeaderText = "Tồn tối thiểu";
            this.tonToiThieuDataGridViewTextBoxColumn.Name = "tonToiThieuDataGridViewTextBoxColumn";
            this.tonToiThieuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tonToiDaDataGridViewTextBoxColumn
            // 
            this.tonToiDaDataGridViewTextBoxColumn.DataPropertyName = "TonToiDa";
            this.tonToiDaDataGridViewTextBoxColumn.HeaderText = "Tồn tối đa";
            this.tonToiDaDataGridViewTextBoxColumn.Name = "tonToiDaDataGridViewTextBoxColumn";
            this.tonToiDaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gIOIHANTONBindingSource
            // 
            this.gIOIHANTONBindingSource.DataMember = "GIOIHANTON";
            this.gIOIHANTONBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(485, 565);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 50);
            this.button2.TabIndex = 23;
            this.button2.Text = "Đóng";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tb_ID_GHT
            // 
            this.tb_ID_GHT.Enabled = false;
            this.tb_ID_GHT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ID_GHT.Location = new System.Drawing.Point(172, 440);
            this.tb_ID_GHT.Name = "tb_ID_GHT";
            this.tb_ID_GHT.Size = new System.Drawing.Size(138, 30);
            this.tb_ID_GHT.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(349, 440);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 25);
            this.label4.TabIndex = 20;
            this.label4.Text = "Mã Hàng hóa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 443);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "Mã Giới hạn tồn";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(159, 566);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 49);
            this.button1.TabIndex = 18;
            this.button1.Text = "Chỉnh sửa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(1029, 911);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 26;
            // 
            // cb_IDHH
            // 
            this.cb_IDHH.DataSource = this.hANGHOABindingSource;
            this.cb_IDHH.DisplayMember = "MaHangHoa";
            this.cb_IDHH.Enabled = false;
            this.cb_IDHH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_IDHH.FormattingEnabled = true;
            this.cb_IDHH.Location = new System.Drawing.Point(485, 437);
            this.cb_IDHH.Name = "cb_IDHH";
            this.cb_IDHH.Size = new System.Drawing.Size(169, 33);
            this.cb_IDHH.TabIndex = 27;
            this.cb_IDHH.ValueMember = "MaHangHoa";
            // 
            // hANGHOABindingSource
            // 
            this.hANGHOABindingSource.DataMember = "HANGHOA";
            this.hANGHOABindingSource.DataSource = this.dataSet1;
            // 
            // gIOIHANTONTableAdapter
            // 
            this.gIOIHANTONTableAdapter.ClearBeforeFill = true;
            // 
            // hANGHOATableAdapter
            // 
            this.hANGHOATableAdapter.ClearBeforeFill = true;
            // 
            // tb_Min
            // 
            this.tb_Min.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Min.Location = new System.Drawing.Point(172, 496);
            this.tb_Min.Name = "tb_Min";
            this.tb_Min.Size = new System.Drawing.Size(138, 30);
            this.tb_Min.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 499);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 25);
            this.label3.TabIndex = 28;
            this.label3.Text = "Tồn tối thiểu";
            // 
            // tb_Max
            // 
            this.tb_Max.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Max.Location = new System.Drawing.Point(485, 496);
            this.tb_Max.Name = "tb_Max";
            this.tb_Max.Size = new System.Drawing.Size(138, 30);
            this.tb_Max.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(349, 499);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 25);
            this.label5.TabIndex = 30;
            this.label5.Text = "Tồn tối đa";
            // 
            // GioiHanTon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 627);
            this.Controls.Add(this.tb_Max);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_Min);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_IDHH);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tb_ID_GHT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GioiHanTon";
            this.Text = "GioiHanTon";
            this.Load += new System.EventHandler(this.GioiHanTon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIOIHANTONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hANGHOABindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tb_ID_GHT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox cb_IDHH;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource gIOIHANTONBindingSource;
        private DataSet1TableAdapters.GIOIHANTONTableAdapter gIOIHANTONTableAdapter;
        private System.Windows.Forms.BindingSource hANGHOABindingSource;
        private DataSet1TableAdapters.HANGHOATableAdapter hANGHOATableAdapter;
        private System.Windows.Forms.TextBox tb_Min;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_Max;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn maGioiHanTonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHangHoaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tonToiThieuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tonToiDaDataGridViewTextBoxColumn;
    }
}