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
    public partial class Report_NhaSanXuat : Form
    {
        public Report_NhaSanXuat()
        {
            InitializeComponent();
        }

        private void Report_NhaSanXuat_Load(object sender, EventArgs e)
        {
            nhasanxuatTableAdapter1.Fill(dataSet11.NHASANXUAT);
            CrystalReport3 rp = new CrystalReport3();
            rp.Database.Tables[0].SetDataSource(dataSet11);
            crystalReportViewer1.ReportSource = rp;
        }
    }
}
