using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtomasyonKutuphane
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void buttonUyeGuncelleme_Click(object sender, EventArgs e)
        {
            FormUyeGuncelleme fr2 = new FormUyeGuncelleme();
            fr2.Show();
           
        }

        private void buttonUyeGirisi_Click(object sender, EventArgs e)
        {
            FormUyeGiris fr = new FormUyeGiris();
            fr.Show();
            
        }

        private void buttonUyeEkleme_Click(object sender, EventArgs e)
        {
            FormUyeKayit fr1 = new FormUyeKayit();
            fr1.Show();
            
        }

        private void buttonYoneticiGiris_Click(object sender, EventArgs e)
        {
            FormYoneticiGiris fr3 = new FormYoneticiGiris();
            fr3.Show();
            
        }

        private void buttonYoneticiEkleme_Click(object sender, EventArgs e)
        {
            FormYoneticiKayit fr4 = new FormYoneticiKayit();
            fr4.Show();
            
        }

        private void buttonYoneticiGuncelleme_Click(object sender, EventArgs e)
        {
            FormYoneticiGuncelleme fr5 = new FormYoneticiGuncelleme();
            fr5.Show();
            
        }

        private void buttonKitapListele_Click(object sender, EventArgs e)
        {
            FormKitapListele fr6 = new FormKitapListele();
            fr6.Show();
            
        }

        private void buttonKitapKaydet_Click(object sender, EventArgs e)
        {
            FormYoneticiGiris fr7 = new FormYoneticiGiris();
            fr7.Show();
            
        }

        private void buttonKitapGuncelle_Click(object sender, EventArgs e)
        {
            FormYoneticiGiris fr8 = new FormYoneticiGiris();
            fr8.Show();
            
        }

        private void buttonKitapOdunc_Click(object sender, EventArgs e)
        {
            FormUyeGiris fr9 = new FormUyeGiris();
            fr9.Show();

        }

        private void buttonKitapIade_Click(object sender, EventArgs e)
        {
            Formİade fr0 = new Formİade();
            fr0.Show();
        }

        private void buttonKitapDegerlendir_Click(object sender, EventArgs e)
        {
            FormKitapDegerlendirme fp = new FormKitapDegerlendirme();
            fp.Show();
        }
    }
}
