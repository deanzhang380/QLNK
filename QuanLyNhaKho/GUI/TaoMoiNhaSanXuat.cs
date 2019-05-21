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
    public partial class TaoMoiNhaSanXuat : Form
    {
        TaoMoiNhaSanXuat_bus bus;
        public TaoMoiNhaSanXuat()
        {
            InitializeComponent();
            bus = new TaoMoiNhaSanXuat_bus();
            Refesh();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void TaoMoiNhaSanXuat_Load(object sender, EventArgs e)
        {

        }

        public void Refesh()
        {
            tb_Ma.Text = bus.CreateID();
            tb_Ten.Text = "";
            tb_Diachi.Text = "";
            tb_Dienthoai.Text = "";
        }

        private void btn_TaoMoi_Click(object sender, EventArgs e)
        {
            bus.InsertNSX(tb_Ma.Text, tb_Ten.Text, tb_Diachi.Text, tb_Dienthoai.Text);
        }

        private void btn_LamLai_Click(object sender, EventArgs e)
        {
            Refesh();
        }

        private void btn_HuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
