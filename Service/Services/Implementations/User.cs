using System;
using Service.Services.Interfaces;

namespace Service.Services.Implementations
{
    public class User : IUser
    {
        public void Login(string username, string password)
        {
            Console.WriteLine("Ugurla login oldu");
        }

        public string SendEmail(string email)
        {
            return "Email gonderildi";
        }
    }
}

