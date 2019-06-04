using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaKho.Bus
{
    class QLNK_bus
    {
        DataSet1TableAdapters.NHANVIENTableAdapter sql = new DataSet1TableAdapters.NHANVIENTableAdapter();

        public string GetCV(string tk)
        {
            return sql.GetCV(tk);
        }
    }
}
