using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Qurbani", "Emrahov");
            Console.WriteLine(student1.name + student1.surname);
            
        }
    }
}
