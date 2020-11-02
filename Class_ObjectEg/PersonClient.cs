using System;


namespace Class_ObjectEg
{
    class PersonClient
    {
        static void Main()
        {
            Person person = new Person();
            person.name = " krishna";
            person.Age = 24;
            person.DisplayPerson();
            Console.Read();
                
        }
    }
}
