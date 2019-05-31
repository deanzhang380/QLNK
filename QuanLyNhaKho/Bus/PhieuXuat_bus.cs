using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaKho.Bus
{
    class PhieuXuat_bus
    {
        //DataSet1TableAdapters.PHIEUNHAPTableAdapter sql = new DataSet1TableAdapters.PHIEUNHAPTableAdapter();
        DataSet1TableAdapters.PHIEUXUATTableAdapter sql = new DataSet1TableAdapters.PHIEUXUATTableAdapter();
        DataSet1TableAdapters.NHANVIENTableAdapter nv = new DataSet1TableAdapters.NHANVIENTableAdapter();
        DataSet1TableAdapters.HANGHOATableAdapter hh = new DataSet1TableAdapters.HANGHOATableAdapter();
        //DataSet1TableAdapters.CHITIETPHIEUNHAPTableAdapter ctpn = new DataSet1TableAdapters.CHITIETPHIEUNHAPTableAdapter();
        DataSet1TableAdapters.CHITIETPHIEUXUATTableAdapter ctpx = new DataSet1TableAdapters.CHITIETPHIEUXUATTableAdapter();
        DataSet1TableAdapters.MIX2TableAdapter mix = new DataSet1TableAdapters.MIX2TableAdapter();
        public string CreateId()
        {
            String temp;
            int id;
            int? num = sql.Count();
            if (num == 0)
            {
                return "PX_001";
            }

            temp = sql.GetLastID();
            id = Convert.ToInt32(temp.Substring(3));
            id += 1;
            if (id < 10)
            {
                return "PX_00" + id.ToString();
            }
            else if (id >= 10 && id < 100)
            {
                return "PX_0" + id.ToString();
            }
            else
            {
                return "PX_" + id.ToString();
            }
        }

        public void Insert(string ma, string malp, string manv, string matt, DateTime dt_ngaylap, DateTime dt_ngaynhap, string kh)
        {
            sql.Insert(ma, malp, manv, matt, dt_ngaylap, dt_ngaynhap, kh);

        }

        public void Insert_CTPX(string ma_PX, string ma_HH, int soluong, string diengiai)
        {
            ctpx.InsertCTPX(ma_HH, ma_PX, soluong, diengiai);
        }

        public void RefeshDS(DataGridView dt, DataSet1 dataSet1, string ma_px)
        {

            mix.Fill(dataSet1.MIX2, ma_px);

            dt.DataSource = dataSet1.MIX2;
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

        public void UpdateSoLuongTon(string ma, int soluongnhap, int dau)
        {
            int? temp = hh.GetSLT(ma);

            if (dau == 1)
            {
                temp += soluongnhap;
            }
            if (dau == 0)
            {
                temp -= soluongnhap;
            }

            hh.UpdateSLT(temp, ma);
        }

        public void DeleteHH(string ma_pn, string ma_HH)
        {
            ctpx.DeleteCTPX(ma_HH, ma_pn);
        }
    }
}
