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
    public partial class Report_BaoCaoTon : Form
    {
        
        public Report_BaoCaoTon()
        {
            InitializeComponent();
        }

        private void Report_BaoCaoTon_Load(object sender, EventArgs e)
        {
            //DataSet1TableAdapters.Report_BaoCaoSoLuongTon_TheoLoaiTableAdapter ta = new DataSet1TableAdapters.Report_BaoCaoSoLuongTon_TheoLoaiTableAdapter();
            //ta.Fill(dataSet11.Report_BaoCaoSoLuongTon_TheoLoai);
            //Report_BaoCaoSoLuongTon rp = new Report_BaoCaoSoLuongTon();
            //rp.Database.Tables[0].SetDataSource(dataSet11);
            //crystalReportViewer1.ReportSource=rp;
            hanghoaTableAdapter1.Fill(dataSet11.HANGHOA);
            loaihanghoaTableAdapter1.Fill(dataSet11.LOAIHANGHOA);
            donvitinhTableAdapter1.Fill(dataSet11.DONVITINH);
            CreateReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
        }
        void CreateReport()
        {
            CrystalReport1 rp = new CrystalReport1();
            rp.Database.Tables[0].SetDataSource(dataSet11);
            rp.Database.Tables[1].SetDataSource(dataSet11);
            rp.Database.Tables[2].SetDataSource(dataSet11);
            crystalReportViewer1.ReportSource = rp;
        }
    }
}
