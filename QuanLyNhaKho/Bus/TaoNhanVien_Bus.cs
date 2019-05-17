using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaKho
{
    class TaoNhanVien_Bus
    {
       // DataSet1TableAdapters.NHANVIENTableAdapter sql;
        public TaoNhanVien_Bus()
        {
           
        }
        public String CreateID()
        {
            DataSet1TableAdapters.NHANVIENTableAdapter sql = new DataSet1TableAdapters.NHANVIENTableAdapter();
            String temp;
            int id;
            int? num = sql.CountNhanVien();
            if (num == 0)
            {
                return "NV_001";
            }

            temp = sql.ScalarQuery();
            id = Convert.ToInt32(temp.Substring(3));
            id += 1;
            if (id < 10)
            {
                return "NV_00" + id.ToString();
            }
            else if (id >= 10 && id < 100)
            {
                return "NV_0" + id.ToString();
            }
            else
            {
                return "NV_" + id.ToString();
            }
        }

        public bool CheckTK(string tk)
        {
            DataSet1TableAdapters.NHANVIENTableAdapter sql = new DataSet1TableAdapters.NHANVIENTableAdapter();
            int? num = sql.CheckTK(tk);
            if(num>0)
            {
                return false;
            }
            return true;
        }

        public void Insert(string manv,string tennv,string tk, string mk,string trangthai, string cv, string sdt)
        {
            DataSet1TableAdapters.NHANVIENTableAdapter sql = new DataSet1TableAdapters.NHANVIENTableAdapter();
            sql.InsertNV(manv, tennv, tk, mk, trangthai, cv, sdt);
        }
    }
}

