using System;
using System.Data;
using System.Windows.Forms;

namespace _Arac_Kiralama
{
    partial class anasayfa
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(anasayfa));
           
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnçıkış = new System.Windows.Forms.Button();
            this.btnanasayfa = new System.Windows.Forms.Button();
            this.aractakip = new System.Windows.Forms.Button();
            this.btnödeme = new System.Windows.Forms.Button();
            this.btnkiralama = new System.Windows.Forms.Button();
            this.btnaracekle = new System.Windows.Forms.Button();
            this.btnmusterıekle = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.arackiralamaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.arackiralamaDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arackiralamaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arackiralamaDataSetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.btnçıkış);
            this.panel2.Controls.Add(this.btnanasayfa);
            this.panel2.Controls.Add(this.aractakip);
            this.panel2.Controls.Add(this.btnödeme);
            this.panel2.Controls.Add(this.btnkiralama);
            this.panel2.Controls.Add(this.btnaracekle);
            this.panel2.Controls.Add(this.btnmusterıekle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1200, 85);
            this.panel2.TabIndex = 30;
            // 
            // btnçıkış
            // 
            this.btnçıkış.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnçıkış.FlatAppearance.BorderSize = 0;
            this.btnçıkış.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnçıkış.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnçıkış.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnçıkış.Image = ((System.Drawing.Image)(resources.GetObject("btnçıkış.Image")));
            this.btnçıkış.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnçıkış.Location = new System.Drawing.Point(1060, 0);
            this.btnçıkış.Name = "btnçıkış";
            this.btnçıkış.Size = new System.Drawing.Size(140, 87);
            this.btnçıkış.TabIndex = 12;
            this.btnçıkış.Text = "Çıkış\r\nYap";
            this.btnçıkış.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnçıkış.UseVisualStyleBackColor = false;
            this.btnçıkış.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnanasayfa
            // 
            this.btnanasayfa.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnanasayfa.FlatAppearance.BorderSize = 0;
            this.btnanasayfa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnanasayfa.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnanasayfa.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnanasayfa.Image = ((System.Drawing.Image)(resources.GetObject("btnanasayfa.Image")));
            this.btnanasayfa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnanasayfa.Location = new System.Drawing.Point(920, 1);
            this.btnanasayfa.Name = "btnanasayfa";
            this.btnanasayfa.Size = new System.Drawing.Size(150, 84);
            this.btnanasayfa.TabIndex = 11;
            this.btnanasayfa.Text = "Ana\r\nSayfa";
            this.btnanasayfa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnanasayfa.UseVisualStyleBackColor = false;
            this.btnanasayfa.Click += new System.EventHandler(this.button2_Click);
            // 
            // aractakip
            // 
            this.aractakip.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.aractakip.FlatAppearance.BorderSize = 0;
            this.aractakip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aractakip.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.aractakip.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.aractakip.Image = ((System.Drawing.Image)(resources.GetObject("aractakip.Image")));
            this.aractakip.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.aractakip.Location = new System.Drawing.Point(594, 1);
            this.aractakip.Name = "aractakip";
            this.aractakip.Size = new System.Drawing.Size(175, 84);
            this.aractakip.TabIndex = 11;
            this.aractakip.Text = "Araç\r\nTakip ";
            this.aractakip.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.aractakip.UseVisualStyleBackColor = false;
            this.aractakip.Click += new System.EventHandler(this.aractakip_Click);
            // 
            // btnödeme
            // 
            this.btnödeme.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnödeme.FlatAppearance.BorderSize = 0;
            this.btnödeme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnödeme.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnödeme.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnödeme.Image = ((System.Drawing.Image)(resources.GetObject("btnödeme.Image")));
            this.btnödeme.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnödeme.Location = new System.Drawing.Point(766, 1);
            this.btnödeme.Name = "btnödeme";
            this.btnödeme.Size = new System.Drawing.Size(158, 84);
            this.btnödeme.TabIndex = 10;
            this.btnödeme.Text = "Ödeme";
            this.btnödeme.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnödeme.UseVisualStyleBackColor = false;
            this.btnödeme.Click += new System.EventHandler(this.btnödeme_Click);
            // 
            // btnkiralama
            // 
            this.btnkiralama.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnkiralama.FlatAppearance.BorderSize = 0;
            this.btnkiralama.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnkiralama.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkiralama.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnkiralama.Image = ((System.Drawing.Image)(resources.GetObject("btnkiralama.Image")));
            this.btnkiralama.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnkiralama.Location = new System.Drawing.Point(407, 0);
            this.btnkiralama.Name = "btnkiralama";
            this.btnkiralama.Size = new System.Drawing.Size(187, 84);
            this.btnkiralama.TabIndex = 9;
            this.btnkiralama.Text = "Araç \r\nKiralama\r\n";
            this.btnkiralama.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnkiralama.UseVisualStyleBackColor = false;
            this.btnkiralama.Click += new System.EventHandler(this.btnkiralama_Click);
            // 
            // btnaracekle
            // 
            this.btnaracekle.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnaracekle.FlatAppearance.BorderSize = 0;
            this.btnaracekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaracekle.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnaracekle.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnaracekle.Image = ((System.Drawing.Image)(resources.GetObject("btnaracekle.Image")));
            this.btnaracekle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnaracekle.Location = new System.Drawing.Point(204, 0);
            this.btnaracekle.Name = "btnaracekle";
            this.btnaracekle.Size = new System.Drawing.Size(207, 84);
            this.btnaracekle.TabIndex = 8;
            this.btnaracekle.Text = "Yeni Araç\r\nKaydı\r\n";
            this.btnaracekle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnaracekle.UseVisualStyleBackColor = false;
            this.btnaracekle.Click += new System.EventHandler(this.btnaracekle_Click);
            // 
            // btnmusterıekle
            // 
            this.btnmusterıekle.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnmusterıekle.FlatAppearance.BorderSize = 0;
            this.btnmusterıekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmusterıekle.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnmusterıekle.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnmusterıekle.Image = ((System.Drawing.Image)(resources.GetObject("btnmusterıekle.Image")));
            this.btnmusterıekle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnmusterıekle.Location = new System.Drawing.Point(-6, 0);
            this.btnmusterıekle.Name = "btnmusterıekle";
            this.btnmusterıekle.Size = new System.Drawing.Size(215, 84);
            this.btnmusterıekle.TabIndex = 7;
            this.btnmusterıekle.Text = "Yeni Müşteri\r\nKaydı\r\n";
            this.btnmusterıekle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnmusterıekle.UseVisualStyleBackColor = false;
            this.btnmusterıekle.Click += new System.EventHandler(this.btnmusterıekle_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 684);
            this.panel1.TabIndex = 31;
            // 
            // panel3
            // 
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel3.Location = new System.Drawing.Point(82, 28);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1065, 624);
            this.panel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(453, 574);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Araç Kiralama";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(91, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(897, 582);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // arackiralamaDataSetBindingSource1
            // 
  
            this.arackiralamaDataSetBindingSource1.Position = 0;
            // 
            // anasayfa
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 769);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "anasayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri_Ekle";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arackiralamaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arackiralamaDataSetBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.BindingSource arackiralamaDataSetBindingSource;

        private System.Windows.Forms.BindingSource arackiralamaDataSetBindingSource1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button aractakip;
        private System.Windows.Forms.Button btnödeme;
        private System.Windows.Forms.Button btnkiralama;
        private System.Windows.Forms.Button btnaracekle;
        private System.Windows.Forms.Button btnmusterıekle;
        private Panel panel1;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Label label1;
        private Button btnanasayfa;
        private Button btnçıkış;
    }

    
}