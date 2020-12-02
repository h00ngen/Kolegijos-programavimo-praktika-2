using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Security.Policy;
using System.Text;

namespace Praktika2
{
    class Person
    {
        public string Name;
        public string Surname;
        public DateTime Birthday;
        public double AgeNumber;
        public string Nickname;
        public string Slaptikas;
        public string Role;
        public string Group;

        public double GetAge()
        {
            AgeNumber = Math.Floor((DateTime.Now - Birthday).TotalDays / 365);
            return AgeNumber;
        }
        public string GetName()
        {
            return Name;
        }
        public string GetSurname()
        {
            return Surname;
        }
        public DateTime GetBirthdate()
        {
            return Birthday;
        }
        public string GetUsername()
        {
            return Nickname;
        }
        public string GetRole()
        {
            return Role;
        }
        public string GetGroup()
        {
            return Group;
        }

        public Person(string name, string surname, DateTime birthday, string nickname, string slaptikas, string role, string group)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(surname))
            {
                throw new Exception("Neįvestas vardas ar pavardė");
            }

            if (string.IsNullOrEmpty(nickname) || string.IsNullOrEmpty(slaptikas))
            {
                throw new Exception("Neįvestas prisijungimo vardas arba slaptažodis");
            }

            Name = name;
            Surname = surname;
            Birthday = birthday;
            Nickname = nickname;
            Slaptikas = slaptikas;
            Role = role;
            Group = group;
        }
    }
}
