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
    public partial class Bilet : Form
    {
        public Bilet()
        {
            InitializeComponent();
        }

        SqlBaglantisi baglan = new SqlBaglantisi();
        public string koltuk,seanssaat,salonadi,Film;
        private void btnbiletal_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komutg = new SqlCommand("Select Biletad,Biletkoltukno,Biletfilmadi,Biletseanstarihi,Biletseanssaati,Biletsalonadi From Bilet Where Biletseanssaati=@p1 and BiletSeanstarihi=@p2 and Biletkoltukno=@p3 and Biletsalonadi=@p4", baglan.baglanti());
                komutg.Parameters.AddWithValue("@p1", txtseanssaat.Text);
                komutg.Parameters.AddWithValue("@p2", mtseanstarihi.Text);
                komutg.Parameters.AddWithValue("@p3", txtkoltukno.Text);
                komutg.Parameters.AddWithValue("@p4", txtsalonadi.Text);

                SqlDataReader drg = komutg.ExecuteReader();
                if (drg.Read() == false)
                {
                    SqlCommand komut = new SqlCommand("insert into Bilet(Biletad,Biletkoltukno,Biletfilmadi,Biletseanstarihi,Biletseanssaati,Biletsalonadi) values(@b1,@b2,@b3,@b4,@b5,@b6)", baglan.baglanti());
                    komut.Parameters.AddWithValue("@b1", txtad.Text);
                    komut.Parameters.AddWithValue("@b2", txtkoltukno.Text);
                    komut.Parameters.AddWithValue("@b3", txtfilmadi.Text);
                    komut.Parameters.AddWithValue("@b4", mtseanstarihi.Text);
                    komut.Parameters.AddWithValue("@b5", txtseanssaat.Text);
                    komut.Parameters.AddWithValue("@b6", txtsalonadi.Text);
                    komut.ExecuteNonQuery();
                    baglan.baglanti().Close();
                    MessageBox.Show("Bilet Alma İşlemi Başarılı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                    MessageBox.Show("Koltuk Dolu.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                baglan.baglanti().Close();
                //
            }
            catch (Exception)
            {

                MessageBox.Show("Bilgileri Tekrardan Kontrolediniz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        

        }

        private void Bilet_Load(object sender, EventArgs e)
        {
            txtkoltukno.Text = koltuk;
            txtfilmadi.Text = Film.ToString();
            txtseanssaat.Text = seanssaat.ToString();
            txtsalonadi.Text = salonadi.ToString();

        }
    }
}
