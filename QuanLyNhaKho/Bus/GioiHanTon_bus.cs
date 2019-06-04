using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaKho.Bus
{
    class GioiHanTon_bus
    {
        DataSet1TableAdapters.GIOIHANTONTableAdapter sql = new DataSet1TableAdapters.GIOIHANTONTableAdapter();

        public string CreateId()
        {
            String temp;
            int id;
            int? num = sql.Count();
            if (num == 0)
            {
                return "GHT_001";
            }

            temp = sql.GetLastID();
            id = Convert.ToInt32(temp.Substring(4));
            id += 1;
            if (id < 10)
            {
                return "GHT_00" + id.ToString();
            }
            else if (id >= 10 && id < 100)
            {
                return "GHT_0" + id.ToString();
            }
            else
            {
                return "GHT_" + id.ToString();
            }

        }

        public void Update(string ma, string min, string max)
        {
            sql.UpdateGHT(min, max, ma);
        }
        public void RefeshDS(DataGridView dt, DataSet1 dataSet1)
        {
            sql.Fill(dataSet1.GIOIHANTON);
            dt.DataSource = dataSet1.GIOIHANTON;
        }
    }
}
