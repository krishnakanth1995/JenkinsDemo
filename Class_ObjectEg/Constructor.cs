using System;


namespace Class_ObjectEg
{
    class Constructor
    {
        class Pen
        {
            string brand;
            string color;
             int ISBN;
            // constructor is private by default and is a special method
            //and constructor name should be same as class
            // Constructor primary usage is to initialize values for the variable 
            // constructor donot have any return type 
            // constructor can initialize values for private fields also.

            // constructor overloading 
            internal Pen() // with no arguments 
            {
                Console.WriteLine(" Default constructor ");
            }

            internal Pen(int ISBN) // with one argument
            {
                this.ISBN = ISBN;
            }
            internal Pen(string b, string color)
            {
                brand = b;
                this.color = color;
                // this keyword is used when same name is used for variable also

            }

            internal void DisplayPen()
            {
                Console.WriteLine(" brand:{0}, color:{1}, ISBN:{2}", brand, color, ISBN);

            }
            static void Main()
            {
                // pen.brand = " parker"
                // pen.color = "  black" this is with access modifier 
                Pen p = new Pen(); // with no arguments
                Pen P1 = new Pen(12345);// with one argument 
                Pen pen = new Pen("Parker", "Black");
                pen.DisplayPen();

                Console.ReadKey();



            }
        }





    }
}
