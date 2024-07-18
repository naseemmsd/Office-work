using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace class_and_Object
{
     class Student
    {
        string name;
        int rollno;
        int age;
        int standard;
           
        public void setStudent(int rollno, string name, int age, int standard)

        { this.rollno = rollno;
          this.name = name;
          this.age = age;
          this.standard = standard;
        }
        public void getStudent()
        {   Console.WriteLine("Your Roll No is:{0}",this.rollno);
            Console.WriteLine("Your name is:{0}", this.name);
            Console.WriteLine("Your age is:{0}", this.age);
           
            Console.WriteLine("Your class is:{0}", this.standard);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Roll No");
            int roll = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Your name ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Your age");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Your class");
            int standard = int.Parse(Console.ReadLine());

            //Student Ali = new Student();
            //Ali.setStudent(22, "ali khan",23,10);
            //Ali.getStudent();
            //Console.WriteLine("---------------");
            //Student Adeed = new Student();
            //Adeed.setStudent(52, "Adeed khan", 63, 12);
            //Adeed.getStudent();
           // object and class
        }
    }
}
