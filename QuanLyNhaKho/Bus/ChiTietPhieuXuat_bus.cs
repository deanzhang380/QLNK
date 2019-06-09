using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace QuanLyNhaKho.Bus
{
    class ChiTietPhieuXuat_bus
    {
        DataSet1TableAdapters.NHANVIENTableAdapter sql = new DataSet1TableAdapters.NHANVIENTableAdapter();
        DataSet1TableAdapters.HANGHOATableAdapter hh = new DataSet1TableAdapters.HANGHOATableAdapter();
        DataSet1TableAdapters.CHITIETPHIEUNHAPTableAdapter ctpn = new DataSet1TableAdapters.CHITIETPHIEUNHAPTableAdapter();
        DataSet1TableAdapters.PHIEUXUATTableAdapter pn = new DataSet1TableAdapters.PHIEUXUATTableAdapter();
        DataSet1TableAdapters.MIX2TableAdapter mix = new DataSet1TableAdapters.MIX2TableAdapter();
        public string GetName(string ma)
        {
            return sql.GetNames(ma).ToString();
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
                if (temp > Int32.Parse(hh.GetMax(ma)))
                {
                    return;
                }
            }
            if (dau == 0)
            {
                temp -= soluongnhap;
                if (temp < Int32.Parse(hh.GetMin(ma)))
                {
                    return;
                }
            }
            hh.UpdateSLT(temp, ma);
            if (temp > Int32.Parse(hh.GetMin(ma)) && temp < Int32.Parse(hh.GetMax(ma)))
            {
                hh.UpdateTTHH("TTHH_001", ma);

            }

            if (temp == Int32.Parse(hh.GetMax(ma)))
            {
                hh.UpdateTTHH("TTHH_004", ma);
            }


        }

        public void DeleteHH(string ma_pn, string ma_HH)
        {
            ctpn.DeleteCTPN(ma_HH, ma_pn);
        }

        public void UpdatePN(string ma, string malpn, string mattp, string nd, string ngaynhap)
        {
        }

        public void Insert_CTPN(string ma_PN, string ma_HH, int soluong, string diengiai)
        {
            ctpn.InsertCTPN(ma_HH, ma_PN, soluong, diengiai);
        }

        public void RefeshDS(DataGridView dt, DataSet1 dataSet1, string ma_pn)
        {

            mix.Fill(dataSet1.MIX2, ma_pn);

            dt.DataSource = dataSet1.MIX2;
        }
    }
}
