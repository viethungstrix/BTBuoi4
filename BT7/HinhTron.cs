using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT7
{
    internal class HinhTron
    {
        ToaDo tam;
        internal ToaDo Tam
        {
            get { return tam; }
            set { tam = value; }
        }
        double bankinh;

        public double BanKinh
        {
            get { return bankinh; }
            set { bankinh = value; }
        }
        public double ChuVi()
        {
            return 2 * Math.PI * bankinh;
        }
        public double DienTich()
        {
            return bankinh * bankinh * Math.PI;
        }
        public HinhTron()
        {
            Tam = new ToaDo();
            bankinh = 10.5;
        }
        public HinhTron(ToaDo tam, double banKinh)
        {
            this.tam = tam;
            this.bankinh = banKinh;
        }
        public void xuat()
        {

            Console.WriteLine("Chu vi la: {0}, Dien tich la: {1}", ChuVi(), DienTich());
        }
    }
}
