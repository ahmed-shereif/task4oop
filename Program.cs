using System.Runtime.Intrinsics.X86;
using task4oop.task5;
using static System.Net.Mime.MediaTypeNames;

namespace task4oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region project1
            //int x;
            //bool xOneParsed = int.TryParse(Console.ReadLine(), out x);

            //int y;
            //bool yOneParsed = int.TryParse(Console.ReadLine(), out y);

            //int z;
            //bool zOneParsed = int.TryParse(Console.ReadLine(), out z);



            //  Try to use ==
            //If(P1 == P2)   Does it work properly? 
            //notWorking
            //_3DPoint p1 = new _3DPoint(x, y, z);

            //_3DPoint p2 = new _3DPoint(2, 2, 2);
            //Console.WriteLine(p1 == p2);

            //Define an array of points and sort this array based on X &Y coordinates.

            //_3DPoint[] pArray= new _3DPoint[] { new _3DPoint(10, 10, 2), p2 ,new _3DPoint(11, 110, 2) };

            //Array.Sort(pArray);

            //foreach (var item in pArray)
            //{
            //Console.WriteLine(item);
            //}


            //_3DPoint p5 =new _3DPoint(8,8,8);
            //_3DPoint p6 =(_3DPoint) p5.Clone();
            //p5.x = 111111;
            //Console.WriteLine(p5);
            //Console.WriteLine(p6);

            #endregion


            #region project2
            //Second Project:
            //Define an interface named IShape with a property Area and a method DisplayShapeInfo.
            //Create two interfaces, ICircle and IRectangle, that inherit from IShape.Implement these interfaces in classes Circle and Rectangle.
            //Test your implementation by creating instances of both classes and displaying their shape information.



            #endregion


            #region project3



            //Duration d= new Duration(1,2,3);
            //Duration d2= new Duration(1,2,4);
            //Console.WriteLine(d.Equals(d2));


            #endregion

            #region Assignment 05

            Console.WriteLine(Maths.add(1, 2));

            #endregion
;


        }
    }
}