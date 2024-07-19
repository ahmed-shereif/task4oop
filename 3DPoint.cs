using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4oop
{
    internal class _3DPoint : IComparable, ICloneable
    {

        public int? x;
        public int? y;
        public int? z;


        public _3DPoint(int? x)
        {
            this.x = x;
        }

        public _3DPoint(int? x,int? y):this(x)
        {
            this.y = y;
          
        }

        public _3DPoint(int? x, int? y,int? z ):this(x,y)
        {
            this.z = z;

        }

        public object Clone()
        {
            return new _3DPoint(this.x,this.y,this.z);

        }

        public int CompareTo(object? obj)
        {
            _3DPoint p =(_3DPoint) obj;

            if (x > p.x && y > p.y)
            {
                return 1;
            }else if (x < p.x && y < p.y)
            {
                return -1;
            }

            else if(x == p.x && y ==p.y)
            {

                return 0;
            }
            return 0;
        }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string? ToString()
        {
            return $"Point Coordinates: ({x}, {y}, {z})";
        }
    }
}
