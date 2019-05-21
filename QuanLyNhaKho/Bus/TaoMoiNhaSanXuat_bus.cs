using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaKho.Bus
{
    class TaoMoiNhaSanXuat_bus
    {
        DataSet1TableAdapters.NHASANXUATTableAdapter sql = new DataSet1TableAdapters.NHASANXUATTableAdapter();
        
        public string CreateID()
        {
            String temp;
            int id;
            int? num = sql.Count();
            if (num == 0)
            {
                return "NSX_001";
            }

            temp = sql.LastID();
            id = Convert.ToInt32(temp.Substring(4));
            id += 1;
            if (id < 10)
            {
                return "NSX_00" + id.ToString();
            }
            else if (id >= 10 && id < 100)
            {
                return "NSX_0" + id.ToString();
            }
            else
            {
                return "NSX_" + id.ToString();
            }
        }
        public void InsertNSX(string ma, string ten, string dc, string dt)
        {
            sql.InsertNSX(ma, ten, dc, dt);
        }
    }
}
