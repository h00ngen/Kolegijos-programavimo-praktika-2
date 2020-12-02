using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktika2
{
    public partial class ProfilisAdmin : Form
    {
        public ProfilisAdmin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
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
                MessageBox.Show("Netinkama nuotrauka");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SlaptazodisKeitimas Slaptazodis = new SlaptazodisKeitimas();
            Slaptazodis.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NaudotojuSarasas sarasas = new NaudotojuSarasas();
            sarasas.ShowDialog();
        }

        private void Registracija_Click(object sender, EventArgs e)
        {
            Registracija registracija = new Registracija();
            registracija.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AdminGrupesIvedimas grupesIvedimas = new AdminGrupesIvedimas();
            grupesIvedimas.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AdminPaskaitosIvedimas paskaitosIvedimas = new AdminPaskaitosIvedimas();
            paskaitosIvedimas.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AdminDestytojoPriskyrimas destytojoPriskyrimas = new AdminDestytojoPriskyrimas();
            destytojoPriskyrimas.ShowDialog();
        }
    }
}
