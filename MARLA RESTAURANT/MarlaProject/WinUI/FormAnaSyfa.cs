using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinUI
{
    public partial class FormAnaSyfa : Form
    {
        public FormAnaSyfa()
        {
            InitializeComponent();
        }

        private void FormAnaSyfa_Load(object sender, EventArgs e)
        {

        }

        private void BtnRest_Click(object sender, EventArgs e)
        {
            FormRestaurant frmRest = new FormRestaurant();
            frmRest.ShowDialog();
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            FormMenu frmMenu = new FormMenu();
            frmMenu.ShowDialog();
        }

        private void BtnUrunKat_Click(object sender, EventArgs e)
        {
            FormUrunKategori frmUrunKat = new FormUrunKategori();
            frmUrunKat.ShowDialog();
        }

        private void BtnAdisOdeme_Click(object sender, EventArgs e)
        {
            FormAdisyonOdeme frmAdisOdeme = new FormAdisyonOdeme();
            frmAdisOdeme.ShowDialog();
        }

        private void BtnMustSip_Click(object sender, EventArgs e)
        {
            FormMusteriSiparis frmMustSip = new FormMusteriSiparis();
            frmMustSip.ShowDialog();
        }

        private void BtnCalisan_Click(object sender, EventArgs e)
        {
            FormCalisan frmCalisan = new FormCalisan();
            frmCalisan.ShowDialog();
        }

        private void BtnDepoMalz_Click(object sender, EventArgs e)
        {
            FormDepoMalzeme frmDepoMalz = new FormDepoMalzeme();
            frmDepoMalz.ShowDialog();
        }

        private void BtnDetay_Click(object sender, EventArgs e)
        {
            FormDetaylar frmDetay = new FormDetaylar();
            frmDetay.ShowDialog();
        }

        private void BtnCariHes_Click(object sender, EventArgs e)
        {
            FormTedarikciCarileri frmCariHes = new FormTedarikciCarileri();
            frmCariHes.ShowDialog();
        }
    }
}
