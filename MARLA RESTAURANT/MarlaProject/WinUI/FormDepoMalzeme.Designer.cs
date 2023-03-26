
namespace WinUI
{
    partial class FormDepoMalzeme
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
            this.BtnGeri = new System.Windows.Forms.Button();
            this.txtDepoArama = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnDepoGetir = new System.Windows.Forms.Button();
            this.dataGridViewDepo = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDepoAdres = new System.Windows.Forms.TextBox();
            this.txtDepoAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDepoSil = new System.Windows.Forms.Button();
            this.btnDepoGuncelle = new System.Windows.Forms.Button();
            this.btnDepoEkle = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtMalzemeAdiAra = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnMalzemeGetir = new System.Windows.Forms.Button();
            this.dataGridViewMalzeme = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMalTedId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkboxMalDurum = new System.Windows.Forms.CheckBox();
            this.txtMalKatId = new System.Windows.Forms.TextBox();
            this.txtMalzemeAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnMalzemeSil = new System.Windows.Forms.Button();
            this.btnMalzemeGuncelle = new System.Windows.Forms.Button();
            this.btnMalzemeEkle = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.txtMalzemeKatArama = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnMalKategoriGetir = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnMalKategoriSil = new System.Windows.Forms.Button();
            this.btnMalKategoriGuncelle = new System.Windows.Forms.Button();
            this.btnMalKategoriEkle = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMalKatAdi = new System.Windows.Forms.TextBox();
            this.dataGridViewMalzemeKategori = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMalzeme)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMalzemeKategori)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(21, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(849, 494);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Snow;
            this.tabPage1.Controls.Add(this.BtnGeri);
            this.tabPage1.Controls.Add(this.txtDepoArama);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.btnDepoGetir);
            this.tabPage1.Controls.Add(this.dataGridViewDepo);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(841, 468);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Depo";
            // 
            // BtnGeri
            // 
            this.BtnGeri.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BtnGeri.Location = new System.Drawing.Point(629, 410);
            this.BtnGeri.Name = "BtnGeri";
            this.BtnGeri.Size = new System.Drawing.Size(185, 32);
            this.BtnGeri.TabIndex = 14;
            this.BtnGeri.Text = "Geri Dön";
            this.BtnGeri.UseVisualStyleBackColor = false;
            this.BtnGeri.Click += new System.EventHandler(this.BtnGeri_Click);
            // 
            // txtDepoArama
            // 
            this.txtDepoArama.Location = new System.Drawing.Point(671, 12);
            this.txtDepoArama.Name = "txtDepoArama";
            this.txtDepoArama.Size = new System.Drawing.Size(143, 20);
            this.txtDepoArama.TabIndex = 13;
            this.txtDepoArama.TextChanged += new System.EventHandler(this.txtDepoArama_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(589, 14);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 15);
            this.label11.TabIndex = 12;
            this.label11.Text = "Depo Arama :";
            // 
            // btnDepoGetir
            // 
            this.btnDepoGetir.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnDepoGetir.Location = new System.Drawing.Point(629, 251);
            this.btnDepoGetir.Name = "btnDepoGetir";
            this.btnDepoGetir.Size = new System.Drawing.Size(185, 32);
            this.btnDepoGetir.TabIndex = 2;
            this.btnDepoGetir.Text = "Depoları Getir";
            this.btnDepoGetir.UseVisualStyleBackColor = false;
            this.btnDepoGetir.Click += new System.EventHandler(this.btnDepoGetir_Click);
            // 
            // dataGridViewDepo
            // 
            this.dataGridViewDepo.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridViewDepo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDepo.Location = new System.Drawing.Point(19, 45);
            this.dataGridViewDepo.Name = "dataGridViewDepo";
            this.dataGridViewDepo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDepo.Size = new System.Drawing.Size(795, 186);
            this.dataGridViewDepo.TabIndex = 1;
            this.dataGridViewDepo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDepo_CellDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Snow;
            this.groupBox1.Controls.Add(this.txtDepoAdres);
            this.groupBox1.Controls.Add(this.txtDepoAdi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnDepoSil);
            this.groupBox1.Controls.Add(this.btnDepoGuncelle);
            this.groupBox1.Controls.Add(this.btnDepoEkle);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(19, 251);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 189);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Depo";
            // 
            // txtDepoAdres
            // 
            this.txtDepoAdres.Location = new System.Drawing.Point(119, 76);
            this.txtDepoAdres.Name = "txtDepoAdres";
            this.txtDepoAdres.Size = new System.Drawing.Size(157, 21);
            this.txtDepoAdres.TabIndex = 9;
            // 
            // txtDepoAdi
            // 
            this.txtDepoAdi.Location = new System.Drawing.Point(119, 35);
            this.txtDepoAdi.Name = "txtDepoAdi";
            this.txtDepoAdi.Size = new System.Drawing.Size(157, 21);
            this.txtDepoAdi.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(29, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Adres :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(29, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Depo Adı :";
            // 
            // btnDepoSil
            // 
            this.btnDepoSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDepoSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDepoSil.Location = new System.Drawing.Point(192, 134);
            this.btnDepoSil.Name = "btnDepoSil";
            this.btnDepoSil.Size = new System.Drawing.Size(84, 36);
            this.btnDepoSil.TabIndex = 5;
            this.btnDepoSil.Text = "SİL";
            this.btnDepoSil.UseVisualStyleBackColor = false;
            this.btnDepoSil.Click += new System.EventHandler(this.btnDepoSil_Click);
            // 
            // btnDepoGuncelle
            // 
            this.btnDepoGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnDepoGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDepoGuncelle.Location = new System.Drawing.Point(98, 134);
            this.btnDepoGuncelle.Name = "btnDepoGuncelle";
            this.btnDepoGuncelle.Size = new System.Drawing.Size(88, 36);
            this.btnDepoGuncelle.TabIndex = 4;
            this.btnDepoGuncelle.Text = "GÜNCELLE";
            this.btnDepoGuncelle.UseVisualStyleBackColor = false;
            this.btnDepoGuncelle.Click += new System.EventHandler(this.btnDepoGuncelle_Click);
            // 
            // btnDepoEkle
            // 
            this.btnDepoEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDepoEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDepoEkle.Location = new System.Drawing.Point(15, 134);
            this.btnDepoEkle.Name = "btnDepoEkle";
            this.btnDepoEkle.Size = new System.Drawing.Size(77, 35);
            this.btnDepoEkle.TabIndex = 3;
            this.btnDepoEkle.Text = "EKLE";
            this.btnDepoEkle.UseVisualStyleBackColor = false;
            this.btnDepoEkle.Click += new System.EventHandler(this.btnDepoEkle_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Snow;
            this.tabPage2.Controls.Add(this.txtMalzemeAdiAra);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.btnMalzemeGetir);
            this.tabPage2.Controls.Add(this.dataGridViewMalzeme);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(841, 468);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Malzeme";
            // 
            // txtMalzemeAdiAra
            // 
            this.txtMalzemeAdiAra.Location = new System.Drawing.Point(672, 10);
            this.txtMalzemeAdiAra.Name = "txtMalzemeAdiAra";
            this.txtMalzemeAdiAra.Size = new System.Drawing.Size(143, 20);
            this.txtMalzemeAdiAra.TabIndex = 18;
            this.txtMalzemeAdiAra.TextChanged += new System.EventHandler(this.txtMalzemeAdiAra_TextChanged_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(548, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 15);
            this.label9.TabIndex = 17;
            this.label9.Text = "Malzeme Adı Arama :";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button1.Location = new System.Drawing.Point(647, 409);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 36);
            this.button1.TabIndex = 16;
            this.button1.Text = "Geri Dön";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnMalzemeGetir
            // 
            this.btnMalzemeGetir.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnMalzemeGetir.Location = new System.Drawing.Point(647, 239);
            this.btnMalzemeGetir.Name = "btnMalzemeGetir";
            this.btnMalzemeGetir.Size = new System.Drawing.Size(171, 37);
            this.btnMalzemeGetir.TabIndex = 5;
            this.btnMalzemeGetir.Text = "Malzemeleri Getir";
            this.btnMalzemeGetir.UseVisualStyleBackColor = false;
            this.btnMalzemeGetir.Click += new System.EventHandler(this.btnMalzemeGetir_Click);
            // 
            // dataGridViewMalzeme
            // 
            this.dataGridViewMalzeme.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridViewMalzeme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMalzeme.Location = new System.Drawing.Point(19, 44);
            this.dataGridViewMalzeme.Name = "dataGridViewMalzeme";
            this.dataGridViewMalzeme.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMalzeme.Size = new System.Drawing.Size(799, 172);
            this.dataGridViewMalzeme.TabIndex = 4;
            this.dataGridViewMalzeme.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMalzeme_CellDoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtMalTedId);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.checkboxMalDurum);
            this.groupBox2.Controls.Add(this.txtMalKatId);
            this.groupBox2.Controls.Add(this.txtMalzemeAdi);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnMalzemeSil);
            this.groupBox2.Controls.Add(this.btnMalzemeGuncelle);
            this.groupBox2.Controls.Add(this.btnMalzemeEkle);
            this.groupBox2.Location = new System.Drawing.Point(19, 232);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(350, 213);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Malzeme";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "TedarikciId :";
            // 
            // txtMalTedId
            // 
            this.txtMalTedId.Location = new System.Drawing.Point(144, 123);
            this.txtMalTedId.Name = "txtMalTedId";
            this.txtMalTedId.Size = new System.Drawing.Size(143, 20);
            this.txtMalTedId.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Malzeme KategoriId :";
            // 
            // checkboxMalDurum
            // 
            this.checkboxMalDurum.AutoSize = true;
            this.checkboxMalDurum.Location = new System.Drawing.Point(144, 62);
            this.checkboxMalDurum.Name = "checkboxMalDurum";
            this.checkboxMalDurum.Size = new System.Drawing.Size(74, 17);
            this.checkboxMalDurum.TabIndex = 10;
            this.checkboxMalDurum.Text = "checkBox";
            this.checkboxMalDurum.UseVisualStyleBackColor = true;
            // 
            // txtMalKatId
            // 
            this.txtMalKatId.Location = new System.Drawing.Point(144, 96);
            this.txtMalKatId.Name = "txtMalKatId";
            this.txtMalKatId.Size = new System.Drawing.Size(143, 20);
            this.txtMalKatId.TabIndex = 9;
            // 
            // txtMalzemeAdi
            // 
            this.txtMalzemeAdi.Location = new System.Drawing.Point(144, 24);
            this.txtMalzemeAdi.Name = "txtMalzemeAdi";
            this.txtMalzemeAdi.Size = new System.Drawing.Size(143, 20);
            this.txtMalzemeAdi.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Durum :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Malzeme Adı :";
            // 
            // btnMalzemeSil
            // 
            this.btnMalzemeSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnMalzemeSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMalzemeSil.Location = new System.Drawing.Point(204, 163);
            this.btnMalzemeSil.Name = "btnMalzemeSil";
            this.btnMalzemeSil.Size = new System.Drawing.Size(83, 33);
            this.btnMalzemeSil.TabIndex = 5;
            this.btnMalzemeSil.Text = "SİL";
            this.btnMalzemeSil.UseVisualStyleBackColor = false;
            this.btnMalzemeSil.Click += new System.EventHandler(this.btnMalzemeSil_Click);
            // 
            // btnMalzemeGuncelle
            // 
            this.btnMalzemeGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnMalzemeGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMalzemeGuncelle.Location = new System.Drawing.Point(107, 163);
            this.btnMalzemeGuncelle.Name = "btnMalzemeGuncelle";
            this.btnMalzemeGuncelle.Size = new System.Drawing.Size(91, 33);
            this.btnMalzemeGuncelle.TabIndex = 4;
            this.btnMalzemeGuncelle.Text = "GÜNCELLE";
            this.btnMalzemeGuncelle.UseVisualStyleBackColor = false;
            this.btnMalzemeGuncelle.Click += new System.EventHandler(this.btnMalzemeGuncelle_Click);
            // 
            // btnMalzemeEkle
            // 
            this.btnMalzemeEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnMalzemeEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMalzemeEkle.Location = new System.Drawing.Point(28, 163);
            this.btnMalzemeEkle.Name = "btnMalzemeEkle";
            this.btnMalzemeEkle.Size = new System.Drawing.Size(73, 33);
            this.btnMalzemeEkle.TabIndex = 3;
            this.btnMalzemeEkle.Text = "EKLE";
            this.btnMalzemeEkle.UseVisualStyleBackColor = false;
            this.btnMalzemeEkle.Click += new System.EventHandler(this.btnMalzemeEkle_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.Snow;
            this.tabPage4.Controls.Add(this.txtMalzemeKatArama);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.button2);
            this.tabPage4.Controls.Add(this.btnMalKategoriGetir);
            this.tabPage4.Controls.Add(this.groupBox3);
            this.tabPage4.Controls.Add(this.dataGridViewMalzemeKategori);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(841, 468);
            this.tabPage4.TabIndex = 2;
            this.tabPage4.Text = "MalzemeKategori";
            // 
            // txtMalzemeKatArama
            // 
            this.txtMalzemeKatArama.Location = new System.Drawing.Point(671, 11);
            this.txtMalzemeKatArama.Name = "txtMalzemeKatArama";
            this.txtMalzemeKatArama.Size = new System.Drawing.Size(143, 20);
            this.txtMalzemeKatArama.TabIndex = 17;
            this.txtMalzemeKatArama.TextChanged += new System.EventHandler(this.txtMalzemeKatArama_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(511, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(162, 15);
            this.label10.TabIndex = 16;
            this.label10.Text = "Malzeme Kategorisi Arama :";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button2.Location = new System.Drawing.Point(648, 401);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(171, 30);
            this.button2.TabIndex = 15;
            this.button2.Text = "Geri Dön";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnMalKategoriGetir
            // 
            this.btnMalKategoriGetir.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnMalKategoriGetir.Location = new System.Drawing.Point(648, 263);
            this.btnMalKategoriGetir.Name = "btnMalKategoriGetir";
            this.btnMalKategoriGetir.Size = new System.Drawing.Size(166, 32);
            this.btnMalKategoriGetir.TabIndex = 5;
            this.btnMalKategoriGetir.Text = "Malzeme Kategori Getir";
            this.btnMalKategoriGetir.UseVisualStyleBackColor = false;
            this.btnMalKategoriGetir.Click += new System.EventHandler(this.btnMalKategoriGetir_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnMalKategoriSil);
            this.groupBox3.Controls.Add(this.btnMalKategoriGuncelle);
            this.groupBox3.Controls.Add(this.btnMalKategoriEkle);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtMalKatAdi);
            this.groupBox3.Location = new System.Drawing.Point(21, 263);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(323, 168);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "MalzemeKategori";
            // 
            // btnMalKategoriSil
            // 
            this.btnMalKategoriSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnMalKategoriSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMalKategoriSil.Location = new System.Drawing.Point(198, 102);
            this.btnMalKategoriSil.Name = "btnMalKategoriSil";
            this.btnMalKategoriSil.Size = new System.Drawing.Size(91, 31);
            this.btnMalKategoriSil.TabIndex = 4;
            this.btnMalKategoriSil.Text = "SİL";
            this.btnMalKategoriSil.UseVisualStyleBackColor = false;
            this.btnMalKategoriSil.Click += new System.EventHandler(this.btnMalKategoriSil_Click);
            // 
            // btnMalKategoriGuncelle
            // 
            this.btnMalKategoriGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnMalKategoriGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMalKategoriGuncelle.Location = new System.Drawing.Point(100, 102);
            this.btnMalKategoriGuncelle.Name = "btnMalKategoriGuncelle";
            this.btnMalKategoriGuncelle.Size = new System.Drawing.Size(92, 31);
            this.btnMalKategoriGuncelle.TabIndex = 3;
            this.btnMalKategoriGuncelle.Text = "GÜNCELLE";
            this.btnMalKategoriGuncelle.UseVisualStyleBackColor = false;
            this.btnMalKategoriGuncelle.Click += new System.EventHandler(this.btnMalKategoriGuncelle_Click);
            // 
            // btnMalKategoriEkle
            // 
            this.btnMalKategoriEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnMalKategoriEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMalKategoriEkle.Location = new System.Drawing.Point(19, 102);
            this.btnMalKategoriEkle.Name = "btnMalKategoriEkle";
            this.btnMalKategoriEkle.Size = new System.Drawing.Size(75, 31);
            this.btnMalKategoriEkle.TabIndex = 2;
            this.btnMalKategoriEkle.Text = "EKLE";
            this.btnMalKategoriEkle.UseVisualStyleBackColor = false;
            this.btnMalKategoriEkle.Click += new System.EventHandler(this.btnMalKategoriEkle_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Malzeme Kategori Adı :";
            // 
            // txtMalKatAdi
            // 
            this.txtMalKatAdi.Location = new System.Drawing.Point(139, 43);
            this.txtMalKatAdi.Name = "txtMalKatAdi";
            this.txtMalKatAdi.Size = new System.Drawing.Size(150, 20);
            this.txtMalKatAdi.TabIndex = 0;
            // 
            // dataGridViewMalzemeKategori
            // 
            this.dataGridViewMalzemeKategori.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridViewMalzemeKategori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMalzemeKategori.Location = new System.Drawing.Point(17, 46);
            this.dataGridViewMalzemeKategori.Name = "dataGridViewMalzemeKategori";
            this.dataGridViewMalzemeKategori.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMalzemeKategori.Size = new System.Drawing.Size(797, 196);
            this.dataGridViewMalzemeKategori.TabIndex = 0;
            this.dataGridViewMalzemeKategori.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMalzemeKategori_CellDoubleClick);
            // 
            // FormDepoMalzeme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(891, 519);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormDepoMalzeme";
            this.Text = "FormDepoMalzeme";
            this.Load += new System.EventHandler(this.FormDepoMalzeme_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMalzeme)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMalzemeKategori)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridViewDepo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDepoGetir;
        private System.Windows.Forms.TextBox txtDepoAdres;
        private System.Windows.Forms.TextBox txtDepoAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDepoSil;
        private System.Windows.Forms.Button btnDepoGuncelle;
        private System.Windows.Forms.Button btnDepoEkle;
        private System.Windows.Forms.Button btnMalzemeGetir;
        private System.Windows.Forms.DataGridView dataGridViewMalzeme;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkboxMalDurum;
        private System.Windows.Forms.TextBox txtMalKatId;
        private System.Windows.Forms.TextBox txtMalzemeAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnMalzemeSil;
        private System.Windows.Forms.Button btnMalzemeGuncelle;
        private System.Windows.Forms.Button btnMalzemeEkle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMalTedId;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnMalKategoriGetir;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnMalKategoriSil;
        private System.Windows.Forms.Button btnMalKategoriGuncelle;
        private System.Windows.Forms.Button btnMalKategoriEkle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMalKatAdi;
        private System.Windows.Forms.DataGridView dataGridViewMalzemeKategori;
        private System.Windows.Forms.TextBox txtDepoArama;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button BtnGeri;
        private System.Windows.Forms.TextBox txtMalzemeAdiAra;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtMalzemeKatArama;
        private System.Windows.Forms.Label label10;
    }
}