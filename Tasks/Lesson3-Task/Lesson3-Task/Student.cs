using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3_Task
{
    public class Student
    {
        public string Fullname;
        public int GroupNo;
        public  int Age;
       

        public Student(string fullName, int groupNo, int age)
        {
            this.Fullname = fullName;
            this.GroupNo = groupNo;
            this.Age = age;
           

           
        }

       public void getBirthYear()
        {
            Console.WriteLine(DateTime.Now.Year - Age);

        }
        

       

       





    }
  
}
