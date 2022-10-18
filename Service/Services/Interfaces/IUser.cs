using System;
namespace Service.Services.Interfaces
{
    public interface IUser
    {
        public void Login(string username, string password);
        public string SendEmail(string email);
    }
}

