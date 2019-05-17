using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyNhaKho;
using System.Windows.Forms;
namespace QuanLyNhaKho.Bus
{
   
    class TrangThaiNhanVien_bus
    {
        DataSet1TableAdapters.TRANGTHAINHANVIENTableAdapter sql = new DataSet1TableAdapters.TRANGTHAINHANVIENTableAdapter();
        public string CreateId()
        {
            String temp;
            int id;
            int? num = sql.Count();
            if (num == 0)
            {
                return "TTNV_001";
            }

            temp = sql.GetLastID();
            id = Convert.ToInt32(temp.Substring(5));
            id += 1;
            if (id < 10)
            {
                return "TTNV_00" + id.ToString();
            }
            else if (id >= 10 && id < 100)
            {
                return "TTNV_0" + id.ToString();
            }
            else
            {
                return "TTNV_" + id.ToString();
            }

        }
        public void InsertCV(string ma, string ten)
        {
            sql.InsertTT(ma, ten);
        }

        public bool Check(string ma)
        {
            if (sql.Check(ma) == 0)
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
            sql.Fill(dataSet1.TRANGTHAINHANVIEN);
            dt.DataSource = dataSet1.TRANGTHAINHANVIEN;
        }

        public void Delete(string ma)
        {
            sql.DeleteTT(ma);
        }
    }
}
