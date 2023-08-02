using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructsExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            doApp();
            Console.ReadKey();
        }

        static void doApp()
        {
            // Create a student using the struct
            Student student1;
            student1.Name = "John";
            student1.Age = 20;
            student1.Major = "Computer Science";

            // Print student details
            Console.WriteLine("Student Name: " + student1.Name);
            Console.WriteLine("Age: " + student1.Age);
            Console.WriteLine("Major: " + student1.Major);
        }
    }

 
    struct Student
    {
        public string Name;
        public int Age;
        public string Major;
    }

}
