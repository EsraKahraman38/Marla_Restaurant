
namespace WinUI
{
    partial class FormMusteriSiparis
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
            this.btnMusteriGetir = new System.Windows.Forms.Button();
            this.groupbox1 = new System.Windows.Forms.GroupBox();
            this.btnMusteriSil = new System.Windows.Forms.Button();
            this.btnMusteriGuncelle = new System.Windows.Forms.Button();
            this.btnMusteriEkle = new System.Windows.Forms.Button();
            this.txtMusteriTel = new System.Windows.Forms.TextBox();
            this.txtMusteriAdres = new System.Windows.Forms.TextBox();
            this.txtMusteriSoyadi = new System.Windows.Forms.TextBox();
            this.txtMusteriAdi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewMusteri = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.BtnSipGeri = new System.Windows.Forms.Button();
            this.btnSiparisGetir = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chSipTuru = new System.Windows.Forms.CheckBox();
            this.dtTeslim = new System.Windows.Forms.DateTimePicker();
            this.dtSiparis = new System.Windows.Forms.DateTimePicker();
            this.txtSiparisCalisanId = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSiparisMusteriId = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSiparisGuncelle = new System.Windows.Forms.Button();
            this.btnSiparisEkle = new System.Windows.Forms.Button();
            this.txtSiparisMasaNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridViewSiparis = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.txtMusteriAdiAra = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupbox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMusteri)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSiparis)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(834, 541);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Snow;
            this.tabPage1.Controls.Add(this.BtnGeri);
            this.tabPage1.Controls.Add(this.txtMusteriAdiAra);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.btnMusteriGetir);
            this.tabPage1.Controls.Add(this.groupbox1);
            this.tabPage1.Controls.Add(this.dataGridViewMusteri);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(826, 515);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Musteri";
            // 
            // BtnGeri
            // 
            this.BtnGeri.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BtnGeri.Location = new System.Drawing.Point(626, 447);
            this.BtnGeri.Name = "BtnGeri";
            this.BtnGeri.Size = new System.Drawing.Size(185, 34);
            this.BtnGeri.TabIndex = 18;
            this.BtnGeri.Text = "Geri Dön";
            this.BtnGeri.UseVisualStyleBackColor = false;
            this.BtnGeri.Click += new System.EventHandler(this.BtnGeri_Click);
            // 
            // btnMusteriGetir
            // 
            this.btnMusteriGetir.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnMusteriGetir.Location = new System.Drawing.Point(626, 260);
            this.btnMusteriGetir.Name = "btnMusteriGetir";
            this.btnMusteriGetir.Size = new System.Drawing.Size(185, 34);
            this.btnMusteriGetir.TabIndex = 1;
            this.btnMusteriGetir.Text = "Müsterileri Getir";
            this.btnMusteriGetir.UseVisualStyleBackColor = false;
            this.btnMusteriGetir.Click += new System.EventHandler(this.btnMusteriGetir_Click);
            // 
            // groupbox1
            // 
            this.groupbox1.Controls.Add(this.btnMusteriSil);
            this.groupbox1.Controls.Add(this.btnMusteriGuncelle);
            this.groupbox1.Controls.Add(this.btnMusteriEkle);
            this.groupbox1.Controls.Add(this.txtMusteriTel);
            this.groupbox1.Controls.Add(this.txtMusteriAdres);
            this.groupbox1.Controls.Add(this.txtMusteriSoyadi);
            this.groupbox1.Controls.Add(this.txtMusteriAdi);
            this.groupbox1.Controls.Add(this.label4);
            this.groupbox1.Controls.Add(this.label3);
            this.groupbox1.Controls.Add(this.label2);
            this.groupbox1.Controls.Add(this.label1);
            this.groupbox1.Location = new System.Drawing.Point(16, 260);
            this.groupbox1.Name = "groupbox1";
            this.groupbox1.Size = new System.Drawing.Size(330, 221);
            this.groupbox1.TabIndex = 1;
            this.groupbox1.TabStop = false;
            this.groupbox1.Text = "Musteri";
            // 
            // btnMusteriSil
            // 
            this.btnMusteriSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnMusteriSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusteriSil.Location = new System.Drawing.Point(221, 164);
            this.btnMusteriSil.Name = "btnMusteriSil";
            this.btnMusteriSil.Size = new System.Drawing.Size(75, 34);
            this.btnMusteriSil.TabIndex = 10;
            this.btnMusteriSil.Text = "SİL";
            this.btnMusteriSil.UseVisualStyleBackColor = false;
            this.btnMusteriSil.Click += new System.EventHandler(this.btnMusteriSil_Click);
            // 
            // btnMusteriGuncelle
            // 
            this.btnMusteriGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnMusteriGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusteriGuncelle.Location = new System.Drawing.Point(100, 164);
            this.btnMusteriGuncelle.Name = "btnMusteriGuncelle";
            this.btnMusteriGuncelle.Size = new System.Drawing.Size(110, 34);
            this.btnMusteriGuncelle.TabIndex = 9;
            this.btnMusteriGuncelle.Text = "GUNCELLE";
            this.btnMusteriGuncelle.UseVisualStyleBackColor = false;
            this.btnMusteriGuncelle.Click += new System.EventHandler(this.btnMusteriGuncelle_Click);
            // 
            // btnMusteriEkle
            // 
            this.btnMusteriEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnMusteriEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusteriEkle.Location = new System.Drawing.Point(17, 164);
            this.btnMusteriEkle.Name = "btnMusteriEkle";
            this.btnMusteriEkle.Size = new System.Drawing.Size(75, 34);
            this.btnMusteriEkle.TabIndex = 8;
            this.btnMusteriEkle.Text = "EKLE";
            this.btnMusteriEkle.UseVisualStyleBackColor = false;
            this.btnMusteriEkle.Click += new System.EventHandler(this.btnMusteriEkle_Click);
            // 
            // txtMusteriTel
            // 
            this.txtMusteriTel.Location = new System.Drawing.Point(117, 118);
            this.txtMusteriTel.Name = "txtMusteriTel";
            this.txtMusteriTel.Size = new System.Drawing.Size(179, 20);
            this.txtMusteriTel.TabIndex = 7;
            // 
            // txtMusteriAdres
            // 
            this.txtMusteriAdres.Location = new System.Drawing.Point(117, 88);
            this.txtMusteriAdres.Name = "txtMusteriAdres";
            this.txtMusteriAdres.Size = new System.Drawing.Size(179, 20);
            this.txtMusteriAdres.TabIndex = 5;
            // 
            // txtMusteriSoyadi
            // 
            this.txtMusteriSoyadi.Location = new System.Drawing.Point(117, 56);
            this.txtMusteriSoyadi.Name = "txtMusteriSoyadi";
            this.txtMusteriSoyadi.Size = new System.Drawing.Size(179, 20);
            this.txtMusteriSoyadi.TabIndex = 3;
            // 
            // txtMusteriAdi
            // 
            this.txtMusteriAdi.Location = new System.Drawing.Point(117, 26);
            this.txtMusteriAdi.Name = "txtMusteriAdi";
            this.txtMusteriAdi.Size = new System.Drawing.Size(179, 20);
            this.txtMusteriAdi.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Telefon Numarası :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Adres :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Müsteri Soyadı :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Müşteri Adı :";
            // 
            // dataGridViewMusteri
            // 
            this.dataGridViewMusteri.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridViewMusteri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMusteri.Location = new System.Drawing.Point(16, 44);
            this.dataGridViewMusteri.Name = "dataGridViewMusteri";
            this.dataGridViewMusteri.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMusteri.Size = new System.Drawing.Size(795, 200);
            this.dataGridViewMusteri.TabIndex = 0;
            this.dataGridViewMusteri.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMusteri_CellDoubleClick);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Snow;
            this.tabPage2.Controls.Add(this.BtnSipGeri);
            this.tabPage2.Controls.Add(this.btnSiparisGetir);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.dataGridViewSiparis);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(826, 515);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Siparis";
            // 
            // BtnSipGeri
            // 
            this.BtnSipGeri.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BtnSipGeri.Location = new System.Drawing.Point(637, 451);
            this.BtnSipGeri.Name = "BtnSipGeri";
            this.BtnSipGeri.Size = new System.Drawing.Size(170, 34);
            this.BtnSipGeri.TabIndex = 19;
            this.BtnSipGeri.Text = "Geri Dön";
            this.BtnSipGeri.UseVisualStyleBackColor = false;
            this.BtnSipGeri.Click += new System.EventHandler(this.BtnSipGeri_Click);
            // 
            // btnSiparisGetir
            // 
            this.btnSiparisGetir.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSiparisGetir.Location = new System.Drawing.Point(637, 255);
            this.btnSiparisGetir.Name = "btnSiparisGetir";
            this.btnSiparisGetir.Size = new System.Drawing.Size(170, 34);
            this.btnSiparisGetir.TabIndex = 12;
            this.btnSiparisGetir.Text = "Siparişleri Getir";
            this.btnSiparisGetir.UseVisualStyleBackColor = false;
            this.btnSiparisGetir.Click += new System.EventHandler(this.btnSiparisGetir_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chSipTuru);
            this.groupBox2.Controls.Add(this.dtTeslim);
            this.groupBox2.Controls.Add(this.dtSiparis);
            this.groupBox2.Controls.Add(this.txtSiparisCalisanId);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtSiparisMusteriId);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.btnSiparisGuncelle);
            this.groupBox2.Controls.Add(this.btnSiparisEkle);
            this.groupBox2.Controls.Add(this.txtSiparisMasaNo);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(15, 255);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(362, 246);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Siparis";
            // 
            // chSipTuru
            // 
            this.chSipTuru.AutoSize = true;
            this.chSipTuru.Location = new System.Drawing.Point(135, 78);
            this.chSipTuru.Name = "chSipTuru";
            this.chSipTuru.Size = new System.Drawing.Size(57, 17);
            this.chSipTuru.TabIndex = 17;
            this.chSipTuru.Text = "Durum";
            this.chSipTuru.UseVisualStyleBackColor = true;
            // 
            // dtTeslim
            // 
            this.dtTeslim.Location = new System.Drawing.Point(135, 50);
            this.dtTeslim.Name = "dtTeslim";
            this.dtTeslim.Size = new System.Drawing.Size(174, 20);
            this.dtTeslim.TabIndex = 16;
            // 
            // dtSiparis
            // 
            this.dtSiparis.Location = new System.Drawing.Point(135, 20);
            this.dtSiparis.Name = "dtSiparis";
            this.dtSiparis.Size = new System.Drawing.Size(174, 20);
            this.dtSiparis.TabIndex = 15;
            // 
            // txtSiparisCalisanId
            // 
            this.txtSiparisCalisanId.Location = new System.Drawing.Point(135, 160);
            this.txtSiparisCalisanId.Name = "txtSiparisCalisanId";
            this.txtSiparisCalisanId.Size = new System.Drawing.Size(174, 20);
            this.txtSiparisCalisanId.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(31, 163);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "CalisanId :";
            // 
            // txtSiparisMusteriId
            // 
            this.txtSiparisMusteriId.Location = new System.Drawing.Point(135, 129);
            this.txtSiparisMusteriId.Name = "txtSiparisMusteriId";
            this.txtSiparisMusteriId.Size = new System.Drawing.Size(174, 20);
            this.txtSiparisMusteriId.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "MusteriId :";
            // 
            // btnSiparisGuncelle
            // 
            this.btnSiparisGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSiparisGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSiparisGuncelle.Location = new System.Drawing.Point(179, 196);
            this.btnSiparisGuncelle.Name = "btnSiparisGuncelle";
            this.btnSiparisGuncelle.Size = new System.Drawing.Size(130, 35);
            this.btnSiparisGuncelle.TabIndex = 9;
            this.btnSiparisGuncelle.Text = "GUNCELLE";
            this.btnSiparisGuncelle.UseVisualStyleBackColor = false;
            this.btnSiparisGuncelle.Click += new System.EventHandler(this.btnSiparisGuncelle_Click);
            // 
            // btnSiparisEkle
            // 
            this.btnSiparisEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSiparisEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSiparisEkle.Location = new System.Drawing.Point(34, 195);
            this.btnSiparisEkle.Name = "btnSiparisEkle";
            this.btnSiparisEkle.Size = new System.Drawing.Size(119, 35);
            this.btnSiparisEkle.TabIndex = 8;
            this.btnSiparisEkle.Text = "EKLE";
            this.btnSiparisEkle.UseVisualStyleBackColor = false;
            this.btnSiparisEkle.Click += new System.EventHandler(this.btnSiparisEkle_Click);
            // 
            // txtSiparisMasaNo
            // 
            this.txtSiparisMasaNo.Location = new System.Drawing.Point(135, 101);
            this.txtSiparisMasaNo.Name = "txtSiparisMasaNo";
            this.txtSiparisMasaNo.Size = new System.Drawing.Size(174, 20);
            this.txtSiparisMasaNo.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Masa Numarası :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Siparis Türü :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Teslim Tarihi :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Siparis Tarihi :";
            // 
            // dataGridViewSiparis
            // 
            this.dataGridViewSiparis.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridViewSiparis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSiparis.Location = new System.Drawing.Point(15, 17);
            this.dataGridViewSiparis.Name = "dataGridViewSiparis";
            this.dataGridViewSiparis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSiparis.Size = new System.Drawing.Size(792, 224);
            this.dataGridViewSiparis.TabIndex = 10;
            this.dataGridViewSiparis.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSiparis_CellDoubleClick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(555, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 15);
            this.label11.TabIndex = 16;
            this.label11.Text = "Müşteri Adı Arama :";
            // 
            // txtMusteriAdiAra
            // 
            this.txtMusteriAdiAra.Location = new System.Drawing.Point(668, 11);
            this.txtMusteriAdiAra.Name = "txtMusteriAdiAra";
            this.txtMusteriAdiAra.Size = new System.Drawing.Size(143, 20);
            this.txtMusteriAdiAra.TabIndex = 17;
            this.txtMusteriAdiAra.TextChanged += new System.EventHandler(this.txtMusteriAdiAra_TextChanged);
            // 
            // FormMusteriSiparis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 545);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormMusteriSiparis";
            this.Text = "FormMusteriSiparis";
            this.Load += new System.EventHandler(this.FormMusteriSiparis_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupbox1.ResumeLayout(false);
            this.groupbox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMusteri)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSiparis)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridViewMusteri;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnMusteriGetir;
        private System.Windows.Forms.GroupBox groupbox1;
        private System.Windows.Forms.Button btnMusteriSil;
        private System.Windows.Forms.Button btnMusteriGuncelle;
        private System.Windows.Forms.Button btnMusteriEkle;
        private System.Windows.Forms.TextBox txtMusteriTel;
        private System.Windows.Forms.TextBox txtMusteriAdres;
        private System.Windows.Forms.TextBox txtMusteriSoyadi;
        private System.Windows.Forms.TextBox txtMusteriAdi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSiparisGetir;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSiparisGuncelle;
        private System.Windows.Forms.Button btnSiparisEkle;
        private System.Windows.Forms.TextBox txtSiparisMasaNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridViewSiparis;
        private System.Windows.Forms.CheckBox chSipTuru;
        private System.Windows.Forms.DateTimePicker dtTeslim;
        private System.Windows.Forms.DateTimePicker dtSiparis;
        private System.Windows.Forms.TextBox txtSiparisCalisanId;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSiparisMusteriId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button BtnGeri;
        private System.Windows.Forms.Button BtnSipGeri;
        private System.Windows.Forms.TextBox txtMusteriAdiAra;
        private System.Windows.Forms.Label label11;
    }
}