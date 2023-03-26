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
    public partial class FormDepoMalzeme : Form
    {
        public FormDepoMalzeme()
        {
            InitializeComponent();
        }
        MarlaRestaurantEntities db = new MarlaRestaurantEntities();
        DepoRepository depoR = new DepoRepository();
        MalzemeRepository malR = new MalzemeRepository();
        MalzemeKategoriRepository malkatR = new MalzemeKategoriRepository();
        TedarikciRepository tedR = new TedarikciRepository();
        private void FormDepoMalzeme_Load(object sender, EventArgs e)
        {
            
        }

        private void btnDepoGetir_Click(object sender, EventArgs e)
        {
            DepoGetir();

        }

        private void DepoGetir()
        {
            dataGridViewDepo.DataSource = depoR.GetAll();
            dataGridViewDepo.Columns["DepoMalzemeDetay"].Visible = false;
        }

        private void btnDepoEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDepoAdi.Text) || string.IsNullOrEmpty(txtDepoAdres.Text))
            {
                MessageBox.Show("Lütfen boş geçmeyiniz !");
                return;
            }
            depoR.Insert(new Depo
            {
                DepoAdi = txtDepoAdi.Text,
                Adres = txtDepoAdres.Text

            });
            DepoGetir();
            Temizle();
        }

        private void Temizle()
        {
            txtDepoAdi.Text = txtDepoAdres.Text = string.Empty;
        }

        Depo seciliDepo;
        private void dataGridViewDepo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewDepo.SelectedRows.Count > 0)
            {
                seciliDepo = depoR.GetByID(Convert.ToInt32(dataGridViewDepo.SelectedRows[0].Cells[0].Value));
                txtDepoAdi.Text = seciliDepo.DepoAdi;
                txtDepoAdres.Text = seciliDepo.Adres;

            }
        }

        private void btnDepoGuncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDepoAdi.Text) || string.IsNullOrEmpty(txtDepoAdres.Text))
            {
                MessageBox.Show("Lütfen boş geçmeyin !");
            }
            else
            {
                seciliDepo.DepoAdi = txtDepoAdi.Text;
                seciliDepo.Adres = txtDepoAdres.Text;

                depoR.Update(seciliDepo);
                DepoGetir();
                Temizle();
            }

        }

        private void btnDepoSil_Click(object sender, EventArgs e)
        {
            depoR.Delete(Convert.ToInt32(dataGridViewDepo.SelectedCells[0].Value));
            DepoGetir();
        }

        private void btnMalzemeGetir_Click(object sender, EventArgs e)
        {
            MalzemeGetir();
        }

        private void MalzemeGetir()
        {
            dataGridViewMalzeme.DataSource = malR.GetAll();
            dataGridViewMalzeme.Columns["DepoMalzemeDetay"].Visible = false;
            dataGridViewMalzeme.Columns["MalzemeKategori"].Visible = false;
            dataGridViewMalzeme.Columns["Tedarikci"].Visible = false;
            dataGridViewMalzeme.Columns["RestaurantMalzemeDetay"].Visible = false;
            dataGridViewMalzeme.Columns["UrunMalzemeDetay"].Visible = false;
        }

        private void btnMalzemeEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMalzemeAdi.Text) || string.IsNullOrEmpty(txtMalKatId.Text) || string.IsNullOrEmpty(txtMalTedId.Text))
            {
                MessageBox.Show("Lütfen boş geçmeyiniz !");
                return;
            }
            malR.Insert(new Malzeme
            {
                MalzemeAdi = txtMalzemeAdi.Text,
                Durum = checkboxMalDurum.Checked,
                MalzemeKategoriID = Convert.ToInt32(txtMalKatId.Text),
                TedarikciID = Convert.ToInt32(txtMalTedId.Text),

            });
            MalzemeGetir();

            TemizleMalzeme();
        }

        private void TemizleMalzeme()
        {
            foreach (var item in groupBox2.Controls)
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
        Malzeme seciliMalzeme;
        private void dataGridViewMalzeme_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewMalzeme.SelectedRows.Count > 0)
            {
                seciliMalzeme = malR.GetByID(Convert.ToInt32(dataGridViewMalzeme.SelectedRows[0].Cells[0].Value));
                txtMalzemeAdi.Text = seciliMalzeme.MalzemeAdi;
                checkboxMalDurum.Checked = Convert.ToBoolean(seciliMalzeme.Durum);
                txtMalKatId.Text = Convert.ToString(seciliMalzeme.MalzemeKategoriID);
                txtMalTedId.Text = Convert.ToString(seciliMalzeme.TedarikciID);

            }
        }

        private void btnMalzemeGuncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMalzemeAdi.Text) || string.IsNullOrEmpty(txtMalKatId.Text) || string.IsNullOrEmpty(txtMalTedId.Text))
            {
                MessageBox.Show("Lütfen boş geçmeyin !");
            }
            else
            {
                seciliMalzeme.MalzemeAdi = txtMalzemeAdi.Text;
                seciliMalzeme.Durum = checkboxMalDurum.Checked;
                seciliMalzeme.MalzemeKategoriID = Convert.ToInt32(txtMalKatId.Text);
                seciliMalzeme.TedarikciID = Convert.ToInt32(txtMalTedId.Text);

                malR.Update(seciliMalzeme);
                MalzemeGetir();
                TemizleMalzeme();
            }
        }

        private void btnMalzemeSil_Click(object sender, EventArgs e)
        {
            malR.Delete(Convert.ToInt32(dataGridViewMalzeme.SelectedCells[0].Value));
            MalzemeGetir();
        }

        //private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        //{

        //    dataGridViewMalzemeKategori.DataSource = db.MalzemeKategori.Where(k => k.MalzemeKategoriID == (int)comboBox1.SelectedValue).Select(k => new
        //    {
        //        MalzemeKategoriId = k.MalzemeKategoriID,
        //        MalzemeKategoriAdi = k.MalzemeKategoriAdi

        //    }).ToList();
        //}

        private void btnMalKategoriGetir_Click(object sender, EventArgs e)
        {
            MalzemeKategoriGetir();
        }

        private void MalzemeKategoriGetir()
        {
            dataGridViewMalzemeKategori.DataSource = malkatR.GetAll();
            dataGridViewMalzemeKategori.Columns["Malzeme"].Visible = false;
        }

        private void btnMalKategoriEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMalKatAdi.Text))
            {
                MessageBox.Show("Lütfen boş geçmeyiniz !");
                return;
            }
            malkatR.Insert(new MalzemeKategori
            {
                MalzemeKategoriAdi = txtMalKatAdi.Text


            });
            MalzemeKategoriGetir();

            TemizleMalzemeKategori();
        }

        private void TemizleMalzemeKategori()
        {
            txtMalKatAdi.Text = string.Empty;
        }

        MalzemeKategori seciliMalKategori;
        private void dataGridViewMalzemeKategori_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewMalzemeKategori.SelectedRows.Count > 0)
            {
                seciliMalKategori = malkatR.GetByID(Convert.ToInt32(dataGridViewMalzemeKategori.SelectedRows[0].Cells[0].Value));
                txtMalKatAdi.Text = seciliMalKategori.MalzemeKategoriAdi;

            }
        }

        private void btnMalKategoriGuncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMalKatAdi.Text))
            {
                MessageBox.Show("Lütfen boş geçmeyin !");
            }
            else
            {
                seciliMalKategori.MalzemeKategoriAdi = txtMalKatAdi.Text;


                malkatR.Update(seciliMalKategori);
                MalzemeKategoriGetir();
                TemizleMalzemeKategori();
            }

        }

        private void btnMalKategoriSil_Click(object sender, EventArgs e)
        {
            malkatR.Delete(Convert.ToInt32(dataGridViewMalzemeKategori.SelectedCells[0].Value));
            MalzemeKategoriGetir();
        }

        private void txtDepoArama_TextChanged(object sender, EventArgs e)
        {
            string depoArama = txtDepoArama.Text.ToLower();
            if (depoArama != "")
            {
                dataGridViewDepo.DataSource = depoR.GetAll().Where(d => d.DepoAdi.ToString().ToLower().Contains(depoArama)).ToList();
                dataGridViewDepo.Columns["DepoMalzemeDetay"].Visible = false;
            }
            else
            {
                dataGridViewDepo.DataSource = depoR.GetAll().ToList();
            }
        }

        private void BtnGeri_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMalzemeAdiAra_TextChanged_1(object sender, EventArgs e)
        {
            string malzemeArama = txtMalzemeAdiAra.Text.ToLower();
            if (malzemeArama != "")
            {
                dataGridViewMalzeme.DataSource = malR.GetAll().Where(m => m.MalzemeAdi.ToLower().Contains(malzemeArama)).ToList();              
                dataGridViewMalzeme.Columns["MalzemeKategori"].Visible = false;
                dataGridViewMalzeme.Columns["Tedarikci"].Visible = false;
                dataGridViewMalzeme.Columns["UrunMalzemeDetay"].Visible = false;
                dataGridViewMalzeme.Columns["DepoMalzemeDetay"].Visible = false;
                dataGridViewMalzeme.Columns["MalzemeKategori"].Visible = false;               
                dataGridViewMalzeme.Columns["RestaurantMalzemeDetay"].Visible = false;
               
            }
            else
            {
                dataGridViewMalzeme.DataSource = malR.GetAll().ToList();
            }
        }

        private void txtMalzemeKatArama_TextChanged(object sender, EventArgs e)
        {
            string malzemeKatArama = txtMalzemeKatArama.Text.ToLower();
            if (malzemeKatArama != "")
            {
                dataGridViewMalzemeKategori.DataSource = malkatR.GetAll().Where(m => m.MalzemeKategoriAdi.ToLower().Contains(malzemeKatArama)).ToList();
                dataGridViewMalzemeKategori.Columns["Malzeme"].Visible = false;               
            }
            else
            {
                dataGridViewMalzemeKategori.DataSource = malkatR.GetAll().ToList();
            }
        }
    }

}

