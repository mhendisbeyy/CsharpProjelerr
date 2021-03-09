using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deneme
{
    public partial class YoneticiAnasayfa : Form
    {
        public YoneticiAnasayfa()
        {
            InitializeComponent();
        }
        public string kullanici;
        
        private void button1_Click(object sender, EventArgs e)
        {
            FilmEkle fr = new FilmEkle();
            fr.Show();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SeansEkle fr = new SeansEkle();
            fr.Show();
           
        }
       
        private void YoneticiAnasayfa_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'deneme1DataSet7.Film' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.filmTableAdapter1.Fill(this.deneme1DataSet7.Film);
            // TODO: Bu kod satırı 'deneme1DataSet.Film' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.filmTableAdapter.Fill(this.deneme1DataSet.Film);
            Lblkullanici.Text = kullanici;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
            if (e.ColumnIndex==4)
            {

                int secilen = dataGridView1.SelectedCells[0].RowIndex;
                FilmDetay frd = new FilmDetay();
                frd.idd= Convert.ToInt32(dataGridView1.Rows[secilen].Cells[0].Value.ToString());
                frd.Show();
            }
            if (e.ColumnIndex==5)
            {
                int secilen = dataGridView1.SelectedCells[0].RowIndex;
                FilmDüzenle fr = new FilmDüzenle();
                fr.id = Convert.ToInt32(dataGridView1.Rows[secilen].Cells[0].Value.ToString());
                fr.Show();


            }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Salon frs = new Salon();
            frs.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            KullaniciEkle frmke = new KullaniciEkle();
            frmke.Show();

        }

        private void btnSeanssil_Click(object sender, EventArgs e)
        {
            SeansSil frsil = new SeansSil();
            frsil.Show();
        }
    }
}
