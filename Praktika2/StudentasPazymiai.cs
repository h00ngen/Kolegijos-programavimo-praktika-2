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
    public partial class StudentasPazymiai : Form
    {
        private SqlConnection conn;
        string vardas;

        public StudentasPazymiai(string name)
        {
            conn = new SqlConnection(@"Server=.;Database=praktika;Integrated Security=true;");
            InitializeComponent();
            this.vardas = name;
        }

        private void cboDalykoPasirinkimas_SelectedIndexChanged(object sender, EventArgs e)
        {
           // Category obj=cboDalykoPasirinkimas.SelectedItem as Category
        }

        private void StudentasPazymiai_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'praktikaDataSetRodytiPazymius.marks' table. You can move, or remove it, as needed.
            this.marksTableAdapter.Fill(this.praktikaDataSetRodytiPazymius.marks);
            // TODO: This line of code loads data into the 'praktikaDataSetPasirinktiDalykaPazymiams.lectures' table. You can move, or remove it, as needed.
            this.lecturesTableAdapter.Fill(this.praktikaDataSetPasirinktiDalykaPazymiams.lectures);
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string answer = this.comboBoxDalykoPasirinkimas.SelectedValue.ToString();
            StudentasPerziuretiPazymius perziuretiPazymius = new StudentasPerziuretiPazymius(answer, this.vardas);
            perziuretiPazymius.ShowDialog();
            //comboBoxDalykoPasirinkimas;
        }
    }
}
