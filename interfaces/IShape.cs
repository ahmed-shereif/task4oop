using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4oop.interfaces
{
    internal interface IShape
    {
        // Property declaration for Area
        double Area { get; }
   
        public string DisplayShapeInfo();
    }
}
