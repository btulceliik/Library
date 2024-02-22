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
    public partial class FormKitapKayit : Form
    {
        public FormKitapKayit()
        {
            InitializeComponent();
        }
        public string id, ad, yazar, yayinevi, tur, stok, sayfasayisi, basimyili;

        private void FormKitapKayit_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            string id, ad, yazar, yayinevi, tur, stok,sayfasayisi,basimyili;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            yazar = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            yayinevi = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            tur = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            stok = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            sayfasayisi = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            basimyili = dataGridView1.Rows[secilen].Cells[7].Value.ToString();

            textBoxKitapISBN.Text = id;
            textBoxKitapAd.Text = ad;
            comboBoxKitapTuru.Text = tur;
            comboBoxKitapYazari.Text = yazar;
            comboBoxYayinEvi.Text = yayinevi;
            textBoxKitapSayfaSayisi.Text = sayfasayisi;
            maskedTextBoxBasimYili.Text = basimyili;
            textBoxStokNumarası.Text = stok;



        }

        SqlBaglantisi bgl = new SqlBaglantisi();

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komutkaydet = new SqlCommand("insert into KITAP (kitapISBN,kitapIsmi,yazar,yayinEviId,turId,stokId,kitapSayfaSayisi,kitapBasinYili) values (@s1,@s2,@s3,@s4,@s5,@s6,@s7,@s8)", bgl.baglanti());
            komutkaydet.Parameters.AddWithValue("@s1", textBoxKitapISBN.Text);
            komutkaydet.Parameters.AddWithValue("@s2", textBoxKitapAd.Text);
            komutkaydet.Parameters.AddWithValue("@s3", comboBoxKitapYazari.Text);
            komutkaydet.Parameters.AddWithValue("@s4", comboBoxYayinEvi.Text);
            komutkaydet.Parameters.AddWithValue("@s5", comboBoxKitapTuru.Text);
            komutkaydet.Parameters.AddWithValue("@s6", textBoxStokNumarası.Text);
            komutkaydet.Parameters.AddWithValue("@s7", textBoxKitapSayfaSayisi.Text);
            komutkaydet.Parameters.AddWithValue("@s8", maskedTextBoxBasimYili.Text);
            komutkaydet.ExecuteNonQuery();
            this.kITAPTableAdapter1.Fill(this.kUTUPHANEDataSet1.KITAP);


            SqlCommand komutoda = new SqlCommand("update KITAP_STOK set stokId=stokId-1 where stokAdet=@stok", bgl.baglanti());
            komutoda.Parameters.AddWithValue("@stok", textBoxStokNumarası.Text);
            komutoda.ExecuteNonQuery();
            bgl.baglanti().Close();
            this.kITAPTableAdapter1.Fill(this.kUTUPHANEDataSet1.KITAP);



        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FormKitapKayit_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'kUTUPHANEDataSet1.KITAP' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.kITAPTableAdapter1.Fill(this.kUTUPHANEDataSet1.KITAP);

            textBoxKitapISBN.Text = id;
            textBoxKitapAd.Text = ad;
            comboBoxKitapTuru.Text = tur;
            comboBoxKitapYazari.Text = yazar;
            comboBoxYayinEvi.Text = yayinevi;
            textBoxKitapSayfaSayisi.Text = sayfasayisi;
            maskedTextBoxBasimYili.Text = basimyili;
            textBoxStokNumarası.Text = stok;



            // KitapTürü listelenme komutları

            SqlCommand komut = new SqlCommand("Select turAdi From KITAP_TURU", bgl.baglanti());
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                comboBoxKitapTuru.Items.Add(oku[0].ToString());
            }
            bgl.baglanti().Close();

            //Yazar listelenme komutları

            SqlCommand komut2 = new SqlCommand("Select yazarAdiSoyadi From KITAP_YAZAR", bgl.baglanti());
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                comboBoxKitapYazari.Items.Add(oku2[0].ToString());
            }
            bgl.baglanti().Close();


            //Yayınevi listelenme komutları

            SqlCommand komut3 = new SqlCommand("Select yayineviAdi From KITAP_YAYINEVI", bgl.baglanti());
            SqlDataReader oku3 = komut3.ExecuteReader();
            while (oku3.Read())
            {
                comboBoxYayinEvi.Items.Add(oku3[0].ToString());
            }
            bgl.baglanti().Close();

            

        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            SqlCommand komutsil = new SqlCommand("delete from KITAP where kitapISBN=@k1", bgl.baglanti());
            komutsil.Parameters.AddWithValue("@k1", textBoxKitapISBN.Text);
            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Silindi");
            this.kITAPTableAdapter1.Fill(this.kUTUPHANEDataSet1.KITAP);

        }

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
                SqlCommand komutguncelle = new SqlCommand("update KITAP set kitapIsmi=@a2,yazar=@a3,yayinEviId=@a4,turId=@a5,stokId=@a6,kitapSayfaSayisi=@a7,kitapBasinYili=@a8 where kitapISBN=@a1", bgl.baglanti());
                komutguncelle.Parameters.AddWithValue("@a1", textBoxKitapISBN.Text);
                komutguncelle.Parameters.AddWithValue("@a2", textBoxKitapAd.Text);
                komutguncelle.Parameters.AddWithValue("@a3", comboBoxKitapYazari.Text);
                komutguncelle.Parameters.AddWithValue("@a4", comboBoxYayinEvi.Text);
                komutguncelle.Parameters.AddWithValue("@a5", comboBoxKitapTuru.Text);
                komutguncelle.Parameters.AddWithValue("@a6", textBoxStokNumarası.Text);
                komutguncelle.Parameters.AddWithValue("@a7", textBoxKitapSayfaSayisi.Text);
                komutguncelle.Parameters.AddWithValue("@a8", maskedTextBoxBasimYili.Text);
                komutguncelle.ExecuteNonQuery();
                
                bgl.baglanti().Close();
                MessageBox.Show("Kayıt Güncellendi");

            
        }
    }
}
