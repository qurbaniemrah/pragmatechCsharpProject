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

           string a = string.Empty;
            Console.WriteLine("Sozun palindrome oldugunu yoxluyuruq");
            a = Console.ReadLine();

            char[] temp = a.ToCharArray();
            Array.Reverse(temp);
            string b = new string(temp);

            if(a.Equals(b))
            {
                Console.WriteLine("Palindromdur");
            }else
            {
                Console.WriteLine("Palindrome deyil");
            }

            //4)Remove duplicate data algoritmini yazin input: csharpcorner, output: csharpone c

            string str = " csharpcorner";
            string result = string.Empty;

            for(int i = 0; i<str.Length; i++)
            {
               if(!result.Contains(str[i]))
                {
                    result += str[i];
                }
                Console.WriteLine(result);
            }



            Console.ReadLine();
           

 //Butun tasklar tamamlandi
 
    
            

           
            
            
            
            


            


        }
    }
}
