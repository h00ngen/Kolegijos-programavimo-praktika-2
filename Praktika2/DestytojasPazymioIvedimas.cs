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
    public partial class DestytojasPazymioIvedimas : Form
    {
        private SqlConnection conn;
        string vardas;

        public DestytojasPazymioIvedimas(string name)
        {
            conn = new SqlConnection(@"Server=.;Database=praktika;Integrated Security=true;");
            InitializeComponent();
            this.vardas = name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show($"{this.vardas}");
            conn.Open();
            string sql1 = "SELECT * FROM lecturedby WHERE FK_lectures = @kintamasis AND FK_user = @prisijungesdestytojas";
            SqlCommand cmd1 = new SqlCommand(sql1, conn);
            cmd1.Parameters.AddWithValue("@kintamasis", this.comboBoxDestytojasPaskaitosIvedimas.SelectedValue);
            cmd1.Parameters.AddWithValue("@prisijungesdestytojas", this.vardas);
            cmd1.ExecuteNonQuery();
            SqlDataReader myReader = cmd1.ExecuteReader();
            string test = null;
            while (myReader.Read())
            {
                test = myReader["FK_user"].ToString();
            }
            conn.Close();

            conn.Open();
            if (String.IsNullOrEmpty(test))
            {
                MessageBox.Show("Jūs neturite šios paskaitos");
            }
            else
            {
                string sql = "INSERT INTO marks (mark, FK_user, FK_lectures) VALUES (@pazymys, @studentas, @paskaita)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@studentas", this.comboBoxStudentoPasirinkimas.Text);
                cmd.Parameters.AddWithValue("@pazymys", this.comboBoxPazymioPasirinkimas.Text);
                cmd.Parameters.AddWithValue("@paskaita", this.comboBoxDestytojasPaskaitosIvedimas.SelectedValue);
                cmd.ExecuteNonQuery();

                MessageBox.Show($"{comboBoxPazymioPasirinkimas.Text} balų sėkmingai įvesti studentui {comboBoxStudentoPasirinkimas.Text}!");
            }
            //MessageBox.Show($"{test}");
            conn.Close();














        }

        private void DestytojasPazymioIvedimas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'praktikaDataSetPasirinkitePaskaita.lectures' table. You can move, or remove it, as needed.
            this.lecturesTableAdapter.Fill(this.praktikaDataSetPasirinkitePaskaita.lectures);
            // TODO: This line of code loads data into the 'praktikaDataSetIvestiStudentuiPazymi.users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.praktikaDataSetIvestiStudentuiPazymi.users);

        }

        private void rodytiTikStudentusToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.usersTableAdapter.RodytiTikStudentus(this.praktikaDataSetIvestiStudentuiPazymi.users);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void DestytojasPaskaitosIvedimas_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*string sql = "SELECT * FROM lectures WHERE lectureID IN(SELECT FK_lectures FROM lecturedby WHERE FK_user = @destytojas)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@destytojas", this.vardas);
            conn.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("kazkas vyksta");
            conn.Close();*/


            //SELECT* FROM lectures WHERE lectureID IN(SELECT FK_lectures FROM lecturedby WHERE FK_user = 'Vaidas')
        }
    }
}
