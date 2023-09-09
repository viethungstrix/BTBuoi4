using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai7
{
    class HinhTron : ToaDo
    {
        ToaDo tam;
        double bankinh;
        internal ToaDo Tam
        {
            get { return tam; }
            set { tam = value; }
        }
        public double BK
        {
            get { return bankinh; }
            set { bankinh = value; }
        }
        public HinhTron(ToaDo tam, double bk)
        {
            this.bankinh = bankinh;
            this.tam = tam;
        }
        public HinhTron()
        {
            this.tam = new ToaDo();
            bankinh = 10;
        }
        public double ChuVi() 
        {
            return 2 * Math.PI * bankinh;
        }
        public double DienTich()
        {
            return bankinh * bankinh * Math.PI;
        }
        public void xuat()
        {
            base.ToString();
            Console.WriteLine("Chu vi ht: {0}, Dien tich ht: {1}", ChuVi(), DienTich());
        }
    }
}
