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
    public partial class AdminPaskaitosSalinimas : Form
    {
        private SqlConnection conn;

        public AdminPaskaitosSalinimas()
        {
            conn = new SqlConnection(@"Server=.;Database=praktika;Integrated Security=true;");
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string sql = "DELETE FROM lectures WHERE name = @lavasai";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@lavasai", this.comboBoxPaskaitosSalinimas.Text);
            conn.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show($"Paskaita {comboBoxPaskaitosSalinimas.Text} sėkmingai ištrinta iš sistemos!");
            conn.Close();
        }

        private void AdminPaskaitosSalinimas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'praktikaDataSetPaskaituTrynimas.lectures' table. You can move, or remove it, as needed.
            this.lecturesTableAdapter.Fill(this.praktikaDataSetPaskaituTrynimas.lectures);
        }
    }
}
