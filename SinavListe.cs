using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DersHaneOTM
{
    public partial class SinavListe : Form
    {
        public SinavListe()
        {
            InitializeComponent();
        }

        private void SinavListe_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'dershaneLoginDataSet3.Sinav' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.sinavTableAdapter.Fill(this.dershaneLoginDataSet3.Sinav);

        }
    }
}
