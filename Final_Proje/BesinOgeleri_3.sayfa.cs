using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Proje
{
    public partial class BesinOgeleri_3 : Form
    {
        public BesinOgeleri_3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BesinOgeleri_2 besinOgeleri_2 = new BesinOgeleri_2();
            besinOgeleri_2.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BesinOgeleri_4 besinOgeleri_4 = new BesinOgeleri_4();
            besinOgeleri_4.Show();
            this.Close();
        }
    }
}
