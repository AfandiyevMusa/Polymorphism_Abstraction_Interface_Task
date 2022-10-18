using System;
using Math;
using Polymorphism_Interface_Task.Models;
using Service.Services.Implementations;

namespace Polymorphism_Interface_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calculator_Task_1
            Calculation calculate = new Calculation();
            Console.WriteLine(calculate.Calculate());

            #region Classroom_Tasks
            ////Task_1
            //Car car1 = new Car();
            //Console.WriteLine(car1.Name);

            ////Task_2
            //Console.WriteLine(car1.Brand);
            //car1.Brand = "Tesla";

            ////Task_3
            //Factorial factorial1 = new Factorial();
            //Console.WriteLine(factorial1.findFactorial());

            ////Task_4
            //Bird bird = new Bird();
            //bird.Sound();
            //bird.Eat();

            //Cat cat = new Cat();
            //cat.Sound();

            //Animal animal = new Animal();
            //animal.Sound();

            ////Task_5
            //Student student = new Student
            //{
            //    Name = "Farid",
            //    Surname = "Guliyev",
            //    Age = "19"
            //};

            //Console.WriteLine(GetStudent(student, "20"));

            ////Task_6
            //Student student = new Student();
            //student.Test2();

            //Employee employee = new Employee();
            //employee.Test2();

            //Task_7
            //Example example = new Example();

            ////Task_8
            //User user = new User();
            //user.Login("hello", "hi");
            //Console.WriteLine(user.SendEmail("helloWorld"));
            #endregion
        }

        //public static Student GetStudent(Student student, string age)
        //{
        //    student.Age = age;
        //    return student;
        //}
    }
}

