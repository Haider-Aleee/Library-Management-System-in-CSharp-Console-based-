using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class User
    {
        public string? Name;
        public string ?Email;
        

        public void RegisterUser(string name, string email)
        {
            Name = name;
            Email = email;
        }
        
        //public void DisplayUserInfo()
        //{
        //    Console.WriteLine($"ID: {Id}, Name: {Name}, Email: {Email}, Phone: {PhoneNumber}, Address: {Address}");
        //}
    }
}
