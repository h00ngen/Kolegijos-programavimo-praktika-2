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
    public partial class AdminVartotojoSalinimas : Form
    {
        private SqlConnection conn;

        public AdminVartotojoSalinimas()
        {
            conn = new SqlConnection(@"Server=.;Database=praktika;Integrated Security=true;");
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM users WHERE username = @koldunai";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@koldunai", this.comboBoxVartotojoSalinimas.Text);
            conn.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show($"Vartotojas {comboBoxVartotojoSalinimas.Text} sekmingai istrintas is sistemos!");
            conn.Close();
        }

        private void AdminVartotojoSalinimas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'praktikaDataSetVartotojoSalinimas.users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.praktikaDataSetVartotojoSalinimas.users);
        }
    }
}
