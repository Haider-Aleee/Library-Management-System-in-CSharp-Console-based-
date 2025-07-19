using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Student : User
    {
        public int StudentId;

        public void RegisterStudent(int studentId, string name, string email)
        {
            StudentId = studentId;
            RegisterUser(name, email);
        }
    }
}
