using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Final_Proje
{
    public partial class giris : Form
    {
        public giris()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-VO51J7C\SQLEXPRESS;Initial Catalog=final_proje_db;Integrated Security=True");
        

        private void button1_Click(object sender, EventArgs e) //giriş yap butonu
        {
            string kullad = textBox1.Text;
            string sifre = textBox2.Text;

            try
            {
                string sorgu = "SELECT * FROM login WHERE kullaniciAdi= '" + textBox1.Text + "' AND sifre= '" + textBox2.Text + "' ";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sorgu, conn);

                DataTable dt = new DataTable();
                sqlDataAdapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    kullad = textBox1.Text;
                    sifre = textBox2.Text;

                    AnaSayfa anaSayfa = new AnaSayfa();
                    this.Hide();
                    anaSayfa.Show();

                    
                }
                else
                {
                    MessageBox.Show("Hatalı Giriş", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Clear();
                    textBox2.Clear();

                    textBox1.Focus();
                }
            }
            catch
            {
                MessageBox.Show("hata var");
            }
            finally
            {
                conn.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e) //Temizle Butonu
        {
            textBox1.Clear();
            textBox2.Clear();

            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult cikis;
            cikis = MessageBox.Show("Çıkmak istediğinden emin misin?","Çıkış Ekranı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(cikis == DialogResult.Yes)
                Application.Exit();
            else
                this.Show();
        }

        private void giris_Load(object sender, EventArgs e)
        {
            
        }
    }
}
