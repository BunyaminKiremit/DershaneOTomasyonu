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
    public partial class KullaniciSilcs : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-ITB5932\\SQLEXPRESS; initial catalog=DershaneLogin; Integrated Security=TRUE");
        public KullaniciSilcs()
        {
            InitializeComponent();
        }

        private void KullaniciSilcs_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'dershaneLoginDataSet2.Giris' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.girisTableAdapter.Fill(this.dershaneLoginDataSet2.Giris);

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("delete from Giris where id='" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();

            dataGridView1.ClearSelection();
            this.girisTableAdapter.Fill(this.dershaneLoginDataSet2.Giris);
            MessageBox.Show("Kayıt Silindi...");
            textEdit1.Text = "";
            textEdit2.Text = "";
          
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textEdit1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textEdit2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void xtraTabPage2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
