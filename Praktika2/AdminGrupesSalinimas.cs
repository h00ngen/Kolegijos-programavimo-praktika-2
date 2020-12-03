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
    public partial class AdminGrupesSalinimas : Form
    {
        private SqlConnection conn;

        public AdminGrupesSalinimas()
        {
            conn = new SqlConnection(@"Server=.;Database=praktika;Integrated Security=true;");
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string sql = "DELETE FROM groups WHERE groupname = @kebabai";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@kebabai", this.comboBoxGrupesSalinimas.Text);
            conn.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show($"Grupė {comboBoxGrupesSalinimas.Text} sėkmingai ištrinta iš sistemos!");
            conn.Close();
        }

        private void AdminGrupesSalinimas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'praktikaDataSet2.groups' table. You can move, or remove it, as needed.
            this.groupsTableAdapter.Fill(this.praktikaDataSet2.groups);
        }
    }
}
