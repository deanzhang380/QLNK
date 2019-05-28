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
    public partial class ThemHangHoa : Form
    {
        ThemHangHoa_bus bus = new ThemHangHoa_bus();
        public ThemHangHoa()
        {
            InitializeComponent();
            Refesh();
        }

        private void ThemHangHoa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet11.NHASANXUAT' table. You can move, or remove it, as needed.
            this.nHASANXUATTableAdapter.Fill(this.dataSet11.NHASANXUAT);
            // TODO: This line of code loads data into the 'dataSet1.TRANGTHAIHANGHOA' table. You can move, or remove it, as needed.
            this.tRANGTHAIHANGHOATableAdapter.Fill(this.dataSet1.TRANGTHAIHANGHOA);
            // TODO: This line of code loads data into the 'dataSet1.DONVITINH' table. You can move, or remove it, as needed.
            this.dONVITINHTableAdapter.Fill(this.dataSet1.DONVITINH);
            // TODO: This line of code loads data into the 'dataSet1.LOAIHANGHOA' table. You can move, or remove it, as needed.
            this.lOAIHANGHOATableAdapter.Fill(this.dataSet1.LOAIHANGHOA);

        }

        private void btn_HuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_TaoMoi_Click(object sender, EventArgs e)
        {
            if(tb_TenHH.Text==""||tb_TenHH.Text.Length<=8)
            {
                MessageBox.Show("Tên mặt hàng không thỏa yêu cầu");
                return;
            }
            try
            {
                bus.Insert(tb_MaHH.Text, tb_TenHH.Text, cb_LoaiHH.SelectedValue.ToString(), cb_Donvi.SelectedValue.ToString(), cb_TrangThaiHH.SelectedValue.ToString(), cb_Nsx.SelectedValue.ToString());
                MessageBox.Show("Thêm mới hàng hóa thành công");

            }catch(Exception)
            {
                MessageBox.Show("Thêm mới hàng hóa thất bại");
            }
        }
        void Refesh()
        {
            tb_MaHH.Text = bus.CreateId();
            tb_TenHH.Text = "";
            
        }

        private void btn_LamLai_Click(object sender, EventArgs e)
        {
            Refesh();
        }
    }
}
