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
using System.Collections;

namespace Deneme
{
    public partial class FilmSalon : Form
    {
        public FilmSalon()
        {
            InitializeComponent();
        }
        public string sno;
        public string ssaat;
        public string filmadi;
        public string starih;
        SqlBaglantisi baglan = new SqlBaglantisi();
        private void FilmSalon_Load(object sender, EventArgs e)
        {
            txtsalon.Text = sno.ToString();
            txtsaat.Text = ssaat.ToString();
            lblfilm.Text = filmadi.ToString();
            mttarih.Text = starih;

            gbKoltuk.Visible = false;
            //
            SqlCommand komut = new SqlCommand("Select Salonkoltuksayisi From Salon Where Salonno=@p1", baglan.baglanti());
            komut.Parameters.AddWithValue("@p1", txtsalon.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txtkoltuksayisi.Text = dr[0].ToString();
                label5.Text = dr[0].ToString();
            }
            baglan.baglanti().Close();

            //

            //

            //int btnsayi =Convert.ToInt32( txtkoltuksayisi.Text) ;
            //int baslaX = 1;
            //int baslaY = 50;
            //int boyutbol;

            //boyutbol = Convert.ToInt32(Math.Ceiling(Math.Sqrt(btnsayi)));

            //for (int i = 1; i <= btnsayi; i++)
            //{
            //    Button btn = new Button();
            //    btn.Name = i.ToString();
            //    btn.AutoSize = false;
            //    btn.Size = new Size(gbKoltuk.Width / boyutbol, gbKoltuk.Height / (boyutbol * 2));
            //    btn.Text = "Koltuk" + i.ToString();
            //    btn.Font = new Font(btn.Font.FontFamily.Name, 20);
            //    btn.Location = new Point(baslaX, baslaY);
            //    gbKoltuk.Controls.Add(btn);
            //    baslaX += btn.Width + 5;

            //    if (baslaX + gbKoltuk.Width / boyutbol > gbKoltuk.Width)
            //    {
            //        baslaX = 1;
            //        baslaY += gbKoltuk.Height / (boyutbol * 2) + 5;
            //    }
            //    btn.Click += new EventHandler(dinamikmetod);

            //}

        }
        protected void dinamikmetod(Object sender, EventArgs e)
        {
            Button dbtn = (sender as Button);
            Bilet frb = new Bilet();
            frb.koltuk = dbtn.Text;
            frb.salonadi = txtsalon.Text;
            frb.Film = lblfilm.Text;
            frb.seanssaat = txtsaat.Text;

            frb.Show();



        }
        int sayac = 0;
        private void Btngetir_Click(object sender, EventArgs e)
        {
            gbKoltuk.Visible = true;

            sayac++;
            try
            {
                if (sayac > 1)
                {
                    FilmSalon fls = new FilmSalon();
                    fls.ssaat = txtsaat.Text;
                    fls.sno = txtsalon.Text;
                    fls.label5.Text = txtkoltuksayisi.Text;
                    fls.filmadi = lblfilm.Text;
                    fls.starih = mttarih.Text;

                    fls.Show();
                    this.Hide();
                }

                ArrayList koltuklar = new ArrayList();
                int btnsayi = Convert.ToInt32(txtkoltuksayisi.Text);
                int baslaX = 60;
                int baslaY = 50;
                int boyutbol;

                boyutbol = Convert.ToInt32(Math.Ceiling(Math.Sqrt(btnsayi)));


                SqlCommand komuts = new SqlCommand("Select Biletkoltukno From Bilet Where Biletseanssaati=@b1 and BiletSeanstarihi=@b2 and Biletsalonadi=@b4", baglan.baglanti());
                komuts.Parameters.AddWithValue("@b1", txtsaat.Text);
                komuts.Parameters.AddWithValue("@b2", mttarih.Text);
                komuts.Parameters.AddWithValue("@b4", txtsalon.Text);
                SqlDataReader dro = komuts.ExecuteReader();

                while (dro.Read())

                {
                    koltuklar.Add(dro["Biletkoltukno"].ToString());



                }

                for (int i = 1; i <= btnsayi; i++)
                {


                    Button btn = new Button();

                    btn.Name = i.ToString();
                    btn.BackColor = Color.Red;
                   
                    btn.AutoSize = false;
                    btn.Size = new Size(150, 150);
                    btn.Text = "Koltuk" + i.ToString();
                    btn.Font = new Font(btn.Font.FontFamily.Name, 20);
                    btn.Location = new Point(baslaX, baslaY);
                    gbKoltuk.Controls.Add(btn);
                    baslaX += btn.Width + 5;

                    if (baslaX + gbKoltuk.Width / boyutbol > gbKoltuk.Width)
                    {
                        baslaX = 60;
                        baslaY += gbKoltuk.Height / (boyutbol) + 50;
                    }
                    btn.Click += new EventHandler(dinamikmetod);

                    if (koltuklar.Contains(btn.Text))
                    {
                        btn.BackColor = Color.Green;
                        btn.BackgroundImage = Image.FromFile(@"D:\C\Merve\Yeni klasör\Deneme\Deneme\Resim\images.jpg");
                    }
                    else
                    {
                        btn.BackColor = Color.Red;

                        btn.BackgroundImage = Image.FromFile(@"D:\C\Merve\Yeni klasör\Deneme\Deneme\Resim\Man-Icon.png");


                    }


                }
            }
            catch (Exception)
            {

                MessageBox.Show("Eksik veya Hatalı Bilgi var.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
