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
    public partial class BesinOgeleri_7 : Form
    {
        public BesinOgeleri_7()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BesinOgeleri_6 besinOgeleri_6 = new BesinOgeleri_6();
            this.Close();
            besinOgeleri_6.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BesinOgeleri_8 besinOgeleri_8 = new BesinOgeleri_8();
            this.Close();
            besinOgeleri_8.Show();
        }
    }
}
