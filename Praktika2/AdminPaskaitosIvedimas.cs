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
    public partial class AdminPaskaitosIvedimas : Form
    {
        private SqlConnection conn;

        public AdminPaskaitosIvedimas()
        {
            conn = new SqlConnection(@"Server=.;Database=praktika;Integrated Security=true;");
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO lectures(name) VALUES (@name)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@name", this.textBoxPaskaitosIvedimas.Text);
            conn.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show($"Paskaita {textBoxPaskaitosIvedimas.Text} sekmingai ivesta i sistema!");
            conn.Close();
        }
    }
}
