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
    public partial class BesinOgeleri_5 : Form
    {
        public BesinOgeleri_5()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BesinOgeleri_4 besinOgeleri_4 = new BesinOgeleri_4();
            this.Close();
            besinOgeleri_4.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BesinOgeleri_6 besinOgeleri_6 = new BesinOgeleri_6();
            this.Close();
            besinOgeleri_6.Show();
        }
    }
}
