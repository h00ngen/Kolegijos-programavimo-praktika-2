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

        private void button2_Click(object sender, EventArgs e)                                      //keisti profilio nuotrauką
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

        private void button1_Click(object sender, EventArgs e)                                      //keisti slaptažodį
        {
            SlaptazodisKeitimas Slaptazodis = new SlaptazodisKeitimas();
            Slaptazodis.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)                                      //registruotų vartotojų sąrašas                            
        {
            NaudotojuSarasas sarasas = new NaudotojuSarasas();
            sarasas.ShowDialog();
        }

        private void Registracija_Click(object sender, EventArgs e)                                 //užregistruoti naują vartotoją
        {
            AdminVartotojuRegistracija registracija = new AdminVartotojuRegistracija();
            registracija.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)                                      //įvesti naują grupę
        {
            AdminGrupesIvedimas grupesIvedimas = new AdminGrupesIvedimas();
            grupesIvedimas.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)                                      //įvesti naują paskaitą
        {
            AdminPaskaitosIvedimas paskaitosIvedimas = new AdminPaskaitosIvedimas();
            paskaitosIvedimas.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)                                      //priskirti dėstytoją prie paskaitos
        {
            AdminDestytojoPriskyrimas destytojoPriskyrimas = new AdminDestytojoPriskyrimas();
            destytojoPriskyrimas.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)                                      //pašalinti užregistruotą vartotoją
        {
            AdminVartotojoSalinimas vartotojoŠalinimas = new AdminVartotojoSalinimas();
            vartotojoŠalinimas.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)                                      //pašalinti grupę
        {
            AdminGrupesSalinimas grupesSalinimas = new AdminGrupesSalinimas();
            grupesSalinimas.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)                                     //pašalinti paskaitą
        {
            AdminPaskaitosSalinimas paskaitosSalinimas = new AdminPaskaitosSalinimas();
            paskaitosSalinimas.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)                                     //Log-out mygtukas
        {
            Application.Exit();
        }

        private void button11_Click(object sender, EventArgs e)                                     //pašalinti dėstytoją nuo paskaitos
        {

        }
    }
}
