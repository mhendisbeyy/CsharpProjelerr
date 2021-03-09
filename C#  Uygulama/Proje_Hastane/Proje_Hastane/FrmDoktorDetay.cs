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
    public partial class FrmDoktorDetay : Form
    {
        public FrmDoktorDetay()
        {
            InitializeComponent();
        }

        private void BtnDuzenle_Click(object sender, EventArgs e)
        {
            FrmBilgiDuzenle frbd = new FrmBilgiDuzenle();
            frbd.Show();
        }
    }
}
