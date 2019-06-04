using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaKho.GUI
{
    public partial class Report_BaoCaoPhieuNhapTheoNgay : Form
    {
        public Report_BaoCaoPhieuNhapTheoNgay()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            phieunhapTableAdapter1.FillByDate(dataSet11.PHIEUNHAP, dateTimePicker1.Value.ToString());
            CreateReport();
        }

        private void Report_BaoCaoPhieuNhapTheoNgay_Load(object sender, EventArgs e)
        {
            nhanvienTableAdapter1.Fill(dataSet11.NHANVIEN);
            trangthainhapxuatTableAdapter1.Fill(dataSet11.TRANGTHAINHAPXUAT);
            loaiphieuxuatnhapTableAdapter1.Fill(dataSet11.LOAIPHIEUXUATNHAP);
        }
        void CreateReport()
        {
            CrystalReport2 rp = new CrystalReport2();
            rp.Database.Tables[0].SetDataSource(dataSet11);
            rp.Database.Tables[1].SetDataSource(dataSet11);
            rp.Database.Tables[2].SetDataSource(dataSet11);
            rp.Database.Tables[3].SetDataSource(dataSet11);
            crystalReportViewer1.ReportSource = rp;
        }
    }
}
