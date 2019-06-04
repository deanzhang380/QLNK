using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaKho.Bus
{
    class QuanLyDanhSachNhaSanXuat_bus
    {
        DataSet1TableAdapters.NHASANXUATTableAdapter sql = new DataSet1TableAdapters.NHASANXUATTableAdapter();
        public void Update(string ma, string ten, string dc, string dt)
        {
            sql.UpdateNSX(ten, dc, dt, ma);
        }

        public string GetName(string ma)
        {
            return sql.GetName(ma);
        }

        public string GetDC(string ma)
        {
            return sql.GetDC(ma);
        
        }

        public string GetDT(string ma)
        {
            return sql.GetDT(ma);
        }
        public void RefeshDS(DataGridView dt, DataSet1 dataSet1)
        {
            sql.Fill(dataSet1.NHASANXUAT);
            dt.DataSource = dataSet1.NHASANXUAT;
        }
    }
}
