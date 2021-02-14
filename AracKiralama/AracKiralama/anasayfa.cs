using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _Arac_Kiralama
{
    public partial class anasayfa : Form
    {
        public anasayfa()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-58U3PAJ;Initial Catalog=arac_kiralama;Integrated Security=True");
      
        private void Form2_Load(object sender, EventArgs e)
        {
            
        }
        private void FormGetir(Form frm)
        {
            panel1.Controls.Clear();
            frm.MdiParent = this;
            panel1.Controls.Add(frm);
            frm.Show();
        }
        private void btnmusterıekle_Click(object sender, EventArgs e)
        {
            musteri musteriekle = new musteri();
            FormGetir(musteriekle);
        }

        private void btnaracekle_Click(object sender, EventArgs e)
        {
            arac aracekle = new arac();
            FormGetir(aracekle);
        }

        private void btnkiralama_Click(object sender, EventArgs e)
        {
            Araç_Kiralama kirala = new Araç_Kiralama();
            FormGetir(kirala);
        }

        private void aractakip_Click(object sender, EventArgs e)
        {
            aractakip durum = new aractakip();
            FormGetir(durum);
        }

        private void btnödeme_Click(object sender, EventArgs e)
        {
            ödeme ayar = new ödeme();
            FormGetir(ayar);
        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            anasayfa form = new anasayfa();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
