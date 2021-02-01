using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace DersHaneOTM
{
    public partial class AnaEkran : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public AnaEkran()
        {
            InitializeComponent();
        }

        private void AnaEkran_Load(object sender, EventArgs e)
        {
            ArkaPlan ak = new ArkaPlan();
            ak.MdiParent = this;
            ak.Show();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            OgrenciEkle oe = new OgrenciEkle();
            oe.MdiParent = this;
            oe.Show();
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            OgrenciSil os = new OgrenciSil();
            os.MdiParent = this;
            os.Show();
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            OgrenciGüncelle og = new OgrenciGüncelle();
            og.MdiParent = this;
            og.Show();
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            OgrenciListe ol = new OgrenciListe();
            ol.MdiParent = this;
            ol.Show();
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            Veli veli = new Veli();
            veli.MdiParent = this;
            veli.Show();
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            PersonelEkle pe = new PersonelEkle();
            pe.MdiParent = this;
            pe.Show();
        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            PersonelSil ps = new PersonelSil();
            ps.MdiParent = this;
            ps.Show();
        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            PersonelGuncelle pg = new PersonelGuncelle();
            pg.MdiParent = this;
            pg.Show();

        }

        private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
        {
            PersonelListe pl = new PersonelListe();
            pl.MdiParent = this;
            pl.Show();

        }

      

       
        private void barButtonItem17_ItemClick(object sender, ItemClickEventArgs e)
        {
            Application.Exit();
        }

        private void barButtonItem19_ItemClick(object sender, ItemClickEventArgs e)
        {
            KullaniciEkle ke = new KullaniciEkle();
            ke.MdiParent = this;
            ke.Show();
        }

        private void barButtonItem20_ItemClick(object sender, ItemClickEventArgs e)
        {
            KullaniciSilcs ks = new KullaniciSilcs();
            ks.MdiParent = this;
            ks.Show();
        }

        private void barButtonItem21_ItemClick(object sender, ItemClickEventArgs e)
        {

            KullaniciGuncelle kg = new KullaniciGuncelle();
            kg.MdiParent = this;
            kg.Show();
        }

        private void barButtonItem10_ItemClick(object sender, ItemClickEventArgs e)
        {
            Sinav snv = new Sinav();
            snv.MdiParent = this;
            snv.Show();
        }

        private void barButtonItem11_ItemClick(object sender, ItemClickEventArgs e)
        {
            SinavListe sl = new SinavListe();
            sl.MdiParent = this;
            sl.Show();
        }
    }
}