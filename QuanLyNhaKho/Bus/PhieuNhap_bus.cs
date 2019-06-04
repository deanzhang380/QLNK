using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace QuanLyNhaKho.Bus
{
    class PhieuNhap_bus
    {
        DataSet1TableAdapters.PHIEUNHAPTableAdapter sql = new DataSet1TableAdapters.PHIEUNHAPTableAdapter();
        DataSet1TableAdapters.NHANVIENTableAdapter nv = new DataSet1TableAdapters.NHANVIENTableAdapter();
        DataSet1TableAdapters.HANGHOATableAdapter hh = new DataSet1TableAdapters.HANGHOATableAdapter();
        DataSet1TableAdapters.CHITIETPHIEUNHAPTableAdapter ctpn = new DataSet1TableAdapters.CHITIETPHIEUNHAPTableAdapter();
        DataSet1TableAdapters.MIXTableAdapter mix = new DataSet1TableAdapters.MIXTableAdapter();
        public string CreateId()
        {
            String temp;
            int id;
            int? num = sql.Count();
            if (num == 0)
            {
                return "PN_001";
            }

            temp = sql.GetLastID();
            id = Convert.ToInt32(temp.Substring(3));
            id += 1;
            if (id < 10)
            {
                return "PN_00" + id.ToString();
            }
            else if (id >= 10 && id < 100)
            {
                return "PN_0" + id.ToString();
            }
            else
            {
                return "PN_" + id.ToString();
            }
        }

        public void Insert(string ma, string malp, string manv,string matt,DateTime dt_ngaylap, DateTime dt_ngaynhap,string nd )
        {
            sql.Insert(ma, malp, manv, matt, dt_ngaylap, dt_ngaynhap, nd);
            
        }

        public void Insert_CTPN(string ma_PN, string ma_HH, int soluong, string diengiai)
        {
            ctpn.InsertCTPN(ma_HH, ma_PN, soluong, diengiai);
        }

        public void RefeshDS(DataGridView dt, DataSet1 dataSet1, string ma_pn)
        {
            
            mix.Fill(dataSet1.MIX,ma_pn);
            
            dt.DataSource = dataSet1.MIX;
        }

        public string CollectID_NV(string tk)
        {
            return nv.GetID(tk);
        }

        public string GetNameHangHoa(string ma)
        {
            return hh.GetNameHH(ma);
        }

        public string GetNameLHH(string ma)
        {
            if (ma == "")
                return "";
            return hh.GetNameLHH(ma).ToString();
        }

        public string GetNameTTHH(string ma)
        {
            if (ma == "")
                return "";
            return hh.GetNameTTHH(ma).ToString();
        }

        public string GetNameNSX(string ma)
        {
            if (ma == "")
                return "";
            return hh.GetNameNSX(ma).ToString();
        }

        public string GetNameDV(string ma)
        {
            if (ma == "")
                return "";
            return hh.GetNameDV(ma).ToString();
        }
        public int? GetNameSL(string ma)
        {
            if (ma == "")
                return 0;
            return hh.GetSLT(ma);
        }

        public void UpdateSoLuongTon(string ma, int soluongnhap,int dau)
        {
            int? temp = hh.GetSLT(ma);
           
            if (dau == 1)
            {
                
                temp += soluongnhap;
                if(temp>Int32.Parse(hh.GetMax(ma)))
                {
                    return;
                }
            }
            if(dau==0)
            {
                temp -= soluongnhap;
                if(temp<Int32.Parse(hh.GetMin(ma)))
                {
                    return;
                }
            }
            hh.UpdateSLT(temp, ma);
            if (temp > Int32.Parse(hh.GetMin(ma)) && temp < Int32.Parse(hh.GetMax(ma)))
            {
                hh.UpdateTTHH("TTHH_001", ma);

            }

            if (temp ==Int32.Parse(hh.GetMax(ma)))
            {
                hh.UpdateTTHH("TTHH_004", ma);
            }


        }

        public void DeleteHH(string ma_pn, string ma_HH)
        {
            ctpn.DeleteCTPN(ma_HH, ma_pn);
        }
    }
}
