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
    public partial class BesinOgeleri_2 : Form
    {
        public BesinOgeleri_2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BesinOgeleri_1 besinOgeleri_1 = new BesinOgeleri_1();
            besinOgeleri_1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BesinOgeleri_3 besinOgeleri_3 = new BesinOgeleri_3();
            besinOgeleri_3.Show();
            this.Close();
        }
    }
}
