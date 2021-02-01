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
    public partial class Veli : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-ITB5932\\SQLEXPRESS; initial catalog=DershaneLogin; Integrated Security=TRUE");
        public Veli()
        {
            InitializeComponent();
        }

        private void Veli_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'dershaneLoginDataSet.OgrenciKayıt' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ogrenciKayıtTableAdapter.Fill(this.dershaneLoginDataSet.OgrenciKayıt);
           

        }
    

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
