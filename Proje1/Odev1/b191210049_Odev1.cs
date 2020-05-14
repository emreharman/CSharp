/****************************************************************************
**					        SAKARYA ÜNİVERSİTESİ
**				    BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				        BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				       NESNEYE DAYALI PROGRAMLAMA DERSİ
**					        2019-2020 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........: 01
**				ÖĞRENCİ ADI............: EMRE HARMAN
**				ÖĞRENCİ NUMARASI.......: B191210049
**              DERSİN ALINDIĞI GRUP...: 1B
****************************************************************************/

using System;
using System.IO;

namespace Odev1
{
    class Ogrenci
    {
        private string ad;
        private string soyad;
        private string harfNotu;
        private string ogrNo;
        private string durum;
        private double odev1, odev2, vize, finalNotu, sonuc;
        private double odevEtki, vizeEtki, finalNotuEtki;
        public Ogrenci()
        {
            odevEtki = 0.1;
            vizeEtki = 0.3;
            finalNotuEtki = 0.5;
        }
        public string Durum
        {
            get { return durum; }
            set { durum = value; }
        }
        public string HarfNotu
        {
            get { return harfNotu; }
            set { harfNotu = value; }
        }
        public double Sonuc
        {
            get { return sonuc; }
            set { sonuc = value; }
        }
        public string Adi
        {
            get { return ad; }
            set { ad = value; }
        }
        public string Soyadi
        {
            get { return soyad; }
            set { soyad = value; }
        }
        public string Numara
        {
            get { return ogrNo; }
            set { ogrNo = value; }
        }
        public double Odev1
        {
            get { return odev1; }
            set { odev1 = value; }
        }
        public double Odev2
        {
            get { return odev2; }
            set { odev2 = value; }
        }
        public double Vize
        {
            get { return vize; }
            set { vize = value; }
        }
        public double FinalNotu
        {
            get { return finalNotu; }
            set { finalNotu = value; }
        }

        public string OgrNo
        {
            get { return ogrNo; }
            set { ogrNo = value; }
        }

        public void DurumHesapla()
        {
            NotHesapla();
            DersNotuHesapla();
            if (HarfNotu == "FF" || harfNotu == "FD")
                durum = "KALDI";
            else
                durum = "GEÇTİ";
        }
        public double NotHesapla()
        {
            sonuc = odev1 * odevEtki + odev2 * odevEtki + vize * vizeEtki + finalNotu * finalNotuEtki;
            return sonuc;
        }
        public string DersNotuHesapla()
        {
            if (sonuc <= 100 && sonuc >= 90)
                harfNotu = "AA";
            else if (sonuc < 90 && sonuc >= 85)
                harfNotu = "BA";
            else if (sonuc < 85 && sonuc >= 80)
                harfNotu = "BB";
            else if (sonuc < 80 && sonuc >= 75)
                harfNotu = "CB";
            else if (sonuc < 75 && sonuc >= 65)
                harfNotu = "CC";
            else if (sonuc < 65 && sonuc >= 58)
                harfNotu = "DC";
            else if (sonuc < 58 && sonuc >= 50)
                harfNotu = "DD";
            else if (sonuc < 50 && sonuc >= 40)
                harfNotu = "FD";
            else
                harfNotu = "FF";
            return harfNotu;
        }
    }
    class Sinif
    {

        private Ogrenci[] ogrenci = new Ogrenci[100];
        public Sinif()
        {
            string[] metin = new string[100];
            int i = 0;
            FileStream fs = new FileStream("sinif.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader oku = new StreamReader(fs);
            while (oku.EndOfStream != true)
            {
                metin[i] = oku.ReadLine();
                string[] kelimeler = metin[i].Split(' ');
                Ogrenci ogr = new Ogrenci();
                ogr.OgrNo = kelimeler[0];
                ogr.Adi = kelimeler[1];
                ogr.Soyadi = kelimeler[2];
                ogr.Odev1 = Convert.ToDouble(kelimeler[3]);
                ogr.Odev2 = Convert.ToDouble(kelimeler[4]);
                ogr.Vize = Convert.ToDouble(kelimeler[5]);
                ogr.FinalNotu = Convert.ToDouble(kelimeler[6]);
                ogr.NotHesapla();
                ogr.DersNotuHesapla();
                ogr.DurumHesapla();
                OgrenciEkle(ogr, i);
                i++;
            }
            OgrSayisi = i;
            oku.Close();
        }
        public void OgrenciEkle(Ogrenci o, int i)
        {
            ogrenci[i] = o;
            ogrSayisi++;
        }
        private int ogrSayisi;
        public int OgrSayisi
        {
            get { return ogrSayisi; }
            set { ogrSayisi = value; }
        }
        public void OgrenciGoster()
        {
            Console.WriteLine("No\t\tAd\t\tSoyad\t\tOrtalama\tHarf Notu\tDurumu");
            Console.WriteLine();
            for (int i = 0; i < ogrSayisi; i++)
            {
                Console.WriteLine(ogrenci[i].OgrNo + "\t" + ogrenci[i].Adi + "\t\t" + ogrenci[i].Soyadi + "\t\t" + ogrenci[i].Sonuc + "\t\t" +
                    ogrenci[i].HarfNotu + "\t\t" + ogrenci[i].Durum);
            }
        }
        private double AAsayi, BAsayi, BBsayi, CBsayi, CCsayi, DCsayi, DDsayi, FDsayi, FFsayi;
        private double AAoran, BAoran, BBoran, CBoran, CCoran, DCoran, DDoran, FDoran, FForan;
        public void IstatistikHesapla()
        {
            double aa = 0, ba = 0, bb = 0, cb = 0, cc = 0, dc = 0, dd = 0, fd = 0, ff = 0;
            for (int i = 0; i < ogrSayisi; i++)
            {
                if (ogrenci[i].HarfNotu == "AA")
                    aa++;
                else if (ogrenci[i].HarfNotu == "BA")
                    ba++;
                else if (ogrenci[i].HarfNotu == "BB")
                    bb++;
                else if (ogrenci[i].HarfNotu == "CB")
                    cb++;
                else if (ogrenci[i].HarfNotu == "CC")
                    cc++;
                else if (ogrenci[i].HarfNotu == "DC")
                    dc++;
                else if (ogrenci[i].HarfNotu == "DD")
                    dd++;
                else if (ogrenci[i].HarfNotu == "FD")
                    fd++;
                else
                    ff++;
                AAsayi = aa; BAsayi = ba; BBsayi = bb; CBsayi = cb; CCsayi = cc; DCsayi = dc; DDsayi = dd; FDsayi = fd; FFsayi = ff;
                AAoran = (aa / ogrSayisi) * 100;
                BAoran = (ba / ogrSayisi) * 100;
                BBoran = (bb / ogrSayisi) * 100;
                CBoran = (cb / ogrSayisi) * 100;
                CCoran = (cc / ogrSayisi) * 100;
                DCoran = (dc / ogrSayisi) * 100;
                DDoran = (dd / ogrSayisi) * 100;
                FDoran = (fd / ogrSayisi) * 100;
                FForan = (ff / ogrSayisi) * 100;
            }
        }
        public void IstatistikKaydet()
        {
            FileStream fs = new FileStream("istatistik.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter yaz = new StreamWriter(fs);
            yaz.WriteLine("AAsayisi: " + AAsayi + " oran: % " + AAoran);
            yaz.WriteLine("BAsayisi: " + BAsayi + " oran: % " + BAoran);
            yaz.WriteLine("BBsayisi: " + BBsayi + " oran: % " + BAoran);
            yaz.WriteLine("CBsayisi: " + CBsayi + " oran: % " + CBoran);
            yaz.WriteLine("CCsayisi: " + CCsayi + " oran: % " + CCoran);
            yaz.WriteLine("DCsayisi: " + DCsayi + " oran: % " + DCoran);
            yaz.WriteLine("DDsayisi: " + DDsayi + " oran: % " + DDoran);
            yaz.WriteLine("FDsayisi: " + FDsayi + " oran: % " + FDoran);
            yaz.WriteLine("FFsayisi: " + FFsayi + " oran: % " + FForan);
            yaz.WriteLine("Kalan Sayısı\t: " + (FFsayi + FDsayi));
            yaz.WriteLine("Geçen Sayısı\t: " + (OgrSayisi - FFsayi - FDsayi));
            yaz.WriteLine("Kalan Oranı\t: % " + (FForan + FDoran));
            if (OgrSayisi > 0)
                yaz.WriteLine("Geçen Oranı\t: % " + (100 - FForan - FDoran));
            else
                yaz.WriteLine("Geçen Oranı\t: % 0");
            yaz.Close();
        }
        public void IstatistikGoster()
        {
            string[] metin = new string[13];
            int i = 0;
            FileStream fs = new FileStream("istatistik.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader oku = new StreamReader(fs);
            while (oku.EndOfStream != true)
            {
                metin[i] = oku.ReadLine();
                i++;
            }
            oku.Close();
            for (int j = 0; j < 13; j++)
            {
                Console.WriteLine(metin[j]);
            }
        }
        public void SinifKaydet()
        {
            FileStream fs = new FileStream("sinif.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter yaz = new StreamWriter(fs);
            for (int i = 0; i < ogrSayisi; i++)
            {
                yaz.WriteLine(ogrenci[i].OgrNo + " " + ogrenci[i].Adi + " " + ogrenci[i].Soyadi + " " + ogrenci[i].Odev1 + " " +
                    ogrenci[i].Odev2 + " " + ogrenci[i].Vize + " " + ogrenci[i].FinalNotu);
            }
            yaz.Close();
        }
    }
    class Program
    {
        static void menu()
        {
            while (true)
            {
                Ogrenci ogr = new Ogrenci();
                Sinif sinif = new Sinif();
                sinif.IstatistikHesapla();
                sinif.IstatistikKaydet();
                Console.Clear();
                char secim;
                Console.WriteLine("1.Öğrenci Ekle\n2.İstatistik Göster\n3.Sınıfı Göster\n4.Çıkış\n");
                Console.Write("Seçiminiz : ");
                secim = (char)Console.Read();
                switch (secim)
                {
                    case '1':
                        Console.Clear();
                        Console.ReadLine();
                        Console.WriteLine("\t\tÖĞRENCİNİN");
                        Console.Write("Numarası\t: ");
                        
                        ogr.Numara = Console.ReadLine().ToUpper();
                        
                        Console.Write("Adı\t\t: ");
                        ogr.Adi = Console.ReadLine().ToUpper();
                        Console.Write("Soyadı\t\t: ");
                        ogr.Soyadi = Console.ReadLine().ToUpper();

                        Console.Write("1. Ödev Notu\t: ");
                        ogr.Odev1 = Convert.ToDouble(Console.ReadLine());
                        
                        Console.Write("2. Ödev Notu\t: ");
                        ogr.Odev2 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Vize Notu\t: ");
                        ogr.Vize = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Final Notu\t: ");
                        ogr.FinalNotu = Convert.ToDouble(Console.ReadLine());
                        ogr.NotHesapla();
                        ogr.DersNotuHesapla();
                        ogr.DurumHesapla();

                        sinif.OgrenciEkle(ogr, sinif.OgrSayisi);
                        sinif.IstatistikHesapla();
                        sinif.SinifKaydet();
                        sinif.IstatistikKaydet();
                        Console.WriteLine("\nOrtalaması\t:" + ogr.Sonuc);
                        Console.WriteLine("Harf Notu\t:" + ogr.HarfNotu);
                        Console.WriteLine("Durumu\t\t:" + ogr.Durum);
                        Console.WriteLine("\nÖğrenci Başarıyla Eklendi.");
                        Console.Write("\nAna Menü İçin Bir Tuşa Basın...");
                        Console.ReadKey();
                        break;
                    case '2':
                        Console.Clear();
                        
                        sinif.IstatistikHesapla();
                        sinif.IstatistikKaydet();
                        sinif.IstatistikGoster();
                        Console.Write("\nAna Menü İçin Bir Tuşa Basın...");
                        Console.ReadKey();
                        break;
                    case '3':
                        Console.Clear();
                        
                        sinif.OgrenciGoster();
                        Console.Write("\nAna Menü İçin Bir Tuşa Basın...");
                        Console.ReadKey();
                        break;
                    case '4':
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }
            }
        }
        static void Main(string[] args)
        {
            Console.Title = "B191210049 EMRE HARMAN ODEV01";
            menu();
        }
    }
}
