
namespace WinUI
{
    partial class FormTedarikciCarileri
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
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridViewTedarikci = new System.Windows.Forms.DataGridView();
            this.txtTedarikciArama = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btTedGeri = new System.Windows.Forms.Button();
            this.btnTedarikciGetir = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTedarikciID = new System.Windows.Forms.TextBox();
            this.btnTedarikciSil = new System.Windows.Forms.Button();
            this.btnTedarikciGuncelle = new System.Windows.Forms.Button();
            this.btnTedarikciEkle = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTedarikciAdi = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridViewCariler = new System.Windows.Forms.DataGridView();
            this.txtCariArama = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnCariHesGeri = new System.Windows.Forms.Button();
            this.BtnCarileriGetir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtTedarikID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCariAdres = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCariTel = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCariVergiNo = new System.Windows.Forms.TextBox();
            this.txtCariUnvan = new System.Windows.Forms.TextBox();
            this.txtCariVergiDairesi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnCariSil = new System.Windows.Forms.Button();
            this.BtnCariGuncelle = new System.Windows.Forms.Button();
            this.BtnCariEkle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCariKodu = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnBorcListele = new System.Windows.Forms.Button();
            this.dataGridViewBorcAlacak = new System.Windows.Forms.DataGridView();
            this.txtFirmaArama = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.BtnBorcAlaGeri = new System.Windows.Forms.Button();
            this.btnAlacakListele = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTedarikci)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCariler)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBorcAlacak)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(24, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(849, 509);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridViewTedarikci);
            this.tabPage3.Controls.Add(this.txtTedarikciArama);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.btTedGeri);
            this.tabPage3.Controls.Add(this.btnTedarikciGetir);
            this.tabPage3.Controls.Add(this.groupBox4);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(841, 483);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Tedarikçi";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTedarikci
            // 
            this.dataGridViewTedarikci.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridViewTedarikci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTedarikci.Location = new System.Drawing.Point(20, 36);
            this.dataGridViewTedarikci.Name = "dataGridViewTedarikci";
            this.dataGridViewTedarikci.Size = new System.Drawing.Size(803, 220);
            this.dataGridViewTedarikci.TabIndex = 18;
            this.dataGridViewTedarikci.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTedarikci_CellDoubleClick_1);
            // 
            // txtTedarikciArama
            // 
            this.txtTedarikciArama.Location = new System.Drawing.Point(680, 8);
            this.txtTedarikciArama.Name = "txtTedarikciArama";
            this.txtTedarikciArama.Size = new System.Drawing.Size(143, 20);
            this.txtTedarikciArama.TabIndex = 17;
            this.txtTedarikciArama.TextChanged += new System.EventHandler(this.txtTedarikciArama_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(578, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 15);
            this.label12.TabIndex = 16;
            this.label12.Text = "Tedarikci Arama :";
            // 
            // btTedGeri
            // 
            this.btTedGeri.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btTedGeri.Location = new System.Drawing.Point(616, 410);
            this.btTedGeri.Name = "btTedGeri";
            this.btTedGeri.Size = new System.Drawing.Size(207, 36);
            this.btTedGeri.TabIndex = 15;
            this.btTedGeri.Text = "Geri Dön";
            this.btTedGeri.UseVisualStyleBackColor = false;
            this.btTedGeri.Click += new System.EventHandler(this.btTedGeri_Click);
            // 
            // btnTedarikciGetir
            // 
            this.btnTedarikciGetir.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnTedarikciGetir.Location = new System.Drawing.Point(616, 271);
            this.btnTedarikciGetir.Name = "btnTedarikciGetir";
            this.btnTedarikciGetir.Size = new System.Drawing.Size(207, 37);
            this.btnTedarikciGetir.TabIndex = 9;
            this.btnTedarikciGetir.Text = "Tedarikcileri Getir";
            this.btnTedarikciGetir.UseVisualStyleBackColor = false;
            this.btnTedarikciGetir.Click += new System.EventHandler(this.btnTedarikciGetir_Click_1);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.txtTedarikciID);
            this.groupBox4.Controls.Add(this.btnTedarikciSil);
            this.groupBox4.Controls.Add(this.btnTedarikciGuncelle);
            this.groupBox4.Controls.Add(this.btnTedarikciEkle);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.txtTedarikciAdi);
            this.groupBox4.Location = new System.Drawing.Point(20, 284);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(323, 162);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tedarikci";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(24, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 13);
            this.label13.TabIndex = 6;
            this.label13.Text = "Tedarikci ID :";
            // 
            // txtTedarikciID
            // 
            this.txtTedarikciID.Location = new System.Drawing.Point(109, 19);
            this.txtTedarikciID.Name = "txtTedarikciID";
            this.txtTedarikciID.Size = new System.Drawing.Size(167, 20);
            this.txtTedarikciID.TabIndex = 5;
            // 
            // btnTedarikciSil
            // 
            this.btnTedarikciSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnTedarikciSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTedarikciSil.Location = new System.Drawing.Point(199, 101);
            this.btnTedarikciSil.Name = "btnTedarikciSil";
            this.btnTedarikciSil.Size = new System.Drawing.Size(77, 35);
            this.btnTedarikciSil.TabIndex = 4;
            this.btnTedarikciSil.Text = "SİL";
            this.btnTedarikciSil.UseVisualStyleBackColor = false;
            this.btnTedarikciSil.Click += new System.EventHandler(this.btnTedarikciSil_Click_1);
            // 
            // btnTedarikciGuncelle
            // 
            this.btnTedarikciGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnTedarikciGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTedarikciGuncelle.Location = new System.Drawing.Point(109, 101);
            this.btnTedarikciGuncelle.Name = "btnTedarikciGuncelle";
            this.btnTedarikciGuncelle.Size = new System.Drawing.Size(84, 35);
            this.btnTedarikciGuncelle.TabIndex = 3;
            this.btnTedarikciGuncelle.Text = "GUNCELLE";
            this.btnTedarikciGuncelle.UseVisualStyleBackColor = false;
            this.btnTedarikciGuncelle.Click += new System.EventHandler(this.btnTedarikciGuncelle_Click_1);
            // 
            // btnTedarikciEkle
            // 
            this.btnTedarikciEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnTedarikciEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTedarikciEkle.Location = new System.Drawing.Point(22, 101);
            this.btnTedarikciEkle.Name = "btnTedarikciEkle";
            this.btnTedarikciEkle.Size = new System.Drawing.Size(81, 35);
            this.btnTedarikciEkle.TabIndex = 2;
            this.btnTedarikciEkle.Text = "EKLE";
            this.btnTedarikciEkle.UseVisualStyleBackColor = false;
            this.btnTedarikciEkle.Click += new System.EventHandler(this.btnTedarikciEkle_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Tedarikci Adı :";
            // 
            // txtTedarikciAdi
            // 
            this.txtTedarikciAdi.Location = new System.Drawing.Point(109, 55);
            this.txtTedarikciAdi.Name = "txtTedarikciAdi";
            this.txtTedarikciAdi.Size = new System.Drawing.Size(167, 20);
            this.txtTedarikciAdi.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridViewCariler);
            this.tabPage1.Controls.Add(this.txtCariArama);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.BtnCariHesGeri);
            this.tabPage1.Controls.Add(this.BtnCarileriGetir);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(841, 483);
            this.tabPage1.TabIndex = 4;
            this.tabPage1.Text = "Cari Hesaplar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewCariler
            // 
            this.dataGridViewCariler.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridViewCariler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCariler.Location = new System.Drawing.Point(17, 47);
            this.dataGridViewCariler.Name = "dataGridViewCariler";
            this.dataGridViewCariler.Size = new System.Drawing.Size(806, 197);
            this.dataGridViewCariler.TabIndex = 24;
            this.dataGridViewCariler.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCariler_CellDoubleClick_1);
            // 
            // txtCariArama
            // 
            this.txtCariArama.Location = new System.Drawing.Point(680, 12);
            this.txtCariArama.Name = "txtCariArama";
            this.txtCariArama.Size = new System.Drawing.Size(143, 20);
            this.txtCariArama.TabIndex = 23;
            this.txtCariArama.TextChanged += new System.EventHandler(this.txtCariArama_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(569, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 15);
            this.label1.TabIndex = 22;
            this.label1.Text = "Cari Hesap Arama :";
            // 
            // BtnCariHesGeri
            // 
            this.BtnCariHesGeri.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BtnCariHesGeri.Location = new System.Drawing.Point(667, 416);
            this.BtnCariHesGeri.Name = "BtnCariHesGeri";
            this.BtnCariHesGeri.Size = new System.Drawing.Size(144, 36);
            this.BtnCariHesGeri.TabIndex = 21;
            this.BtnCariHesGeri.Text = "Geri Dön";
            this.BtnCariHesGeri.UseVisualStyleBackColor = false;
            this.BtnCariHesGeri.Click += new System.EventHandler(this.BtnCariHesGeri_Click);
            // 
            // BtnCarileriGetir
            // 
            this.BtnCarileriGetir.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BtnCarileriGetir.Location = new System.Drawing.Point(667, 265);
            this.BtnCarileriGetir.Name = "BtnCarileriGetir";
            this.BtnCarileriGetir.Size = new System.Drawing.Size(144, 37);
            this.BtnCarileriGetir.TabIndex = 20;
            this.BtnCarileriGetir.Text = "Cari Hesapları Getir";
            this.BtnCarileriGetir.UseVisualStyleBackColor = false;
            this.BtnCarileriGetir.Click += new System.EventHandler(this.BtnCarileriGetir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.txtTedarikID);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtCariAdres);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtCariTel);
            this.groupBox1.Controls.Add(this.txtCariUnvan);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtCariVergiNo);
            this.groupBox1.Controls.Add(this.txtCariVergiDairesi);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.BtnCariSil);
            this.groupBox1.Controls.Add(this.BtnCariGuncelle);
            this.groupBox1.Controls.Add(this.BtnCariEkle);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCariKodu);
            this.groupBox1.Location = new System.Drawing.Point(32, 265);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(541, 206);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cari Hesap";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(23, 69);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(68, 13);
            this.label20.TabIndex = 33;
            this.label20.Text = "TedarikciID :";
            // 
            // txtTedarikID
            // 
            this.txtTedarikID.Location = new System.Drawing.Point(126, 62);
            this.txtTedarikID.Name = "txtTedarikID";
            this.txtTedarikID.Size = new System.Drawing.Size(149, 20);
            this.txtTedarikID.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(302, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "Adres :";
            // 
            // txtCariAdres
            // 
            this.txtCariAdres.Location = new System.Drawing.Point(348, 106);
            this.txtCariAdres.Multiline = true;
            this.txtCariAdres.Name = "txtCariAdres";
            this.txtCariAdres.Size = new System.Drawing.Size(167, 36);
            this.txtCariAdres.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(298, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Telefon :";
            // 
            // txtCariTel
            // 
            this.txtCariTel.Location = new System.Drawing.Point(348, 33);
            this.txtCariTel.Name = "txtCariTel";
            this.txtCariTel.Size = new System.Drawing.Size(167, 20);
            this.txtCariTel.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Vergi Dairesi :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(302, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Unvan :";
            // 
            // txtCariVergiNo
            // 
            this.txtCariVergiNo.Location = new System.Drawing.Point(126, 92);
            this.txtCariVergiNo.Name = "txtCariVergiNo";
            this.txtCariVergiNo.Size = new System.Drawing.Size(149, 20);
            this.txtCariVergiNo.TabIndex = 9;
            // 
            // txtCariUnvan
            // 
            this.txtCariUnvan.Location = new System.Drawing.Point(348, 58);
            this.txtCariUnvan.Multiline = true;
            this.txtCariUnvan.Name = "txtCariUnvan";
            this.txtCariUnvan.Size = new System.Drawing.Size(167, 42);
            this.txtCariUnvan.TabIndex = 7;
            // 
            // txtCariVergiDairesi
            // 
            this.txtCariVergiDairesi.Location = new System.Drawing.Point(126, 122);
            this.txtCariVergiDairesi.Name = "txtCariVergiDairesi";
            this.txtCariVergiDairesi.Size = new System.Drawing.Size(149, 20);
            this.txtCariVergiDairesi.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Vergi Numarası :";
            // 
            // BtnCariSil
            // 
            this.BtnCariSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnCariSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnCariSil.Location = new System.Drawing.Point(245, 165);
            this.BtnCariSil.Name = "BtnCariSil";
            this.BtnCariSil.Size = new System.Drawing.Size(94, 35);
            this.BtnCariSil.TabIndex = 4;
            this.BtnCariSil.Text = "SİL";
            this.BtnCariSil.UseVisualStyleBackColor = false;
            this.BtnCariSil.Click += new System.EventHandler(this.BtnCariSil_Click);
            // 
            // BtnCariGuncelle
            // 
            this.BtnCariGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnCariGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnCariGuncelle.Location = new System.Drawing.Point(114, 165);
            this.BtnCariGuncelle.Name = "BtnCariGuncelle";
            this.BtnCariGuncelle.Size = new System.Drawing.Size(125, 35);
            this.BtnCariGuncelle.TabIndex = 3;
            this.BtnCariGuncelle.Text = "GUNCELLE";
            this.BtnCariGuncelle.UseVisualStyleBackColor = false;
            this.BtnCariGuncelle.Click += new System.EventHandler(this.BtnCariGuncelle_Click);
            // 
            // BtnCariEkle
            // 
            this.BtnCariEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnCariEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnCariEkle.Location = new System.Drawing.Point(22, 165);
            this.BtnCariEkle.Name = "BtnCariEkle";
            this.BtnCariEkle.Size = new System.Drawing.Size(81, 35);
            this.BtnCariEkle.TabIndex = 2;
            this.BtnCariEkle.Text = "EKLE";
            this.BtnCariEkle.UseVisualStyleBackColor = false;
            this.BtnCariEkle.Click += new System.EventHandler(this.BtnCariEkle_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Cari Hesap Kodu :";
            // 
            // txtCariKodu
            // 
            this.txtCariKodu.Location = new System.Drawing.Point(126, 33);
            this.txtCariKodu.Name = "txtCariKodu";
            this.txtCariKodu.Size = new System.Drawing.Size(149, 20);
            this.txtCariKodu.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnBorcListele);
            this.tabPage2.Controls.Add(this.dataGridViewBorcAlacak);
            this.tabPage2.Controls.Add(this.txtFirmaArama);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.BtnBorcAlaGeri);
            this.tabPage2.Controls.Add(this.btnAlacakListele);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(841, 483);
            this.tabPage2.TabIndex = 5;
            this.tabPage2.Text = "Borç-Alacak Durumu";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnBorcListele
            // 
            this.btnBorcListele.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnBorcListele.Location = new System.Drawing.Point(635, 309);
            this.btnBorcListele.Name = "btnBorcListele";
            this.btnBorcListele.Size = new System.Drawing.Size(189, 37);
            this.btnBorcListele.TabIndex = 32;
            this.btnBorcListele.Text = "Borcları Listele";
            this.btnBorcListele.UseVisualStyleBackColor = false;
            this.btnBorcListele.Click += new System.EventHandler(this.btnBorcListele_Click);
            // 
            // dataGridViewBorcAlacak
            // 
            this.dataGridViewBorcAlacak.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridViewBorcAlacak.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBorcAlacak.Location = new System.Drawing.Point(20, 36);
            this.dataGridViewBorcAlacak.Name = "dataGridViewBorcAlacak";
            this.dataGridViewBorcAlacak.Size = new System.Drawing.Size(804, 267);
            this.dataGridViewBorcAlacak.TabIndex = 30;
            // 
            // txtFirmaArama
            // 
            this.txtFirmaArama.Location = new System.Drawing.Point(681, 8);
            this.txtFirmaArama.Name = "txtFirmaArama";
            this.txtFirmaArama.Size = new System.Drawing.Size(143, 20);
            this.txtFirmaArama.TabIndex = 29;
            this.txtFirmaArama.TextChanged += new System.EventHandler(this.txtFirmaArama_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(596, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 15);
            this.label10.TabIndex = 28;
            this.label10.Text = "Firma Arama :";
            // 
            // BtnBorcAlaGeri
            // 
            this.BtnBorcAlaGeri.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BtnBorcAlaGeri.Location = new System.Drawing.Point(635, 431);
            this.BtnBorcAlaGeri.Name = "BtnBorcAlaGeri";
            this.BtnBorcAlaGeri.Size = new System.Drawing.Size(189, 36);
            this.BtnBorcAlaGeri.TabIndex = 27;
            this.BtnBorcAlaGeri.Text = "Geri Dön";
            this.BtnBorcAlaGeri.UseVisualStyleBackColor = false;
            this.BtnBorcAlaGeri.Click += new System.EventHandler(this.BtnBorcAlaGeri_Click);
            // 
            // btnAlacakListele
            // 
            this.btnAlacakListele.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAlacakListele.Location = new System.Drawing.Point(20, 309);
            this.btnAlacakListele.Name = "btnAlacakListele";
            this.btnAlacakListele.Size = new System.Drawing.Size(189, 37);
            this.btnAlacakListele.TabIndex = 26;
            this.btnAlacakListele.Text = "Alacakları Listele";
            this.btnAlacakListele.UseVisualStyleBackColor = false;
            this.btnAlacakListele.Click += new System.EventHandler(this.btnAlacakListele_Click);
            // 
            // FormTedarikciCarileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(919, 549);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormTedarikciCarileri";
            this.Text = "FormTedarikciCarileri";
            this.Load += new System.EventHandler(this.FormTedarikciCarileri_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTedarikci)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCariler)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBorcAlacak)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txtTedarikciArama;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btTedGeri;
        private System.Windows.Forms.Button btnTedarikciGetir;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtTedarikciID;
        private System.Windows.Forms.Button btnTedarikciSil;
        private System.Windows.Forms.Button btnTedarikciGuncelle;
        private System.Windows.Forms.Button btnTedarikciEkle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTedarikciAdi;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtCariArama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnCariHesGeri;
        private System.Windows.Forms.Button BtnCarileriGetir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnCariSil;
        private System.Windows.Forms.Button BtnCariGuncelle;
        private System.Windows.Forms.Button BtnCariEkle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCariKodu;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCariAdres;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCariTel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCariVergiDairesi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCariVergiNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCariUnvan;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtFirmaArama;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button BtnBorcAlaGeri;
        private System.Windows.Forms.Button btnAlacakListele;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtTedarikID;
        private System.Windows.Forms.DataGridView dataGridViewTedarikci;
        private System.Windows.Forms.DataGridView dataGridViewCariler;
        private System.Windows.Forms.DataGridView dataGridViewBorcAlacak;
        private System.Windows.Forms.Button btnBorcListele;
    }
}