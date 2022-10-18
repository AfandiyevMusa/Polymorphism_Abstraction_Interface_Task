using System;
namespace Polymorphism_Interface_Task.Models
{
    public abstract class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Age { get; set; }

        public void Test()
        {
            Console.WriteLine("test");
        }
        public abstract void Test2();
    }
}

