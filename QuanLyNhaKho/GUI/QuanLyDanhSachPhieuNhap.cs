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
    public partial class QuanLyDanhSachPhieuNhap : Form
    {
        QuanLyDanhSachPhieuNhap_bus bus = new QuanLyDanhSachPhieuNhap_bus();
        public QuanLyDanhSachPhieuNhap()
        {
            InitializeComponent();
        }

        private void QuanLyDanhSachPhieuNhap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.LOAIPHIEUXUATNHAP' table. You can move, or remove it, as needed.
            this.lOAIPHIEUXUATNHAPTableAdapter.Fill(this.dataSet1.LOAIPHIEUXUATNHAP);
            // TODO: This line of code loads data into the 'dataSet1.TRANGTHAINHAPXUAT' table. You can move, or remove it, as needed.
            this.tRANGTHAINHAPXUATTableAdapter.Fill(this.dataSet1.TRANGTHAINHAPXUAT);
            // TODO: This line of code loads data into the 'dataSet1.PHIEUNHAP' table. You can move, or remove it, as needed.

            this.pHIEUNHAPTableAdapter.Fill(this.dataSet1.PHIEUNHAP);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bus.RefeshDS(dataGridView1, dataSet1, dateTimePicker1.Value.ToString(),0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bus.RefeshDS(dataGridView1, dataSet1, dateTimePicker2.Value.ToString(), 1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bus.RefeshDS(dataGridView1, dataSet1, comboBox1.SelectedValue.ToString(), 2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bus.RefeshDS(dataGridView1, dataSet1, comboBox2.SelectedValue.ToString(), 3);
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string mapn = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            string malpx = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            string manv = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            string mattp = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            string ngaylapphieu = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            string ngaynhap = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            string nd = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();

            Form form = new ChiTietPhieuNhap(mapn, malpx,manv,mattp,ngaylapphieu,ngaynhap,nd);
            form.Show();
        }
    }
}
