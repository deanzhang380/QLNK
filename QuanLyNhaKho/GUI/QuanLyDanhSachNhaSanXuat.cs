using System;
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
    public partial class QuanLyDanhSachNhaSanXuat : Form
    {
        QuanLyDanhSachNhaSanXuat_bus bus = new QuanLyDanhSachNhaSanXuat_bus();
        public QuanLyDanhSachNhaSanXuat()
        {
            InitializeComponent();
        }

        private void QuanLyDanhSachNhaSanXuat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.NHASANXUAT' table. You can move, or remove it, as needed.
            this.nHASANXUATTableAdapter.Fill(this.dataSet1.NHASANXUAT);

        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            tb_ID.Text= dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            tb_Name.Text= dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            tb_Diachi.Text= dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            tb_Sdt.Text= dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                bus.Update(tb_ID.Text, tb_Name.Text, tb_Diachi.Text, tb_Sdt.Text);
                MessageBox.Show("Cập nhật nhà sản xuất thành công");
                bus.RefeshDS(dataGridView1, dataSet1);
            }catch(Exception)
            {
                MessageBox.Show("Cập nhật nhà sản xuất thất bại");
            }
           
        }
    }
}
