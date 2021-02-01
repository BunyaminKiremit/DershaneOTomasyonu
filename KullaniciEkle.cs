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
    public partial class KullaniciEkle : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-ITB5932\\SQLEXPRESS; initial catalog=DershaneLogin; Integrated Security=TRUE");
        public KullaniciEkle()
        {
            InitializeComponent();
        }

        private void KullaniciEkle_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'dershaneLoginDataSet2.Giris' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.girisTableAdapter.Fill(this.dershaneLoginDataSet2.Giris);

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Ekle();
        }
        public void Ekle()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Giris(KullaniciAdi,Sifre) values(@KullaniciAdi,@Sifre)", con);
            cmd.Parameters.AddWithValue("@KullaniciAdi", textEdit1.Text);
            cmd.Parameters.AddWithValue("@Sifre", textEdit2.Text);
           
            cmd.ExecuteNonQuery();
            con.Close();
            dataGridView1.ClearSelection();
            this.girisTableAdapter.Fill(this.dershaneLoginDataSet2.Giris);
            MessageBox.Show("KUllanıcı Kaydedildi...");
            textEdit1.Text = "";
            textEdit2.Text = "";
            
        }
    }
}
