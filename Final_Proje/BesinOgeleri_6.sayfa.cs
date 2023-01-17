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
    public partial class BesinOgeleri_6 : Form
    {
        public BesinOgeleri_6()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BesinOgeleri_5 besinOgeleri_5 = new BesinOgeleri_5();
            this.Close();
            besinOgeleri_5.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BesinOgeleri_7 besinOgeleri_7 = new BesinOgeleri_7();
            this.Close();
            besinOgeleri_7.Show();
        }
    }
}
