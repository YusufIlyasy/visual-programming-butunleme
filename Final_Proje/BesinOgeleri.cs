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
    public partial class BesinOgeleri : Form
    {
        public BesinOgeleri()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BesinOgeleri_1 besinOgeleri_1 = new BesinOgeleri_1();
            besinOgeleri_1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BesinOgeleri_2 besinOgeleri_2 = new BesinOgeleri_2();
            besinOgeleri_2.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BesinOgeleri_4 besinOgeleri_4 = new BesinOgeleri_4();
            besinOgeleri_4.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BesinOgeleri_5 besinOgeleri_5 = new BesinOgeleri_5();
            besinOgeleri_5.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BesinOgeleri_7 besinOgeleri_7 = new BesinOgeleri_7();
            besinOgeleri_7.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            BesinOgeleri_9 besinOgeleri_9 = new BesinOgeleri_9();
            besinOgeleri_9.Show();
            this.Close();
        }
    }
}
