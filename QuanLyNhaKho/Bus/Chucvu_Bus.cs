using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyNhaKho;
using System.Windows.Forms;

namespace QuanLyNhaKho.Bus
{
    class Chucvu_Bus
    {
        DataSet1TableAdapters.CHUCVUTableAdapter sql = new DataSet1TableAdapters.CHUCVUTableAdapter();

        public string CreateId()
        {
            String temp;
            int id;
            int? num = sql.Count();
            if (num == 0)
            {
                return "CV_001";
            }

            temp = sql.GetLastID();
            id = Convert.ToInt32(temp.Substring(3));
            id += 1;
            if (id < 10)
            {
                return "CV_00" + id.ToString();
            }
            else if (id >= 10 && id < 100)
            {
                return "CV_0" + id.ToString();
            }
            else
            {
                return "CV_" + id.ToString();
            }

        }
        public void InsertCV(string ma, string ten)
        {
            sql.InsertCV(ma, ten);
        }

        public bool Check(string ma)
        {
            if(sql.Check(ma)==0)
            {
                return true;
            }
            return false;
        }

        public void Update(string ma,string ten)
        {
            sql.UpdateCV(ma, ten);
        }

        public void RefeshDS(DataGridView dt, DataSet1 dataSet1)
        {
            sql.Fill(dataSet1.CHUCVU);
            dt.DataSource = dataSet1.CHUCVU;
        }

        public void Delete(string ma)
        {
            sql.DeleteCV(ma);
        }
    }
}
