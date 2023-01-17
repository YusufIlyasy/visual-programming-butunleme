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
    public partial class BesinOgeleri_1 : Form
    {
        public BesinOgeleri_1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BesinOgeleri_2 besinOgeleri_2 = new BesinOgeleri_2();
            this.Close();
            besinOgeleri_2.Show();
        }
    }
}
