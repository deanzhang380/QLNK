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
        string Permission;
        public QLNK(string per)
        {
            InitializeComponent();
            Permission = per;
        }

        Form ReturnFrm()
        {
            return this;
        }

        private void tạoMớiNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Form form = new TaoMoiNhanVien();
            SetCenter(form);
            form.TopLevel = false;
            panel1.Controls.Add(form);
            form.Show();
        }

        private void thêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Form form = new QuanLyDanhSachNhanVien();
            SetCenter(form);
            form.TopLevel = false;
           
            panel1.Controls.Add(form);
            form.Show();
        }

        private void chứcVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Form form = new Chức_vụ();
            SetCenter(form);
            form.TopLevel = false;
            
            panel1.Controls.Add(form);
            form.Show();
        }

        private void trạngTháiNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Form form = new TrangThaiNhanVien();
            SetCenter(form);
            form.TopLevel = false;
           
            panel1.Controls.Add(form);
            form.Show();
        }

        private void báoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quảnLýLoạiHàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void loạiHangHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Form form = new LoaiHangHoa();
            SetCenter(form);
            form.TopLevel = false;

            panel1.Controls.Add(form);
            form.Show();
        }

        private void nhàCungỨngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void SetCenter(Form form)
        {
            form.Top = panel1.Height / 2 - form.Height / 2;
            form.Left = panel1.Width / 2 - form.Width / 2;
        }

        private void tạoMớiNhàSảnXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Form form = new TaoMoiNhaSanXuat();
            SetCenter(form);
            form.TopLevel = false;
            panel1.Controls.Add(form);
            form.Show();
        }

        private void trạngTháiHàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Form form = new TrangThaiHangHoa();
            SetCenter(form);
            form.TopLevel = false;
            panel1.Controls.Add(form);
            form.Show();
        }

        private void thêmMớiHàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Form form = new ThemHangHoa();
            SetCenter(form);
            form.TopLevel = false;
            panel1.Controls.Add(form);
            form.Show();
        }

        private void danhSáchHàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Form form = new QuanLyDanhSachHangHoa();
            SetCenter(form);
            form.TopLevel = false;
            panel1.Controls.Add(form);
            form.Show();
        }

        private void giớiHạnTồnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
