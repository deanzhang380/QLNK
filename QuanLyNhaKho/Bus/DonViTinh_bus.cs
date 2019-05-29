using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QuanLyNhaKho.Bus
{
    class DonViTinh_bus
    {
        DataSet1TableAdapters.DONVITINHTableAdapter sql = new DataSet1TableAdapters.DONVITINHTableAdapter();
        public string CreateID()
        {
            String temp;
            int id;
            int? num = sql.Count();
            if (num == 0)
            {
                return "DVT_001";
            }

            temp = sql.GetLastID();
            id = Convert.ToInt32(temp.Substring(4));
            id += 1;
            if (id < 10)
            {
                return "DVT_00" + id.ToString();
            }
            else if (id >= 10 && id < 100)
            {
                return "DVT_0" + id.ToString();
            }
            else
            {
                return "DVT_" + id.ToString();
            }
        }
        public void Update(string ma,string ten)
        {
            sql.UpdateDVT(ten, ma);
        }
        public void Insert(string ma, string ten)
        {
            sql.InsertDVT(ma, ten);
        }

        public void RefeshDS(DataGridView dt, DataSet1 dataSet1)
        {
            sql.Fill(dataSet1.DONVITINH);
            dt.DataSource = dataSet1.DONVITINH;
        }
    }
}
