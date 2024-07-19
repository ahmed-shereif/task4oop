using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task4oop.interfaces;

namespace task4oop
{
    internal class Recatangle : IRectangle
    {

        public double Area { get; set; }

        public double l;
        public double w;

        public double clacRectArea()
        {
            Area = l*w;
            return Area;
        }

        public string DisplayShapeInfo()
        {
            Console.WriteLine(Area);
            return Area.ToString();
        }
    }
}
