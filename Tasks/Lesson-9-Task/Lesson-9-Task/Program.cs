using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_9_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hormetli istifadeci! Zehmet olmasa olke adini qeyd edin");
            string country = Console.ReadLine();
            Console.WriteLine("Hormetli sitifadeci! Zehmet olmasa olkeye aid paytaxti qeyd edin");
            string capital = Console.ReadLine();

            var cities = new Dictionary< string,  string>()
            {
                 {"Azerbaijan", "Baku" },
                 {"Turkey", "Ankara" },
                 {"Italia", "Rome" },
                 {"Georgia", "Tbilisi" },
                 {"Russia", "Moskow" },

            };

            country = cities["Azerbaijan"];
            country = cities["Turkey"];
            country = cities["Italia"];
            country = cities["Georgia"];
            country = cities["Russia"];

            Console.WriteLine(cities["Turkey"]);
            Console.ReadLine(); 


           





        }
    }
}
