namespace _Arac_Kiralama
{
    partial class musteri
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(musteri));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Bilgiler = new System.Windows.Forms.GroupBox();
            this.btnformutemizle = new System.Windows.Forms.Button();
            this.btnara = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.musteridogumtarihi = new System.Windows.Forms.TextBox();
            this.btndüzenle = new System.Windows.Forms.Button();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.kangrubu = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.musteritc = new System.Windows.Forms.TextBox();
            this.musterisoyad = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.ehliyetyasi = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.musteriadres = new System.Windows.Forms.RichTextBox();
            this.ehliyetno = new System.Windows.Forms.TextBox();
            this.ehliyettürü = new System.Windows.Forms.TextBox();
            this.musteriad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnfotoekle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.fotograf = new System.Windows.Forms.PictureBox();
            this.musterimail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dogumyeri = new System.Windows.Forms.TextBox();
            this.musteritel = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Bilgiler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotograf)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(601, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(887, 673);
            this.dataGridView1.TabIndex = 30;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // Bilgiler
            // 
            this.Bilgiler.Controls.Add(this.btnformutemizle);
            this.Bilgiler.Controls.Add(this.btnara);
            this.Bilgiler.Controls.Add(this.label1);
            this.Bilgiler.Controls.Add(this.musteridogumtarihi);
            this.Bilgiler.Controls.Add(this.btndüzenle);
            this.Bilgiler.Controls.Add(this.btnkaydet);
            this.Bilgiler.Controls.Add(this.btnsil);
            this.Bilgiler.Controls.Add(this.kangrubu);
            this.Bilgiler.Controls.Add(this.label12);
            this.Bilgiler.Controls.Add(this.musteritc);
            this.Bilgiler.Controls.Add(this.musterisoyad);
            this.Bilgiler.Controls.Add(this.label11);
            this.Bilgiler.Controls.Add(this.ehliyetyasi);
            this.Bilgiler.Controls.Add(this.label10);
            this.Bilgiler.Controls.Add(this.musteriadres);
            this.Bilgiler.Controls.Add(this.ehliyetno);
            this.Bilgiler.Controls.Add(this.ehliyettürü);
            this.Bilgiler.Controls.Add(this.musteriad);
            this.Bilgiler.Controls.Add(this.label5);
            this.Bilgiler.Controls.Add(this.btnfotoekle);
            this.Bilgiler.Controls.Add(this.label3);
            this.Bilgiler.Controls.Add(this.label9);
            this.Bilgiler.Controls.Add(this.label2);
            this.Bilgiler.Controls.Add(this.label8);
            this.Bilgiler.Controls.Add(this.fotograf);
            this.Bilgiler.Controls.Add(this.musterimail);
            this.Bilgiler.Controls.Add(this.label7);
            this.Bilgiler.Controls.Add(this.label4);
            this.Bilgiler.Controls.Add(this.dogumyeri);
            this.Bilgiler.Controls.Add(this.musteritel);
            this.Bilgiler.Controls.Add(this.label6);
            this.Bilgiler.Controls.Add(this.label13);
            this.Bilgiler.Controls.Add(this.label18);
            this.Bilgiler.Controls.Add(this.label20);
            this.Bilgiler.Controls.Add(this.label21);
            this.Bilgiler.Location = new System.Drawing.Point(12, 88);
            this.Bilgiler.Name = "Bilgiler";
            this.Bilgiler.Size = new System.Drawing.Size(583, 673);
            this.Bilgiler.TabIndex = 31;
            this.Bilgiler.TabStop = false;
            this.Bilgiler.Text = "Bilgiler";
            // 
            // btnformutemizle
            // 
            this.btnformutemizle.BackColor = System.Drawing.Color.Silver;
            this.btnformutemizle.FlatAppearance.BorderSize = 0;
            this.btnformutemizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnformutemizle.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnformutemizle.ForeColor = System.Drawing.SystemColors.Window;
            this.btnformutemizle.Image = ((System.Drawing.Image)(resources.GetObject("btnformutemizle.Image")));
            this.btnformutemizle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnformutemizle.Location = new System.Drawing.Point(382, 570);
            this.btnformutemizle.Name = "btnformutemizle";
            this.btnformutemizle.Size = new System.Drawing.Size(152, 54);
            this.btnformutemizle.TabIndex = 81;
            this.btnformutemizle.Text = "Formu \r\nTemizle";
            this.btnformutemizle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnformutemizle.UseVisualStyleBackColor = false;
            this.btnformutemizle.Click += new System.EventHandler(this.btnformutemizle_Click);
            // 
            // btnara
            // 
            this.btnara.BackColor = System.Drawing.Color.Silver;
            this.btnara.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnara.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnara.ForeColor = System.Drawing.Color.White;
            this.btnara.Location = new System.Drawing.Point(285, 47);
            this.btnara.Name = "btnara";
            this.btnara.Size = new System.Drawing.Size(75, 30);
            this.btnara.TabIndex = 80;
            this.btnara.Text = "Ara";
            this.btnara.UseVisualStyleBackColor = false;
            this.btnara.Click += new System.EventHandler(this.btnara_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 72;
            this.label1.Text = "T.C No";
            // 
            // musteridogumtarihi
            // 
            this.musteridogumtarihi.Location = new System.Drawing.Point(122, 178);
            this.musteridogumtarihi.Name = "musteridogumtarihi";
            this.musteridogumtarihi.Size = new System.Drawing.Size(238, 22);
            this.musteridogumtarihi.TabIndex = 70;
            // 
            // btndüzenle
            // 
            this.btndüzenle.BackColor = System.Drawing.Color.Silver;
            this.btndüzenle.FlatAppearance.BorderSize = 0;
            this.btndüzenle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndüzenle.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btndüzenle.ForeColor = System.Drawing.SystemColors.Window;
            this.btndüzenle.Image = ((System.Drawing.Image)(resources.GetObject("btndüzenle.Image")));
            this.btndüzenle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndüzenle.Location = new System.Drawing.Point(382, 420);
            this.btndüzenle.Name = "btndüzenle";
            this.btndüzenle.Size = new System.Drawing.Size(152, 54);
            this.btndüzenle.TabIndex = 69;
            this.btndüzenle.Text = "Düzenle";
            this.btndüzenle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btndüzenle.UseVisualStyleBackColor = false;
            this.btndüzenle.Click += new System.EventHandler(this.btndüzenle_Click_1);
            // 
            // btnkaydet
            // 
            this.btnkaydet.BackColor = System.Drawing.Color.Silver;
            this.btnkaydet.FlatAppearance.BorderSize = 0;
            this.btnkaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnkaydet.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkaydet.ForeColor = System.Drawing.SystemColors.Window;
            this.btnkaydet.Image = ((System.Drawing.Image)(resources.GetObject("btnkaydet.Image")));
            this.btnkaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnkaydet.Location = new System.Drawing.Point(382, 342);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(152, 54);
            this.btnkaydet.TabIndex = 67;
            this.btnkaydet.Text = "Kaydet";
            this.btnkaydet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnkaydet.UseVisualStyleBackColor = false;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // btnsil
            // 
            this.btnsil.BackColor = System.Drawing.Color.Silver;
            this.btnsil.FlatAppearance.BorderSize = 0;
            this.btnsil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsil.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsil.ForeColor = System.Drawing.SystemColors.Window;
            this.btnsil.Image = ((System.Drawing.Image)(resources.GetObject("btnsil.Image")));
            this.btnsil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsil.Location = new System.Drawing.Point(382, 500);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(152, 54);
            this.btnsil.TabIndex = 71;
            this.btnsil.Text = "Sil";
            this.btnsil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsil.UseVisualStyleBackColor = false;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click_1);
            // 
            // kangrubu
            // 
            this.kangrubu.FormattingEnabled = true;
            this.kangrubu.Items.AddRange(new object[] {
            "0 Rh-",
            "0 Rh+",
            "A Rh-",
            "A Rh+",
            "B Rh-",
            "B Rh+",
            "AB Rh-",
            "AB Rh+"});
            this.kangrubu.Location = new System.Drawing.Point(122, 423);
            this.kangrubu.Name = "kangrubu";
            this.kangrubu.Size = new System.Drawing.Size(238, 24);
            this.kangrubu.TabIndex = 64;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(34, 430);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 17);
            this.label12.TabIndex = 63;
            this.label12.Text = "Kan Grubu";
            // 
            // musteritc
            // 
            this.musteritc.Location = new System.Drawing.Point(122, 50);
            this.musteritc.Name = "musteritc";
            this.musteritc.Size = new System.Drawing.Size(157, 22);
            this.musteritc.TabIndex = 65;
            // 
            // musterisoyad
            // 
            this.musterisoyad.Location = new System.Drawing.Point(122, 131);
            this.musterisoyad.Name = "musterisoyad";
            this.musterisoyad.Size = new System.Drawing.Size(238, 22);
            this.musterisoyad.TabIndex = 68;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 388);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 17);
            this.label11.TabIndex = 56;
            this.label11.Text = "Ehliyet Ver.Tar.";
            // 
            // ehliyetyasi
            // 
            this.ehliyetyasi.Location = new System.Drawing.Point(122, 385);
            this.ehliyetyasi.Name = "ehliyetyasi";
            this.ehliyetyasi.Size = new System.Drawing.Size(238, 22);
            this.ehliyetyasi.TabIndex = 61;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 344);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 17);
            this.label10.TabIndex = 54;
            this.label10.Text = "Ehliyet Türü";
            // 
            // musteriadres
            // 
            this.musteriadres.Location = new System.Drawing.Point(122, 500);
            this.musteriadres.Name = "musteriadres";
            this.musteriadres.Size = new System.Drawing.Size(238, 124);
            this.musteriadres.TabIndex = 60;
            this.musteriadres.Text = "";
            // 
            // ehliyetno
            // 
            this.ehliyetno.Location = new System.Drawing.Point(122, 301);
            this.ehliyetno.Name = "ehliyetno";
            this.ehliyetno.Size = new System.Drawing.Size(238, 22);
            this.ehliyetno.TabIndex = 62;
            // 
            // ehliyettürü
            // 
            this.ehliyettürü.Location = new System.Drawing.Point(122, 342);
            this.ehliyettürü.Name = "ehliyettürü";
            this.ehliyettürü.Size = new System.Drawing.Size(238, 22);
            this.ehliyettürü.TabIndex = 59;
            // 
            // musteriad
            // 
            this.musteriad.Location = new System.Drawing.Point(122, 90);
            this.musteriad.Name = "musteriad";
            this.musteriad.Size = new System.Drawing.Size(238, 22);
            this.musteriad.TabIndex = 66;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 17);
            this.label5.TabIndex = 77;
            this.label5.Text = "Doğum Yeri";
            // 
            // btnfotoekle
            // 
            this.btnfotoekle.BackColor = System.Drawing.Color.Silver;
            this.btnfotoekle.FlatAppearance.BorderSize = 0;
            this.btnfotoekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfotoekle.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnfotoekle.ForeColor = System.Drawing.SystemColors.Window;
            this.btnfotoekle.Image = ((System.Drawing.Image)(resources.GetObject("btnfotoekle.Image")));
            this.btnfotoekle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnfotoekle.Location = new System.Drawing.Point(393, 247);
            this.btnfotoekle.Name = "btnfotoekle";
            this.btnfotoekle.Size = new System.Drawing.Size(172, 34);
            this.btnfotoekle.TabIndex = 79;
            this.btnfotoekle.Text = "Fotoğraf Ekle";
            this.btnfotoekle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnfotoekle.UseVisualStyleBackColor = false;
            this.btnfotoekle.Click += new System.EventHandler(this.btnfotoekle_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 75;
            this.label3.Text = "Soyad";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(39, 304);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 17);
            this.label9.TabIndex = 52;
            this.label9.Text = "Ehliyet No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 17);
            this.label2.TabIndex = 74;
            this.label2.Text = "Ad";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 500);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 17);
            this.label8.TabIndex = 55;
            this.label8.Text = "Adres";
            // 
            // fotograf
            // 
            this.fotograf.Image = ((System.Drawing.Image)(resources.GetObject("fotograf.Image")));
            this.fotograf.Location = new System.Drawing.Point(393, 49);
            this.fotograf.Name = "fotograf";
            this.fotograf.Size = new System.Drawing.Size(172, 179);
            this.fotograf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fotograf.TabIndex = 78;
            this.fotograf.TabStop = false;
            // 
            // musterimail
            // 
            this.musterimail.Location = new System.Drawing.Point(122, 457);
            this.musterimail.Name = "musterimail";
            this.musterimail.Size = new System.Drawing.Size(238, 22);
            this.musterimail.TabIndex = 58;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(61, 457);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 17);
            this.label7.TabIndex = 53;
            this.label7.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 17);
            this.label4.TabIndex = 76;
            this.label4.Text = "Doğum Tarihi";
            // 
            // dogumyeri
            // 
            this.dogumyeri.Location = new System.Drawing.Point(122, 225);
            this.dogumyeri.Name = "dogumyeri";
            this.dogumyeri.Size = new System.Drawing.Size(238, 22);
            this.dogumyeri.TabIndex = 73;
            // 
            // musteritel
            // 
            this.musteritel.Location = new System.Drawing.Point(122, 264);
            this.musteritel.Name = "musteritel";
            this.musteritel.Size = new System.Drawing.Size(238, 22);
            this.musteritel.TabIndex = 57;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 17);
            this.label6.TabIndex = 51;
            this.label6.Text = "Cep Telefonu";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(-65, 1);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 17);
            this.label13.TabIndex = 47;
            this.label13.Text = "T.C No";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(-61, 82);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(48, 17);
            this.label18.TabIndex = 50;
            this.label18.Text = "Soyad";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(-38, 39);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(25, 17);
            this.label20.TabIndex = 49;
            this.label20.Text = "Ad";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(-61, 446);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(45, 17);
            this.label21.TabIndex = 30;
            this.label21.Text = "Adres";
            // 
            // musteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1500, 800);
            this.Controls.Add(this.Bilgiler);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "musteri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri";
            this.Load += new System.EventHandler(this.İşlemler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Bilgiler.ResumeLayout(false);
            this.Bilgiler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotograf)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox Bilgiler;
        private System.Windows.Forms.Button btnara;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox musteridogumtarihi;
        private System.Windows.Forms.Button btndüzenle;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.ComboBox kangrubu;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox musteritc;
        private System.Windows.Forms.TextBox musterisoyad;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox ehliyetyasi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox musteriadres;
        private System.Windows.Forms.TextBox ehliyetno;
        private System.Windows.Forms.TextBox ehliyettürü;
        private System.Windows.Forms.TextBox musteriad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnfotoekle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox fotograf;
        private System.Windows.Forms.TextBox musterimail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox dogumyeri;
        private System.Windows.Forms.TextBox musteritel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btnformutemizle;
    }
}

