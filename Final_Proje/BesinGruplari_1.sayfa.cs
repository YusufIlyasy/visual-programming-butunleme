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
    public partial class BesinGruplari_1 : Form
    {
        public BesinGruplari_1()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            BesinGruplari besinGruplari = new BesinGruplari();
            this.Close();
            besinGruplari.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BesinGruplari_2 besinGruplari2 = new BesinGruplari_2();
            this.Close();
            besinGruplari2.Show();
        }
    }
}