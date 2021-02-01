using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DersHaneOTM
{
    public partial class GirisEkranı : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-ITB5932\\SQLEXPRESS; initial catalog=DershaneLogin; Integrated Security=TRUE");
        public GirisEkranı()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            AnaEkran ana = new AnaEkran();
            ana.Show();
            this.Hide();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String Kullanici_adi = textBox1.Text;
            String Sifre = textBox2.Text;
            bool Kayitlimi = false;
            con.Open();
            SqlCommand cmd = new SqlCommand("Select *from Giris", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (Kullanici_adi == dr["KullaniciAdi"].ToString() && Sifre == dr["Sifre"].ToString())
                {
                    Kayitlimi = true;
                    break;
                }
            }
            con.Close();
            if (Kayitlimi == true)
            {
                AnaEkran ana = new AnaEkran();
                ana.Show();
                this.Hide();
            }
            else MessageBox.Show("Kullanıcı adı veya Şifre Hatalıdır !");

        }
    }
}
