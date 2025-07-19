using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Admin : User
    {
        public int AdminId;

        public void RegisterAdmin(int adminId, string name, string email)
        {
            AdminId = adminId;
            RegisterUser(name, email);
        }
    }
}
