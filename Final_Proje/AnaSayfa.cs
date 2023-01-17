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
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BeslenmeIleIlgiliKavramlar beslenmeIleIlgiliKavramlar = new BeslenmeIleIlgiliKavramlar();
            beslenmeIleIlgiliKavramlar.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BesinOgeleri besinOgeleri = new BesinOgeleri();
            besinOgeleri.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BesinGruplari besinGruplari = new BesinGruplari();
            besinGruplari.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        
    }
}
