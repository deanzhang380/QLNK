using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace QuanLyNhaKho.Bus
{
    class QuanLyDanhSachHangHoa_bus
    {
        DataSet1TableAdapters.HANGHOATableAdapter sql = new DataSet1TableAdapters.HANGHOATableAdapter();
        DataSet1TableAdapters.DONVITINHTableAdapter dv = new DataSet1TableAdapters.DONVITINHTableAdapter();
        DataSet1TableAdapters.LOAIHANGHOATableAdapter lhh = new DataSet1TableAdapters.LOAIHANGHOATableAdapter();
        DataSet1TableAdapters.NHASANXUATTableAdapter nsx = new DataSet1TableAdapters.NHASANXUATTableAdapter();
        DataSet1TableAdapters.TRANGTHAIHANGHOATableAdapter tthh = new DataSet1TableAdapters.TRANGTHAIHANGHOATableAdapter();

        public void Update(string ma, string ten, string trangthai,string loai, string dv,string nsx,int num)
        {
            sql.UpdateHH(ten, trangthai, dv, nsx, loai, num,ma);
        }

        public string Getnamedv(string ma)
        {
            return dv.GetName(ma);
        }
        public string Getnamelhh(string ma)
        {
            return lhh.GetName(ma);
        }

        public string Getnamensx(string ma)
        {
            return nsx.GetName(ma);
        }

        public string Getnametthh(string ma)
        {
            return tthh.GetName(ma);
        }
    }
}
