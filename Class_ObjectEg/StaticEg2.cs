using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_ObjectEg
{

    class Mobile
    {
        internal static string companyname; /// class variable
        internal static string modelname;/// object vatiable 


        /// not static method can access both static and non- static variables.
        void Displaymodel()
        {
            Console.WriteLine("companyname{0}, modelname{1}", companyname, modelname);

        }

        

        class StaticEg2
        {
            internal static void Info()
            {
                Console.WriteLine(" static method");

            }
            static void Main()
            {
                Mobile mobile = new Mobile();
                Mobile.modelname = " vivov11pro";

                Mobile.companyname = " Vivo";
                mobile.Displaymodel();
                // info method and static method in same class so. class is not required
                Info();


                Console.Read();

            }
        }

    }

}
