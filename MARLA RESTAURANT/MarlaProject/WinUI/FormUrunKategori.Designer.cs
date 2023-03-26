
namespace WinUI
{
    partial class FormUrunKategori
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtKategoriArama = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.BtnGeri = new System.Windows.Forms.Button();
            this.dataGridViewKategori = new System.Windows.Forms.DataGridView();
            this.btnKategoriler = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMenuId = new System.Windows.Forms.TextBox();
            this.btnSilKat = new System.Windows.Forms.Button();
            this.btnGuncelleKat = new System.Windows.Forms.Button();
            this.btnEkleKat = new System.Windows.Forms.Button();
            this.txtKagetoriAdi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtUrunArama = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnUrunGeri = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chxDurum = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUrunAciklamasi = new System.Windows.Forms.TextBox();
            this.txtKategoriId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnUrunSil = new System.Windows.Forms.Button();
            this.btnUrunGuncelle = new System.Windows.Forms.Button();
            this.btnUrunEkle = new System.Windows.Forms.Button();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewUrun = new System.Windows.Forms.DataGridView();
            this.btnUrunler = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKategori)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUrun)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tabControl1.Location = new System.Drawing.Point(3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(883, 522);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Snow;
            this.tabPage1.Controls.Add(this.txtKategoriArama);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.BtnGeri);
            this.tabPage1.Controls.Add(this.dataGridViewKategori);
            this.tabPage1.Controls.Add(this.btnKategoriler);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(875, 496);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Kategori";
            // 
            // txtKategoriArama
            // 
            this.txtKategoriArama.Location = new System.Drawing.Point(705, 12);
            this.txtKategoriArama.Name = "txtKategoriArama";
            this.txtKategoriArama.Size = new System.Drawing.Size(143, 22);
            this.txtKategoriArama.TabIndex = 12;
            this.txtKategoriArama.TextChanged += new System.EventHandler(this.txtKategoriArama_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(608, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 15);
            this.label10.TabIndex = 11;
            this.label10.Text = "Kategori Arama :";
            // 
            // BtnGeri
            // 
            this.BtnGeri.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BtnGeri.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnGeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.BtnGeri.Location = new System.Drawing.Point(682, 402);
            this.BtnGeri.Name = "BtnGeri";
            this.BtnGeri.Size = new System.Drawing.Size(170, 34);
            this.BtnGeri.TabIndex = 10;
            this.BtnGeri.Text = "Geri Dön";
            this.BtnGeri.UseVisualStyleBackColor = false;
            this.BtnGeri.Click += new System.EventHandler(this.BtnGeri_Click);
            // 
            // dataGridViewKategori
            // 
            this.dataGridViewKategori.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridViewKategori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKategori.Location = new System.Drawing.Point(19, 46);
            this.dataGridViewKategori.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewKategori.Name = "dataGridViewKategori";
            this.dataGridViewKategori.RowHeadersWidth = 51;
            this.dataGridViewKategori.RowTemplate.Height = 24;
            this.dataGridViewKategori.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewKategori.Size = new System.Drawing.Size(833, 186);
            this.dataGridViewKategori.TabIndex = 9;
            this.dataGridViewKategori.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewKategori_CellDoubleClick);
            // 
            // btnKategoriler
            // 
            this.btnKategoriler.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnKategoriler.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnKategoriler.Location = new System.Drawing.Point(674, 256);
            this.btnKategoriler.Margin = new System.Windows.Forms.Padding(2);
            this.btnKategoriler.Name = "btnKategoriler";
            this.btnKategoriler.Size = new System.Drawing.Size(178, 34);
            this.btnKategoriler.TabIndex = 8;
            this.btnKategoriler.Text = "Kategorileri Getir";
            this.btnKategoriler.UseVisualStyleBackColor = false;
            this.btnKategoriler.Click += new System.EventHandler(this.btnKategoriler_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMenuId);
            this.groupBox1.Controls.Add(this.btnSilKat);
            this.groupBox1.Controls.Add(this.btnGuncelleKat);
            this.groupBox1.Controls.Add(this.btnEkleKat);
            this.groupBox1.Controls.Add(this.txtKagetoriAdi);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(19, 256);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(338, 180);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kategori";
            // 
            // txtMenuId
            // 
            this.txtMenuId.Location = new System.Drawing.Point(130, 72);
            this.txtMenuId.Margin = new System.Windows.Forms.Padding(2);
            this.txtMenuId.Name = "txtMenuId";
            this.txtMenuId.Size = new System.Drawing.Size(156, 22);
            this.txtMenuId.TabIndex = 12;
            // 
            // btnSilKat
            // 
            this.btnSilKat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSilKat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnSilKat.Location = new System.Drawing.Point(208, 117);
            this.btnSilKat.Margin = new System.Windows.Forms.Padding(2);
            this.btnSilKat.Name = "btnSilKat";
            this.btnSilKat.Size = new System.Drawing.Size(78, 33);
            this.btnSilKat.TabIndex = 10;
            this.btnSilKat.Text = "SİL";
            this.btnSilKat.UseVisualStyleBackColor = false;
            this.btnSilKat.Click += new System.EventHandler(this.btnSilKat_Click);
            // 
            // btnGuncelleKat
            // 
            this.btnGuncelleKat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnGuncelleKat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnGuncelleKat.Location = new System.Drawing.Point(103, 117);
            this.btnGuncelleKat.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuncelleKat.Name = "btnGuncelleKat";
            this.btnGuncelleKat.Size = new System.Drawing.Size(101, 32);
            this.btnGuncelleKat.TabIndex = 9;
            this.btnGuncelleKat.Text = "GÜNCELLE";
            this.btnGuncelleKat.UseVisualStyleBackColor = false;
            this.btnGuncelleKat.Click += new System.EventHandler(this.btnGuncelleKat_Click);
            // 
            // btnEkleKat
            // 
            this.btnEkleKat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnEkleKat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnEkleKat.Location = new System.Drawing.Point(30, 117);
            this.btnEkleKat.Margin = new System.Windows.Forms.Padding(2);
            this.btnEkleKat.Name = "btnEkleKat";
            this.btnEkleKat.Size = new System.Drawing.Size(69, 33);
            this.btnEkleKat.TabIndex = 8;
            this.btnEkleKat.Text = "EKLE";
            this.btnEkleKat.UseVisualStyleBackColor = false;
            this.btnEkleKat.Click += new System.EventHandler(this.btnEkleKat_Click);
            // 
            // txtKagetoriAdi
            // 
            this.txtKagetoriAdi.Location = new System.Drawing.Point(130, 37);
            this.txtKagetoriAdi.Margin = new System.Windows.Forms.Padding(2);
            this.txtKagetoriAdi.Name = "txtKagetoriAdi";
            this.txtKagetoriAdi.Size = new System.Drawing.Size(156, 22);
            this.txtKagetoriAdi.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label7.Location = new System.Drawing.Point(31, 72);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "MenuId :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label8.Location = new System.Drawing.Point(31, 40);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Kategori Adı :";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Snow;
            this.tabPage2.Controls.Add(this.txtUrunArama);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.BtnUrunGeri);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.dataGridViewUrun);
            this.tabPage2.Controls.Add(this.btnUrunler);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(875, 496);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ürünler";
            // 
            // txtUrunArama
            // 
            this.txtUrunArama.Location = new System.Drawing.Point(710, 12);
            this.txtUrunArama.Name = "txtUrunArama";
            this.txtUrunArama.Size = new System.Drawing.Size(143, 21);
            this.txtUrunArama.TabIndex = 15;
            this.txtUrunArama.TextChanged += new System.EventHandler(this.txtUrunArama_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(631, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Ürün Arama :";
            // 
            // BtnUrunGeri
            // 
            this.BtnUrunGeri.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BtnUrunGeri.Location = new System.Drawing.Point(690, 444);
            this.BtnUrunGeri.Name = "BtnUrunGeri";
            this.BtnUrunGeri.Size = new System.Drawing.Size(163, 34);
            this.BtnUrunGeri.TabIndex = 13;
            this.BtnUrunGeri.Text = "Geri Dön";
            this.BtnUrunGeri.UseVisualStyleBackColor = false;
            this.BtnUrunGeri.Click += new System.EventHandler(this.BtnUrunGeri_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chxDurum);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtFiyat);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtUrunAciklamasi);
            this.groupBox3.Controls.Add(this.txtKategoriId);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.btnUrunSil);
            this.groupBox3.Controls.Add(this.btnUrunGuncelle);
            this.groupBox3.Controls.Add(this.btnUrunEkle);
            this.groupBox3.Controls.Add(this.txtUrunAdi);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(17, 253);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(352, 225);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Urun";
            // 
            // chxDurum
            // 
            this.chxDurum.AutoSize = true;
            this.chxDurum.Location = new System.Drawing.Point(155, 160);
            this.chxDurum.Name = "chxDurum";
            this.chxDurum.Size = new System.Drawing.Size(64, 19);
            this.chxDurum.TabIndex = 18;
            this.chxDurum.Text = "Durum";
            this.chxDurum.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "Durum :";
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(155, 122);
            this.txtFiyat.Margin = new System.Windows.Forms.Padding(2);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(153, 21);
            this.txtFiyat.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 125);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Fiyat :";
            // 
            // txtUrunAciklamasi
            // 
            this.txtUrunAciklamasi.Location = new System.Drawing.Point(155, 88);
            this.txtUrunAciklamasi.Margin = new System.Windows.Forms.Padding(2);
            this.txtUrunAciklamasi.Name = "txtUrunAciklamasi";
            this.txtUrunAciklamasi.Size = new System.Drawing.Size(153, 21);
            this.txtUrunAciklamasi.TabIndex = 12;
            // 
            // txtKategoriId
            // 
            this.txtKategoriId.Location = new System.Drawing.Point(155, 23);
            this.txtKategoriId.Margin = new System.Windows.Forms.Padding(2);
            this.txtKategoriId.Name = "txtKategoriId";
            this.txtKategoriId.Size = new System.Drawing.Size(153, 21);
            this.txtKategoriId.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 91);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Urun Acıklaması :";
            // 
            // btnUrunSil
            // 
            this.btnUrunSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnUrunSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunSil.Location = new System.Drawing.Point(225, 192);
            this.btnUrunSil.Margin = new System.Windows.Forms.Padding(2);
            this.btnUrunSil.Name = "btnUrunSil";
            this.btnUrunSil.Size = new System.Drawing.Size(83, 34);
            this.btnUrunSil.TabIndex = 10;
            this.btnUrunSil.Text = "SİL";
            this.btnUrunSil.UseVisualStyleBackColor = false;
            this.btnUrunSil.Click += new System.EventHandler(this.btnUrunSil_Click);
            // 
            // btnUrunGuncelle
            // 
            this.btnUrunGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnUrunGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunGuncelle.Location = new System.Drawing.Point(125, 192);
            this.btnUrunGuncelle.Margin = new System.Windows.Forms.Padding(2);
            this.btnUrunGuncelle.Name = "btnUrunGuncelle";
            this.btnUrunGuncelle.Size = new System.Drawing.Size(96, 34);
            this.btnUrunGuncelle.TabIndex = 9;
            this.btnUrunGuncelle.Text = "GÜNCELLE";
            this.btnUrunGuncelle.UseVisualStyleBackColor = false;
            this.btnUrunGuncelle.Click += new System.EventHandler(this.btnUrunGuncelle_Click);
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnUrunEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunEkle.Location = new System.Drawing.Point(31, 192);
            this.btnUrunEkle.Margin = new System.Windows.Forms.Padding(2);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Size = new System.Drawing.Size(90, 34);
            this.btnUrunEkle.TabIndex = 8;
            this.btnUrunEkle.Text = "EKLE";
            this.btnUrunEkle.UseVisualStyleBackColor = false;
            this.btnUrunEkle.Click += new System.EventHandler(this.btnUrunEkle_Click);
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(155, 58);
            this.txtUrunAdi.Margin = new System.Windows.Forms.Padding(2);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(153, 21);
            this.txtUrunAdi.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Urun Adi :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "KategoriId :";
            // 
            // dataGridViewUrun
            // 
            this.dataGridViewUrun.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridViewUrun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUrun.Location = new System.Drawing.Point(17, 44);
            this.dataGridViewUrun.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewUrun.Name = "dataGridViewUrun";
            this.dataGridViewUrun.RowHeadersWidth = 51;
            this.dataGridViewUrun.RowTemplate.Height = 24;
            this.dataGridViewUrun.Size = new System.Drawing.Size(836, 200);
            this.dataGridViewUrun.TabIndex = 11;
            this.dataGridViewUrun.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUrun_CellDoubleClick);
            // 
            // btnUrunler
            // 
            this.btnUrunler.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnUrunler.Location = new System.Drawing.Point(690, 259);
            this.btnUrunler.Margin = new System.Windows.Forms.Padding(2);
            this.btnUrunler.Name = "btnUrunler";
            this.btnUrunler.Size = new System.Drawing.Size(163, 38);
            this.btnUrunler.TabIndex = 10;
            this.btnUrunler.Text = "Urunleri Getir";
            this.btnUrunler.UseVisualStyleBackColor = false;
            this.btnUrunler.Click += new System.EventHandler(this.btnUrunler_Click);
            // 
            // FormUrunKategori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 538);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormUrunKategori";
            this.Text = "FormUrunKategori";
            this.Load += new System.EventHandler(this.FormUrunKategori_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKategori)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUrun)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridViewKategori;
        private System.Windows.Forms.Button btnKategoriler;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSilKat;
        private System.Windows.Forms.Button btnGuncelleKat;
        private System.Windows.Forms.Button btnEkleKat;
        private System.Windows.Forms.TextBox txtKagetoriAdi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUrunAciklamasi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnUrunSil;
        private System.Windows.Forms.Button btnUrunGuncelle;
        private System.Windows.Forms.Button btnUrunEkle;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.TextBox txtKategoriId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewUrun;
        private System.Windows.Forms.Button btnUrunler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chxDurum;
        private System.Windows.Forms.Button BtnGeri;
        private System.Windows.Forms.Button BtnUrunGeri;
        private System.Windows.Forms.TextBox txtKategoriArama;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtUrunArama;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMenuId;
    }
}