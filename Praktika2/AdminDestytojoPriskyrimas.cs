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
    public partial class AdminDestytojoPriskyrimas : Form
    {
        string paskaita;
        private SqlConnection conn;

        public AdminDestytojoPriskyrimas()
        {
            conn = new SqlConnection(@"Server=.;Database=praktika;Integrated Security=true;");
            InitializeComponent();
        }

        private void comboBoxDestytojoPasirinkimas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AdminDestytojoPriskyrimas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'praktikaDataSet1.lectures' table. You can move, or remove it, as needed.
            this.lecturesTableAdapter.Fill(this.praktikaDataSet1.lectures);
            // TODO: This line of code loads data into the 'praktikaDataSet.users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.praktikaDataSet.users);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.usersTableAdapter.FillBy(this.praktikaDataSet.users);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        public void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            string sql1 = "SELECT lectureID FROM lectures WHERE name = @paskaita1";
            SqlCommand cmd1 = new SqlCommand(sql1, conn);
            cmd1.Parameters.AddWithValue("@paskaita1", this.comboBoxPaskaitosPasirinkimas.Text);
            cmd1.ExecuteNonQuery();
            SqlDataReader myReader = cmd1.ExecuteReader();
            while (myReader.Read())
            { 
                this.paskaita = myReader["lectureID"].ToString();
            }
            conn.Close();


            conn.Open();
            string sql2 = "INSERT INTO lecturedby VALUES (@paskaita, @vartotojas)";
            SqlCommand cmd2 = new SqlCommand(sql2, conn);
            cmd2.Parameters.AddWithValue("@vartotojas", this.comboBoxDestytojoPasirinkimas.Text);
            cmd2.Parameters.AddWithValue("@paskaita", this.paskaita);
            cmd2.ExecuteNonQuery();

            MessageBox.Show($"Mokytojas {comboBoxDestytojoPasirinkimas.Text} sėkmingai priskirtas prie paskaitos {comboBoxPaskaitosPasirinkimas.Text}!");
            conn.Close();
        }
    }
}
