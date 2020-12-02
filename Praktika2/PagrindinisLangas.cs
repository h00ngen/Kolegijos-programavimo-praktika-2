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
    public partial class PagrindinisLangas : Form
    {
        public PagrindinisLangas()
        {
            InitializeComponent();
        }

        private void PrisijungimasVartotojas_Click(object sender, EventArgs e)
        {
            PrisijungimasStudentas studentas = new PrisijungimasStudentas();
            studentas.ShowDialog();
        }

        private void PrisijungimasAdministratorius_Click(object sender, EventArgs e)
        {
            PrisijungimasAdmin admin = new PrisijungimasAdmin();
            admin.ShowDialog();
        }

        private void PrisijungimasDestytojas_Click(object sender, EventArgs e)
        {
            PrisijungimasDestytojas destytojas = new PrisijungimasDestytojas();
            destytojas.ShowDialog();
        }
    }
}
