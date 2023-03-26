
namespace WinUI
{
    partial class FormDetaylar
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
            this.btnUMGetir = new System.Windows.Forms.Button();
            this.dataGridViewUrunMalzemeDetay = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.BtnDepMalzDetGeri = new System.Windows.Forms.Button();
            this.DepoMalDetGetir = new System.Windows.Forms.Button();
            this.dataGridViewDepoMalzemeDetay = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.BtnRestMalzDetGeri = new System.Windows.Forms.Button();
            this.BtnRestMalzDetGetir = new System.Windows.Forms.Button();
            this.dataGridViewRestMalzDet = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.BtnUrunSipDetGeri = new System.Windows.Forms.Button();
            this.BtnUrunSipDetGetir = new System.Windows.Forms.Button();
            this.dataGridViewUrunSiparisDetay = new System.Windows.Forms.DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.BtnAdisSipDetGetir = new System.Windows.Forms.Button();
            this.btnASDGetir = new System.Windows.Forms.Button();
            this.dataGridViewAdisyonSiparisDetay = new System.Windows.Forms.DataGridView();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.BtnAdisOdDetGetir = new System.Windows.Forms.Button();
            this.btnAdisyonOdemeDetayGetir = new System.Windows.Forms.Button();
            this.dataGridViewAdisyonOdemeDetay = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUrunMalzemeDetay)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepoMalzemeDetay)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRestMalzDet)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUrunSiparisDetay)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdisyonSiparisDetay)).BeginInit();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdisyonOdemeDetay)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(927, 509);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Snow;
            this.tabPage1.Controls.Add(this.BtnGeri);
            this.tabPage1.Controls.Add(this.btnUMGetir);
            this.tabPage1.Controls.Add(this.dataGridViewUrunMalzemeDetay);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(919, 483);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "UrunMalzemeDetay";
            // 
            // BtnGeri
            // 
            this.BtnGeri.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BtnGeri.Location = new System.Drawing.Point(716, 429);
            this.BtnGeri.Name = "BtnGeri";
            this.BtnGeri.Size = new System.Drawing.Size(183, 32);
            this.BtnGeri.TabIndex = 3;
            this.BtnGeri.Text = "Geri Dön";
            this.BtnGeri.UseVisualStyleBackColor = false;
            this.BtnGeri.Click += new System.EventHandler(this.BtnGeri_Click);
            // 
            // btnUMGetir
            // 
            this.btnUMGetir.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnUMGetir.Location = new System.Drawing.Point(716, 330);
            this.btnUMGetir.Name = "btnUMGetir";
            this.btnUMGetir.Size = new System.Drawing.Size(183, 34);
            this.btnUMGetir.TabIndex = 2;
            this.btnUMGetir.Text = "Urun Malzeme Detaylarını Getir";
            this.btnUMGetir.UseVisualStyleBackColor = false;
            this.btnUMGetir.Click += new System.EventHandler(this.btnUMGetir_Click);
            // 
            // dataGridViewUrunMalzemeDetay
            // 
            this.dataGridViewUrunMalzemeDetay.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridViewUrunMalzemeDetay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUrunMalzemeDetay.Location = new System.Drawing.Point(17, 15);
            this.dataGridViewUrunMalzemeDetay.Name = "dataGridViewUrunMalzemeDetay";
            this.dataGridViewUrunMalzemeDetay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUrunMalzemeDetay.Size = new System.Drawing.Size(882, 295);
            this.dataGridViewUrunMalzemeDetay.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Snow;
            this.tabPage2.Controls.Add(this.BtnDepMalzDetGeri);
            this.tabPage2.Controls.Add(this.DepoMalDetGetir);
            this.tabPage2.Controls.Add(this.dataGridViewDepoMalzemeDetay);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(919, 483);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "DepoMalzemeDetay";
            // 
            // BtnDepMalzDetGeri
            // 
            this.BtnDepMalzDetGeri.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BtnDepMalzDetGeri.Location = new System.Drawing.Point(715, 426);
            this.BtnDepMalzDetGeri.Name = "BtnDepMalzDetGeri";
            this.BtnDepMalzDetGeri.Size = new System.Drawing.Size(183, 32);
            this.BtnDepMalzDetGeri.TabIndex = 6;
            this.BtnDepMalzDetGeri.Text = "Geri Dön";
            this.BtnDepMalzDetGeri.UseVisualStyleBackColor = false;
            this.BtnDepMalzDetGeri.Click += new System.EventHandler(this.BtnDepMalzDetGeri_Click);
            // 
            // DepoMalDetGetir
            // 
            this.DepoMalDetGetir.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.DepoMalDetGetir.Location = new System.Drawing.Point(715, 310);
            this.DepoMalDetGetir.Name = "DepoMalDetGetir";
            this.DepoMalDetGetir.Size = new System.Drawing.Size(183, 34);
            this.DepoMalDetGetir.TabIndex = 5;
            this.DepoMalDetGetir.Text = "Depo Malzeme Detay Getir";
            this.DepoMalDetGetir.UseVisualStyleBackColor = false;
            this.DepoMalDetGetir.Click += new System.EventHandler(this.DepoMalDetGetir_Click);
            // 
            // dataGridViewDepoMalzemeDetay
            // 
            this.dataGridViewDepoMalzemeDetay.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridViewDepoMalzemeDetay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDepoMalzemeDetay.Location = new System.Drawing.Point(18, 16);
            this.dataGridViewDepoMalzemeDetay.Name = "dataGridViewDepoMalzemeDetay";
            this.dataGridViewDepoMalzemeDetay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDepoMalzemeDetay.Size = new System.Drawing.Size(880, 275);
            this.dataGridViewDepoMalzemeDetay.TabIndex = 3;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Snow;
            this.tabPage3.Controls.Add(this.BtnRestMalzDetGeri);
            this.tabPage3.Controls.Add(this.BtnRestMalzDetGetir);
            this.tabPage3.Controls.Add(this.dataGridViewRestMalzDet);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(919, 483);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "RestaurantMalzemeDetay";
            // 
            // BtnRestMalzDetGeri
            // 
            this.BtnRestMalzDetGeri.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BtnRestMalzDetGeri.Location = new System.Drawing.Point(718, 434);
            this.BtnRestMalzDetGeri.Name = "BtnRestMalzDetGeri";
            this.BtnRestMalzDetGeri.Size = new System.Drawing.Size(183, 32);
            this.BtnRestMalzDetGeri.TabIndex = 11;
            this.BtnRestMalzDetGeri.Text = "Geri Dön";
            this.BtnRestMalzDetGeri.UseVisualStyleBackColor = false;
            this.BtnRestMalzDetGeri.Click += new System.EventHandler(this.BtnRestMalzDetGeri_Click);
            // 
            // BtnRestMalzDetGetir
            // 
            this.BtnRestMalzDetGetir.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BtnRestMalzDetGetir.Location = new System.Drawing.Point(704, 294);
            this.BtnRestMalzDetGetir.Name = "BtnRestMalzDetGetir";
            this.BtnRestMalzDetGetir.Size = new System.Drawing.Size(197, 30);
            this.BtnRestMalzDetGetir.TabIndex = 9;
            this.BtnRestMalzDetGetir.Text = "Restaurant Malzemelerini Getir";
            this.BtnRestMalzDetGetir.UseVisualStyleBackColor = false;
            this.BtnRestMalzDetGetir.Click += new System.EventHandler(this.BtnRestMalzDetGetir_Click);
            // 
            // dataGridViewRestMalzDet
            // 
            this.dataGridViewRestMalzDet.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridViewRestMalzDet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRestMalzDet.Location = new System.Drawing.Point(19, 15);
            this.dataGridViewRestMalzDet.Name = "dataGridViewRestMalzDet";
            this.dataGridViewRestMalzDet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRestMalzDet.Size = new System.Drawing.Size(882, 266);
            this.dataGridViewRestMalzDet.TabIndex = 6;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.Snow;
            this.tabPage4.Controls.Add(this.BtnUrunSipDetGeri);
            this.tabPage4.Controls.Add(this.BtnUrunSipDetGetir);
            this.tabPage4.Controls.Add(this.dataGridViewUrunSiparisDetay);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(919, 483);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "UrunSiparisDetay";
            // 
            // BtnUrunSipDetGeri
            // 
            this.BtnUrunSipDetGeri.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BtnUrunSipDetGeri.Location = new System.Drawing.Point(712, 427);
            this.BtnUrunSipDetGeri.Name = "BtnUrunSipDetGeri";
            this.BtnUrunSipDetGeri.Size = new System.Drawing.Size(192, 32);
            this.BtnUrunSipDetGeri.TabIndex = 12;
            this.BtnUrunSipDetGeri.Text = "Geri Dön";
            this.BtnUrunSipDetGeri.UseVisualStyleBackColor = false;
            this.BtnUrunSipDetGeri.Click += new System.EventHandler(this.BtnUrunSipDetGeri_Click);
            // 
            // BtnUrunSipDetGetir
            // 
            this.BtnUrunSipDetGetir.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BtnUrunSipDetGetir.Location = new System.Drawing.Point(712, 294);
            this.BtnUrunSipDetGetir.Name = "BtnUrunSipDetGetir";
            this.BtnUrunSipDetGetir.Size = new System.Drawing.Size(192, 34);
            this.BtnUrunSipDetGetir.TabIndex = 8;
            this.BtnUrunSipDetGetir.Text = "Ürün Sipariş Detaylarını Getir";
            this.BtnUrunSipDetGetir.UseVisualStyleBackColor = false;
            this.BtnUrunSipDetGetir.Click += new System.EventHandler(this.BtnUrunSipDetGetir_Click);
            // 
            // dataGridViewUrunSiparisDetay
            // 
            this.dataGridViewUrunSiparisDetay.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridViewUrunSiparisDetay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUrunSiparisDetay.Location = new System.Drawing.Point(13, 16);
            this.dataGridViewUrunSiparisDetay.Name = "dataGridViewUrunSiparisDetay";
            this.dataGridViewUrunSiparisDetay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUrunSiparisDetay.Size = new System.Drawing.Size(891, 259);
            this.dataGridViewUrunSiparisDetay.TabIndex = 6;
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.Snow;
            this.tabPage5.Controls.Add(this.BtnAdisSipDetGetir);
            this.tabPage5.Controls.Add(this.btnASDGetir);
            this.tabPage5.Controls.Add(this.dataGridViewAdisyonSiparisDetay);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(919, 483);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "AdisyonSiparisDetay";
            // 
            // BtnAdisSipDetGetir
            // 
            this.BtnAdisSipDetGetir.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BtnAdisSipDetGetir.Location = new System.Drawing.Point(711, 424);
            this.BtnAdisSipDetGetir.Name = "BtnAdisSipDetGetir";
            this.BtnAdisSipDetGetir.Size = new System.Drawing.Size(190, 32);
            this.BtnAdisSipDetGetir.TabIndex = 13;
            this.BtnAdisSipDetGetir.Text = "Geri Dön";
            this.BtnAdisSipDetGetir.UseVisualStyleBackColor = false;
            this.BtnAdisSipDetGetir.Click += new System.EventHandler(this.BtnAdisSipDetGetir_Click);
            // 
            // btnASDGetir
            // 
            this.btnASDGetir.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnASDGetir.Location = new System.Drawing.Point(711, 304);
            this.btnASDGetir.Name = "btnASDGetir";
            this.btnASDGetir.Size = new System.Drawing.Size(190, 32);
            this.btnASDGetir.TabIndex = 8;
            this.btnASDGetir.Text = "Adisyon Siparis Detay Getir";
            this.btnASDGetir.UseVisualStyleBackColor = false;
            this.btnASDGetir.Click += new System.EventHandler(this.btnASDGetir_Click);
            // 
            // dataGridViewAdisyonSiparisDetay
            // 
            this.dataGridViewAdisyonSiparisDetay.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridViewAdisyonSiparisDetay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAdisyonSiparisDetay.Location = new System.Drawing.Point(15, 19);
            this.dataGridViewAdisyonSiparisDetay.Name = "dataGridViewAdisyonSiparisDetay";
            this.dataGridViewAdisyonSiparisDetay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAdisyonSiparisDetay.Size = new System.Drawing.Size(886, 265);
            this.dataGridViewAdisyonSiparisDetay.TabIndex = 6;
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.Color.Snow;
            this.tabPage6.Controls.Add(this.BtnAdisOdDetGetir);
            this.tabPage6.Controls.Add(this.btnAdisyonOdemeDetayGetir);
            this.tabPage6.Controls.Add(this.dataGridViewAdisyonOdemeDetay);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(919, 483);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "AdisyonOdemeDetay";
            // 
            // BtnAdisOdDetGetir
            // 
            this.BtnAdisOdDetGetir.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BtnAdisOdDetGetir.Location = new System.Drawing.Point(695, 421);
            this.BtnAdisOdDetGetir.Name = "BtnAdisOdDetGetir";
            this.BtnAdisOdDetGetir.Size = new System.Drawing.Size(204, 32);
            this.BtnAdisOdDetGetir.TabIndex = 14;
            this.BtnAdisOdDetGetir.Text = "Geri Dön";
            this.BtnAdisOdDetGetir.UseVisualStyleBackColor = false;
            this.BtnAdisOdDetGetir.Click += new System.EventHandler(this.BtnAdisOdDetGetir_Click);
            // 
            // btnAdisyonOdemeDetayGetir
            // 
            this.btnAdisyonOdemeDetayGetir.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAdisyonOdemeDetayGetir.Location = new System.Drawing.Point(695, 296);
            this.btnAdisyonOdemeDetayGetir.Name = "btnAdisyonOdemeDetayGetir";
            this.btnAdisyonOdemeDetayGetir.Size = new System.Drawing.Size(204, 32);
            this.btnAdisyonOdemeDetayGetir.TabIndex = 11;
            this.btnAdisyonOdemeDetayGetir.Text = "Adisyon Ödeme Detay Getir";
            this.btnAdisyonOdemeDetayGetir.UseVisualStyleBackColor = false;
            this.btnAdisyonOdemeDetayGetir.Click += new System.EventHandler(this.btnAdisyonOdemeDetayGetir_Click);
            // 
            // dataGridViewAdisyonOdemeDetay
            // 
            this.dataGridViewAdisyonOdemeDetay.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridViewAdisyonOdemeDetay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAdisyonOdemeDetay.Location = new System.Drawing.Point(19, 18);
            this.dataGridViewAdisyonOdemeDetay.Name = "dataGridViewAdisyonOdemeDetay";
            this.dataGridViewAdisyonOdemeDetay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAdisyonOdemeDetay.Size = new System.Drawing.Size(880, 260);
            this.dataGridViewAdisyonOdemeDetay.TabIndex = 9;
            // 
            // FormDetaylar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 533);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormDetaylar";
            this.Text = "FormDetaylar";
            this.Load += new System.EventHandler(this.FormDetaylar_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUrunMalzemeDetay)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepoMalzemeDetay)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRestMalzDet)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUrunSiparisDetay)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdisyonSiparisDetay)).EndInit();
            this.tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdisyonOdemeDetay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridViewUrunMalzemeDetay;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnUMGetir;
        private System.Windows.Forms.Button DepoMalDetGetir;
        private System.Windows.Forms.DataGridView dataGridViewDepoMalzemeDetay;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridViewRestMalzDet;
        private System.Windows.Forms.Button BtnRestMalzDetGetir;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button BtnUrunSipDetGetir;
        private System.Windows.Forms.DataGridView dataGridViewUrunSiparisDetay;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Button btnASDGetir;
        private System.Windows.Forms.DataGridView dataGridViewAdisyonSiparisDetay;
        private System.Windows.Forms.Button btnAdisyonOdemeDetayGetir;
        private System.Windows.Forms.DataGridView dataGridViewAdisyonOdemeDetay;
        private System.Windows.Forms.Button BtnGeri;
        private System.Windows.Forms.Button BtnDepMalzDetGeri;
        private System.Windows.Forms.Button BtnRestMalzDetGeri;
        private System.Windows.Forms.Button BtnUrunSipDetGeri;
        private System.Windows.Forms.Button BtnAdisSipDetGetir;
        private System.Windows.Forms.Button BtnAdisOdDetGetir;
    }
}