﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaKho
{
    public class Login_Bus
    {
        public bool Check(string tk, string mk)
        {
            DataSet1TableAdapters.NHANVIENTableAdapter sql = new DataSet1TableAdapters.NHANVIENTableAdapter();
            int? num = sql.CheckLogin(tk, mk);
            if(num>0)
            {
                return true;
            }
            return false;
        }
    }
}