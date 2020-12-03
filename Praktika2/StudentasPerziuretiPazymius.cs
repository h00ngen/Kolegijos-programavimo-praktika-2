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
    public partial class StudentasPerziuretiPazymius : Form
    {
        private SqlConnection conn;
        string dalykas;
        string useris;

        public StudentasPerziuretiPazymius(string dalykas, string useris)
        {
            conn = new SqlConnection(@"Server=.;Database=praktika;Integrated Security=true;");
            InitializeComponent();
            this.dalykas = dalykas;
            this.useris = useris;
            conn.Open();
            string sql = "SELECT * FROM marks WHERE FK_lectures = @belekas AND FK_user = @belekaip";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@belekas", this.dalykas);
            cmd.Parameters.AddWithValue("@belekaip", this.useris);
            cmd.ExecuteNonQuery();
            SqlDataReader myReader = cmd.ExecuteReader();
            while (myReader.Read())
            {
                listBox1.Items.Add($"{myReader["mark"]}");
            }
            conn.Close();
        }










        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*conn.Open();
            string sql = "SELECT * FROM marks WHERE FK_lectures = @belekas AND FK_user = @belekaip";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@belekas", this.dalykas);
            cmd.Parameters.AddWithValue("@belekaip", this.useris);
            SqlDataReader myReader = cmd.ExecuteReader();
            while (myReader.Read())
            {
                //this.paskaita = myReader["lectureID"].ToString();
                listBox1.Items.Insert(0,$"{myReader["mark"].ToString()}y");
            }
            //conn.Close();
            //conn.Open();
            cmd.ExecuteNonQuery();
            //MessageBox.Show($"Grupe {textBoxGrupesIvedimas.Text} sekmingai ivesta i sistema!");
            conn.Close();*/
        }
    }
}
