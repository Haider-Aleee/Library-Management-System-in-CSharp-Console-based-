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

        public Admin(int adminId, string adminName, string adminEmail)
        {
            AdminId = adminId;
            Name = adminName;
            Email = adminEmail;
        }
    }
}
