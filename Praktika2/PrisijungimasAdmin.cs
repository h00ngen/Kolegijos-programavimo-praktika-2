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
    public partial class PrisijungimasAdmin : Form
    {
        private UsersRepository duomenys = new UsersRepository();

        public PrisijungimasAdmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                User administratorius = duomenys.Login(textBox1.Text, textBox2.Text);
                ProfilisAdmin prof = new ProfilisAdmin();
                prof.ShowDialog();
            }
            catch (Exception xc)
            {
                MessageBox.Show(xc.Message);
            }
        }
    }
}
