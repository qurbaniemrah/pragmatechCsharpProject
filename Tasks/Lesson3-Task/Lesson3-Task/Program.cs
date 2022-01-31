using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3_Task
{
//Student class-i yaradin:
//Fullname
//GroupNo
//Age
//Student classi ucun GetBirthYear() metodunu yazin.Bu metod Studentin dogum ilini geri qaytarir
//Student Arrayi yaradin.
//Qrup nomresini daxil etmekle bir qrupda nece telebenin oxudugunu check eden method yazin.(2ci parametr kimi array daxil edeceksiz)
//ps:Student yaradilarken butun deyerlerin verilmesi mecburidir
    public class Program
    {
       

        static void Main(string[] args)
        {
            Student student1 = new Student("Qurbani",10,30);
            student1.getBirthYear();
            Console.WriteLine(student1);
            Console.ReadKey();
          
        }
    }
}
