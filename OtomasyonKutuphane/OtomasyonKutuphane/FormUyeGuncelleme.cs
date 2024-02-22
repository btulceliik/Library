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
    public partial class FormUyeGuncelleme : Form
    {
        public FormUyeGuncelleme()
        {
            InitializeComponent();
        }
        public string id,ad,soyad,yas,dogumtarihi,sifre,tel,mail,adres;

        SqlBaglantisi bgl = new SqlBaglantisi();

        private void FormUyeGuncelleme_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            string id,ad,soyad,yas,dogumtarihi,sifre,tel,mail,adres;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            soyad = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            sifre = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            tel = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            yas = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            mail = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            dogumtarihi = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            adres = dataGridView1.Rows[secilen].Cells[8].Value.ToString();

            textBoxUyeID.Text = id;
            textBoxUyeAd.Text = ad;
            textBoxUyeSoyad.Text = soyad;
            comboBoxUyeYas.Text = yas;
            maskedTextBoxDogumTarihi.Text = dogumtarihi;
            textBoxUyeSifre.Text = sifre;
            maskedTextBoxUyeTelefon.Text = tel;
            textBoxUyeMail.Text = mail;
            textBoxUyeİl.Text = adres;

            
        }

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komutguncelle = new SqlCommand("update UYE set uyeAdi=@a2,uyeSoyadi=@a3,uyeSifre=@a4,uyeTel=@a5,uyeYas=@a6,uyeEposta=@a7,uyeDogumTarihi=@a8,uyeAdresID=@a9 where uyeId=@a1", bgl.baglanti());
                komutguncelle.Parameters.AddWithValue("@a1", textBoxUyeID.Text);
                komutguncelle.Parameters.AddWithValue("@a2", textBoxUyeAd.Text);
                komutguncelle.Parameters.AddWithValue("@a3", textBoxUyeSoyad.Text);
                komutguncelle.Parameters.AddWithValue("@a4", textBoxUyeSifre.Text);
                komutguncelle.Parameters.AddWithValue("@a5", maskedTextBoxUyeTelefon.Text);
                komutguncelle.Parameters.AddWithValue("@a6", comboBoxUyeYas.Text);
                komutguncelle.Parameters.AddWithValue("@a7", textBoxUyeMail.Text);
                komutguncelle.Parameters.AddWithValue("@a8", maskedTextBoxDogumTarihi.Text);
                komutguncelle.Parameters.AddWithValue("@a9", textBoxUyeİl.Text);
                komutguncelle.ExecuteNonQuery();

                komutguncelle.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Kayıt Güncellendi");
                


            }
            catch (Exception)
            {
                MessageBox.Show("HATA! Lütfen Tekrar Deneyiniz");
            }
        }

        

        private void buttonSil_Click(object sender, EventArgs e)
        {
            SqlCommand komutsil = new SqlCommand("delete from UYE where uyeId=@k1", bgl.baglanti());
            komutsil.Parameters.AddWithValue("@k1", textBoxUyeID.Text);
            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Silindi");
            this.uYETableAdapter.Fill(this.kUTUPHANEDataSet5.UYE);

        }

        

        private void FormUyeGuncelleme_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'kUTUPHANEDataSet5.UYE' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.uYETableAdapter.Fill(this.kUTUPHANEDataSet5.UYE);


            textBoxUyeID.Text = id;
            textBoxUyeAd.Text = ad;
            textBoxUyeSoyad.Text = soyad;
            comboBoxUyeYas.Text = yas;
            maskedTextBoxDogumTarihi.Text = dogumtarihi;
            textBoxUyeSifre.Text = sifre;
            maskedTextBoxUyeTelefon.Text = tel;
            textBoxUyeMail.Text = mail;
            textBoxUyeİl.Text = adres;


        }

        
    }
}
