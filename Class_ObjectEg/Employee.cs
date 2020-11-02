using System;


namespace Class_ObjectEg
{
    class Employee
    {
        string Name;
        int Age;
        string Degree;

        void DisplayDetails()
        {
            Console.WriteLine(" name:{0},age:{1}, degree:{2}", Name, Age, Degree);
        }

        static void Main()
        {
            Employee employee1 = new Employee();
            employee1.Name = " Krishna";
            employee1.Age = 24;
            employee1.Degree = " MS";
            employee1.DisplayDetails();
            Employee employee2 = new Employee();
            employee2.Name = " Tyni";
            employee2.Age = 24;
            employee2.Degree = " MS";
            employee2.DisplayDetails();

            Console.ReadKey();

        }






    }

}
