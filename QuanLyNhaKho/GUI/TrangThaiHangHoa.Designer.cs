namespace QuanLyNhaKho.GUI
{
    partial class TrangThaiHangHoa
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
            this.dataSet1 = new QuanLyNhaKho.DataSet1();
            this.tRANGTHAIHANGHOABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tRANGTHAIHANGHOATableAdapter = new QuanLyNhaKho.DataSet1TableAdapters.TRANGTHAIHANGHOATableAdapter();
            this.maTrangThaiHangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenTrangTHaiHangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button4 = new System.Windows.Forms.Button();
            this.tb_Ten = new System.Windows.Forms.TextBox();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRANGTHAIHANGHOABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(197, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "Quản lý trạng thái hàng hóa";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maTrangThaiHangDataGridViewTextBoxColumn,
            this.tenTrangTHaiHangDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tRANGTHAIHANGHOABindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(708, 357);
            this.dataGridView1.TabIndex = 12;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tRANGTHAIHANGHOABindingSource
            // 
            this.tRANGTHAIHANGHOABindingSource.DataMember = "TRANGTHAIHANGHOA";
            this.tRANGTHAIHANGHOABindingSource.DataSource = this.dataSet1;
            // 
            // tRANGTHAIHANGHOATableAdapter
            // 
            this.tRANGTHAIHANGHOATableAdapter.ClearBeforeFill = true;
            // 
            // maTrangThaiHangDataGridViewTextBoxColumn
            // 
            this.maTrangThaiHangDataGridViewTextBoxColumn.DataPropertyName = "MaTrangThaiHang";
            this.maTrangThaiHangDataGridViewTextBoxColumn.HeaderText = "MaTrangThaiHang";
            this.maTrangThaiHangDataGridViewTextBoxColumn.Name = "maTrangThaiHangDataGridViewTextBoxColumn";
            // 
            // tenTrangTHaiHangDataGridViewTextBoxColumn
            // 
            this.tenTrangTHaiHangDataGridViewTextBoxColumn.DataPropertyName = "TenTrangTHaiHang";
            this.tenTrangTHaiHangDataGridViewTextBoxColumn.HeaderText = "TenTrangTHaiHang";
            this.tenTrangTHaiHangDataGridViewTextBoxColumn.Name = "tenTrangTHaiHangDataGridViewTextBoxColumn";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(486, 493);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(151, 49);
            this.button4.TabIndex = 25;
            this.button4.Text = "Đóng";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // tb_Ten
            // 
            this.tb_Ten.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Ten.Location = new System.Drawing.Point(486, 437);
            this.tb_Ten.Name = "tb_Ten";
            this.tb_Ten.Size = new System.Drawing.Size(218, 30);
            this.tb_Ten.TabIndex = 24;
            // 
            // tb_ID
            // 
            this.tb_ID.Enabled = false;
            this.tb_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ID.Location = new System.Drawing.Point(173, 437);
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(138, 30);
            this.tb_ID.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(332, 440);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 25);
            this.label3.TabIndex = 22;
            this.label3.Text = "Tên Trạng Thái";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 440);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 25);
            this.label2.TabIndex = 21;
            this.label2.Text = "Mã Trạng Thái";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(160, 493);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 49);
            this.button1.TabIndex = 20;
            this.button1.Text = "Chỉnh sửa";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // TrangThaiHangHoa
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
            this.Name = "TrangThaiHangHoa";
            this.Text = "TrangThaiHangHoa";
            this.Load += new System.EventHandler(this.TrangThaiHangHoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRANGTHAIHANGHOABindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource tRANGTHAIHANGHOABindingSource;
        private DataSet1TableAdapters.TRANGTHAIHANGHOATableAdapter tRANGTHAIHANGHOATableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maTrangThaiHangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenTrangTHaiHangDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox tb_Ten;
        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}