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
    public partial class TrangThaiNhanVien : Form
    {
        TrangThaiNhanVien_bus bus = new TrangThaiNhanVien_bus();
        public TrangThaiNhanVien()
        {
            InitializeComponent();
        }

        private void TrangThaiNhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.TRANGTHAINHANVIEN' table. You can move, or remove it, as needed.
            this.tRANGTHAINHANVIENTableAdapter.Fill(this.dataSet1.TRANGTHAINHANVIEN);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                bus.Update(tb_ID.Text, tb_Ten.Text);
                MessageBox.Show("Cập nhật thành công");
                bus.RefeshDS(dataGridView1, dataSet1);
            }
            catch (Exception)
            {
                MessageBox.Show("Cập nhật thất bại");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                bus.Delete(tb_ID.Text);
                MessageBox.Show("Xoá thành công");
                bus.RefeshDS(dataGridView1, dataSet1);
            }
            catch (Exception)
            {
                MessageBox.Show("Xóa thất bại");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (bus.Check(tb_ID.Text) == false)
            {
                MessageBox.Show("Mã Trạng Thái đã có trong danh sách");
            }
            else
            {
                try
                {
                    bus.InsertCV(tb_ID.Text, tb_Ten.Text);
                    MessageBox.Show("Thêm mới thành công");
                    bus.RefeshDS(dataGridView1, dataSet1);
                }
                catch (Exception)
                {
                    MessageBox.Show("Thêm mới thất bại");
                }

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tb_ID.Text = bus.CreateId();
            tb_Ten.Text = "";
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            tb_ID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            tb_Ten.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
    }
}
