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
using System.IO;
using System.Drawing.Imaging;

namespace _Arac_Kiralama
{
    public partial class arac : Form
    {
        public arac()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-58U3PAJ;Initial Catalog=arac_kiralama;Integrated Security=True");
        void listele()
        {
            baglanti.Open();
            SqlDataAdapter adaptor = new SqlDataAdapter("SELECT * FROM arac", baglanti);
            DataSet ds = new DataSet();
            adaptor.Fill(ds, "arac");
            dataGridView1.DataSource = ds.Tables["arac"];
            baglanti.Close();
        }

        void temizle()
        {
            fotograf.ImageLocation = "";
            plaka.Clear();
            marka.Text = "";
            model.Text = "";
            yıl.Text = "";
            vites.Text = "";
            yakıttürü.Text = "";
            km.Clear();
            renk.Text = "";
            günlükfiyat.Clear();
        }
        void markaDoldur()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM markalar", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                marka.Items.Add(oku["marka"]);
            }
            baglanti.Close();
        }
        void renkDoldur()
        {
            baglanti.Open();
            SqlCommand kmt = new SqlCommand("SELECT * FROM renkler", baglanti);
            SqlDataReader read = kmt.ExecuteReader();
            while (read.Read())
            {
                renk.Items.Add(read["renk"]);
            }
            baglanti.Close();
        }
        void modelDoldur()
        {
            baglanti.Open();
            SqlCommand kmt = new SqlCommand("SELECT model FROM arac WHERE marka='" + marka.Text + "'", baglanti);
            SqlDataReader read = kmt.ExecuteReader();
            model.Items.Clear();
            while (read.Read())
            {               
                model.Items.Add(read["model"]);                
            }
            baglanti.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            listele();
            markaDoldur();
            renkDoldur();
        }

        private void button1_Click(object sender, EventArgs e)//resim ekle
        {
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Filter = "Resim Dosyası |*.jpg;*.png|Tüm Dosyalar |*.*";
            dosya.ShowDialog();
            string DosyaYolu = dosya.FileName;
            fotograf.ImageLocation = DosyaYolu;
        }

        private void button2_Click(object sender, EventArgs e)//arac ekle
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = baglanti;
                cmd.CommandText = "INSERT INTO arac(plaka,marka,model,yıl,vites,yakıt_türü,km,renk,günlük_fiyat,aracdurum) VALUES('" + plaka.Text + "', '" + marka.Text + "', '" + model.Text + "','" + yıl.Text + "', '" + vites.Text + "', '" + yakıttürü.Text + "','" + km.Text + "',  '" + renk.Text + "',  '" + günlükfiyat.Text + "','müsait')";
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                baglanti.Close();
                temizle();
                listele();
                MessageBox.Show("Kaydedildi!");
            }
        }

        private void button3_Click(object sender, EventArgs e)//arac guncelle
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = baglanti;
                cmd.CommandText = "UPDATE arac SET plaka='" + plaka.Text + "',marka = '" + marka.Text + "', model = '" + model.Text + "', yıl = '" + yıl.Text + "', vites = '" + vites.Text + "'," +
                   "yakıt_türü='" + yakıttürü.Text + "',km='" + km.Text + "',renk='" + renk.Text + "',günlük_fiyat='" + günlükfiyat.Text + "' WHERE aracID='" + Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value) + "'";
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                baglanti.Close();
                temizle();
                listele();
                MessageBox.Show("Güncellendi!");
            }
        }

        private void button4_Click(object sender, EventArgs e)//arac sil
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = baglanti;
                cmd.CommandText = "DELETE FROM arac WHERE aracID='" + Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value) + "'";
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                baglanti.Close();
                temizle();
                listele();
                MessageBox.Show("Silindi!");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            plaka.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            marka.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            model.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            yıl.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            vites.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            yakıttürü.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            km.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            renk.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            günlükfiyat.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();

        }

        private void btnformutemizle_Click(object sender, EventArgs e)
        {
            temizle();
            listele();
        }
        private void btnara_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlDataAdapter arama = new SqlDataAdapter("SELECT * FROM arac WHERE plaka='" + plaka.Text + "'", baglanti);
            DataSet ds = new DataSet();
            arama.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();
        }
    
        private void marka_SelectedValueChanged(object sender, EventArgs e)
        {
                modelDoldur();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                string a = dataGridView1.Rows[i].Cells["aracdurum"].Value.ToString();
               
                if (a=="kiralanmış")
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Salmon;
                }
                else
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.White;
                }
            }
        }
    }
}
