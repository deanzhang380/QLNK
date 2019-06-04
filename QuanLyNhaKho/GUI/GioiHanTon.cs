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
    public partial class GioiHanTon : Form
    {
        GioiHanTon_bus bus = new GioiHanTon_bus();
        public GioiHanTon()
        {
            InitializeComponent();
        }

        private void GioiHanTon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.HANGHOA' table. You can move, or remove it, as needed.
            this.hANGHOATableAdapter.Fill(this.dataSet1.HANGHOA);
            // TODO: This line of code loads data into the 'dataSet1.GIOIHANTON' table. You can move, or remove it, as needed.
            this.gIOIHANTONTableAdapter.Fill(this.dataSet1.GIOIHANTON);

        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            tb_ID_GHT.Text= dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            cb_IDHH.SelectedValue= dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            tb_Min.Text= dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            tb_Max.Text= dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            cb_IDHH.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cb_IDHH.Enabled = true;
            tb_ID_GHT.Text = bus.CreateId();

        }

        public bool Check_TB(string t)
        {
            for (int i = 0; i < t.Length; i++)
            {
                if (!char.IsNumber(t[i]))
                {
                    return false;
                }
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Check_TB(tb_Max.Text) == false || Check_TB(tb_Min.Text) == false)
            {
                MessageBox.Show("Giá trị ở 2 ô giới hạn phải là con số");
                return;
            }
            try
            {
                bus.Update(tb_ID_GHT.Text, tb_Min.Text, tb_Max.Text);
                MessageBox.Show("Cập nhật thành công");
                bus.RefeshDS(dataGridView1, dataSet1);
            }
            catch(Exception)
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
