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
    
    public partial class FilmDüzenle : Form
    {
        public FilmDüzenle()
        {
            InitializeComponent();
        }
        public int id;
        SqlBaglantisi baglan = new SqlBaglantisi();
        private void FilmDüzenle_Load(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = txtresim.Text;
            SqlCommand komut = new SqlCommand("select*from Film where Filmid=@p1", baglan.baglanti());
            komut.Parameters.AddWithValue("@p1", id);
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                txtfilmid.Text = dr[0].ToString();
                txtfilmadi.Text = dr[1].ToString();
                txtfilmturu.Text = dr[2].ToString();
                rctfilmicerik.Text = dr[3].ToString();
                txtyonetmen.Text = dr[4].ToString();
                rctoyuncular.Text = dr[5].ToString();
                txtresim.Text = dr[6].ToString();
                if (Convert.ToInt16(dr[7])==1)
                {
                    txtvizyon.Text = "Var";
                }
                else
                {
                    txtvizyon.Text = "Yok";
                }
            }
            baglan.baglanti().Close();

            pictureBox1.ImageLocation = txtresim.Text;
        }

        private void txtguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut1 = new SqlCommand("update Film Set Filmadi=@f1,Filmturu=@f2,Filmicerik=@f3,Filmyonetmen=@f4,Filmoyuncular=@f5,Filmafis=@f6,Filmvizyon=@f7 where Filmid=@f8", baglan.baglanti());
            komut1.Parameters.AddWithValue("@f1",txtfilmadi.Text);
            komut1.Parameters.AddWithValue("@f2",txtfilmturu.Text);
            komut1.Parameters.AddWithValue("@f3",rctfilmicerik.Text);
            komut1.Parameters.AddWithValue("@f4",txtyonetmen.Text);
            komut1.Parameters.AddWithValue("@f5",rctoyuncular.Text);
            komut1.Parameters.AddWithValue("@f6",txtresim.Text);
            if (txtvizyon.Text=="Var")
            {
                komut1.Parameters.AddWithValue("@f7", 1);
            }
            else
            {
                komut1.Parameters.AddWithValue("@f7", 0);
            }
            komut1.Parameters.AddWithValue("@f8",id);
            komut1.ExecuteNonQuery();

            baglan.baglanti().Close();
            MessageBox.Show("Güncelleme İşlemi Başarı ile Tamamlandı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        private void btnresimsec_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
            txtresim.Text = openFileDialog1.FileName;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komutsil = new SqlCommand("delete from Film Where Filmid=@f1", baglan.baglanti());
                komutsil.Parameters.AddWithValue("@f1", txtfilmid.Text);
                komutsil.ExecuteNonQuery();
                baglan.baglanti().Close();
                MessageBox.Show("Silme İşlemi Başarı ile Tamamlandı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.None);
                YoneticiAnasayfa frm = new YoneticiAnasayfa();
                frm.Show(); this.Hide();
            }
            catch (Exception)
            {

                MessageBox.Show("Bu Filme Ait Seans Bilgisi Var Önce Seansı Siliniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            


        }
    }
}
