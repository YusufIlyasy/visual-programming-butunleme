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
    public partial class BeslenmeİleIlgiliKavramlarFormu_5 : Form
    {
        public BeslenmeİleIlgiliKavramlarFormu_5()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            BeslenmeİleIlgiliKavramlarFormu_4 beslenmeİleIlgiliKavramlarFormu_4 = new BeslenmeİleIlgiliKavramlarFormu_4();
            beslenmeİleIlgiliKavramlarFormu_4.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BeslenmeİleIlgiliKavramlarFormu_6 beslenmeİleIlgiliKavramlarFormu_6 = new BeslenmeİleIlgiliKavramlarFormu_6();
            beslenmeİleIlgiliKavramlarFormu_6.Show();
            this.Close();
        }
    }
}
