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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlBaglantisi baglan = new SqlBaglantisi();
        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'deneme1DataSet13.Film' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.filmTableAdapter.Fill(this.deneme1DataSet13.Film);

        }

        private void btnseansara_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            SqlCommand komut = new SqlCommand("Select Seanssaat,Filmadi,Salonno,Seansbaslangictarihi,Seansbitistarihi from Seanslar inner join Film on Film.Filmid=Seanslar.Filmid inner join Salon on Salon.Salonid=Seanslar.Salonid Where Filmadi=@f1 ", baglan.baglanti());
            komut.Parameters.AddWithValue("@f1", cmbfilmadi.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                dataGridView1.ColumnCount = 5;
                dataGridView1.Columns[0].Name = "Film Adı";
                dataGridView1.Columns[1].Name = "Seans Saati";
                dataGridView1.Columns[2].Name = "Salon No";
                dataGridView1.Columns[3].Name = "Başlangıç Tarihi";
                dataGridView1.Columns[4].Name = "Bitiş Tarihi";

                dataGridView1.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString());


            }
            baglan.baglanti().Close();
        }
    }
}
