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
    public partial class BeslenmeİleIlgiliKavramlarFormu_4 : Form
    {
        public BeslenmeİleIlgiliKavramlarFormu_4()
        {
            InitializeComponent();
        }

        private void BeslenmeİleIlgiliKavramlarFormu_4_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            BeslenmeİleIlgiliKavramlarFormu_3 beslenmeİleIlgiliKavramlarFormu_3 = new BeslenmeİleIlgiliKavramlarFormu_3();
            beslenmeİleIlgiliKavramlarFormu_3.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BeslenmeİleIlgiliKavramlarFormu_5 beslenmeİleIlgiliKavramlarFormu_5 = new BeslenmeİleIlgiliKavramlarFormu_5();
            beslenmeİleIlgiliKavramlarFormu_5.Show();
            this.Close();
        }
    }
}
