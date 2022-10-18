using System;
namespace Polymorphism_Interface_Task.Models
{
    public class Animal
    {
        public Animal()
        {
        }

        public virtual void Sound()
        {
            Console.WriteLine("Animal Sound");
        }

        public void Eat()
        {
            Console.WriteLine("Animals eating!");
        }
    }
}

