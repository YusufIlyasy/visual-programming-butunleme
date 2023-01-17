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
    public partial class BesinGruplari_3 : Form
    {
        public BesinGruplari_3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BesinGruplari_2 besinGruplari_2 = new BesinGruplari_2();
            this.Close();
            besinGruplari_2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BesinGruplari_4 besinGruplari_4 = new BesinGruplari_4();
            this.Close();
            besinGruplari_4.Show();
        }
    }
}
