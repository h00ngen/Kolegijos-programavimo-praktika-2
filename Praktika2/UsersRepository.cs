using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Praktika2
{
    class UsersRepository
    {
        private List<User> usersList;

        private SqlConnection conn;

        public UsersRepository()
        {
            conn = new SqlConnection(@"Server=.;Database=praktika;Integrated Security=true;");

            usersList = new List<User>();
            //usersList.Add(new User("Laurynas", "Gudavicius", DateTime.Now, "l", "l"));
            usersList.Add(new Admin("Laurynas", "Gudavicius", DateTime.Now, "admin", "admin", "Administratorius", "Darbuotojas"));
        }

        public void Register(User user)
        {
            string sql = "INSERT INTO users(name, surname, birthdate, username, password, role, FK_group) " +
                "VALUES (@name, @surname, @birthdate, @username, @password, @role, @FK_group)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@name", user.GetName());
            cmd.Parameters.AddWithValue("@surname", user.GetSurname());
            cmd.Parameters.AddWithValue("@birthdate", user.GetBirthdate());
            cmd.Parameters.AddWithValue("@username", user.GetUsername());
            cmd.Parameters.AddWithValue("@password", user.GetPassword());
            cmd.Parameters.AddWithValue("@role", user.GetRole());
            cmd.Parameters.AddWithValue("@FK_group", user.GetGroup());
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            usersList.Add(user);
        }

        public User Login(string username, string password)
        {
            foreach (User u in usersList)
                if (u.GetUsername().Equals(username) && u.GetPassword().Equals(password))
                    return u;

            throw new Exception("Neteisingi prisijungimo duomenys");
        }

        public User SlaptazodzioKeitimas(string password)
        {
            foreach (User u in usersList)
                if (u.GetPassword().Equals(password))
                {
                    MessageBox.Show("Slaptažodis pakeistas sėkmingai!");
                    return u;
                }

            throw new Exception("Neteisingai įvestas senasis slaptažodis");
        }
    }
}