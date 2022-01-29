using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateStudentClass
{
    internal class Program
    {
        //Student.cs olsun, Name, Surname, Age propertyleri olsun, ancaq constructorda set olsun.Neche defe instance aldigimizi qaytaran Counter olsun, hansiniki yalniz constructorda set ede bilek.
       class Student
        {
            public string Name;
            public string Surname;
            public int Age;
            public List <Student> Students;
            public static int count;
            public Student(string name, string surname, int age)
            {
                this.Name = name;
                this.Surname = surname;
                this.Age = age;
                Students = new List<Student>();
                count++;
                Console.WriteLine($"{count}-adam qeydiyyatdan kecdi");
                Console.ReadLine();
            }

        }

        static void Main(string[] args)
        {
            Student student1 = new Student("Qurbani", "Emrahov", 29);

            

        }
    }
}
