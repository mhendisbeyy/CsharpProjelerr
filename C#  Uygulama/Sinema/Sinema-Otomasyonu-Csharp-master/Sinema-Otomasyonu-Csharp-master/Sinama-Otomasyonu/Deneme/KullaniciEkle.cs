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

namespace Deneme
{
    public partial class KullaniciEkle : Form
    {
        public KullaniciEkle()
        {
            InitializeComponent();
        }
        SqlBaglantisi baglan = new SqlBaglantisi();
        private void btnekle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Yonetici(Yoneticiad,Yoneticisifre) values(@p1,@p2)", baglan.baglanti());
            komut.Parameters.AddWithValue("@p1",txtkullanici.Text);
            komut.Parameters.AddWithValue("@p2", txtsifre.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Kayıt Başarı ile eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            baglan.baglanti().Close();
            KullaniciEkle frmk = new KullaniciEkle();
            frmk.Show();
            this.Hide();


        }

        private void KullaniciEkle_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'deneme1DataSet6.Yonetici' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.yoneticiTableAdapter.Fill(this.deneme1DataSet6.Yonetici);

        }
    }
}
