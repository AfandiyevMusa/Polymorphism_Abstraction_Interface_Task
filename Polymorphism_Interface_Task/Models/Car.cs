using System;
namespace Polymorphism_Interface_Task.Models
{
    public class Car
    {
        public readonly string Name;

        //public Car()
        //{
        //    Name = "BMW";
        //}

        public string Brand { get; private set; }

        public Car()
        {
            Brand = "Mercedes";
        }


    }
}

