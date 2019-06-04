using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaKho.Bus
{
    class ThemHangHoa_bus
    {
        DataSet1TableAdapters.HANGHOATableAdapter sql = new DataSet1TableAdapters.HANGHOATableAdapter();
        DataSet1TableAdapters.GIOIHANTONTableAdapter ght = new DataSet1TableAdapters.GIOIHANTONTableAdapter();
        public string CreateId()
        {
            String temp;
            int id;
            int? num = sql.Count();
            if (num == 0)
            {
                return "HH_001";
            }

            temp = sql.GetLastID();
            id = Convert.ToInt32(temp.Substring(3));
            id += 1;
            if (id < 10)
            {
                return "HH_00" + id.ToString();
            }
            else if (id >= 10 && id < 100)
            {
                return "HH_0" + id.ToString();
            }
            else
            {
                return "HH_" + id.ToString();
            }
        }

        public void Insert(string ma, string ten, string loai, string donvi, string nsx)
        {
            sql.Insert(ma, ten, "TTHH_003", donvi, nsx, loai,0);
        }

        public string CreateId_GHT()
        {
            String temp;
            int id;
            int? num = ght.Count();
            if (num == 0)
            {
                return "GHT_001";
            }

            temp = ght.GetLastID();
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
        public void Insert_GHT(string ma, string mahh, string max, string min)
        {
            ght.InsertGHT(ma, mahh, min, max);
        }
    }
}
