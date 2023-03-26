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
    public partial class FormDetaylar : Form
    {
        public FormDetaylar()
        {
            InitializeComponent();
        }
        MarlaRestaurantEntities db = new MarlaRestaurantEntities();
        UrunMalzemeDetayRepository umdR = new UrunMalzemeDetayRepository();
        DepoMalzemeDetayRepository dmdR = new DepoMalzemeDetayRepository();
        RestaurantMalzemeDetayRepository resmdR = new RestaurantMalzemeDetayRepository();
        UrunSiparisDetayRepository urunsiparisdR = new UrunSiparisDetayRepository();
        AdisyonSiparisDetayRepository adisyonSDR = new AdisyonSiparisDetayRepository();
        AdisyonOdemeYontemiDetay adisyonOdemeR = new AdisyonOdemeYontemiDetay();
        private void FormDetaylar_Load(object sender, EventArgs e)
        {

        }
        private void btnUMGetir_Click(object sender, EventArgs e)
        {
            UrunMalzemeDetayGetir();
        }

        private void UrunMalzemeDetayGetir()
        {
            dataGridViewUrunMalzemeDetay.DataSource = db.UrunMalzemeDetay.Select(
               ud => new
               {
                   ud.UrunMalzemeID,
                   ud.Urun.UrunAdi,
                   ud.Malzeme.MalzemeAdi,
                   ud.MalzemeStok,
               }
               ).OrderByDescending(ud => ud.MalzemeAdi).Take(10).ToList();
        }

        private void DepoMalDetGetir_Click(object sender, EventArgs e)
        {
            DepoMalzemeDetayGetir();
        }

        private void DepoMalzemeDetayGetir()
        {
            dataGridViewDepoMalzemeDetay.DataSource = db.DepoMalzemeDetay.Select(
                dm => new
                {
                    dm.DepoMalzemeID,
                    dm.Depo.DepoAdi,
                    dm.Malzeme.MalzemeAdi,
                    dm.DepoStok,
                }
                ).OrderByDescending(dm => dm.MalzemeAdi).Take(10).ToList();
        }


        // RESTAURANT MALZEME DETAY
        private void btnRestaurantDetayGetir_Click(object sender, EventArgs e)
        {
            RestaurantMalzemeDetayGetir();
        }

        private void RestaurantMalzemeDetayGetir()
        {
            dataGridViewRestMalzDet.DataSource = db.RestaurantMalzemeDetay.Select(
               md => new
                {
                   md.RestaurantMalzemeDetayID,
                   md.Malzeme.MalzemeAdi,
                   md.Restaurant.RestaurantAdi,
                   md.RestaurantStok
               }
                ).OrderByDescending(md => md.MalzemeAdi).Take(10).ToList();
        }

        //Restaurant Malzme Detay Getir
        private void BtnRestMalzDetGetir_Click(object sender, EventArgs e)
        {
            RestaurantMalzDetGetir();
        }

        private void RestaurantMalzDetGetir()
        {
            dataGridViewRestMalzDet.DataSource = db.Malzeme.Select(m => new
            {
                m.MalzemeID,
                m.MalzemeAdi
            }).ToList();
        }

        private void btnResListele_Click(object sender, EventArgs e)
        {
            dataGridViewRestMalzDet.DataSource = db.Restaurant.Select(r => new
            {
                r.RestaurantID,
                r.RestaurantAdi,
                r.Adres
            }).ToList();
        }


        // URUN SİPARİS DETAY

        private void BtnUrunSipDetGetir_Click(object sender, EventArgs e)
        {
            UrunSiparisDetayGetir();
        }

        private void UrunSiparisDetayGetir()
        {
            dataGridViewUrunSiparisDetay.DataSource = db.UrunSiparisDetay.Select(sd => new
            {
                  sd.UrunSiparisDetayID,
                  sd.Urun.UrunID,
                  sd.Urun.UrunAdi,
                  sd.SiparisID,
                  sd.SiparisMiktari,
                  sd.Fiyat,
               }
               ).ToList();
        }

        //ADİSYON SİPARİS DETAY
        private void btnASDGetir_Click(object sender, EventArgs e)
        {
            AdisyonSiparisDetayGetir();
        }

        private void AdisyonSiparisDetayGetir()
        {
            dataGridViewAdisyonSiparisDetay.DataSource = db.AdisyonSiparisDetay.Select(
               p => new
               {
                  p.AdisyonSiparisDetayID,
                  p.SiparisID,
                  p.Siparis.Musteri.Adi,
                  p.Siparis.Musteri.Soyadi,
                  p.AdisyonID,
                  p.Adisyon.Tarih
               }
               ).ToList();
        }

        private void btnAdisyonOdemeDetayGetir_Click(object sender, EventArgs e)
        {
            AdisyonOdemeDetayGetir();
        }

        private void AdisyonOdemeDetayGetir()
        {
            dataGridViewAdisyonOdemeDetay.DataSource = db.AdisyonOdemeDetay.Select(
               od => new
               {
                   od.AdisyonOdemeDetayID,
                   od.AdisyonID,
                   od.OdemeYontemiID,
                   od.OdemeYontemiAdi,
               }
               ).ToList();
        }

        private void BtnGeri_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BtnDepMalzDetGeri_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BtnRestMalzDetGeri_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BtnUrunSipDetGeri_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BtnAdisSipDetGetir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BtnAdisOdDetGetir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
