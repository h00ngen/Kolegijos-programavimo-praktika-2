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
    public partial class ProfilisDestytojas : Form
    {
        public ProfilisDestytojas()
        {
            InitializeComponent();
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
                MessageBox.Show("Not a good picture");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SlaptazodisKeitimas Slaptazodis = new SlaptazodisKeitimas();
            Slaptazodis.ShowDialog();
        }
    }
}
