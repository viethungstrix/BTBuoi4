using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT7
{
    internal class ToaDo
    {
        float x, y;
        string ten;
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
        public ToaDo() : this(5, 5)
        {
            ten = "gh";
        }
        public override string ToString()
        {
            return "Tam hinh tron " + ten + "(" + x + "," + y + ")";
        }
    }
}
