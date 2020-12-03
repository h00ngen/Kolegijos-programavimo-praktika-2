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
    public partial class AdminGrupesIvedimas : Form
    {
        private SqlConnection conn;

        public AdminGrupesIvedimas()
        {
            conn = new SqlConnection(@"Server=.;Database=praktika;Integrated Security=true;");
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO groups(groupname) VALUES (@groupname)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@groupname", this.textBoxGrupesIvedimas.Text);
            conn.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show($"Grupe {textBoxGrupesIvedimas.Text} sekmingai ivesta i sistema!");
            conn.Close();
        }
    }
}
