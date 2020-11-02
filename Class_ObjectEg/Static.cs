using System;


namespace Class_ObjectEg
{
    class Student
    {
        internal static string collegename;
        string name, dept;

        internal Student(string name, string dept)
        {
            this.name = name;
            this.dept = dept;

        }


        internal void DisplayDetails()
        {
            Console.WriteLine("College:{0},name: {1}, dept:{2}", collegename,name, dept);

        }

        class Static
        {
            static void Main()
            {
                
                Console.WriteLine(" Enter college name");
                Student.collegename = Console.ReadLine();
                string name, dept;

                Console.WriteLine("Enter number of students");
                int no = Convert.ToInt32(Console.ReadLine());
                Student[] student = new Student[no];
                try
                {
                    for (int i = 0; i < no; i++)
                    {
                        Console.WriteLine("Enter name");
                        name = Console.ReadLine();
                        Console.WriteLine("Enter dept");
                        dept = Console.ReadLine();
                        student[i] = new Student(name, dept);


                    }

                    for (int i = 0; i < no; i++)
                    {
                        student[i].DisplayDetails();


                    }
                }
                catch (Exception Ex)
                {
                    Console.WriteLine(Ex);
                }

                Console.ReadKey();

            }
        }
    }
}

