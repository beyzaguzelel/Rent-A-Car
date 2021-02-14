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
    public partial class musteri : Form
    {
        public musteri()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-58U3PAJ;Initial Catalog=arac_kiralama;Integrated Security=True");
        
        void listele()
        {            
            SqlDataAdapter adaptor = new SqlDataAdapter("SELECT * FROM müsteri", baglanti);
            DataSet ds = new DataSet();
            adaptor.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
        void temizle()
        {
            fotograf.ImageLocation = "";
            musteritc.Clear();
            musteriad.Clear();
            musterisoyad.Clear();
            musteridogumtarihi.Clear();
            dogumyeri.Clear();
            musterimail.Clear();
            musteriadres.Clear();
            musteritel.Clear();
            ehliyetno.Clear();
            ehliyettürü.Clear();
            ehliyetyasi.Clear();
            kangrubu.Text = "";
        }

        private void İşlemler_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

            musteritc.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            musteriad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            musterisoyad.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            musteridogumtarihi.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            dogumyeri.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            musteritel.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            musterimail.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            musteriadres.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            ehliyetno.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            ehliyettürü.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            ehliyetyasi.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            kangrubu.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO müsteri(tc,ad,soyad,dogum_tarihi,dogum_yeri,telefon,email,adres,ehliyet_no,ehliyet_turu,ehliyet_yasi,kan_grubu) VALUES(@musteritc,@musteriad,  @musterisoyad ,@musteridogumtarihi, @dogumyeri , @musteritel,@musterimail, @musteriadres, @ehliyetno,@ehliyettürü, @ehliyetyasi,@kangrubu)", baglanti);
                cmd.Parameters.AddWithValue("@musteritc", musteritc.Text);
                cmd.Parameters.AddWithValue("@musteriad", musteriad.Text);
                cmd.Parameters.AddWithValue("@musterisoyad" ,musterisoyad.Text);
                cmd.Parameters.AddWithValue("@musteridogumtarihi", musteridogumtarihi.Text);
                cmd.Parameters.AddWithValue("@dogumyeri", dogumyeri.Text);
                cmd.Parameters.AddWithValue("@musteritel", musteritel.Text);
                cmd.Parameters.AddWithValue("@musterimail", musterimail.Text);
                cmd.Parameters.AddWithValue("@musteriadres", musteriadres.Text);
                cmd.Parameters.AddWithValue("@ehliyetno", ehliyetno.Text);
                cmd.Parameters.AddWithValue("@ehliyettürü", ehliyettürü.Text);
                cmd.Parameters.AddWithValue("@ehliyetyasi", ehliyetyasi.Text);
                cmd.Parameters.AddWithValue("@kangrubu", kangrubu.Text);
                cmd.ExecuteNonQuery();
                listele();
                baglanti.Close();
                temizle();                  
                MessageBox.Show("Kaydedildi!");
            }
        }

        private void btndüzenle_Click_1(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = baglanti;
                cmd.CommandText = "UPDATE müsteri SET tc='" + musteritc.Text + "',ad = '" + musteriad.Text + "', soyad = '" + musterisoyad.Text + "', dogum_tarihi = '" + musteridogumtarihi.Text + "', dogum_yeri = '" + dogumyeri.Text + "'," +
                   "telefon='" + musteritel.Text + "',email='" + musterimail.Text + "',adres='" + musteriadres.Text + "',ehliyet_no='" + ehliyetno.Text + "',ehliyet_turu='" + ehliyettürü.Text + "',ehliyet_yasi = '" + ehliyetyasi.Text + "', kan_grubu = '" + kangrubu.Text + "' WHERE musteriID='" + Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value) + "'";
                cmd.ExecuteNonQuery();
                listele();
                baglanti.Close();
                temizle();             
                MessageBox.Show("Güncellendi!");
            }
        }
        private void btnsil_Click_1(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM müsteri WHERE musteriID='" + Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value)+"'",baglanti); 
                cmd.ExecuteNonQuery();
                listele();
                baglanti.Close();
                temizle();                
                MessageBox.Show("Silindi!");
            }
        }

        private void btnfotoekle_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Filter = "Resim Dosyası |*.jpg;*.png|Tüm Dosyalar |*.*";
            dosya.ShowDialog();
            string DosyaYolu = dosya.FileName;
            fotograf.ImageLocation = DosyaYolu;
        }

        private void btnara_Click_1(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlDataAdapter arama = new SqlDataAdapter("SELECT * FROM müsteri WHERE tc='" + musteritc.Text + "'", baglanti);
            DataSet ds = new DataSet();
            arama.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        private void btnformutemizle_Click(object sender, EventArgs e)
        {
            temizle();
            listele();
        }
    }
}
