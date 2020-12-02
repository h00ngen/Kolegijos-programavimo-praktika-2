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
    public partial class NaudotojuSarasas : Form
    {
        public NaudotojuSarasas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = checkedListBox1.Items.Count - 1; i >= 0; i--)
            {
                if (checkedListBox1.GetItemChecked(i))
                {
                    checkedListBox1.Items.Remove(checkedListBox1.Items[i]);
                    MessageBox.Show("Sėkmingai ištrynėte vartotoją!");
                }
            }
        }
    }
}
