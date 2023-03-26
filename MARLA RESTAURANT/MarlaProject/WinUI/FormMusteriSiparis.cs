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
    public partial class FormMusteriSiparis : Form
    {
        public FormMusteriSiparis()
        {
            InitializeComponent();
        }
        MarlaRestaurantEntities db = new MarlaRestaurantEntities();
        MusteriRepository musR = new MusteriRepository();
        SiparisRepository sipR = new SiparisRepository();
        private void FormMusteriSiparis_Load(object sender, EventArgs e)
        {

        }

        private void btnMusteriGetir_Click(object sender, EventArgs e)
        {
            MusteriGetir();

        }

        private void MusteriGetir()
        {
            dataGridViewMusteri.DataSource = musR.GetAll();
            dataGridViewMusteri.Columns["Siparis"].Visible = false;
        }

        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMusteriAdi.Text) || string.IsNullOrEmpty(txtMusteriSoyadi.Text) || string.IsNullOrEmpty(txtMusteriAdres.Text) || string.IsNullOrEmpty(txtMusteriTel.Text))
            {
                MessageBox.Show("Lütfen boş geçmeyiniz !");
                return;
            }
            musR.Insert(new Musteri
            {
                Adi = txtMusteriAdi.Text,
                Soyadi =txtMusteriSoyadi.Text,
                Adres = txtMusteriAdres.Text,
                Telefon = txtMusteriTel.Text

            });
            MusteriGetir();
            Temizle();
        }

        private void Temizle()
        {
            txtMusteriAdi.Text = txtMusteriSoyadi.Text = txtMusteriAdres.Text = txtMusteriTel.Text = string.Empty;
        }

        Musteri seciliMusteri;
        private void dataGridViewMusteri_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewMusteri.SelectedRows.Count > 0)
            {
                seciliMusteri = musR.GetByID(Convert.ToInt32(dataGridViewMusteri.SelectedRows[0].Cells[0].Value));
                txtMusteriAdi.Text = seciliMusteri.Adi;
                txtMusteriSoyadi.Text = seciliMusteri.Soyadi;
                txtMusteriAdres.Text = seciliMusteri.Adres;
                txtMusteriTel.Text = seciliMusteri.Telefon;
            }
        }

        private void btnMusteriGuncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMusteriAdi.Text) || string.IsNullOrEmpty(txtMusteriSoyadi.Text) || string.IsNullOrEmpty(txtMusteriAdres.Text) || string.IsNullOrEmpty(txtMusteriTel.Text))
            {
                MessageBox.Show("Lütfen boş geçmeyin !");
            }
            else
            {
                seciliMusteri.Adi= txtMusteriAdi.Text;
                seciliMusteri.Soyadi = txtMusteriSoyadi.Text;
                seciliMusteri.Adres = txtMusteriAdres.Text;
                seciliMusteri.Telefon = txtMusteriTel.Text;

                musR.Update(seciliMusteri);
                MusteriGetir();
                Temizle();
            }
        }

        private void btnMusteriSil_Click(object sender, EventArgs e)
        {
            musR.Delete(Convert.ToInt32(dataGridViewMusteri.SelectedCells[0].Value));
            MusteriGetir();
        }

        private void btnSiparisGetir_Click(object sender, EventArgs e)
        {
            SiparisGetir();
        }

        private void SiparisGetir()
        {
            dataGridViewSiparis.DataSource = db.Siparis.Select(
                s => new
                {
                    s.SiparisID,
                    s.Musteri.Adi,
                    s.Musteri.Soyadi,
                    s.SiparisTarihi,
                    s.TeslimTarihi,
                    s.SiparisTuru,
                    s.MasaNumarası,
                    s.Calisan.CalisanAdi,
                    s.Calisan.CalisanSoyadi
                }
                ).OrderByDescending(s => s.SiparisID).Take(10).ToList();

            //dataGridViewSiparis.DataSource = sipR.GetAll();
            //dataGridViewSiparis.Columns["AdisyonSiparisDetay"].Visible = false;
            //dataGridViewSiparis.Columns["Calisan"].Visible = false;
            //dataGridViewSiparis.Columns["Musteri"].Visible = false;
            //dataGridViewSiparis.Columns["UrunSiparisDetay"].Visible = false;
        }

        private void btnSiparisEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(dtSiparis.Checked.ToString()) ||
                string.IsNullOrEmpty(dtTeslim.Checked.ToString()) ||
                string.IsNullOrEmpty(txtSiparisMasaNo.Text) ||
                string.IsNullOrEmpty(chSipTuru.Checked.ToString()) ||
                string.IsNullOrEmpty(txtSiparisMusteriId.Text) || 
                string.IsNullOrEmpty(txtSiparisCalisanId.Text))
            {
                MessageBox.Show("Lütfen boş geçmeyiniz !");
                return;
            }
            sipR.Insert(new Siparis
            {
                SiparisTarihi = dtSiparis.Value,
                TeslimTarihi = dtTeslim.Value,
                SiparisTuru = chSipTuru.Checked,
                MasaNumarası = Convert.ToInt32(txtSiparisMasaNo.Text),
                MusteriID = Convert.ToInt32(txtSiparisMusteriId.Text),
                CalisanId = Convert.ToInt32(txtSiparisCalisanId.Text)
            });
            SiparisGetir();
            TemizleSiparis(); 

        }

        private void TemizleSiparis()
        {
            foreach (var item in  groupBox2.Controls)
            {
                if (item is TextBox)
                {
                    TextBox txt = (TextBox)item;
                    txt.Clear();
                }
                else if (item is CheckBox)
                {
                    CheckBox chc = (CheckBox)item;
                    chc.Checked = false;
                }
            }
        }

        Siparis seciliSiparis;
        private void dataGridViewSiparis_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewSiparis.SelectedRows.Count > 0)
            {
                seciliSiparis = sipR.GetByID(Convert.ToInt32(dataGridViewSiparis.SelectedRows[0].Cells[0].Value));
                dtSiparis.Value = seciliSiparis.SiparisTarihi;
                dtTeslim.Value = seciliSiparis.TeslimTarihi;
                chSipTuru.Checked = Convert.ToBoolean(seciliSiparis.SiparisTuru);
                txtSiparisMasaNo.Text = Convert.ToString(seciliSiparis.MasaNumarası);
                txtSiparisMusteriId.Text = Convert.ToString(seciliSiparis.MusteriID);
                txtSiparisCalisanId.Text = Convert.ToString(seciliSiparis.CalisanId);
            }
        }
        private void btnSiparisGuncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(dtSiparis.Checked.ToString()) ||
                string.IsNullOrEmpty(dtTeslim.Checked.ToString()) ||
                string.IsNullOrEmpty(txtSiparisMasaNo.Text) ||
                string.IsNullOrEmpty(txtSiparisMasaNo.Text) || 
                string.IsNullOrEmpty(txtSiparisMusteriId.Text) || 
                string.IsNullOrEmpty(txtSiparisCalisanId.Text))
            {
                MessageBox.Show("Lütfen boş geçmeyin !");
            }
            else
            {
                seciliSiparis.SiparisTarihi = dtSiparis.Value;
                seciliSiparis.TeslimTarihi = dtTeslim.Value;
                seciliSiparis.SiparisTuru = chSipTuru.Checked;
                seciliSiparis.MasaNumarası =Convert.ToInt32(txtSiparisMasaNo.Text);
                seciliSiparis.MusteriID = Convert.ToInt32(txtSiparisMusteriId.Text);
                seciliSiparis.CalisanId = Convert.ToInt32(txtSiparisCalisanId.Text);

                sipR.Update(seciliSiparis);
                SiparisGetir();
                TemizleSiparis();
            }
        }

        //private void btnSiparisSil_Click(object sender, EventArgs e)
        //{
        //    sipR.Delete(Convert.ToInt32(dataGridViewSiparis.SelectedCells[0].Value));
        //    SiparisGetir();
        //}

        private void txtMusteriAdiAra_TextChanged(object sender, EventArgs e)
        {
            string musteriArama = txtMusteriAdiAra.Text.ToLower();
            if (musteriArama != "")
            {
                dataGridViewMusteri.DataSource = musR.GetAll().Where(s => s.Adi.ToLower().Contains(musteriArama)).ToList();
                dataGridViewMusteri.Columns["Siparis"].Visible = false;
            }
            else
            {
                dataGridViewMusteri.DataSource = musR.GetAll().ToList();
            }
        }

        private void BtnGeri_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSipGeri_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //private void txtSiparisArama_TextChanged(object sender, EventArgs e)
        //{
        //    string siparisArama = txtSiparisArama.Text.ToLower();
        //    if (siparisArama != "")
        //    {
        //        dataGridViewSiparis.DataSource = sipR.GetAll().Where(m => m.Musteri.Adi.ToLower().Contains(siparisArama)).ToList();
        //        //dataGridViewSiparis.Columns["Musteri"].Visible = false;
        //        //dataGridViewSiparis.Columns["UrunSiparisDetay"].Visible = false;
        //        //dataGridViewSiparis.Columns["Calisan"].Visible = false;
        //    }
        //    else
        //    {
        //        dataGridViewMusteri.DataSource = sipR.GetAll().ToList();
        //    }
        //}
    }
}
