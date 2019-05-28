﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhaKho.Bus;

namespace QuanLyNhaKho.GUI
{
    public partial class QuanLyDanhSachHangHoa : Form
    {
        QuanLyDanhSachHangHoa_bus bus = new QuanLyDanhSachHangHoa_bus();
        public QuanLyDanhSachHangHoa()
        {
            InitializeComponent();
        }

        private void QuanLyDanhSachHangHoa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.NHASANXUAT' table. You can move, or remove it, as needed.
            this.nHASANXUATTableAdapter.Fill(this.dataSet1.NHASANXUAT);
            // TODO: This line of code loads data into the 'dataSet1.TRANGTHAIHANGHOA' table. You can move, or remove it, as needed.
            this.tRANGTHAIHANGHOATableAdapter.Fill(this.dataSet1.TRANGTHAIHANGHOA);
            // TODO: This line of code loads data into the 'dataSet1.DONVITINH' table. You can move, or remove it, as needed.
            this.dONVITINHTableAdapter.Fill(this.dataSet1.DONVITINH);
            // TODO: This line of code loads data into the 'dataSet1.LOAIHANGHOA' table. You can move, or remove it, as needed.
            this.lOAIHANGHOATableAdapter.Fill(this.dataSet1.LOAIHANGHOA);
            // TODO: This line of code loads data into the 'dataSet1.HANGHOA' table. You can move, or remove it, as needed.
            this.hANGHOATableAdapter.Fill(this.dataSet1.HANGHOA);

        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            tb_MaNV.Text= dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            tb_TenNV.Text= dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            cb_LoaiHangHoa.Text = bus.Getnamelhh(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
            cb_Donvi.Text = bus.Getnamedv(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
            cb_Nsx.Text = bus.Getnamensx(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
            cb_TrangThaiHH.Text = bus.Getnametthh(dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
