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
    public partial class FilmHakkinda : Form
    {
        public FilmHakkinda()
        {
            InitializeComponent();
        }
        SqlBaglantisi baglan = new SqlBaglantisi();
        public int idd;
        private void FilmDetay_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'deneme1DataSet4.Seanslar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.seanslarTableAdapter1.Fill(this.deneme1DataSet4.Seanslar);
            // TODO: Bu kod satırı 'deneme1DataSet1.Seanslar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.seanslarTableAdapter.Fill(this.deneme1DataSet1.Seanslar);
            Lblid.Text = idd.ToString();
            SqlCommand komut = new SqlCommand("Select*From Film Where Filmid=@p1", baglan.baglanti());
            komut.Parameters.AddWithValue("@p1", Lblid.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                lblfilmadi.Text = dr[1].ToString();
                lblturu.Text = dr[2].ToString();
                lblozet.Text = dr[3].ToString();
                lblyonetmen.Text = dr[4].ToString();
                lbloyuncular.Text = dr[5].ToString();
                pictureBox1.ImageLocation = dr[6].ToString();

            }
            baglan.baglanti().Close();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
