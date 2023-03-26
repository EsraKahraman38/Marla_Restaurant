
namespace WinUI
{
    partial class FormAdisyonOdeme
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
            this.btnAdisyonGetir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdisyonSil = new System.Windows.Forms.Button();
            this.btnAdisyonGuncelle = new System.Windows.Forms.Button();
            this.btnAdisyonEkle = new System.Windows.Forms.Button();
            this.dataGridViewAdisyon = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.BtnOdeGeri = new System.Windows.Forms.Button();
            this.btnOdemeYontGetir = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtOdemeYontemiAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOdemeYontSil = new System.Windows.Forms.Button();
            this.btnOdemeYontGuncelle = new System.Windows.Forms.Button();
            this.btnOdemeYontEkle = new System.Windows.Forms.Button();
            this.dataGridViewOdeme = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdisyon)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOdeme)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(915, 510);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Snow;
            this.tabPage1.Controls.Add(this.BtnGeri);
            this.tabPage1.Controls.Add(this.btnAdisyonGetir);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.dataGridViewAdisyon);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(907, 484);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Adisyon";
            // 
            // BtnGeri
            // 
            this.BtnGeri.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BtnGeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGeri.Location = new System.Drawing.Point(718, 421);
            this.BtnGeri.Name = "BtnGeri";
            this.BtnGeri.Size = new System.Drawing.Size(167, 31);
            this.BtnGeri.TabIndex = 6;
            this.BtnGeri.Text = "Geri Dön";
            this.BtnGeri.UseVisualStyleBackColor = false;
            this.BtnGeri.Click += new System.EventHandler(this.BtnGeri_Click);
            // 
            // btnAdisyonGetir
            // 
            this.btnAdisyonGetir.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAdisyonGetir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdisyonGetir.Location = new System.Drawing.Point(718, 271);
            this.btnAdisyonGetir.Name = "btnAdisyonGetir";
            this.btnAdisyonGetir.Size = new System.Drawing.Size(167, 33);
            this.btnAdisyonGetir.TabIndex = 2;
            this.btnAdisyonGetir.Text = "Adisyonları Getir";
            this.btnAdisyonGetir.UseVisualStyleBackColor = false;
            this.btnAdisyonGetir.Click += new System.EventHandler(this.btnAdisyonGetir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Snow;
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnAdisyonSil);
            this.groupBox1.Controls.Add(this.btnAdisyonGuncelle);
            this.groupBox1.Controls.Add(this.btnAdisyonEkle);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(19, 302);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 150);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adisyon";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(84, 43);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(197, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tarih :";
            // 
            // btnAdisyonSil
            // 
            this.btnAdisyonSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAdisyonSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnAdisyonSil.Location = new System.Drawing.Point(210, 91);
            this.btnAdisyonSil.Name = "btnAdisyonSil";
            this.btnAdisyonSil.Size = new System.Drawing.Size(98, 34);
            this.btnAdisyonSil.TabIndex = 2;
            this.btnAdisyonSil.Text = "SİL";
            this.btnAdisyonSil.UseVisualStyleBackColor = false;
            this.btnAdisyonSil.Click += new System.EventHandler(this.btnAdisyonSil_Click);
            // 
            // btnAdisyonGuncelle
            // 
            this.btnAdisyonGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAdisyonGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnAdisyonGuncelle.Location = new System.Drawing.Point(108, 90);
            this.btnAdisyonGuncelle.Name = "btnAdisyonGuncelle";
            this.btnAdisyonGuncelle.Size = new System.Drawing.Size(96, 34);
            this.btnAdisyonGuncelle.TabIndex = 1;
            this.btnAdisyonGuncelle.Text = "GÜNCELLE";
            this.btnAdisyonGuncelle.UseVisualStyleBackColor = false;
            this.btnAdisyonGuncelle.Click += new System.EventHandler(this.btnAdisyonGuncelle_Click);
            // 
            // btnAdisyonEkle
            // 
            this.btnAdisyonEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAdisyonEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnAdisyonEkle.Location = new System.Drawing.Point(12, 90);
            this.btnAdisyonEkle.Name = "btnAdisyonEkle";
            this.btnAdisyonEkle.Size = new System.Drawing.Size(90, 34);
            this.btnAdisyonEkle.TabIndex = 0;
            this.btnAdisyonEkle.Text = "EKLE";
            this.btnAdisyonEkle.UseVisualStyleBackColor = false;
            this.btnAdisyonEkle.Click += new System.EventHandler(this.btnAdisyonEkle_Click);
            // 
            // dataGridViewAdisyon
            // 
            this.dataGridViewAdisyon.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridViewAdisyon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAdisyon.GridColor = System.Drawing.SystemColors.Menu;
            this.dataGridViewAdisyon.Location = new System.Drawing.Point(19, 17);
            this.dataGridViewAdisyon.Name = "dataGridViewAdisyon";
            this.dataGridViewAdisyon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAdisyon.Size = new System.Drawing.Size(866, 235);
            this.dataGridViewAdisyon.TabIndex = 0;
            this.dataGridViewAdisyon.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAdisyon_CellDoubleClick);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Snow;
            this.tabPage2.Controls.Add(this.BtnOdeGeri);
            this.tabPage2.Controls.Add(this.btnOdemeYontGetir);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.dataGridViewOdeme);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(907, 484);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ödeme Yöntemi";
            // 
            // BtnOdeGeri
            // 
            this.BtnOdeGeri.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BtnOdeGeri.Location = new System.Drawing.Point(698, 424);
            this.BtnOdeGeri.Name = "BtnOdeGeri";
            this.BtnOdeGeri.Size = new System.Drawing.Size(191, 33);
            this.BtnOdeGeri.TabIndex = 10;
            this.BtnOdeGeri.Text = "Geri Dön";
            this.BtnOdeGeri.UseVisualStyleBackColor = false;
            this.BtnOdeGeri.Click += new System.EventHandler(this.BtnOdeGeri_Click);
            // 
            // btnOdemeYontGetir
            // 
            this.btnOdemeYontGetir.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnOdemeYontGetir.Location = new System.Drawing.Point(698, 263);
            this.btnOdemeYontGetir.Name = "btnOdemeYontGetir";
            this.btnOdemeYontGetir.Size = new System.Drawing.Size(191, 33);
            this.btnOdemeYontGetir.TabIndex = 5;
            this.btnOdemeYontGetir.Text = "Ödeme Yöntemi Getir";
            this.btnOdemeYontGetir.UseVisualStyleBackColor = false;
            this.btnOdemeYontGetir.Click += new System.EventHandler(this.btnOdemeYontGetir_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtOdemeYontemiAdi);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnOdemeYontSil);
            this.groupBox2.Controls.Add(this.btnOdemeYontGuncelle);
            this.groupBox2.Controls.Add(this.btnOdemeYontEkle);
            this.groupBox2.Location = new System.Drawing.Point(20, 280);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(375, 177);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ödeme Yöntemi";
            // 
            // txtOdemeYontemiAdi
            // 
            this.txtOdemeYontemiAdi.Location = new System.Drawing.Point(167, 51);
            this.txtOdemeYontemiAdi.Name = "txtOdemeYontemiAdi";
            this.txtOdemeYontemiAdi.Size = new System.Drawing.Size(168, 21);
            this.txtOdemeYontemiAdi.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ödeme Yöntemi Adı :";
            // 
            // btnOdemeYontSil
            // 
            this.btnOdemeYontSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnOdemeYontSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOdemeYontSil.Location = new System.Drawing.Point(242, 105);
            this.btnOdemeYontSil.Name = "btnOdemeYontSil";
            this.btnOdemeYontSil.Size = new System.Drawing.Size(93, 28);
            this.btnOdemeYontSil.TabIndex = 2;
            this.btnOdemeYontSil.Text = "SİL";
            this.btnOdemeYontSil.UseVisualStyleBackColor = false;
            this.btnOdemeYontSil.Click += new System.EventHandler(this.btnOdemeYontSil_Click);
            // 
            // btnOdemeYontGuncelle
            // 
            this.btnOdemeYontGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnOdemeYontGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOdemeYontGuncelle.Location = new System.Drawing.Point(122, 105);
            this.btnOdemeYontGuncelle.Name = "btnOdemeYontGuncelle";
            this.btnOdemeYontGuncelle.Size = new System.Drawing.Size(102, 28);
            this.btnOdemeYontGuncelle.TabIndex = 1;
            this.btnOdemeYontGuncelle.Text = "GUNCELLE";
            this.btnOdemeYontGuncelle.UseVisualStyleBackColor = false;
            this.btnOdemeYontGuncelle.Click += new System.EventHandler(this.btnOdemeYontGuncelle_Click);
            // 
            // btnOdemeYontEkle
            // 
            this.btnOdemeYontEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnOdemeYontEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOdemeYontEkle.Location = new System.Drawing.Point(18, 105);
            this.btnOdemeYontEkle.Name = "btnOdemeYontEkle";
            this.btnOdemeYontEkle.Size = new System.Drawing.Size(86, 28);
            this.btnOdemeYontEkle.TabIndex = 0;
            this.btnOdemeYontEkle.Text = "EKLE";
            this.btnOdemeYontEkle.UseVisualStyleBackColor = false;
            this.btnOdemeYontEkle.Click += new System.EventHandler(this.btnOdemeYontEkle_Click);
            // 
            // dataGridViewOdeme
            // 
            this.dataGridViewOdeme.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridViewOdeme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOdeme.Location = new System.Drawing.Point(20, 17);
            this.dataGridViewOdeme.Name = "dataGridViewOdeme";
            this.dataGridViewOdeme.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOdeme.Size = new System.Drawing.Size(869, 217);
            this.dataGridViewOdeme.TabIndex = 3;
            this.dataGridViewOdeme.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOdeme_CellDoubleClick);
            // 
            // FormAdisyonOdeme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 534);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormAdisyonOdeme";
            this.Text = "FormAdisyonOdeme";
            this.Load += new System.EventHandler(this.FormAdisyonOdeme_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdisyon)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOdeme)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridViewAdisyon;
        private System.Windows.Forms.Button btnAdisyonGetir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdisyonSil;
        private System.Windows.Forms.Button btnAdisyonGuncelle;
        private System.Windows.Forms.Button btnAdisyonEkle;
        private System.Windows.Forms.Button btnOdemeYontGetir;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtOdemeYontemiAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOdemeYontSil;
        private System.Windows.Forms.Button btnOdemeYontGuncelle;
        private System.Windows.Forms.Button btnOdemeYontEkle;
        private System.Windows.Forms.DataGridView dataGridViewOdeme;
        private System.Windows.Forms.Button BtnGeri;
        private System.Windows.Forms.Button BtnOdeGeri;
    }
}