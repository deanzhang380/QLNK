using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaKho.Bus
{
    class QuanLyDanhSachPhieuNhap_bus
    {
        DataSet1TableAdapters.Search_PhieuNhapTableAdapter sql = new DataSet1TableAdapters.Search_PhieuNhapTableAdapter();
        public void RefeshDS(DataGridView dt, DataSet1 dataSet1, string temp,int num)
        {
            if (num == 0)
            {
                sql.FillByNgayLapPhieu(dataSet1.Search_PhieuNhap, temp);
                dt.DataSource = dataSet1.Search_PhieuNhap;
            }
            if (num == 1)
            {
                sql.FillByNgayNhap(dataSet1.Search_PhieuNhap, temp);
                dt.DataSource = dataSet1.Search_PhieuNhap;
            }
            if (num == 2)
            {
                sql.FillByTTP(dataSet1.Search_PhieuNhap, temp);
                dt.DataSource = dataSet1.Search_PhieuNhap;
            }
            if (num == 3)
            {
                sql.FillByLoaiPhieu(dataSet1.Search_PhieuNhap, temp);
                dt.DataSource = dataSet1.Search_PhieuNhap;
            }
        }
    }
}
