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
    public partial class Sinav : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-ITB5932\\SQLEXPRESS; initial catalog=DershaneLogin; Integrated Security=TRUE");
       
        public Sinav()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            double SAY1, SOZ1, EA1;
            double turk1_d, turk1_y, mat1_d,  mat1_y,  sos1_d,  sos1_y,  fen1_d,  fen1_y ;

            turk1_d = double.Parse(textBox1.Text);
            turk1_y = double.Parse(textBox2.Text);
            mat1_d = double.Parse(textBox3.Text);
            mat1_y = double.Parse(textBox4.Text); 
            sos1_d = double.Parse(textBox5.Text);      
            sos1_y = double.Parse(textBox6.Text);
            fen1_d = double.Parse(textBox7.Text);     
            fen1_y = double.Parse(textBox8.Text);
            SAY1 = Convert.ToDouble(126.789 + ((turk1_d - (turk1_y / 4)) * 0.686) + ((sos1_d - (sos1_y / 4)) * 0.521) + ((mat1_d - (mat1_y / 4)) * 2.488) + ((fen1_d - (fen1_y / 4)) * 2.085));
            SOZ1 = Convert.ToDouble(118.703 + ((turk1_d - (turk1_y / 4)) * 2.566) + ((sos1_d - (sos1_y / 4)) * 2.04) + ((mat1_d - (mat1_y / 4)) * 0.837) + ((fen1_d - (fen1_y / 4)) * 0.667));
            EA1 = Convert.ToDouble(120.705 + ((turk1_d - (turk1_y / 4)) * 2.016) + ((sos1_d - (sos1_y / 4)) * 0.86) + ((mat1_d - (mat1_y / 4)) * 2.466) + ((fen1_d - (fen1_y / 4)) * 0.655));

            labelControl10.Text = SAY1.ToString();
            labelControl11.Text = SOZ1.ToString();
            labelControl12.Text = EA1.ToString();


            SqlCommand cmd = new SqlCommand("Select * From OgrenciKayıt where numara='" + comboBox1.SelectedItem.ToString() + "'", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                textBox9.Text = comboBox1.SelectedItem.ToString();
                textBox10.Text = dr["ad"].ToString();
                textBox12.Text = dr["soyad"].ToString();
                textBox11.Text = dr["alan"].ToString();
                if (dr["alan"]=="Sayısal")
                {
                    textBox13.Text = SAY1.ToString();
                }
                else if (dr["alan"] == "Eşit Ağırlık")
                {
                    textBox13.Text = EA1.ToString();
                }
                else textBox13.Text = SOZ1.ToString();

            }
            con.Close();
        }

        private void Sinav_Load(object sender, EventArgs e)
        {
            
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT *FROM OgrenciKayıt";
            komut.Connection = con;
            komut.CommandType = CommandType.Text;

            SqlDataReader dr;
            con.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["numara"]);
            }
            con.Close();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * From OgrenciKayıt where numara='" + comboBox1.SelectedItem.ToString() +"'",con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                labelControl17.Text = dr["ad"].ToString();
                labelControl18.Text = dr["soyad"].ToString();
                labelControl19.Text = dr["alan"].ToString();

            }
            con.Close();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Sinav(numara,ad,soyad,alan,puan,sinav) values(@numara,@ad,@soyad,@alan,@puan,@sinav)", con);
            cmd.Parameters.AddWithValue("@numara", comboBox1.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@ad", textBox10.Text);
            cmd.Parameters.AddWithValue("@soyad", textBox12.Text);
            cmd.Parameters.AddWithValue("@alan", textBox11.Text);
            cmd.Parameters.AddWithValue("@puan", textBox13.Text);
            cmd.Parameters.AddWithValue("@sinav", comboBox2.SelectedItem.ToString());
            cmd.ExecuteNonQuery();
            con.Close();
            cmd.Dispose();
            MessageBox.Show("Sınav Puanı Kaydedildi ...");
            comboBox1.SelectedIndex = 0;
            textBox10.Text = "";
            textBox12.Text = "";
            textBox11.Text = "";
            textBox13.Text = "";
            comboBox2.SelectedIndex = 0;


        }
      
    }
}
