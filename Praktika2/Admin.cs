using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktika2
{
    class Admin : User
    {
        public Admin(string name, string surname, DateTime birthDate, string username, string password, string role, string group) : base(name, surname, birthDate, username, password, role, group)
        {

        }
    }
}