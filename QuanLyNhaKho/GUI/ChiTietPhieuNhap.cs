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
    public partial class ChiTietPhieuNhap : Form
    {
        string Mapn;
        string Malpx ;
        string Manv ;
        string Mattp ;
        string Ngaylapphieu ;
        string Ngaynhap;
        string Nd;

        ChiTietPhieuNhap_bus bus = new ChiTietPhieuNhap_bus();
        public ChiTietPhieuNhap(string mapn,string mapx,string manv,string mattp, string date1, string date2,string nd)
        {
            InitializeComponent();
            Mapn = mapn;
            Malpx = mapx;
            Manv = manv;
            Mattp = mattp;
            Ngaylapphieu = date1;
            Ngaynhap = date2;
            Nd = nd;
        }

        private void ChiTietPhieuNhap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet11.HANGHOA' table. You can move, or remove it, as needed.
            this.hANGHOATableAdapter.Fill(this.dataSet11.HANGHOA);
            // TODO: This line of code loads data into the 'dataSet11.TRANGTHAINHAPXUAT' table. You can move, or remove it, as needed.
            this.tRANGTHAINHAPXUATTableAdapter.Fill(this.dataSet11.TRANGTHAINHAPXUAT);
            // TODO: This line of code loads data into the 'dataSet11.LOAIPHIEUXUATNHAP' table. You can move, or remove it, as needed.
            this.lOAIPHIEUXUATNHAPTableAdapter.Fill(this.dataSet11.LOAIPHIEUXUATNHAP);
            tb_ID.Text = Mapn;
            cb_loaiphieu.SelectedValue = Malpx;
            cb_trangthai.SelectedValue = Mattp;
            dt_ngaylap.Value = DateTime.Parse(Ngaylapphieu);
            dt_ngaynhap.Value = DateTime.Parse(Ngaynhap);
            tb_nd.Text = Nd;
            tb_NameNV.Text = bus.GetName(Manv);

            bus.RefeshDS(dataGridView1, dataSet11, Mapn);
        }

        private void cb_MaHH_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void cb_MaHH_TextChanged(object sender, EventArgs e)
        {
            tb_TenHH.Text = bus.GetNameHangHoa(cb_MaHH.Text);
            tb_LHH.Text = bus.GetNameLHH(cb_MaHH.Text);
            tb_dv.Text = bus.GetNameDV(cb_MaHH.Text);
            tb_soluongton.Text = bus.GetNameSL(cb_MaHH.Text).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                bus.UpdatePN(tb_ID.Text, cb_loaiphieu.SelectedValue.ToString(), cb_trangthai.SelectedValue.ToString(), tb_nd.Text, dt_ngaynhap.Value.ToString());
                MessageBox.Show("Cập nhật thông tin phiếu nhập thành công");
            }catch(Exception)
            {
                MessageBox.Show("Cập nhật thông tin phiếu nhập thất bại");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                bus.Insert_CTPN(tb_ID.Text, cb_MaHH.SelectedValue.ToString(), Int32.Parse(tb_Soluongnhap.Text), tb_diengiai.Text);
                MessageBox.Show("Thêm hàng hóa thành công");
                bus.RefeshDS(dataGridView1, dataSet11, tb_ID.Text);
                bus.UpdateSoLuongTon(cb_MaHH.SelectedValue.ToString(), Int32.Parse(tb_Soluongnhap.Text), 1);

            }
            catch (Exception)
            {
                MessageBox.Show("Thêm hàng hóa thất bại");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string current = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                bus.DeleteHH(Mapn, current);
                bus.UpdateSoLuongTon(current, Int32.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString()), 0);
                bus.RefeshDS(dataGridView1, dataSet11, Mapn);
                MessageBox.Show("Xóa hàng hóa thành công");
               
            }
            catch (Exception)
            {
                MessageBox.Show("Xóa hàng hóa thất bại");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
