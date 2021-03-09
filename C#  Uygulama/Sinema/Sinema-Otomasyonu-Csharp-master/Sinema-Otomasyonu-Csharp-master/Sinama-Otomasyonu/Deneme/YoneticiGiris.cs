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
    public partial class YoneticiGiris : Form
    {
        public string kullanici;
        public YoneticiGiris()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();

        private void Btngiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select Yoneticiad,Yoneticisifre from Yonetici where Yoneticiad=@p1 and Yoneticisifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtkullaniciad.Text);
            komut.Parameters.AddWithValue("@p2", txtsifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                YoneticiAnasayfa frm = new YoneticiAnasayfa();
                frm.kullanici = txtkullaniciad.Text;
                frm.Show();
                
            }
            else
            {
                MessageBox.Show("Hatalı Giriş", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            bgl.baglanti().Close();
        }

        private void YoneticiGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
