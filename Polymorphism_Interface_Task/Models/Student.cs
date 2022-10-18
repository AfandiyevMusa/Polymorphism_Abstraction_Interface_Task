using System;
namespace Polymorphism_Interface_Task.Models
{
    public class Student:Person
    {
        public override string ToString()
        {
            return Name + " " + Surname + " " + Age;
        }
        public override void Test2()
        {
            Console.WriteLine("Test student");
        }

    }
}

