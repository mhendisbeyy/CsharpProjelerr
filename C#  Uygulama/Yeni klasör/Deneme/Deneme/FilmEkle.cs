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
    public partial class FilmEkle : Form
    {
        public FilmEkle()
        {
            InitializeComponent();
        }
        SqlBaglantisi baglan = new SqlBaglantisi();
       

       

        private void FilmEkle_Load(object sender, EventArgs e)
        {

        }

        private void btnresimsec_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
            txtresim.Text = openFileDialog1.FileName;
        }

        private void btnfilmekle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Film(Filmadi,Filmturu,Filmicerik,Filmyonetmen,Filmoyuncular,Filmafis,Filmvizyon) Values(@p1,@p2,@p3,@p4,@p5,@p6,1)", baglan.baglanti());
            komut.Parameters.AddWithValue("@p1", txtfilmadi.Text);
            komut.Parameters.AddWithValue("@p2", txtfilmturu.Text);
            komut.Parameters.AddWithValue("@p3", rctfilmicerik.Text);
            komut.Parameters.AddWithValue("@p4", txtyonetmen.Text);
            komut.Parameters.AddWithValue("@p5", rctoyuncular.Text);
            komut.Parameters.AddWithValue("@p6", txtresim.Text);
            komut.ExecuteNonQuery();
            baglan.baglanti().Close();
            MessageBox.Show("Kayıt Başarı İle Tamamlandı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
