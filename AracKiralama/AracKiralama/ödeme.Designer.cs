
namespace _Arac_Kiralama
{
    partial class ödeme
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
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblkasa = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnödeme = new System.Windows.Forms.Button();
            this.txtmiktar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Salmon;
            this.panel5.Controls.Add(this.lblkasa);
            this.panel5.Controls.Add(this.label10);
            this.panel5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel5.Location = new System.Drawing.Point(895, 142);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(307, 59);
            this.panel5.TabIndex = 21;
            // 
            // lblkasa
            // 
            this.lblkasa.AutoSize = true;
            this.lblkasa.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblkasa.Location = new System.Drawing.Point(240, 20);
            this.lblkasa.Name = "lblkasa";
            this.lblkasa.Size = new System.Drawing.Size(21, 23);
            this.lblkasa.TabIndex = 1;
            this.lblkasa.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(28, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(163, 28);
            this.label10.TabIndex = 0;
            this.label10.Text = "Kasa Toplam";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(69, 142);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(809, 356);
            this.dataGridView1.TabIndex = 22;
            // 
            // btnödeme
            // 
            this.btnödeme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnödeme.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnödeme.Location = new System.Drawing.Point(137, 58);
            this.btnödeme.Name = "btnödeme";
            this.btnödeme.Size = new System.Drawing.Size(124, 32);
            this.btnödeme.TabIndex = 24;
            this.btnödeme.Text = "Ödeme Yap";
            this.btnödeme.UseVisualStyleBackColor = true;
            this.btnödeme.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtmiktar
            // 
            this.txtmiktar.Location = new System.Drawing.Point(137, 21);
            this.txtmiktar.Name = "txtmiktar";
            this.txtmiktar.Size = new System.Drawing.Size(124, 22);
            this.txtmiktar.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "Ödenen Miktar";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.btnödeme);
            this.panel6.Controls.Add(this.txtmiktar);
            this.panel6.Location = new System.Drawing.Point(895, 288);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(307, 113);
            this.panel6.TabIndex = 27;
            // 
            // ödeme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1500, 800);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ödeme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ayarlar";
            this.Load += new System.EventHandler(this.ayarlar_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblkasa;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnödeme;
        private System.Windows.Forms.TextBox txtmiktar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel6;
    }
}