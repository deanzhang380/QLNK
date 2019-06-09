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
    public partial class ChiTietPhieuXuat : Form
    {
        ChiTietPhieuXuat_bus bus = new ChiTietPhieuXuat_bus();
        string Mapn;
        string Malpx;
        string Manv;
        string Mattp;
        string Ngaylapphieu;
        string Ngaynhap;
        string KH;
        public ChiTietPhieuXuat(string mapn, string mapx, string manv, string mattp, string date1, string date2, string kh)
        {
            InitializeComponent();
            Mapn = mapn;
            Malpx = mapx;
            Manv = manv;
            Mattp = mattp;
            Ngaylapphieu = date1;
            Ngaynhap = date2;
            KH = kh;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChiTietPhieuXuat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet11.TRANGTHAINHAPXUAT' table. You can move, or remove it, as needed.
            this.tRANGTHAINHAPXUATTableAdapter.Fill(this.dataSet11.TRANGTHAINHAPXUAT);
            // TODO: This line of code loads data into the 'dataSet11.LOAIPHIEUXUATNHAP' table. You can move, or remove it, as needed.
            this.lOAIPHIEUXUATNHAPTableAdapter.Fill(this.dataSet11.LOAIPHIEUXUATNHAP);

            tb_ID.Text = Mapn;
            cb_loaiphieu.SelectedValue = Malpx;
            cb_trangthai.SelectedValue = Mattp;
            dt_ngaylap.Value = DateTime.Parse(Ngaylapphieu);
            dt_ngaynhap.Value = DateTime.Parse(Ngaynhap);
            tb_nd.Text = KH;
            tb_NameNV.Text = bus.GetName(Manv);

            bus.RefeshDS(dataGridView1, dataSet11, Mapn);

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
