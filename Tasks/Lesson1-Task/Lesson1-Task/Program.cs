using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1)5 ədədin orta qiymətinin tapılması algoritmi qurun;
//2)Düzbucaqlının sahə və perimetrini tapan algoritmi qurun;
//3)Daxil edilən ədədin vurma cədvəlini yazdiran algoritmi qurun;
//4)1 le verilmis eded arasinda kvadratlari cemi algoritmini qurun;
//5)0 la verilmiş ədəd arasındaki ədədlərin hasili ilə cəminin fərqini hesablayan algoritmi qurun;
//Hər birini methodlar vasitesile yazin. Ugurlar! :)

namespace Lesson1_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1)5 ədədin orta qiymətinin tapılması algoritmi qurun;
            int[] ededler = { 1, 2, 3, 4, 5 };
            int cem = ededler[0] + ededler[1] + ededler[2] + ededler[3] + ededler[4];
            int say = ededler.Length;
            int netice = cem / say;
            Console.WriteLine(netice);


            //2)Düzbucaqlının sahə və perimetrini tapan algoritmi qurun;
            int DuzbucaqlininEni = 5;
            int DuzbucaqlininUzunlugu = 6;
            int DuzbucaqlininSahesi = DuzbucaqlininEni * DuzbucaqlininUzunlugu;
            int perimetr = (DuzbucaqlininEni + DuzbucaqlininUzunlugu) * 2;
            Console.WriteLine($"Sahe beraberdir : {DuzbucaqlininSahesi} ve Perimetr beraberdir: {perimetr}");


            //3)Daxil edilən ədədin vurma cədvəlini yazdiran algoritmi qurun;
            //Console.WriteLine("Eded daxil et :");
            //int eded = Int32.Parse(Console.ReadLine());
            //int[] vurulacaqEdedler = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //foreach(int items in vurulacaqEdedler)
            //{
            //    Console.WriteLine(items * eded);
            //}

            //if(eded<=9)
            //{
            //    Console.WriteLine(eded);
            //}else
            //{
            //    Console.WriteLine("Daxil etdiyiniz eded boyuk oldugu ucun vurma cedveli cixarila bilmir");
            //}


            //4)1 le verilmis eded arasinda kvadratlari cemi algoritmini qurun;
            
            Console.WriteLine("Verilmis eded");
            int bir = 1;
            int VerilmisEded = Int32.Parse(Console.ReadLine());
            int KvadratlariCemi = bir + (VerilmisEded * VerilmisEded);
            Console.WriteLine(KvadratlariCemi);


            Console.ReadLine();






        }
    }
}
