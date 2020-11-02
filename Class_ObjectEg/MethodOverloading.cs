using System;


namespace Class_ObjectEg
{
    class Shape 
    {
        internal double Area(int r)
        {
            return (3.14 * r * r);
        }
        internal int Area (int l , int b)
        {
            return (l * b);
        }
    }
    class MethodOverloading
    {
        static void Main()
        {
            Console.WriteLine(" Enter raduis of Circle");
            int radius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Enter Length of Reactangle");
            int Lenght = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Enter Breadth of Reactangle");
            int Breadth = Convert.ToInt32(Console.ReadLine());
            Shape shape = new Shape();
            Console.WriteLine(" Area of circle {0}", shape.Area(radius));
            Console.WriteLine(" Area of rectangle {0}", shape.Area(Lenght,Breadth));
            Console.Read();

        }
    }
}
