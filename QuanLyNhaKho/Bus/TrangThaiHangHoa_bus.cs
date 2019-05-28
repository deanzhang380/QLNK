using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaKho.Bus
{
    class TrangThaiHangHoa_bus
    {
        DataSet1TableAdapters.TRANGTHAIHANGHOATableAdapter sql = new DataSet1TableAdapters.TRANGTHAIHANGHOATableAdapter();
        public string CreateId()
        {
            String temp;
            int id;
            int? num = sql.Count();
            if (num == 0)
            {
                return "TTHH_001";
            }

            temp = sql.GetLastID();
            id = Convert.ToInt32(temp.Substring(5));
            id += 1;
            if (id < 10)
            {
                return "TTHH_00" + id.ToString();
            }
            else if (id >= 10 && id < 100)
            {
                return "TTHH_0" + id.ToString();
            }
            else
            {
                return "TTHH_" + id.ToString();
            }

        }
        public bool Check(string ma)
        {
            if (sql.Check(ma)==0)
            {
                return true;
            }
            return false;
        }

        public void Update(string ma, string ten)
        {
            sql.UpdateTT(ma, ten);
        }

        public void RefeshDS(DataGridView dt, DataSet1 dataSet1)
        {
            sql.Fill(dataSet1.TRANGTHAIHANGHOA);
            dt.DataSource = dataSet1.TRANGTHAINHANVIEN;
        }
    }
}
