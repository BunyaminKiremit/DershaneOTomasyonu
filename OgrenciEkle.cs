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
    public partial class OgrenciEkle : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-ITB5932\\SQLEXPRESS; initial catalog=DershaneLogin; Integrated Security=TRUE");

        public OgrenciEkle()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //ekle
            Ekle();
          
        }
        public void Ekle() {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into OgrenciKayıt(ad,soyad,tckimlik,dogumtarihi,cinsiyet,telefon,alan,adres,kayıttarihi,velitc,veliad,velisoyad,velitelefon) values(@ad,@soyad,@tckimlik,@dogumtarihi,@cinsiyet,@telefon,@alan,@adres,@kayıttarihi,@velitc,@veliad,@velisoyad,@velitelefon)",con);
            cmd.Parameters.AddWithValue("@ad", textEdit1.Text);
            cmd.Parameters.AddWithValue("@soyad", textEdit2.Text);
            cmd.Parameters.AddWithValue("@tckimlik", textEdit3.Text);
            cmd.Parameters.AddWithValue("@dogumtarihi", dateTimePicker1.Value);
            cmd.Parameters.AddWithValue("@cinsiyet", comboBoxEdit1.SelectedItem);
            cmd.Parameters.AddWithValue("@telefon", textEdit5.Text);
            cmd.Parameters.AddWithValue("@alan", comboBoxEdit2.SelectedItem);
            cmd.Parameters.AddWithValue("@adres", textEdit6.Text);
            cmd.Parameters.AddWithValue("@kayıttarihi", dateTimePicker2.Value);
            cmd.Parameters.AddWithValue("@velitc", textEdit8.Text);
            cmd.Parameters.AddWithValue("@veliad", textEdit9.Text);
            cmd.Parameters.AddWithValue("@velisoyad", textEdit10.Text);
            cmd.Parameters.AddWithValue("@velitelefon", textEdit11.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            dataGridView1.ClearSelection();
            this.ogrenciKayıtTableAdapter.Fill(this.dershaneLoginDataSet.OgrenciKayıt);
            MessageBox.Show("Öğrenci Eklendi");

            textEdit1.Text = "";
            textEdit2.Text = "";
            textEdit3.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            comboBoxEdit1.SelectedIndex = 0;
            textEdit5.Text = "";
            comboBoxEdit2.SelectedIndex = 0;           
            textEdit6.Text = "";
            dateTimePicker2.Value = DateTime.Now;
            textEdit8.Text = "";
            textEdit9.Text = "";
            textEdit10.Text = "";
            textEdit11.Text = "";


        }


        private void OgrenciEkle_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'dershaneLoginDataSet.OgrenciKayıt' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ogrenciKayıtTableAdapter.Fill(this.dershaneLoginDataSet.OgrenciKayıt);
           
        }
       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textEdit1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textEdit2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textEdit3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            comboBoxEdit1.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textEdit5.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            comboBoxEdit2.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            textEdit6.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            dateTimePicker2.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            textEdit8.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            textEdit9.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            textEdit10.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
            textEdit11.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();
        }
    }
}
