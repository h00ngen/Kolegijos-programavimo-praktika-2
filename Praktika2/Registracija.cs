using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Praktika2
{
    public partial class Registracija : Form
    {
        private SqlConnection conn;

        public Registracija()
        {
            conn = new SqlConnection(@"Server=.;Database=praktika;Integrated Security=true;");
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Person person = new Person(textBox1.Text, textBox2.Text, dateTimePicker1.Value, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text);
                person.GetAge();
                if (person.GetAge() < 17)
                {
                    throw new Exception("Blogai įvesta data (greičiausiai esate per jaunas");
                }

                SqlCommand cmd = new SqlCommand("SELECT username FROM users WHERE username=@username", conn);
                cmd.Parameters.AddWithValue("@username", this.textBox3.Text);
                conn.Open();

                var check = cmd.ExecuteScalar();

                if (check != null)
                {
                    MessageBox.Show("Toks vartotojo vardas jau egzistuoja. Prašome įvesti kitokį vartotojo vardą", this.textBox3.Text);
                    conn.Close();
                }

                else
                {
                    MessageBox.Show($"Naujas vartotojas sėkmingai pridėtas prie sistemos!");

                    User user = new User(textBox1.Text, textBox2.Text, dateTimePicker1.Value, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text);
                    UsersRepository duom = new UsersRepository();
                    duom.Register(user);
                }
            }
            catch (Exception xc)
            {
                MessageBox.Show(xc.Message);
            }
        }
    }
}
