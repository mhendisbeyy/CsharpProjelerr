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
    public partial class SeansEkle : Form
    {
        public SeansEkle()
        {
            InitializeComponent();
        }
        SqlBaglantisi baglan = new SqlBaglantisi();
        private void button1_Click(object sender, EventArgs e)
        {
            
            SqlCommand komut = new SqlCommand("insert into Seanslar(Seansbaslangictarihi,Seansbitistarihi,Seanssaat,Filmid,Salonid) values(@p1,@p2,@p3,@p4,@p5)", baglan.baglanti());
            komut.Parameters.AddWithValue("@p1", dtpbaslangic.Value);
            komut.Parameters.AddWithValue("@p2", dtpbitis.Value);
            komut.Parameters.AddWithValue("@p3", mskdsaat.Text);
            komut.Parameters.AddWithValue("@p4", label7.Text);
            komut.Parameters.AddWithValue("@p5", label8.Text);

            komut.ExecuteNonQuery();
            baglan.baglanti().Close();
            MessageBox.Show("Kayıt Başarı İle Tamamlandı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void SeansEkle_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'deneme1DataSet3.Salon' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.salonTableAdapter.Fill(this.deneme1DataSet3.Salon);
            // TODO: Bu kod satırı 'deneme1DataSet2.Film' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.filmTableAdapter.Fill(this.deneme1DataSet2.Film);

            SqlCommand komutge = new SqlCommand("Select Salonid from Salon Where Salonno=@s1", baglan.baglanti());
            komutge.Parameters.AddWithValue(@"s1", cmbsalonadi.Text);
            SqlDataReader drge = komutge.ExecuteReader();
            while (drge.Read())
            {
                label8.Text = drge[0].ToString();
            }
            baglan.baglanti().Close();

            SqlCommand komutg = new SqlCommand("Select Filmid,Filmadi from Film ", baglan.baglanti());
            SqlDataReader drg = komutg.ExecuteReader();
            while(drg.Read())
            {
                cmbfilmadi.Text = drg[1].ToString();
            }
            baglan.baglanti().Close();

            





        }

        private void cmbfilmadi_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand komutg = new SqlCommand("Select Filmid from Film Where Filmadi=@f1", baglan.baglanti());
            komutg.Parameters.AddWithValue(@"f1", cmbfilmadi.Text);
            SqlDataReader drg = komutg.ExecuteReader();
            while(drg.Read())
            {
                label7.Text = drg[0].ToString();
            }
            baglan.baglanti().Close();
            

        }

        private void cmbsalonadi_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand komutg = new SqlCommand("Select Salonid from Salon Where Salonno=@s1", baglan.baglanti());
            komutg.Parameters.AddWithValue(@"s1", cmbsalonadi.Text);
            SqlDataReader drg = komutg.ExecuteReader();
            while (drg.Read())
            {
                label8.Text = drg[0].ToString();
            }
            baglan.baglanti().Close();

        }
    }
}
