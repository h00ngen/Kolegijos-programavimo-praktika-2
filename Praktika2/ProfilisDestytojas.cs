using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Praktika2
{
    public partial class ProfilisDestytojas : Form
    {
        private SqlConnection conn;
        string vardas;

        public ProfilisDestytojas(string name, string surname)
        {
            conn = new SqlConnection(@"Server=.;Database=praktika;Integrated Security=true;");
            InitializeComponent();
            vardasDestytojas.Text = name;
            pavardeDestytojas.Text = surname;
            this.vardas = name;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            String imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All files (*.*)|*.*";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    pictureBox1.ImageLocation = imageLocation;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Netinkama nuotrauka. Pasirinkite kitą");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SlaptazodisKeitimas Slaptazodis = new SlaptazodisKeitimas();
            Slaptazodis.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DestytojasPazymioIvedimas pazymioIvedimas = new DestytojasPazymioIvedimas(vardas);
            pazymioIvedimas.ShowDialog();
        }
    }
}
