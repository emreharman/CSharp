/****************************************************************************
**																		   	
**				YAZAN.............: Emre Harman							   	
**				TARİH.............: 12.05.2020	
**
****************************************************************************/

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

namespace _02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Connection stringimiz ve bağlantımız
        const string veriYolu = @"Data Source=DESKTOP-QH1AV1B; Initial Catalog=dboCalisma2; Integrated Security=True";
        SqlConnection baglanti = new SqlConnection(veriYolu);
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        
        private void btnGiris_Click(object sender, EventArgs e)
        {
            //Kullanıcının girdiği değerler
            string kulAd = txtKullaniciAdi.Text;
            string parola = txtParola.Text;
            
            //Bağlantımızı açtık
            baglanti.Open();
            string sorgu = "SELECT kullaniciAdi,parola,durum,girisHak FROM T_Kullanicilar";//Sordu cümlemizi yazdık.
            SqlCommand komut = new SqlCommand(sorgu,baglanti);//Baglantimizi kurduk.Simdi sorguyu calistirip veriyi almamiz lazim.
            //Komutu  gerçekleştirdik.
            SqlDataReader dr = komut.ExecuteReader();
            //Tablomuzu satır satır okuyup verilemizi kontrol edeceğiz.
            while (dr.Read())
            {
                //Eğer alanlardan biri ya da ikisi birden boş ise
                if(kulAd=="" || parola == "")
                {
                    MessageBox.Show("Kullanıcı adı ya da Parola boş bırakılamaz.");
                    baglanti.Close();
                    break;
                }
               
                //Kullanıcı adı ve parola doğru girilmiş ve aynı zamanda kullanıcının durumu aktif ise form2'ye yönlendir.
                //Kullanıcının başarılı giriş yaptığı için her ihtimale karşı giriş hakkını yeniden 3 yap.
                if (dr["kullaniciAdi"].ToString() == kulAd && dr["parola"].ToString()==parola && dr["durum"].ToString()=="aktif")
                {
                    Form2 form2 = new Form2();
                    form2.Show();
                    this.Close();
                    dr.Close();
                    komut.CommandText = "UPDATE T_Kullanicilar SET girisHak=3 WHERE kullaniciAdi='"+kulAd+"' ";
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    break;
                }
                //Kullanıcı adı ve parola doğru ancak durumu kilitli ise hata ver, tekrar girişi engelle.
                if(dr["kullaniciAdi"].ToString() == kulAd && dr["parola"].ToString() == parola && dr["durum"].ToString() == "kilitli")
                {
                    MessageBox.Show("Hesabınız kilitlidir. Lütfen sistem yöneticinizle iletişime geçin.");
                    btnGiris.Enabled = false; 
                    baglanti.Close();
                    break;
                }
                //Kullanıcı adı ya da parola yanlışsa
                if(dr["kullaniciAdi"].ToString()!=kulAd || dr["parola"].ToString() != parola)
                {
                    //KUllanıcının durumu kilitli ise girişini engelle.
                    if (dr["durum"].ToString() == "kilitli")
                    {
                        MessageBox.Show("Hesabınız kilitlidir. Lütfen sistem yöneticinizle iletişime geçin.");
                        btnGiris.Enabled = false;
                        baglanti.Close();
                        break;
                    }
                    dr.Close();//Yeni komut yazmak için açık olan DataReader'ı kapatmamız lazım.
                    //Kullanıcının giriş hakkını 1 azalt, veri tabanında güncelle
                    komut.CommandText = "UPDATE T_Kullanicilar SET girisHak=girisHak-1";
                    komut.ExecuteNonQuery();
                    komut.CommandText = "SELECT * FROM T_Kullanicilar WHERE kullaniciAdi='"+kulAd+"'";
                    dr = komut.ExecuteReader();//Güncel bilgiyi tekrar oku.
                    //Güncel bilgiyi okuyoruz.
                    while (dr.Read())
                    {
                        //Kullanıcının kalan hakkını bildirdik.
                        MessageBox.Show("Kullanıcı adınız ya da Parolanız yanlış. Kalan hak "+dr["girisHak"].ToString());
                        //giriş hakkı bittiyse durumunu kilitli yaparak girişini engelliyoruz.
                        if (dr["girisHak"].ToString() == "0")
                        {
                            dr.Close();
                            komut.CommandText = "UPDATE T_Kullanicilar SET durum='kilitli'";
                            komut.ExecuteNonQuery();
                            MessageBox.Show("Hesabınız kilitlenmiştir. Lütfen sistem yöneticinizle iletişime geçin.");
                            btnGiris.Enabled = false;
                            txtKullaniciAdi.Clear();
                            txtParola.Clear();
                            baglanti.Close();
                            break;
                        }
                    }
                    txtKullaniciAdi.Clear();
                    txtParola.Clear();
                    baglanti.Close();
                    break;
                }
                
            }
        }
    }
}
