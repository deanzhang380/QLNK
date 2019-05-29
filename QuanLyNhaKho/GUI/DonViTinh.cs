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
    public partial class DonViTinh : Form
    {
        DonViTinh_bus bus = new DonViTinh_bus();
        public DonViTinh()
        {
            InitializeComponent();
        }

        private void DonViTinh_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.DONVITINH' table. You can move, or remove it, as needed.
            this.dONVITINHTableAdapter.Fill(this.dataSet1.DONVITINH);

        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            if(tb_Ten.Text=="")
            {
                MessageBox.Show("Dữ liệu trống");
                return;
            }
            try
            {
                bus.Update(tb_ID.Text, tb_Ten.Text);
                MessageBox.Show("Cập nhật thành công");
                bus.RefeshDS(dataGridView1, dataSet1);
                Refesh();
            }
            catch(Exception)
            {
                MessageBox.Show("Cập nhật thất bại");
            }
            
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            tb_ID.Text= dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            tb_Ten.Text= dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tb_ID.Text=bus.CreateID();
            tb_Ten.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (tb_Ten.Text == "")
            {
                MessageBox.Show("Dữ liệu trống");
                return;
            }
            try
            {
                bus.Insert(tb_ID.Text, tb_Ten.Text);
                MessageBox.Show("Thêm đơn vị tính thành công");
                bus.RefeshDS(dataGridView1, dataSet1);
                Refesh();
            }
            catch(Exception)
            {
                MessageBox.Show("Thêm đơn vị thất bại");
            }
           
        }

        public void Refesh()
        {
            tb_ID.Text = "";
            tb_Ten.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
