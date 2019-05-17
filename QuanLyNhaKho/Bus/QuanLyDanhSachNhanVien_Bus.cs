using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;
using System.Windows.Forms;
namespace QuanLyNhaKho.Bus
{
    class QuanLyDanhSachNhanVien_Bus
    {
        DataSet1TableAdapters.NHANVIENTableAdapter sql = new DataSet1TableAdapters.NHANVIENTableAdapter();
        DataSet1TableAdapters.CHUCVUTableAdapter cvadap = new DataSet1TableAdapters.CHUCVUTableAdapter();
        DataSet1TableAdapters.TRANGTHAINHANVIENTableAdapter ttadp = new DataSet1TableAdapters.TRANGTHAINHANVIENTableAdapter();
        //   public NhanVien Getinfo(string ma)
        //    {


        //        return nv;
        //    }
        //}

        public void UpdateNV(string ma,NhanVien nhanVien)
        {
            sql.UpdateNV(nhanVien.Ten, nhanVien.Tk, nhanVien.MK, nhanVien.trangthai, nhanVien.chucvu, nhanVien.sdt, ma);
        }

        public string GetnameTT(string ma)
        {
            return ttadp.GetTen(ma);
        }

        public string GetnameCV(string ma)
        {
            return cvadap.GetTen(ma);
        }

        public void RefeshDS(DataGridView dt,DataSet1 dataSet1)
        {
            sql.Fill(dataSet1.NHANVIEN);
            dt.DataSource = dataSet1.NHANVIEN;
        }

        public void DeleteNV(string ma)
        {
            sql.DeleteNV(ma);
        }
    }
}
