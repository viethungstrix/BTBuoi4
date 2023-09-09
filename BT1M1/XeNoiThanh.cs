using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT1M1
{
    internal class XeNoiThanh
    {
        string mschuyen, tentaixe, soxe;
        int sotuyen, sokm;
        double doanhthu;
        public string MaSoChuyen
        {
            get { return mschuyen; }
            set { mschuyen = value; }
        }
        public string HoTenTaiXe
        {
            get { return tentaixe; }
            set { tentaixe = value;}
        }
        public string SoXe
        {
            get { return soxe; }
            set { soxe = value; }
        }
        public double Doanhthu
        {
            get { return doanhthu; } 
            set { doanhthu = value; }
        }
        public int SoKmDiDuoc
        {
            get { return sokm; }
            set { sokm = value; }
        }
        public int SoTuyen
        {
            get { return sotuyen; }
            set { sotuyen = value; }
        }
        public XeNoiThanh(string mschuyen, string tentaixe, string soxe, int sotuyen, int sokm, double doanhthu)
        {
            this.sotuyen = sotuyen;
        }
    }
}
