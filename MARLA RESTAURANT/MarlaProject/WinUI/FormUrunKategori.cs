using BLL.Repositories;
using DAL;
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
    public partial class FormUrunKategori : Form
    {
        public FormUrunKategori()
        {
            InitializeComponent();
        }

        MarlaRestaurantEntities db = new MarlaRestaurantEntities();
        KategoriRepository katR = new KategoriRepository();
        UrunRepository urunR = new UrunRepository();

        private void FormUrunKategori_Load(object sender, EventArgs e)
        {
         
        }

        private void btnEkleKat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtKagetoriAdi.Text) || string.IsNullOrEmpty(txtMenuId.Text))
            {
                MessageBox.Show("Kategori Adini boş geçmeyiniz");
                return;
            }
            katR.Insert(new MenuKategori
            {
                MenuKategoriAdi = txtKagetoriAdi.Text,
                MenuID = Convert.ToInt32(txtMenuId.Text)
            });
            KategoriGetir();
            Temizle2();
        }

        private void Temizle2()
        {
            foreach (var item in groupBox1.Controls)
            {

                if (item is TextBox)
                {
                    TextBox txt = (TextBox)item;
                    txt.Clear();
                }

                if (item is ComboBox)
                {
                    ComboBox cb = (ComboBox)item;
                    cb.Text = null;
                }
            }
        }

        private void Temizle()
        {
            
        }

        private void btnKategoriler_Click(object sender, EventArgs e)
        {
            KategoriGetir();
        }

        private void KategoriGetir()
        {
            dataGridViewKategori.DataSource = katR.GetAll();
            dataGridViewKategori.Columns["Menu"].Visible = false;
            dataGridViewKategori.Columns["Urun"].Visible = false;           

            //dataGridViewKategori.DataSource = db.MenuKategori.Select(
            //    k => new
            //    {
            //       k.MenuKategoriID,
            //       k.MenuKategoriAdi,
            //       k.Menu.MenuID,
            //       k.Menu.MenuAdi
            //    }
            //    ).OrderByDescending(k => k.MenuKategoriAdi).Take(10).ToList();
        }

        private void btnGuncelleKat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtKagetoriAdi.Text) || string.IsNullOrEmpty(txtMenuId.Text))
            {
                MessageBox.Show("Lütfen boş geçmeyin !");
            }
            else
            {
                seciliKategori.MenuKategoriAdi = txtKagetoriAdi.Text;
                seciliKategori.MenuID = Convert.ToInt32(txtMenuId.Text);

                katR.Update(seciliKategori);
                KategoriGetir();
                Temizle2();
            }
        }

        MenuKategori seciliKategori;
        private void dataGridViewKategori_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewKategori.SelectedRows.Count > 0)
            {
                seciliKategori = katR.GetByID(Convert.ToInt32(dataGridViewKategori.SelectedRows[0].Cells[0].Value));
                txtKagetoriAdi.Text = seciliKategori.MenuKategoriAdi;
                txtMenuId.Text = Convert.ToString(seciliKategori.MenuID);
            }
        }

        private void btnSilKat_Click(object sender, EventArgs e)
        {
            katR.Delete(Convert.ToInt32(dataGridViewKategori.SelectedCells[0].Value));
            KategoriGetir();
        }

        private void btnUrunler_Click(object sender, EventArgs e)
        {
            UrunGetir();
        }

        private void UrunGetir()
        {
            dataGridViewUrun.DataSource = urunR.GetAll();
            dataGridViewUrun.Columns["MenuKategori"].Visible = false;
            dataGridViewUrun.Columns["UrunSiparisDetay"].Visible = false;
            dataGridViewUrun.Columns["UrunMalzemeDetay"].Visible = false;


            //dataGridViewUrun.DataSource = db.Urun.Select(
            //   u => new
            //   {
            //      u.UrunID,
            //      u.MenuKategori.MenuKategoriID,
            //      u.MenuKategori.MenuKategoriAdi,
            //      u.UrunAdi,
            //      u.UrunAciklamasi,
            //      u.Fiyat,
            //      u.Durum, 
            //   }
            //   ).OrderByDescending(u => u.UrunAdi).Take(10).ToList();
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtKategoriId.Text) || 
                string.IsNullOrEmpty(txtUrunAdi.Text) || 
                string.IsNullOrEmpty(txtUrunAciklamasi.Text) || 
                string.IsNullOrEmpty(txtFiyat.Text) ||
                string.IsNullOrEmpty(chxDurum.Checked.ToString()))
            {
                MessageBox.Show("sizin için de uygunsa boş geçmeyiniz lütfen ");
                return;
            }
            urunR.Insert(new Urun
            {
                KategoriID = Convert.ToInt32(txtKategoriId.Text),
                UrunAdi = txtUrunAdi.Text,
                UrunAciklamasi = txtUrunAciklamasi.Text,
                Fiyat = Convert.ToDecimal(txtFiyat.Text),
                Durum = chxDurum.Checked
            });

            UrunGetir();
            Temizle3();
        }

        private void Temizle3()
        {
            foreach (var item in groupBox3.Controls)
            {
                if (item is TextBox)
                {
                    TextBox txt = (TextBox)item;
                    txt.Clear();
                }
                if (item is CheckBox)
                {
                    CheckBox chk = (CheckBox)item;
                    chk.Checked = false;
                }
            }
        }
  
        Urun seciliUrun;
        private void dataGridViewUrun_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewUrun.SelectedRows.Count > 0)
            {
                seciliUrun = urunR.GetByID(Convert.ToInt32(dataGridViewUrun.SelectedRows[0].Cells[0].Value));
                txtKategoriId.Text = Convert.ToString(seciliUrun.KategoriID);
                txtUrunAdi.Text = seciliUrun.UrunAdi;
                txtUrunAciklamasi.Text = seciliUrun.UrunAciklamasi;
                txtFiyat.Text = Convert.ToString(seciliUrun.Fiyat);
                chxDurum.Checked = Convert.ToBoolean(seciliUrun.Durum);
            }
        }
        private void btnUrunGuncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtKategoriId.Text) || 
                string.IsNullOrEmpty(txtUrunAdi.Text) || 
                string.IsNullOrEmpty(txtUrunAciklamasi.Text) || 
                string.IsNullOrEmpty(txtFiyat.Text) ||
                string.IsNullOrEmpty(chxDurum.Checked.ToString()))
            {
                MessageBox.Show("Lütfen boş geçmeyin !");
            }
            else
            {
                seciliUrun.KategoriID = Convert.ToInt32(txtKategoriId.Text);
                seciliUrun.UrunAdi = txtUrunAdi.Text;
                seciliUrun.UrunAciklamasi = txtUrunAciklamasi.Text;
                seciliUrun.Fiyat = Convert.ToDecimal(txtFiyat.Text);
                seciliUrun.Durum = chxDurum.Checked;
                urunR.Update(seciliUrun);
                UrunGetir();
                Temizle3();
            }
        }

        private void btnUrunSil_Click(object sender, EventArgs e)
        {

            urunR.Delete(Convert.ToInt32(dataGridViewUrun.SelectedCells[0].Value));
            UrunGetir();
        }

        private void BtnGeri_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnUrunGeri_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtKategoriArama_TextChanged(object sender, EventArgs e)
        {
            string kategoriArama = txtKategoriArama.Text.ToLower();
            if (kategoriArama != "")
            {
                dataGridViewKategori.DataSource = katR.GetAll().Where(k => k.MenuKategoriAdi.ToLower().Contains(kategoriArama)).ToList();
                dataGridViewKategori.Columns["Urun"].Visible = false;
                dataGridViewKategori.Columns["Menu"].Visible = false;
            }
            else
            {
                dataGridViewKategori.DataSource = katR.GetAll().ToList();
            }
        }

        private void txtUrunArama_TextChanged(object sender, EventArgs e)
        {
            string urunArama = txtUrunArama.Text.ToLower();
            if (urunArama != "")
            {
                dataGridViewUrun.DataSource = urunR.GetAll().Where(u => u.UrunAdi.ToLower().Contains(urunArama)).ToList();
                dataGridViewUrun.Columns["MenuKategori"].Visible = false;
                dataGridViewUrun.Columns["UrunSiparisDetay"].Visible = false;
                dataGridViewUrun.Columns["UrunMalzemeDetay"].Visible = false;
            }
            else
            {
                dataGridViewUrun.DataSource = urunR.GetAll().ToList();
            }
        }
    }
}
