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
    public partial class Salon : Form
    {
        public Salon()
        {
            InitializeComponent();
        }
        SqlBaglantisi baglan = new SqlBaglantisi();
        private void Salon_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'deneme1DataSet10.Salon' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.salonTableAdapter.Fill(this.deneme1DataSet10.Salon);
            // TODO: Bu kod satırı 'deneme1DataSet9.Salon' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
         
            SqlCommand komut = new SqlCommand("Select*From Film", baglan.baglanti());
           


            //Label[] Ldizi =new Label[10];
            //for (int i=1;i<Ldizi.Length;i++)
            //{
            //    Ldizi[i]= new Label();
            //    Ldizi[i].Text = "Koltuk" + i.ToString();
            //    this.Controls.Add(Ldizi[i]);
            //    Ldizi[i].Top = i * 30;
            //    Ldizi[i].Left = 100;
            //}

           
        }
      

        private void btnsalonekle_Click(object sender, EventArgs e)
        {
            SqlCommand komutg = new SqlCommand("insert into Salon(Salonno,Salonkoltuksayisi) values(@s1,@s2)", baglan.baglanti());
            komutg.Parameters.AddWithValue("@s1", txtsalon.Text);
            komutg.Parameters.AddWithValue("@s2", txtkoltuksayisi.Text);
            komutg.ExecuteNonQuery();
            baglan.baglanti().Close();
            MessageBox.Show("Kayıt Başarı ile eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Salon frms = new Salon();
            frms.Show();
            this.Hide();

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtsalon.Text= dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtkoltuksayisi.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            

        }

        private void btnduzenle_Click(object sender, EventArgs e)
        {
            SqlCommand komutu = new SqlCommand("update Salon Set Salonno=@k1,Salonkoltuksayisi=@k2 where Salonid=@k3", baglan.baglanti());
            komutu.Parameters.AddWithValue("@k1", txtsalon.Text);
            komutu.Parameters.AddWithValue("@k2", txtkoltuksayisi.Text);
            komutu.Parameters.AddWithValue("@k3", txtid.Text);
            komutu.ExecuteNonQuery();
            baglan.baglanti().Close();
            MessageBox.Show("Güncelleme İşlemi Başarı ile Tamamlandı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.None);
            Salon frs = new Salon();
            frs.Show();
            this.Hide();
        }
    }
}
