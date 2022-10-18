using System;
namespace Polymorphism_Interface_Task.Models
{
    public class Bird:Animal
    {
        public override void Sound()
        {
            Console.WriteLine("Bird Sound");
        }
    }
}

