namespace _Arac_Kiralama
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtkullanıcı = new System.Windows.Forms.TextBox();
            this.btngiriş = new System.Windows.Forms.Button();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblkaydol = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-4, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(337, 609);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtkullanıcı
            // 
            this.txtkullanıcı.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtkullanıcı.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtkullanıcı.Location = new System.Drawing.Point(376, 259);
            this.txtkullanıcı.Name = "txtkullanıcı";
            this.txtkullanıcı.Size = new System.Drawing.Size(222, 26);
            this.txtkullanıcı.TabIndex = 1;
            // 
            // btngiriş
            // 
            this.btngiriş.BackColor = System.Drawing.Color.Black;
            this.btngiriş.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngiriş.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngiriş.ForeColor = System.Drawing.Color.White;
            this.btngiriş.Location = new System.Drawing.Point(376, 360);
            this.btngiriş.Name = "btngiriş";
            this.btngiriş.Size = new System.Drawing.Size(222, 29);
            this.btngiriş.TabIndex = 3;
            this.btngiriş.Text = "Giriş Yap";
            this.btngiriş.UseVisualStyleBackColor = false;
            this.btngiriş.Click += new System.EventHandler(this.btngiriş_Click);
            // 
            // txtsifre
            // 
            this.txtsifre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsifre.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsifre.Location = new System.Drawing.Point(376, 314);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.PasswordChar = '*';
            this.txtsifre.Size = new System.Drawing.Size(222, 26);
            this.txtsifre.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(384, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Araç Kiralama Sistemi";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(373, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kullanıcı adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(373, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Şifre:";
            // 
            // lblkaydol
            // 
            this.lblkaydol.AutoSize = true;
            this.lblkaydol.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblkaydol.Location = new System.Drawing.Point(538, 547);
            this.lblkaydol.Name = "lblkaydol";
            this.lblkaydol.Size = new System.Drawing.Size(60, 18);
            this.lblkaydol.TabIndex = 7;
            this.lblkaydol.Text = "Kaydol";
            this.lblkaydol.Click += new System.EventHandler(this.lblkaydol_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(649, 608);
            this.ControlBox = false;
            this.Controls.Add(this.lblkaydol);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.btngiriş);
            this.Controls.Add(this.txtkullanıcı);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Login_Load);
            this.Shown += new System.EventHandler(this.Login_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtkullanıcı;
        private System.Windows.Forms.Button btngiriş;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblkaydol;
    }
}