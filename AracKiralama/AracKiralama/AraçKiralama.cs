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
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace _Arac_Kiralama
{
    public partial class Araç_Kiralama : Form
    {
        public Araç_Kiralama()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-58U3PAJ;Initial Catalog=arac_kiralama;Integrated Security=True");
        void temizle()
        {           
            plaka.Clear();
            marka.Text = "";
            model.Text = "";
            renk.Text = "";
            txtkm.Text = "";
            ücret.Clear();

            kiralayantc.Text = "";
            ad.Clear();
            soyad.Clear();
            tel.Clear();
            ehliyetno.Clear();

            alıştarihi.Text = "";
            dönüştarihi.Text = "";

            fatura.Text = "";
            toplamücret.Text="";            
            ödemesekli.Text="";
            hesap.Clear();

        }
        void comboDoldur()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM subeler", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                kiralanansube.Items.Add(oku["sube"]);
                teslimsube.Items.Add(oku["sube"]);
            }
            baglanti.Close();
        }

        private void Araç_Kiralama_Load(object sender, EventArgs e)
        {
            comboDoldur();              
        }

        private void kiralayantc_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM müsteri Where tc like'"+kiralayantc.Text+"'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ad.Text = oku["ad"].ToString();
                soyad.Text = oku["soyad"].ToString();
                tel.Text = oku["telefon"].ToString();
                ehliyetno.Text = oku["ehliyet_yasi"].ToString();
                fatura.Text = oku["musteriID"].ToString();

            }
            baglanti.Close();
          
        }
        private void plaka_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM arac Where plaka like'" + plaka.Text + "'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                marka.Text = oku["marka"].ToString();
                model.Text = oku["model"].ToString();
                renk.Text = oku["renk"].ToString();
                txtkm.Text = oku["km"].ToString();
                ücret.Text = oku["günlük_fiyat"].ToString();
            }
            baglanti.Close();

        }
        private void dönüştarihi_ValueChanged(object sender, EventArgs e)
        {
            DateTime d1 = Convert.ToDateTime(alıştarihi.Text);
            DateTime d2 = Convert.ToDateTime(dönüştarihi.Text);
            TimeSpan ts = d2 - d1;

            int a = ts.Days * Convert.ToInt32(ücret.Text);
            toplamücret.Text = a.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
             
                
                SqlCommand komut = new SqlCommand();
                komut.Connection = baglanti;
                komut.CommandText = "INSERT INTO kiralamabilgileri(plaka,marka,model,renk,km,ücret,tc,ad,soyad,telefon,ehliyetno,alıştarihi,dönüştarihi,kiralanansube,teslimsube,faturano,ödemesekli,hesap,toplamücret,kalanücret,aracdurumu) VALUES('" + plaka.Text + "', '" + marka.Text + "', '" + model.Text + "','" +
                   renk.Text + "','" + txtkm.Text + "', '" + ücret.Text + "', '" + kiralayantc.Text + "','" + ad.Text + "',  '" + soyad.Text + "',  '" + tel.Text + "',  '" + ehliyetno.Text + "',  '" + alıştarihi.Text + "','" +
                   dönüştarihi.Text + "','" + kiralanansube.Text + "','" + teslimsube.Text + "','" + fatura.Text + "','" + ödemesekli.Text + "','" + hesap.Text + "','" + toplamücret.Text + "','" + toplamücret.Text + "','kiralanmış')";
                komut.ExecuteNonQuery();
                komut.Dispose();

                SqlCommand kmd = new SqlCommand();
                kmd.Connection = baglanti;
                kmd.CommandText = "UPDATE arac SET aracdurum='kiralanmış' WHERE plaka='" + plaka.Text + "'";
                kmd.ExecuteNonQuery();
                kmd.Dispose();

                baglanti.Close();
                MessageBox.Show("Araç kiralandı!");
            }
        }
     

        private void button2_Click(object sender, EventArgs e)
        {
            temizle();
        }
        private void pdf_Click(object sender, EventArgs e)
        {
            Document pdf = new Document(PageSize.A4,20f,20f,30f,30f);
            PdfWriter pWriter = PdfWriter.GetInstance(pdf,new FileStream("C:\\Users\\beyza\\Desktop\\kirasozlesmesi.pdf", FileMode.Create));
            pdf.Open();

            System.Drawing.Image img=System.Drawing.Image.FromFile("D:\\AracKiralama\\images\\1.png");
            iTextSharp.text.Image ItextImage = iTextSharp.text.Image.GetInstance(img, System.Drawing.Imaging.ImageFormat.Png);
            ItextImage.Alignment = Element.ALIGN_CENTER;

            pdf.Add(ItextImage);
            pdf.Add(new Paragraph("                         "));


            iTextSharp.text.Font font = FontFactory.GetFont(iTextSharp.text.Font.FontFamily.TIMES_ROMAN.ToString(),18,iTextSharp.text.Font.BOLD );
            iTextSharp.text.Font font1 = FontFactory.GetFont(iTextSharp.text.Font.FontFamily.TIMES_ROMAN.ToString(), 12, iTextSharp.text.Font.NORMAL);


            pdf.Add(new Paragraph("                          ARAÇ KIRALAMA SÖZLESMESİ", font));
            pdf.Add(new Paragraph("                         "));

            pdf.Add(new Paragraph("Müsterinin Bilgileri:", font));
            pdf.Add(new Paragraph("TC : " + kiralayantc.Text + "\n AD : " + ad.Text + " \nSOYAD : " + soyad.Text + " \nTELEFON :" + tel.Text,font1));

            pdf.Add(new Paragraph("Arac Bilgileri:", font));
            pdf.Add(new Paragraph("PLAKA : " + plaka.Text + " \nMARKA :" + marka.Text + " \nMODEL :" + model.Text + " \nRENK :" + renk.Text,font1));

            pdf.Add(new Paragraph("Kiralama Bilgileri:", font));
            pdf.Add(new Paragraph("ALIS TARIHI : " + alıştarihi.Text + " \nDÖNÜS TARIHI :" + dönüştarihi.Text + " \nKIRALANAN SUBE:" + kiralanansube.Text + " \nTESLIM SUBE :" + teslimsube.Text,font1));

            pdf.Add(new Paragraph("Ödeme Bilgileri:", font));
            
            pdf.Add(new Paragraph("KIRALAMA UCRETI : " + ücret.Text + "\n ÖDEME SEKLI :" + ödemesekli.Text,font1));

            MessageBox.Show("PDF Kaydedildi!");

            pdf.Close(); 

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
