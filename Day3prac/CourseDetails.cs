using System;


namespace Day3prac
{
    class CourseDetails
    {
        int courseid, couserfee;
        string coursename;
        static string institutename;
        static int instituteid;

        CourseDetails(int courseid, int coursefee, string coursename)
        {
            this.courseid = courseid;
            this.couserfee = coursefee;
            this.coursename = coursename;
        }

        void DisplayDetails()
        {
            instituteid = 1001;
            Console.WriteLine(" Courseid:{0}, coursefee:{1}, coursename:{2}, institute name{3}, instituteid{4}", courseid, couserfee, coursename, institutename, instituteid);

        }
        static void Main()
        {
            Console.WriteLine(" Enter institute name");
            CourseDetails.institutename = Console.ReadLine();
            Console.WriteLine(" Enter size ");
            int size = Convert.ToInt32(Console.ReadLine());
            CourseDetails [] cd = new CourseDetails[size];

            for (int i =0; i< size; i++)
            {
                Console.WriteLine(" Enter courseid");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" Enter coursefee");
                int coursefee = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" Enter coursename");
                string coursename = Console.ReadLine();

                cd[i] = new CourseDetails(id, coursefee, coursename);


;            }

            for (int i = 0; i< size; i++)
            {
                cd[i].DisplayDetails();

            }

            Console.Read();

        }
    }
}
