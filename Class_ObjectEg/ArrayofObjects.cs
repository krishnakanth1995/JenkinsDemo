using System;


namespace Class_ObjectEg
{
    class Movie
    {
        int id;
        string moviename;

        internal Movie(int id , string moviename)
        {
            this.id = id;
            this.moviename = moviename;

        }
        
        internal void DisplayMovie()
        {
            Console.WriteLine("id : {0}, moviename:{1}", id, moviename);

        }
    }
    class ArrayofObjects
    {
        static void Main()
        {
            Console.WriteLine(" Enter size");
            int size = Convert.ToInt32(Console.ReadLine());
            Movie[] mov = new Movie[size];


            for (int i = 0; i < size; i++)
            {

                Console.WriteLine(" Enter id and moviename");
                int id = Convert.ToInt32(Console.ReadLine());
                string moviename = Console.ReadLine();
                mov[i] = new Movie(id, moviename);


            }


            for (int i = 0; i < size; i++)
            {
                mov[i].DisplayMovie();
            }

            Console.ReadKey();
        
        } 


    }
}
