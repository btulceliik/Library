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



namespace OtomasyonKutuphane
{
    public partial class FormYoneticiGuncelleme : Form
    {
        public FormYoneticiGuncelleme()
        {
            InitializeComponent();
        }

        public string id,ad,soyad,telefon,mail,sifre;

        SqlBaglantisi bgl = new SqlBaglantisi();

        private void FormYoneticiGuncelleme_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            SqlCommand komutsil = new SqlCommand("delete from YONETICI where yoneticiId=@k1", bgl.baglanti());
            komutsil.Parameters.AddWithValue("@k1", textBoxYoneticiID.Text);
            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Silindi");
            this.yONETICITableAdapter.Fill(this.kUTUPHANEDataSet3.YONETICI);
        }

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            string id, ad, soyad, telefon, mail, sifre;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            soyad = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            sifre = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            mail = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            telefon = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            


            textBoxYoneticiID.Text = id;
            textBoxYoneticiAd.Text = ad;
            textBoxYoneticiSoyad.Text = soyad;
            textBoxYoneticiSifre.Text = sifre;
            maskedTextBoxYoneticiTelefon.Text = telefon;
            textBoxYoneticiMail.Text = mail;
        }    

        

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komutguncelle = new SqlCommand("update YONETICI set yoneticiAdi=@a2,yoneticiSoyadi=@a3,yoneticiSifre=@a4,yoneticiMail=@a5,yoneticiTelefon=@a6 where yoneticiId=@a1", bgl.baglanti());
                komutguncelle.Parameters.AddWithValue("@a1", textBoxYoneticiID.Text);
                komutguncelle.Parameters.AddWithValue("@a2", textBoxYoneticiAd.Text);
                komutguncelle.Parameters.AddWithValue("@a3", textBoxYoneticiSoyad.Text);
                komutguncelle.Parameters.AddWithValue("@a4", textBoxYoneticiSifre.Text);
                komutguncelle.Parameters.AddWithValue("@a5", textBoxYoneticiMail.Text);
                komutguncelle.Parameters.AddWithValue("@a6", maskedTextBoxYoneticiTelefon.Text);
                komutguncelle.ExecuteNonQuery();

                bgl.baglanti().Close();
                MessageBox.Show("Kayıt Güncellendi");
                

            }
            catch (Exception)
            {
                MessageBox.Show("HATA! Lütfen Tekrar Deneyiniz");
            }
        }



        private void FormYoneticiGuncelleme_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'kUTUPHANEDataSet3.YONETICI' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.yONETICITableAdapter.Fill(this.kUTUPHANEDataSet3.YONETICI);

            textBoxYoneticiID.Text = id;
            textBoxYoneticiAd.Text = ad;
            textBoxYoneticiSoyad.Text = soyad;
            maskedTextBoxYoneticiTelefon.Text = telefon;
            textBoxYoneticiSifre.Text = sifre;
            textBoxYoneticiMail.Text = mail;


        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

       
    }
}
