using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace task4oop.task5
{
    internal class Maths
    {

        public static T add<T>(T x1,T x2)where T: struct
        {
            dynamic dx1 = x1;
            dynamic dx2 = x2;
            return dx1 + dx2;
        }
        public static T subtract<T>(T x1, T x2) where T : struct
        {
            dynamic dx1 = x1;
            dynamic dx2 = x2;
            return dx1 - dx2;
        }
        public static T multibly<T>(T x1, T x2) where T : struct
        {
            dynamic dx1 = x1;
            dynamic dx2 = x2;
            return dx1 * dx2;
        }
        public static T divide<T>(T x1, T x2) where T : struct
        {
            dynamic dx1 = x1;
            dynamic dx2 = x2;
            return dx1 / dx2;
        }
    }
}
