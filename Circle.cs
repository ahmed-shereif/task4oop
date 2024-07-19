using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task4oop.interfaces;

namespace task4oop
{
    internal class Circle : ICircle
    {
        public Circle() { }
        public double Area { get; set; }

        public double radius;

        public double clacCicleArea()
        {
            Area=3.14 * radius * radius ;
            return Area;

        }

        public string DisplayShapeInfo()
        {
            Console.WriteLine(Area);
            return Area.ToString();
        }
    }
}
