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
    public partial class BesinGruplari : Form
    {
        public BesinGruplari()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BesinGruplari_2 besinGruplari_2 = new BesinGruplari_2();
            besinGruplari_2.Show();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            BesinGruplari_1 besinGruplari_1 = new BesinGruplari_1();
            this.Close();
            besinGruplari_1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BesinGruplari_2 besinGruplari_2 = new BesinGruplari_2();
            this.Close();
            besinGruplari_2.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BesinGruplari_2 besinGruplari_2 = new BesinGruplari_2();
            this.Close();
            besinGruplari_2.Show();
        }
    }
}
