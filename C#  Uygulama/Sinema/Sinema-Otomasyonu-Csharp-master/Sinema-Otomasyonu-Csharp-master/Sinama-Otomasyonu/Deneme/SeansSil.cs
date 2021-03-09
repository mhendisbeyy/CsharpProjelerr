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
    public partial class SeansSil : Form
    {
        public SeansSil()
        {
            InitializeComponent();
        }
        SqlBaglantisi baglan = new SqlBaglantisi();
        private void cmbfilmadi_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand komutg = new SqlCommand("Select Filmid from Film Where Filmadi=@f1", baglan.baglanti());
            komutg.Parameters.AddWithValue(@"f1", txtfilmadi.Text);
            SqlDataReader drg = komutg.ExecuteReader();
            while (drg.Read())
            {
                label7.Text = drg[0].ToString();
            }
            baglan.baglanti().Close();
            //


        }

        private void cmbsalonadi_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand komutg = new SqlCommand("Select Salonid from Salon Where Salonno=@s1", baglan.baglanti());
            komutg.Parameters.AddWithValue(@"s1", txtsalonadi.Text);
            SqlDataReader drg = komutg.ExecuteReader();
            while (drg.Read())
            {
                label8.Text = drg[0].ToString();
            }
            baglan.baglanti().Close();
        }

        private void SeansSil_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'deneme1DataSet12.Salon' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.salonTableAdapter.Fill(this.deneme1DataSet12.Salon);
            // TODO: Bu kod satırı 'deneme1DataSet11.Film' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.filmTableAdapter.Fill(this.deneme1DataSet11.Film);
            SqlCommand komutge = new SqlCommand("Select Salonid from Salon Where Salonno=@s1", baglan.baglanti());
            komutge.Parameters.AddWithValue(@"s1", txtsalonadi.Text);
            SqlDataReader drge = komutge.ExecuteReader();
            while (drge.Read())
            {
                label8.Text = drge[0].ToString();
            }
            baglan.baglanti().Close();

            SqlCommand komutg = new SqlCommand("Select Filmid,Filmadi from Film ", baglan.baglanti());
            SqlDataReader drg = komutg.ExecuteReader();
            while (drg.Read())
            {
                txtfilmadi.Text = drg[1].ToString();
            }
            baglan.baglanti().Close();
            //
            dataGridView1.Rows.Clear();
            SqlCommand komutgt = new SqlCommand("Select Seanssaat,Filmadi,Salonno from Seanslar inner join Film on Film.Filmid=Seanslar.Filmid inner join Salon on Salon.Salonid=Seanslar.Salonid  ", baglan.baglanti());
            SqlDataReader drgt = komutgt.ExecuteReader();
            while (drgt.Read())
            {
                dataGridView1.ColumnCount = 3;
                dataGridView1.Columns[0].Name = "Film Adı";
                dataGridView1.Columns[1].Name = "Seans Saati";
                dataGridView1.Columns[2].Name = "Salon No";

                dataGridView1.Rows.Add(drgt[0].ToString(), drgt[1].ToString(), drgt[2].ToString());


            }
            baglan.baglanti().Close();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            SqlCommand komutsil = new SqlCommand("Delete from Seanslar Where Filmid =@f1 and Salonid=@f2 and Seanssaat=@f3", baglan.baglanti());
            komutsil.Parameters.AddWithValue("@f1", label7.Text);
            komutsil.Parameters.AddWithValue("@f2", label8.Text);
            komutsil.Parameters.AddWithValue("@f3", mskdsaat.Text);
            komutsil.ExecuteNonQuery();
            baglan.baglanti().Close();
            MessageBox.Show("Kayıt Başarı İle Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            SeansSil Frs = new SeansSil();
            Frs.Show();
            this.Hide();

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            mskdsaat.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtfilmadi.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtsalonadi.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
        }

        private void txtfilmadi_TextChanged(object sender, EventArgs e)
        {
            SqlCommand komutg = new SqlCommand("Select Filmid from Film Where Filmadi=@f1", baglan.baglanti());
            komutg.Parameters.AddWithValue(@"f1", txtfilmadi.Text);
            SqlDataReader drg = komutg.ExecuteReader();
            while (drg.Read())
            {
                label7.Text = drg[0].ToString();
            }
            baglan.baglanti().Close();
        }

        private void txtsalonadi_TextChanged(object sender, EventArgs e)
        {
            SqlCommand komutg = new SqlCommand("Select Salonid from Salon Where Salonno=@s1", baglan.baglanti());
            komutg.Parameters.AddWithValue(@"s1", txtsalonadi.Text);
            SqlDataReader drg = komutg.ExecuteReader();
            while (drg.Read())
            {
                label8.Text = drg[0].ToString();
            }
            baglan.baglanti().Close();
        }
    }
}
