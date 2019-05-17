using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhaKho.GUI;

namespace QuanLyNhaKho
{
    public partial class QLNK: Form
    {
        public QLNK()
        {
            InitializeComponent();
           
        }

        Form ReturnFrm()
        {
            return this;
        }

        private void tạoMớiNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new TaoMoiNhanVien();
            form.Show();
        }

        private void thêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new QuanLyDanhSachNhanVien();
            form.Show();
        }

        private void chứcVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new Chức_vụ();
            form.Show();
        }

        private void trạngTháiNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new TrangThaiNhanVien();
            form.Show();
        }
    }
}
