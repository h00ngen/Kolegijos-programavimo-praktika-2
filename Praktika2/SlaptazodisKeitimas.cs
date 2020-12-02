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
    public partial class SlaptazodisKeitimas : Form
    {
        private UsersRepository duomenys = new UsersRepository();

        public SlaptazodisKeitimas()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                User administratorius = duomenys.SlaptazodzioKeitimas(textBox1.Text);
            }
            catch (Exception xc)
            {
                MessageBox.Show(xc.Message);
            }
        }
    }
}
