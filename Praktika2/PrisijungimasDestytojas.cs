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
    public partial class PrisijungimasDestytojas : Form
    {
        private UsersRepository duomenys = new UsersRepository();

        private SqlConnection conn;
        private string username;

        public PrisijungimasDestytojas()
        {
            InitializeComponent();
            conn = new SqlConnection(@"Server=.;Database=praktika;Integrated Security=true;");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT username FROM users WHERE username =@username", conn);
                SqlCommand cmd2 = new SqlCommand("SELECT username FROM users WHERE password =@password", conn);
                cmd.Parameters.AddWithValue("@username", this.textBox1.Text);
                cmd2.Parameters.AddWithValue("@password", this.textBox2.Text);
                conn.Open();

                var check = cmd.ExecuteScalar();
                var check2 = cmd2.ExecuteScalar();
                conn.Close();
                if (check != null && check2 != null)
                {
                    ProfilisStudentas prof = new ProfilisStudentas();
                    prof.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Neteisingas slapyvardis arba slaptažodis. Patikrinkite įvestus duomenis dar kartą");
                }
            }
            catch (Exception xc)
            {
                MessageBox.Show(xc.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
