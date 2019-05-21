using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaKho
{
    public class Login_Bus
    {
        DataSet1TableAdapters.NHANVIENTableAdapter sql = new DataSet1TableAdapters.NHANVIENTableAdapter();
        public bool Check(string tk, string mk)
        {
            
            int? num = sql.CheckLogin(tk, mk);
            if(num>0)
            {
                return true;
            }
            return false;
        }

        public string GetPermission(string tk)
        {
            string s= sql.GetPers(tk);
            return s;

        }
    }
}
