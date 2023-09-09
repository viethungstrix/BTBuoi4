using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai7
{
    class ToaDo
    {
        string ten;
        float x, y;
        public string Ten
        {
            get { return ten; }
            set { ten = value; }
        }
        public float X
        {
            get { return x; }
            set { x = value; }
        }
        public float Y
        {
            get { return y; }
            set { y = value; }
        }
        public ToaDo(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
        public ToaDo():this(0,0)
        {
            ten = "gh";
        }
        public override string ToString()
        {
            return "Ten toa do: {0}" + ten + "truc tung: {1}" + x +"truc hoanh: {2}" + y;
        }
    }
}
