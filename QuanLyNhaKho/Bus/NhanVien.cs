using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaKho.Bus
{
    class NhanVien
    {
        public string ID;
        public string Ten;
        public string Tk;
        public string MK;
        public string sdt;
        public string trangthai;
        public string chucvu;
        public NhanVien()
        {

        }
        public NhanVien(string iD, string ten, string tk, string mK, string sdt, string trangthai, string chucvu)
        {
            ID = iD;
            Ten = ten;
            Tk = tk;
            MK = mK;
            this.sdt = sdt;
            this.trangthai = trangthai;
            this.chucvu = chucvu;
        }
    }
}
