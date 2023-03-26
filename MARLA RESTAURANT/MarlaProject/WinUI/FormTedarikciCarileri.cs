using BLL.Repositories;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinUI
{
    public partial class FormTedarikciCarileri : Form
    {
        MarlaRestaurantEntities db = new MarlaRestaurantEntities();
        TedarikciRepository tedR = new TedarikciRepository();
        CariHesaplarRepository cariR = new CariHesaplarRepository();
        public FormTedarikciCarileri()
        {
            InitializeComponent();
        }

        private void FormTedarikciCarileri_Load(object sender, EventArgs e)
        {

        }
        private void btnTedarikciGetir_Click_1(object sender, EventArgs e)
        {
            TedarikciGetir();
        }

        private void TedarikciGetir()
        {
            //dataGridViewTedarikci.DataSource = tedR.GetAll();
            //dataGridViewTedarikci.Columns["CariHesaplar"].Visible = false;
            //dataGridViewTedarikci.Columns["Malzeme"].Visible = false;
            //dataGridViewTedarikci.Columns["Evraklar"].Visible = false;
            //dataGridViewTedarikci.Columns["CARI_HESAP_HAREKETLERI"].Visible = false;

            dataGridViewTedarikci.DataSource = db.Tedarikci.Select(
                t => new
                {
                    t.TedarikciID,
                    t.TedarikciAdi,
                }
                ).ToList();
        }

        private void btnTedarikciEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTedarikciAdi.Text))
            {
                MessageBox.Show("Lütfen Boş Geçmeyiniz..!");
                return;
            }
            tedR.Insert(new Tedarikci
            {
                //TedarikciID=Convert.ToInt32(txtTedarikciID.Text),
                TedarikciAdi = txtTedarikciAdi.Text
            });
            TedarikciGetir();
            TemizleTedarikci();
        }

        private void TemizleTedarikci()
        {
           /* txtTedarikciID.Text =*/ txtTedarikciAdi.Text = string.Empty;
        }


        Tedarikci seciliTedarikci;

        private void dataGridViewTedarikci_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewTedarikci.SelectedRows.Count > 0)
            {
                seciliTedarikci = tedR.GetByID(Convert.ToInt32(dataGridViewTedarikci.CurrentRow.Cells[0].Value));
                //txtTedarikciID.Text = Convert.ToString(seciliTedarikci.TedarikciID);
                txtTedarikciAdi.Text = seciliTedarikci.TedarikciAdi;
            }
        }

        private void btnTedarikciGuncelle_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTedarikciAdi.Text))
            {
                MessageBox.Show("Lütfen Boş Geçmeyiin..!");
            }
            else
            {
                //seciliTedarikci.TedarikciID = Convert.ToInt32(txtTedarikciID.Text);
                seciliTedarikci.TedarikciAdi = txtTedarikciAdi.Text;
                tedR.Update(seciliTedarikci);
                TedarikciGetir();
                TedarikciTemizle();
            }
        }

        private void btnTedarikciSil_Click(object sender, EventArgs e)
        {
            tedR.Delete(Convert.ToInt32(dataGridViewTedarikci.SelectedCells[0].Value));
            TedarikciGetir();
        }

        private void btTedGeri_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCariHesGeri_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCarileriGetir_Click(object sender, EventArgs e)
        {
            CarileriGetir();
        }

        private void CarileriGetir()
        {
            dataGridViewCariler.DataSource = db.CariHesaplar.Select(
                c => new
                {
                    c.CariHesapID,
                    c.CariKodu,
                    c.TedarikciID,
                    c.Tedarikci.TedarikciAdi,
                    c.Unvan,
                    c.VergiDairesi,
                    c.VergiNumarasi,
                    c.Telefon,
                    c.Adres,                  
                }
                ).OrderByDescending(c => c.Unvan).Take(10).ToList();

            //dataGridViewTedarikci.Columns["CariHesaplar"].Visible = false;
           // dataGridViewBorcAlacak.Columns["CariHesaplar"].Visible = false;
        }

        private void BtnCariEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCariKodu.Text) ||
                string.IsNullOrEmpty(txtTedarikID.Text) ||
                string.IsNullOrEmpty(txtCariUnvan.Text) ||
                string.IsNullOrEmpty(txtCariVergiDairesi.Text) ||
                string.IsNullOrEmpty(txtCariVergiNo.Text) ||
                string.IsNullOrEmpty(txtCariTel.Text) || 
                string.IsNullOrEmpty(txtCariAdres.Text))
            {
                MessageBox.Show("Lütfen boş geçmeyiniz..!");
                return;
            }
            cariR.Insert(new CariHesaplar
            {
                CariKodu = txtCariKodu.Text,
                TedarikciID = Convert.ToInt32(txtTedarikID.Text),
                Unvan = txtCariUnvan.Text,
                VergiDairesi = txtCariVergiDairesi.Text,
                VergiNumarasi = txtCariVergiNo.Text,
                Telefon = txtCariTel.Text,
                Adres=txtCariAdres.Text
            });
            CarileriGetir();
            CarileriTemizle();
        }

        private void CarileriTemizle()
        {
            foreach (var item in groupBox1.Controls)
            {
                if (item is TextBox)
                {
                    TextBox txt = (TextBox)item;
                    txt.Clear();
                }
            }
        }

        CariHesaplar seciliCariHesap;
        private void dataGridViewCariler_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewCariler.SelectedRows.Count > 0)
            {
                seciliCariHesap = cariR.GetByID(Convert.ToInt32(dataGridViewCariler.CurrentRow.Cells[0].Value));
                txtCariKodu.Text = seciliCariHesap.CariKodu;
                txtTedarikID.Text = Convert.ToString(seciliCariHesap.TedarikciID);
                txtCariUnvan.Text = seciliCariHesap.Unvan;
                txtCariVergiDairesi.Text = seciliCariHesap.VergiDairesi;
                txtCariVergiNo.Text = seciliCariHesap.VergiNumarasi;
                txtCariTel.Text = seciliCariHesap.Telefon;
                txtCariAdres.Text = seciliCariHesap.Adres;
            }
        }

        private void BtnCariGuncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCariKodu.Text) || 
                string.IsNullOrEmpty(txtTedarikID.Text) ||
                string.IsNullOrEmpty(txtCariUnvan.Text) || 
                string.IsNullOrEmpty(txtCariVergiDairesi.Text) || 
                string.IsNullOrEmpty(txtCariVergiNo.Text) || 
                string.IsNullOrEmpty(txtCariTel.Text) || 
                string.IsNullOrEmpty(txtCariAdres.Text))
            {
                MessageBox.Show("Lütfen boş geçmeyin !");
            }
            else
            {
               seciliCariHesap.CariKodu= txtCariKodu.Text;
                seciliCariHesap.TedarikciID =Convert.ToInt32(txtTedarikID.Text);
                seciliCariHesap.Unvan = txtCariUnvan.Text;
                seciliCariHesap.VergiNumarasi = txtCariVergiNo.Text;
                seciliCariHesap.VergiDairesi = txtCariVergiDairesi.Text;
                seciliCariHesap.Telefon = txtCariTel.Text;
                seciliCariHesap.Adres = txtCariAdres.Text;

                cariR.Update(seciliCariHesap);
                CarileriGetir();
                CarileriTemizle();
            }
        }

        private void BtnCariSil_Click(object sender, EventArgs e)
        {
            cariR.Delete(Convert.ToInt32(dataGridViewCariler.SelectedCells[0].Value));
            CarileriGetir();
        }

        private void BtnBorcAlaGeri_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTedarikciArama_TextChanged(object sender, EventArgs e)
        {
            string tedarikciArama = txtTedarikciArama.Text.ToLower();
            if (tedarikciArama != "")
            {
                dataGridViewTedarikci.DataSource = tedR.GetAll().Where(t => t.TedarikciAdi.ToLower().Contains(tedarikciArama)).ToList();
                dataGridViewTedarikci.Columns["CariHesaplar"].Visible = false;
                dataGridViewTedarikci.Columns["Malzeme"].Visible = false;              
            }
            else
            {
                dataGridViewTedarikci.DataSource = tedR.GetAll().ToList();
            }
        }

        private void txtCariArama_TextChanged(object sender, EventArgs e)
        {
            string cariArama = txtCariArama.Text.ToLower();
            if (cariArama != "")
            {
                dataGridViewCariler.DataSource = cariR.GetAll().Where(c => c.Unvan.ToString().ToLower().Contains(cariArama)).ToList();
                dataGridViewCariler.Columns["Tedarikci"].Visible = false;
                //dataGridViewCariler.Columns["CARI_HESAP_HAREKETLERI"].Visible = false;              
            }
            else
            {
                dataGridViewCariler.DataSource = cariR.GetAll().ToList();
            }
        }

        private void txtFirmaArama_TextChanged(object sender, EventArgs e)
        {
            string firmaArama = txtFirmaArama.Text.ToLower();
            if (firmaArama != "")
            {
                dataGridViewBorcAlacak.DataSource = cariR.GetAll().Where(c => c.Unvan.ToString().ToLower().Contains(firmaArama)).ToList();
                //dataGridViewBorcAlacak.Columns["CariHesaplar"].Visible = false;
                //dataGridViewBorcAlacak.Columns["Evraklar"].Visible = false;
            }
            else
            {
                dataGridViewBorcAlacak.DataSource = cariR.GetAll().ToList();

            }
        }
        private void TedarikciTemizle()
        {
            txtTedarikciID.Text = txtTedarikciAdi.Text = string.Empty;
        }

        private void btnTedarikciEkle_Click_1(object sender, EventArgs e)
        {
            if ( string.IsNullOrEmpty(txtTedarikciAdi.Text))
            {
                MessageBox.Show("Boş Bırakmayınız..!");
                return;
            }
            tedR.Insert(new Tedarikci
            {
                TedarikciAdi = txtTedarikciAdi.Text
            }) ;
            TedarikciGetir();
            TedarikciTemizle();
        }

        private void btnTedarikciSil_Click_1(object sender, EventArgs e)
        {
            tedR.Delete(Convert.ToInt32(dataGridViewTedarikci.SelectedCells[0].Value));
            TedarikciGetir();
        }

        private void dataGridViewCariler_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewCariler.SelectedRows.Count > 0)
            {
                seciliCariHesap = cariR.GetByID(Convert.ToInt32(dataGridViewCariler.CurrentRow.Cells[0].Value));
                txtCariKodu.Text = seciliCariHesap.CariKodu;
                txtTedarikID.Text = Convert.ToString(seciliCariHesap.TedarikciID);
                txtCariUnvan.Text = seciliCariHesap.Unvan;
                txtCariVergiDairesi.Text = seciliCariHesap.VergiDairesi;
                txtCariVergiNo.Text = seciliCariHesap.VergiNumarasi;
                txtCariTel.Text = seciliCariHesap.Telefon;
                txtCariAdres.Text = seciliCariHesap.Adres;
            }
        }

        private void btnAlacakListele_Click(object sender, EventArgs e)
        {
            // SqlParameter parametre = new SqlParameter("@cari", System.Data.SqlDbType.NVarChar,int.MaxValue)
            // {
            //     Direction = System.Data.ParameterDirection.Output
            // };

            //var liste= db.Database.ExecuteSqlCommand("Sp_Cari_Alacak @cari out",parametre);

            dataGridViewBorcAlacak.DataSource = CallMyProcedure("EXEC Sp_Cari_Alacak @cari","");
        }
        public List<borc> CallMyBorcProcedure(string Sp, string parameter)
        {
            using (var context = new MarlaRestaurantEntities())
            {
                var result = context.Database.SqlQuery<borc>(Sp, new SqlParameter("@cari", parameter)).ToList();
                return result;
            }
        }
        public List<alacak> CallMyProcedure(string Sp ,string parameter)
        {
            using (var context = new MarlaRestaurantEntities())
            {
                var result = context.Database.SqlQuery<alacak>(Sp, new SqlParameter("@cari", parameter)).ToList();
                return result;
            }
        }

        private void btnBorcListele_Click(object sender, EventArgs e)
        {
            dataGridViewBorcAlacak.DataSource = CallMyBorcProcedure("EXEC Sp_Cari_Borc @cari", "");
        }
    }
}
