using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class User
    {
        public int Id;
        public string Name;
        public string Email;
        public string PhoneNumber;
        public string Address;
        public User(int id, string name, string email, string phoneNumber, string address)
        {
            Id = id;
            Name = name;
            Email = email;
            PhoneNumber = phoneNumber;
            Address = address;
        }
        
        public void DisplayUserInfo()
        {
            Console.WriteLine($"ID: {Id}, Name: {Name}, Email: {Email}, Phone: {PhoneNumber}, Address: {Address}");
        }
    }
}
