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
    public partial class Chức_vụ : Form
    {
        Chucvu_Bus bus = new Chucvu_Bus();
        public Chức_vụ()
        {
            InitializeComponent();
        }

        private void Chức_vụ_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.CHUCVU' table. You can move, or remove it, as needed.
            this.cHUCVUTableAdapter.Fill(this.dataSet1.CHUCVU);
           

        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            tb_ID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            tb_Ten.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                bus.Update(tb_ID.Text, tb_Ten.Text);
                MessageBox.Show("Cập nhật thành công");
                bus.RefeshDS(dataGridView1, dataSet1);
            }catch(Exception)
            {
                MessageBox.Show("Cập nhật thất bại");
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
