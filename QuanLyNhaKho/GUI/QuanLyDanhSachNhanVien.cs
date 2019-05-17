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

namespace QuanLyNhaKho
{
    public partial class QuanLyDanhSachNhanVien : Form
    {
        QuanLyDanhSachNhanVien_Bus bus = new QuanLyDanhSachNhanVien_Bus();
        NhanVien nhanVien = new NhanVien();

        public QuanLyDanhSachNhanVien()
        {
            InitializeComponent();
       
        }

        private void QuanLyDanhSachNhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.TRANGTHAINHANVIEN' table. You can move, or remove it, as needed.
            this.tRANGTHAINHANVIENTableAdapter.Fill(this.dataSet1.TRANGTHAINHANVIEN);
            // TODO: This line of code loads data into the 'dataSet1.CHUCVU' table. You can move, or remove it, as needed.
            this.cHUCVUTableAdapter.Fill(this.dataSet1.CHUCVU);
            // TODO: This line of code loads data into the 'dataSet1.NHANVIEN' table. You can move, or remove it, as needed.
            this.nHANVIENTableAdapter.Fill(this.dataSet1.NHANVIEN);

          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tb_MaNV.Text == "")
            {
                MessageBox.Show("Chưa chọn thông tin nhân viên cần được cập nhật");

            }
            else
            {
                try
                {
                    nhanVien = new NhanVien(tb_MaNV.Text, tb_TenNV.Text, tb_TK.Text, tb_MK.Text, tb_Sdt.Text, cb_TrangThai.SelectedValue.ToString(), cb_CV.SelectedValue.ToString());
                    bus.UpdateNV(nhanVien.ID, nhanVien);
                    MessageBox.Show("Thông tin nhân viên đã được cập nhật");
                    bus.RefeshDS(dataGridView1, dataSet1);
                }catch(Exception)
                {
                    MessageBox.Show("Error!");
                }


            }
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            tb_MaNV.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            tb_TenNV.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            tb_TK.Text= dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            tb_MK.Text= dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            cb_TrangThai.Text= bus.GetnameTT(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
            cb_CV.Text= bus.GetnameCV(dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());
            tb_Sdt.Text= dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tb_MaNV.Text == "")
            {
                MessageBox.Show("Chưa chọn thông tin nhân viên cần xóa");

            }
            else
            {
                try
                {
                    nhanVien = new NhanVien(tb_MaNV.Text, tb_TenNV.Text, tb_TK.Text, tb_MK.Text, tb_Sdt.Text, cb_TrangThai.SelectedValue.ToString(), cb_CV.SelectedValue.ToString());
                    bus.DeleteNV(nhanVien.ID);
                    MessageBox.Show("Thông tin nhân viên đã được xóa");
                    bus.RefeshDS(dataGridView1, dataSet1);
                }
                catch (Exception)
                {
                    MessageBox.Show("Error!");
                }
            }
        }
    }
}
