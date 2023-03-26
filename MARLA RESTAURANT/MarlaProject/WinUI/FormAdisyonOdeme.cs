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
    public partial class FormAdisyonOdeme : Form
    {
        public FormAdisyonOdeme()
        {
            InitializeComponent();
        }
        MarlaRestaurantEntities db = new MarlaRestaurantEntities();
        AdisyonRepository adR = new AdisyonRepository();
        OdemeYontemiRepository odemeyontR = new OdemeYontemiRepository();
        AdisyonOdemeYontemiDetay adodyonR = new AdisyonOdemeYontemiDetay();
        private void FormAdisyonOdeme_Load(object sender, EventArgs e)
        {

        }

        private void btnAdisyonGetir_Click(object sender, EventArgs e)
        {
            AdisyonGetir();
        }

        private void AdisyonGetir()
        {
            dataGridViewAdisyon.DataSource = db.Adisyon.Select(
               r => new
               {
                   r.AdisyonID,
                   r.Tarih
               }
               ).OrderByDescending(r => r.Tarih).Take(10).ToList();

            //dataGridViewAdisyon.DataSource = adR.GetAll();
        }

        private void btnAdisyonEkle_Click(object sender, EventArgs e)
        {
           
            adR.Insert(new Adisyon
            {
                Tarih = dateTimePicker1.Value
            });
            AdisyonGetir();
            TemizleAdisyon();            
        }

        private void TemizleAdisyon()
        {
            dateTimePicker1.Value = DateTime.Now;
        }

        Adisyon seciliAdisyon;
        private void dataGridViewAdisyon_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewAdisyon.SelectedRows.Count > 0)
            {
                seciliAdisyon = adR.GetByID(Convert.ToInt32(dataGridViewAdisyon.CurrentRow.Cells[0].Value));
                dateTimePicker1.Value = seciliAdisyon.Tarih; 
            }
        }

        private void btnAdisyonGuncelle_Click(object sender, EventArgs e)
        {
            seciliAdisyon.Tarih = dateTimePicker1.Value;
            adR.Update(seciliAdisyon);
            AdisyonGetir();
            TemizleAdisyon();
        }

        private void btnAdisyonSil_Click(object sender, EventArgs e)
        {
            adR.Delete(Convert.ToInt32(dataGridViewAdisyon.SelectedCells[0].Value));
            AdisyonGetir();
        }

        private void btnOdemeYontGetir_Click(object sender, EventArgs e)
        {
            OdemeYontemiGetir();
        }

        private void OdemeYontemiGetir()
        {
            dataGridViewOdeme.DataSource = db.OdemeYontemi.Select(
              o => new
              {
                  o.OdemeYontemiID,
                  o.OdemeYontemiAdi                 
              }
              ).OrderByDescending(o => o.OdemeYontemiAdi).Take(10).ToList();

            //dataGridViewOdeme.DataSource = odemeyontR.GetAll();
        }

        private void btnOdemeYontEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtOdemeYontemiAdi.Text))
            {
                MessageBox.Show("Lütfen boş geçmeyiniz !");
                return;
            }
            odemeyontR.Insert(new OdemeYontemi
            {
                OdemeYontemiAdi = txtOdemeYontemiAdi.Text,
                

            });
            OdemeYontemiGetir();
            TemizleOdemeYontemi();
        }

        private void TemizleOdemeYontemi()
        {
            txtOdemeYontemiAdi.Text = string.Empty;
        }

        OdemeYontemi seciliOdemeYontemi;
        private void dataGridViewOdeme_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewOdeme.SelectedRows.Count > 0)
            {
                seciliOdemeYontemi = odemeyontR.GetByID(Convert.ToInt32(dataGridViewOdeme.SelectedRows[0].Cells[0].Value));
                txtOdemeYontemiAdi.Text = seciliOdemeYontemi.OdemeYontemiAdi;        
            }
        }

        private void btnOdemeYontGuncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtOdemeYontemiAdi.Text))
            {
                MessageBox.Show("Lütfen Boş Geçmeyinin..!");
            }
            else
            {
                seciliOdemeYontemi.OdemeYontemiAdi = txtOdemeYontemiAdi.Text;
               

                odemeyontR.Update(seciliOdemeYontemi);
                OdemeYontemiGetir();
                TemizleOdemeYontemi();
            }
        }

        private void btnOdemeYontSil_Click(object sender, EventArgs e)
        {
            odemeyontR.Delete(Convert.ToInt32(dataGridViewOdeme.SelectedCells[0].Value));
            OdemeYontemiGetir();
        }

        private void BtnGeri_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnOdeGeri_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
