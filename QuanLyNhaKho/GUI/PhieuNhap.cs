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
    public partial class PhieuNhap : Form
    {
        PhieuNhap_bus bus = new PhieuNhap_bus();
        bool flag = false;
        string taikhoan;
        string ma_pn;
        public PhieuNhap(string name,string tk)
        {
            InitializeComponent();

            tb_NameNV.Text = name;
            taikhoan = tk;
            
        }

        private void PhieuNhap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet11.TRANGTHAINHAPXUAT' table. You can move, or remove it, as needed.
            this.tRANGTHAINHAPXUATTableAdapter.Fill(this.dataSet11.TRANGTHAINHAPXUAT);
            // TODO: This line of code loads data into the 'dataSet1.HANGHOA' table. You can move, or remove it, as needed.
            this.hANGHOATableAdapter.Fill(this.dataSet1.HANGHOA);
            // TODO: This line of code loads data into the 'dataSet1.LOAIPHIEUXUATNHAP' table. You can move, or remove it, as needed.
            this.lOAIPHIEUXUATNHAPTableAdapter.Fill(this.dataSet1.LOAIPHIEUXUATNHAP);
            Refesh();
            cb_MaHH.Text = "";
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        public void Refesh()
        {
            tb_ID.Text = bus.CreateId();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(flag==false)
            {
                MessageBox.Show("Hãy lập phiếu nhập trước");
                return;
            }

            try
            {
                bus.Insert_CTPN(ma_pn, cb_MaHH.SelectedValue.ToString(), Int32.Parse(tb_Soluongnhap.Text), tb_diengiai.Text);
                MessageBox.Show("Thêm hàng hóa thành công");
                bus.RefeshDS(dataGridView1, dataSet1, ma_pn);
                bus.UpdateSoLuongTon(cb_MaHH.SelectedValue.ToString(),Int32.Parse(tb_Soluongnhap.Text),1);

            }
            catch(Exception)
            {
                MessageBox.Show("Thêm hàng hóa thất bại");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                bus.Insert(tb_ID.Text, cb_loaiphieu.SelectedValue.ToString(), taikhoan, cb_trangthai.SelectedValue.ToString(),
                    dt_ngaylap.Value.Date, dt_ngaynhap.Value.Date, tb_nd.Text);
                MessageBox.Show("Tạo phiếu nhập thành công");
                ma_pn = tb_ID.Text;
                bus.RefeshDS(dataGridView1, dataSet1, ma_pn);
                flag = true;
            }
            catch(Exception)
            {
                MessageBox.Show("Tạo phiếu nhập thất bại");
            }
        }

        private void comboBox2_TextChanged(object sender, EventArgs e)
        {
            tb_TenHH.Text = bus.GetNameHangHoa(cb_MaHH.Text);
            tb_LHH.Text = bus.GetNameLHH(cb_MaHH.Text);
            tb_dv.Text = bus.GetNameDV(cb_MaHH.Text);
            tb_soluongton.Text = bus.GetNameSL(cb_MaHH.Text).ToString();
        }

        private void dt_ngaynhap_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string current = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                bus.DeleteHH(ma_pn, current);
                bus.UpdateSoLuongTon(current, Int32.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString()), 0);
                bus.RefeshDS(dataGridView1, dataSet1, ma_pn);
                MessageBox.Show("Xóa hàng hóa thành công");
                RefeshHangHoa_info();
            }catch(Exception)
            {
                MessageBox.Show("Xóa hàng hóa thất bại");
            }
           
        }

        void RefeshHangHoa_info()
        {
            cb_MaHH.SelectedValue = "";
        }

       
    }
}
