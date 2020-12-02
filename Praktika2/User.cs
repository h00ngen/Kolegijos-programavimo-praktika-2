using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktika2
{
    class User : Person
    {
        protected string username;
        protected string password;
        protected string name;
        protected string surname;
        protected DateTime birthdate2;
        protected string role;
        protected string group;

        public User(string name, string surname, DateTime birthDate, string username, string password, string role, string group) : base(name, surname, birthDate, username, password, role, group)
        {
            this.username = username;
            this.password = password;
            this.name = name;
            this.surname = surname;
            this.birthdate2 = birthDate;
            this.role = role;
            this.group = group;
        }

        public string GetUsername()
        {
            return username;
        }

        public string GetPassword()
        {
            return password;
        }

        public string GetName()
        {
            return name;
        }

        public string GetSurname()
        {
            return surname;
        }
        public DateTime GetBirthdate()
        {
            return birthdate2;
        }
        public string GetRole()
        {
            return role;
        }
        public string GetGroup()
        {
            return group;
        }
    }
}
