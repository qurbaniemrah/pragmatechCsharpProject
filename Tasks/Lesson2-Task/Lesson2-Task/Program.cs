using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_Task
{
    //1)String Substring algorithmini qurun;
    //1)String Substring algorithmini qurun;
    //2)Reverse algoritmi qurun : input: hello, output: olleh
    //3)Verilmis sozun palindrome oldugunu yoxlayan algoritm mes:input: ana, output: ana(soldan ve sagdan eyni oxunur)
    //4)Remove duplicate data algoritmini yazin input: csharpcorner, output: csharpone c
    //Hazir methodlardan istifade etmeyin)) Meqsed hazir methodlarin algoritmini yazmaqdir Ugurlar! :)
    internal class Program

    {
        static void Main(string[] args)
        {
            //1)String Substring algorithmini qurun;
            //string name = "Qurbani";
            //string[] letters = name.Split(' ');
            //foreach (string letter in letters)
            //{
            //    Console.WriteLine(letter.Substring(0, 7));

            //}

            //2)Reverse algoritmi qurun : input: hello, output: olleh
            //Console.WriteLine("Soz daxil edin");
            //string soz = Console.ReadLine();
            //char[] ch = new char[soz.Length];
            //for (int i = soz.Length - 1; i>=0; i--)
            //{
            //    ch[i]=soz[i];
            //}

            //foreach (char c in ch)
            //{
            //    Console.WriteLine(c);
                
            //}

            //3)Verilmis sozun palindrome oldugunu yoxlayan algoritm mes:input: ana, output: ana(soldan ve sagdan eyni oxunur)
            Console.WriteLine("Palindrome yoxla :");
            string sozler = Console.ReadLine();
            char[] sozlerinKarakterleri = new char[sozler.Length];
            foreach(char c in sozler)
            {
                Console.WriteLine(c);
            }
            Console.WriteLine(sozlerinKarakterleri);
            
            
            Console.ReadLine();


        }
    }
}
