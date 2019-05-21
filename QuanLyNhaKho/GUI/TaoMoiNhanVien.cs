using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaKho
{
    public partial class TaoMoiNhanVien : Form
    {
        TaoNhanVien_Bus bus= new TaoNhanVien_Bus();

        public TaoMoiNhanVien()
        {
            InitializeComponent();
            
        }

        private void TaoMoiNhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.TRANGTHAINHANVIEN' table. You can move, or remove it, as needed.
            this.tRANGTHAINHANVIENTableAdapter.Fill(this.dataSet1.TRANGTHAINHANVIEN);

            // TODO: This line of code loads data into the 'dataSet1.CHUCVU' table. You can move, or remove it, as needed.
            this.cHUCVUTableAdapter.Fill(this.dataSet1.CHUCVU);
            Refesh();
        }

        private void btn_TaoMoi_Click(object sender, EventArgs e)
        {
            if(tb_MatKhau.Text!=tb_MatKhau2.Text)
            {
                MessageBox.Show("Mật khẩu không khớp");
            }
            if(bus.CheckTK(tb_TaiKhoan.Text)==false)
            {
                MessageBox.Show("Tên tài khoản đã tồn tại");
            }
            if (CheckField() == false)
            {
                MessageBox.Show("Hãy xác nhận rằng đã điền đầy đủ thông tin");
            }
            else
            {
                try
                {
                    bus.Insert(tb_MaNV.Text, tb_TenNhanVien.Text,tb_TaiKhoan.Text, tb_MatKhau.Text, cb_TrangThai.SelectedValue.ToString(), cb_ChucVu.SelectedValue.ToString(),tb_sdt.Text );
                    MessageBox.Show("Thêm mới nhân viên thành công!");
                    Refesh();
                }
                catch (Exception)
                {
                    MessageBox.Show("Thêm nhân viên thất bại.");
                }
            }
        }

        private void btn_LamLai_Click(object sender, EventArgs e)
        {
            
        }

        bool CheckField()
        {
            if(tb_TaiKhoan.Text==""||tb_MatKhau.Text==""||tb_MatKhau2.Text==""||tb_TenNhanVien.Text=="")
            { return false; }
            return true;
        }

        void Refesh()
        {
            tb_MaNV.Text = bus.CreateID();
            tb_TaiKhoan.Text = null;
            tb_MatKhau.Text = null;
            tb_MatKhau2.Text = null;
            tb_TenNhanVien.Text = null;
        }

        private void btn_HuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
