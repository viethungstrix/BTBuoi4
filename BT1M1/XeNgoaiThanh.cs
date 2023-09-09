using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT1M1
{
    internal class XeNgoaiThanh
    {
        string noiden;
        public string NoiDen
        {
            get { return noiden; }
            set { noiden = value; }
        }
        int songaydiduoc;
        public int SoNgayDiDuoc
        {
            get { return songaydiduoc; }
            set { songaydiduoc = value;}
        }
        public XeNgoaiThanh(string noiden, int songaydiduoc)
        {
            this.noiden = noiden;
            this.songaydiduoc= songaydiduoc;
        }
    }
}
