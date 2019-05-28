using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaKho.Bus
{
    class LoaiHangHoa_bus
    {
        DataSet1TableAdapters.LOAIHANGHOATableAdapter sql = new DataSet1TableAdapters.LOAIHANGHOATableAdapter();
        public string CreateId()
        {
            String temp;
            int id;
            int? num = sql.Count();
            if (num == 0)
            {
                return "LHH_001";
            }

            temp = sql.GetLastID();
            id = Convert.ToInt32(temp.Substring(4));
            id += 1;
            if (id < 10)
            {
                return "LHH_00" + id.ToString();
            }
            else if (id >= 10 && id < 100)
            {
                return "LHH_0" + id.ToString();
            }
            else
            {
                return "LHH_" + id.ToString();
            }


        }

        public void Update(string ten,string ma)
        {
            sql.UpdateLHH(ten, ma);
        }

        public void Insert(string ma, string ten)
        {
            sql.InsertLHH(ma, ten);
        }

        public void RefeshDS(DataGridView dt, DataSet1 dataSet1)
        {
            sql.Fill(dataSet1.LOAIHANGHOA);
            dt.DataSource = dataSet1.LOAIHANGHOA;
        }

    }
}
