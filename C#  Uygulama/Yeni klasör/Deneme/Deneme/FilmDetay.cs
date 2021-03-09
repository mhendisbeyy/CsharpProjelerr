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
    public partial class FilmDetay : Form
    {
        public FilmDetay()
        {
            InitializeComponent();
        }
        SqlBaglantisi baglan = new SqlBaglantisi();
        public int idd;
        private void Form1_Load(object sender, EventArgs e)
        { 
            Lblid.Text = idd.ToString();
            SqlCommand komut = new SqlCommand("Select*From Film Where Filmid=@p1", baglan.baglanti());
            komut.Parameters.AddWithValue("@p1", Lblid.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblfilmadi.Text = dr[1].ToString();
                lblturu.Text = dr[2].ToString();
                lblozet.Text = dr[3].ToString();
                lblyonetmen.Text = dr[4].ToString();
                lbloyuncular.Text = dr[5].ToString();
                pictureBox1.ImageLocation = dr[6].ToString();

            }
            baglan.baglanti().Close();
            //
            dataGridView2.Rows.Clear();
            SqlCommand komutg = new SqlCommand("Select Seanssaat,Filmadi,Salonno from Seanslar inner join Film on Film.Filmid=Seanslar.Filmid inner join Salon on Salon.Salonid=Seanslar.Salonid Where Filmadi=@f1 ", baglan.baglanti());
            komutg.Parameters.AddWithValue("@f1", lblfilmadi.Text);
            SqlDataReader drg = komutg.ExecuteReader();
            while (drg.Read())
            {
                dataGridView2.ColumnCount = 3;
                dataGridView2.Columns[0].Name = "Film Adı";
                dataGridView2.Columns[1].Name = "Seans Saati";
                dataGridView2.Columns[2].Name = "Salon No";

                dataGridView2.Rows.Add(drg[0].ToString(), drg[1].ToString(), drg[2].ToString());


            }
            baglan.baglanti().Close();
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            FilmSalon frfs = new FilmSalon();
            frfs.sno =  dataGridView2.Rows[secilen].Cells[2].Value.ToString();
            frfs.ssaat = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
            frfs.filmadi = dataGridView2.Rows[secilen].Cells[1].Value.ToString();
            frfs.Show();
            

        }
    }

    }

        
      

