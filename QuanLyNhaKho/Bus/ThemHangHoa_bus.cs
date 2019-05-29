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

        public void Insert(string ma, string ten, string loai, string donvi, string trangthai, string nsx)
        {
            sql.Insert(ma, ten, trangthai, donvi, nsx, loai,0);
        }
    }
}
