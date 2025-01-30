namespace Plak_UI
{
    partial class AlbumPanel
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
            grpxAlbum = new GroupBox();
            btnGuncelle = new Button();
            btnSatisiDuranAlbumler = new Button();
            btnIndirimdekiAlbumler = new Button();
            btnSil = new Button();
            btnSatistakiAlbumler = new Button();
            btnEklenenSonOnAlbum = new Button();
            btnEkle = new Button();
            btnGetir = new Button();
            lstListe = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            grpxYeniAlbum = new GroupBox();
            cmxSatisDurum = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            btnAlbumKayit = new Button();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtIndirim = new TextBox();
            txtFiyat = new TextBox();
            txtSanatci = new TextBox();
            txtAlbumAdi = new TextBox();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            grpxAlbum.SuspendLayout();
            grpxYeniAlbum.SuspendLayout();
            SuspendLayout();
            // 
            // grpxAlbum
            // 
            grpxAlbum.Controls.Add(btnGuncelle);
            grpxAlbum.Controls.Add(btnSatisiDuranAlbumler);
            grpxAlbum.Controls.Add(btnIndirimdekiAlbumler);
            grpxAlbum.Controls.Add(btnSil);
            grpxAlbum.Controls.Add(btnSatistakiAlbumler);
            grpxAlbum.Controls.Add(btnEklenenSonOnAlbum);
            grpxAlbum.Controls.Add(btnEkle);
            grpxAlbum.Controls.Add(btnGetir);
            grpxAlbum.Controls.Add(lstListe);
            grpxAlbum.Location = new Point(67, 80);
            grpxAlbum.Margin = new Padding(4, 5, 4, 5);
            grpxAlbum.Name = "grpxAlbum";
            grpxAlbum.Padding = new Padding(4, 5, 4, 5);
            grpxAlbum.Size = new Size(1163, 943);
            grpxAlbum.TabIndex = 0;
            grpxAlbum.TabStop = false;
            grpxAlbum.Text = "Album Panel";
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(430, 463);
            btnGuncelle.Margin = new Padding(4, 5, 4, 5);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(291, 82);
            btnGuncelle.TabIndex = 1;
            btnGuncelle.Text = "GÜNCELLE";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSatisiDuranAlbumler
            // 
            btnSatisiDuranAlbumler.Location = new Point(74, 735);
            btnSatisiDuranAlbumler.Margin = new Padding(4, 5, 4, 5);
            btnSatisiDuranAlbumler.Name = "btnSatisiDuranAlbumler";
            btnSatisiDuranAlbumler.Size = new Size(291, 77);
            btnSatisiDuranAlbumler.TabIndex = 0;
            btnSatisiDuranAlbumler.Text = "SATIŞI OLMAYAN ALBÜMLERİ GÖSTER";
            btnSatisiDuranAlbumler.UseVisualStyleBackColor = true;
            btnSatisiDuranAlbumler.Click += btnSatisiDuranAlbumler_Click;
            // 
            // btnIndirimdekiAlbumler
            // 
            btnIndirimdekiAlbumler.Location = new Point(430, 735);
            btnIndirimdekiAlbumler.Margin = new Padding(4, 5, 4, 5);
            btnIndirimdekiAlbumler.Name = "btnIndirimdekiAlbumler";
            btnIndirimdekiAlbumler.Size = new Size(291, 77);
            btnIndirimdekiAlbumler.TabIndex = 0;
            btnIndirimdekiAlbumler.Text = "İNDİRİMDEKİ ALBUMLERİ GETİR";
            btnIndirimdekiAlbumler.UseVisualStyleBackColor = true;
            btnIndirimdekiAlbumler.Click += btnIndirimdekiAlbumler_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(430, 603);
            btnSil.Margin = new Padding(4, 5, 4, 5);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(291, 82);
            btnSil.TabIndex = 1;
            btnSil.Text = "SİL";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click_1;
            // 
            // btnSatistakiAlbumler
            // 
            btnSatistakiAlbumler.Location = new Point(804, 593);
            btnSatistakiAlbumler.Margin = new Padding(4, 5, 4, 5);
            btnSatistakiAlbumler.Name = "btnSatistakiAlbumler";
            btnSatistakiAlbumler.Size = new Size(290, 92);
            btnSatistakiAlbumler.TabIndex = 0;
            btnSatistakiAlbumler.Text = "SATIŞTAKİ ALBÜMLERİ GETİR";
            btnSatistakiAlbumler.UseVisualStyleBackColor = true;
            btnSatistakiAlbumler.Click += btnSatistakiAlbumler_Click;
            // 
            // btnEklenenSonOnAlbum
            // 
            btnEklenenSonOnAlbum.Location = new Point(804, 463);
            btnEklenenSonOnAlbum.Margin = new Padding(4, 5, 4, 5);
            btnEklenenSonOnAlbum.Name = "btnEklenenSonOnAlbum";
            btnEklenenSonOnAlbum.Size = new Size(290, 82);
            btnEklenenSonOnAlbum.TabIndex = 0;
            btnEklenenSonOnAlbum.Text = "SON EKLENEN 10 ALBUMU GETİR";
            btnEklenenSonOnAlbum.UseVisualStyleBackColor = true;
            btnEklenenSonOnAlbum.Click += btnEklenenSonOnAlbum_Click;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(74, 603);
            btnEkle.Margin = new Padding(4, 5, 4, 5);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(291, 82);
            btnEkle.TabIndex = 1;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnGetir
            // 
            btnGetir.Location = new Point(74, 463);
            btnGetir.Margin = new Padding(4, 5, 4, 5);
            btnGetir.Name = "btnGetir";
            btnGetir.Size = new Size(291, 82);
            btnGetir.TabIndex = 1;
            btnGetir.Text = "GETİR";
            btnGetir.UseVisualStyleBackColor = true;
            btnGetir.Click += btnGetir_Click;
            // 
            // lstListe
            // 
            lstListe.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7 });
            lstListe.GridLines = true;
            lstListe.Location = new Point(74, 48);
            lstListe.Margin = new Padding(4, 5, 4, 5);
            lstListe.Name = "lstListe";
            lstListe.Size = new Size(1018, 362);
            lstListe.TabIndex = 0;
            lstListe.UseCompatibleStateImageBehavior = false;
            lstListe.View = View.Details;
            lstListe.SelectedIndexChanged += lstListe_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "AlbumId";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Album Adı";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Sanatçı";
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Çıkış Tarihi";
            columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Fiyat";
            columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "İndirim Oranı";
            columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Satış Durumu";
            columnHeader7.Width = 100;
            // 
            // grpxYeniAlbum
            // 
            grpxYeniAlbum.Controls.Add(cmxSatisDurum);
            grpxYeniAlbum.Controls.Add(dateTimePicker1);
            grpxYeniAlbum.Controls.Add(btnAlbumKayit);
            grpxYeniAlbum.Controls.Add(label6);
            grpxYeniAlbum.Controls.Add(label5);
            grpxYeniAlbum.Controls.Add(label3);
            grpxYeniAlbum.Controls.Add(label4);
            grpxYeniAlbum.Controls.Add(label2);
            grpxYeniAlbum.Controls.Add(label1);
            grpxYeniAlbum.Controls.Add(txtIndirim);
            grpxYeniAlbum.Controls.Add(txtFiyat);
            grpxYeniAlbum.Controls.Add(txtSanatci);
            grpxYeniAlbum.Controls.Add(txtAlbumAdi);
            grpxYeniAlbum.Location = new Point(1327, 80);
            grpxYeniAlbum.Margin = new Padding(4, 5, 4, 5);
            grpxYeniAlbum.Name = "grpxYeniAlbum";
            grpxYeniAlbum.Padding = new Padding(4, 5, 4, 5);
            grpxYeniAlbum.Size = new Size(599, 943);
            grpxYeniAlbum.TabIndex = 1;
            grpxYeniAlbum.TabStop = false;
            grpxYeniAlbum.Text = "Yeni Album Kayıt";
            // 
            // cmxSatisDurum
            // 
            cmxSatisDurum.FormattingEnabled = true;
            cmxSatisDurum.Items.AddRange(new object[] { "Stokta Var", "Stokta Yok" });
            cmxSatisDurum.Location = new Point(273, 518);
            cmxSatisDurum.Margin = new Padding(4, 5, 4, 5);
            cmxSatisDurum.Name = "cmxSatisDurum";
            cmxSatisDurum.Size = new Size(254, 33);
            cmxSatisDurum.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(273, 258);
            dateTimePicker1.Margin = new Padding(4, 5, 4, 5);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(254, 31);
            dateTimePicker1.TabIndex = 3;
            // 
            // btnAlbumKayit
            // 
            btnAlbumKayit.Location = new Point(166, 617);
            btnAlbumKayit.Margin = new Padding(4, 5, 4, 5);
            btnAlbumKayit.Name = "btnAlbumKayit";
            btnAlbumKayit.Size = new Size(363, 92);
            btnAlbumKayit.TabIndex = 2;
            btnAlbumKayit.Text = "SİSTEME KAYDET";
            btnAlbumKayit.UseVisualStyleBackColor = true;
            btnAlbumKayit.Click += btnAlbumKayit_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(153, 520);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(113, 25);
            label6.TabIndex = 1;
            label6.Text = "Satış Durum:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(153, 428);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(72, 25);
            label5.TabIndex = 1;
            label5.Text = "İndirim:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(153, 258);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(97, 25);
            label3.TabIndex = 1;
            label3.Text = "Çıkış Tarihi:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(153, 348);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(53, 25);
            label4.TabIndex = 1;
            label4.Text = "Fiyat:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(153, 167);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(68, 25);
            label2.TabIndex = 1;
            label2.Text = "Sanatçı";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(153, 87);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(101, 25);
            label1.TabIndex = 1;
            label1.Text = "Album Adı:";
            // 
            // txtIndirim
            // 
            txtIndirim.Location = new Point(273, 428);
            txtIndirim.Margin = new Padding(4, 5, 4, 5);
            txtIndirim.Name = "txtIndirim";
            txtIndirim.Size = new Size(254, 31);
            txtIndirim.TabIndex = 0;
            // 
            // txtFiyat
            // 
            txtFiyat.Location = new Point(273, 335);
            txtFiyat.Margin = new Padding(4, 5, 4, 5);
            txtFiyat.Name = "txtFiyat";
            txtFiyat.Size = new Size(254, 31);
            txtFiyat.TabIndex = 0;
            // 
            // txtSanatci
            // 
            txtSanatci.Location = new Point(273, 162);
            txtSanatci.Margin = new Padding(4, 5, 4, 5);
            txtSanatci.Name = "txtSanatci";
            txtSanatci.Size = new Size(254, 31);
            txtSanatci.TabIndex = 0;
            // 
            // txtAlbumAdi
            // 
            txtAlbumAdi.Location = new Point(273, 82);
            txtAlbumAdi.Margin = new Padding(4, 5, 4, 5);
            txtAlbumAdi.Name = "txtAlbumAdi";
            txtAlbumAdi.Size = new Size(254, 31);
            txtAlbumAdi.TabIndex = 0;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // AlbumPanel
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1924, 1050);
            Controls.Add(grpxYeniAlbum);
            Controls.Add(grpxAlbum);
            Margin = new Padding(4, 5, 4, 5);
            Name = "AlbumPanel";
            Text = "AlbumPanel";
            Load += AlbumPanel_Load;
            grpxAlbum.ResumeLayout(false);
            grpxYeniAlbum.ResumeLayout(false);
            grpxYeniAlbum.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpxAlbum;
        private Button btnSatisiDuranAlbumler;
        private Button btnSatistakiAlbumler;
        private Button btnEklenenSonOnAlbum;
        private Button btnIndirimdekiAlbumler;
        private ListView lstListe;
        private Button btnGuncelle;
        private Button btnSil;
        private Button btnEkle;
        private Button btnGetir;
        private GroupBox grpxYeniAlbum;
        private TextBox txtFiyat;
        private TextBox txtSanatci;
        private TextBox txtAlbumAdi;
        private Button btnAlbumKayit;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label4;
        private Label label2;
        private Label label1;
        private TextBox txtIndirim;
        private DateTimePicker dateTimePicker1;
        private ComboBox cmxSatisDurum;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
    }
}