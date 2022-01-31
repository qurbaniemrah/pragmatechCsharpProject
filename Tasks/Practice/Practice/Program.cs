using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            int result = 0;
           foreach(int i in arr)
            {
                result += i;
            }
            Console.WriteLine(result);
            Console.ReadLine();

        }
    }
}
