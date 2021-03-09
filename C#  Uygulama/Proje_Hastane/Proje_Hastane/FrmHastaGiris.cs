using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_Hastane
{
    public partial class FrmHastaGiris : Form
    {
        public FrmHastaGiris()
        {
            InitializeComponent();
        }

        private void BtnGiris_Click(object sender, EventArgs e)
        {
            FrmHastaDetay Frhd = new FrmHastaDetay();
            Frhd.Show();
        }

        private void lluye_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmHastaKayit frhk = new FrmHastaKayit();
            frhk.Show();
        }
    }
}
