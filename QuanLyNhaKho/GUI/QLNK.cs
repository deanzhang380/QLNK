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
using QuanLyNhaKho.Bus;

namespace QuanLyNhaKho
{
    public partial class QLNK: Form
    {
        QLNK_bus bus = new QLNK_bus();
        string Permission;
        public string TenNV;
        string cv;
        public QLNK(string per,string name)
        {
            InitializeComponent();
            Permission = per;
            TenNV = name;
            cv = bus.GetCV(per);
            CheckPer();
        }

        public void CheckPer()
        {
            if(cv=="CV_002")
            {
                nhânViênToolStripMenuItem.Enabled = false;
                thêmMớiHàngHóaToolStripMenuItem.Enabled = false;
                danhMụcHàngHóaToolStripMenuItem.Enabled = false;
                nhàCungỨngToolStripMenuItem.Enabled = false;
                báoCáoToolStripMenuItem1.Enabled = false;
            }
            if(cv=="CV_003")
            {

                nhânViênToolStripMenuItem.Enabled = false;
                quảnLýLoạiHàngHóaToolStripMenuItem.Enabled = false;
                nhàCungỨngToolStripMenuItem.Enabled = false;
                thêmMớiHàngHóaToolStripMenuItem.Enabled = false;
            }
            if(cv=="CV_004")
            {
                nhânViênToolStripMenuItem.Enabled = false;
                thêmMớiHàngHóaToolStripMenuItem.Enabled = false;
                danhMụcHàngHóaToolStripMenuItem.Enabled = false;
                nhàCungỨngToolStripMenuItem.Enabled = false;
                báoCáoToolStripMenuItem1.Enabled = false;
                phiếuNhậpToolStripMenuItem.Enabled = false;
                danhSáchPhiếuNhậpToolStripMenuItem.Enabled = false;
                danhSáchPhiếuXuấtToolStripMenuItem.Enabled = false;
            }
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
            panel1.Controls.Clear();
            Form form = new DonViTinh();
            SetCenter(form);
            form.TopLevel = false;

            panel1.Controls.Add(form);
            form.Show();
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
            panel1.Controls.Clear();
            Form form = new GioiHanTon();
            SetCenter(form);
            form.TopLevel = false;
            panel1.Controls.Add(form);
            form.Show();
        }

        private void phiếuNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Form form = new PhieuNhap(TenNV,Permission);
            SetCenter(form);
            form.TopLevel = false;
            panel1.Controls.Add(form);
            form.Show();
        }

        private void phiếuXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Form form = new PhieuXuat(TenNV, Permission);
            SetCenter(form);
            form.TopLevel = false;
            panel1.Controls.Add(form);
            form.Show();
        }

        private void danhSáchNhàCungỨngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Form form = new QuanLyDanhSachNhaSanXuat();
            SetCenter(form);
            form.TopLevel = false;
            panel1.Controls.Add(form);
            form.Show();
        }

        private void hàngHóaTồnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Form form = new Report_BaoCaoTon();
            SetCenter(form);
            form.TopLevel = false;
            panel1.Controls.Add(form);
            form.Show();
        }

        private void báoCáoPhiếuNhậpTheoNgàyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Form form = new Report_BaoCaoPhieuNhapTheoNgay();
            SetCenter(form);
            form.TopLevel = false;
            panel1.Controls.Add(form);
            form.Show();
        }

        private void danhSáchPhiếuNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Form form = new QuanLyDanhSachPhieuNhap();
            SetCenter(form);
            form.TopLevel = false;
            panel1.Controls.Add(form);
            form.Show();
        }

        private void báoCáoNhàSảnXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Form form = new Report_NhaSanXuat();
            SetCenter(form);
            form.TopLevel = false;
            panel1.Controls.Add(form);
            form.Show();
        }
    }
}
