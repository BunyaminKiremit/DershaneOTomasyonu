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
    public partial class PersonelEkle : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-ITB5932\\SQLEXPRESS; initial catalog=DershaneLogin; Integrated Security=TRUE");
        public PersonelEkle()
        {
            InitializeComponent();
        }

        private void PersonelEkle_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'dershaneLoginDataSet1.PersonelKayit' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.personelKayitTableAdapter.Fill(this.dershaneLoginDataSet1.PersonelKayit);

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Ekle();
        }
        public void Ekle()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into PersonelKayit(ad,soyad,tckimlik,cinsiyet,brans,telefon,adres,gorev) values(@ad,@soyad,@tckimlik,@cinsiyet,@brans,@telefon,@adres,@gorev)", con);
            cmd.Parameters.AddWithValue("@ad", textEdit1.Text);
            cmd.Parameters.AddWithValue("@soyad", textEdit2.Text);
            cmd.Parameters.AddWithValue("@tckimlik", textEdit3.Text);
            cmd.Parameters.AddWithValue("@cinsiyet", comboBoxEdit1.SelectedItem);
            cmd.Parameters.AddWithValue("@brans", comboBoxEdit2.SelectedItem);
            cmd.Parameters.AddWithValue("@telefon", textEdit5.Text);            
            cmd.Parameters.AddWithValue("@adres", textEdit6.Text);
            cmd.Parameters.AddWithValue("@gorev", comboBoxEdit3.SelectedItem);
            cmd.ExecuteNonQuery();
            con.Close();
            dataGridView1.ClearSelection();
            this.personelKayitTableAdapter.Fill(this.dershaneLoginDataSet1.PersonelKayit);
            MessageBox.Show("Personel Eklendi...");
            textEdit1.Text = "";
            textEdit2.Text = "";
            textEdit3.Text = "";
            comboBoxEdit1.SelectedIndex = 0;
            comboBoxEdit2.SelectedIndex = 0;
            textEdit5.Text = "";
            textEdit6.Text = "";
            comboBoxEdit3.SelectedIndex = 0;



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textEdit1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textEdit2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textEdit3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();          
            comboBoxEdit1.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            comboBoxEdit2.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textEdit5.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            textEdit6.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            comboBoxEdit3.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
        }
    }
}
