using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        LedTv tv = new LedTv("Led Tv", "lg", "xxx", "x", 4000, 0, 14, "1240");
        Buzdolabi bd = new Buzdolabi("Buzdolabı", "arcelik", "abc", "x", 3500, 0, 300, "aa");
        LapTop lt = new LapTop("Lap Top", "asus", "xxx", "ab", 6000, 0, 14, "1240", 500, 8, 10000);
        CepTel ct = new CepTel("Cep Telefonu", "samsung", "a5", "abc", 2500, 0, 64, 2, 3000);
        private void Form1_Load(object sender, EventArgs e)
        {
            //ledTv                       
            lblLedTvHamFiyat.Text = Convert.ToString(tv.HamFiyat);
            lblLedTvStok.Text = Convert.ToString(tv.StokAdedi);
            nmrLedTvSecilenAdet.Value = tv.SecilenAdet;

            //Buzdolabi            
            lblBuzdolabiHamFiyat.Text = Convert.ToString(bd.HamFiyat);
            lblBuzdolabiStok.Text = Convert.ToString(bd.StokAdedi);
            nmrBuzdolabiSecilenAdet.Value = bd.SecilenAdet;

            //LapTop
            lblLapTopHamFiyat.Text = Convert.ToString(lt.HamFiyat);
            lblLapTopStok.Text = Convert.ToString(lt.StokAdedi);
            nmrLapTopSecilenAdet.Value = lt.SecilenAdet;

            //CepTel
            lblCepTelHamFiyat.Text = Convert.ToString(ct.HamFiyat);
            lblCepTelStok.Text = Convert.ToString(ct.StokAdedi);
            nmrCepTelSecilenAdet.Value = ct.SecilenAdet;
        }
        private void btnSepeteEkle_Click(object sender, EventArgs e)
        {
            Sepet sepet = new Sepet();
            lstAdet.Items.Clear();
            lstKdvliFiyat.Items.Clear();
            lstUrun.Items.Clear();

            //ledTv
            tv.SecilenAdet = Convert.ToInt32(nmrLedTvSecilenAdet.Value);
            tv.KdvUygula();
            tv.StokAdedi -= tv.SecilenAdet;
            lblLedTvStok.Text = Convert.ToString(tv.StokAdedi);
            sepet.SepeteUrunEkle(tv);
            if (tv.SecilenAdet != 0)
            {
                lstAdet.Items.Add(tv.SecilenAdet);
                lstUrun.Items.Add(tv.Ad);
                lstKdvliFiyat.Items.Add(String.Format("{0:0.00}", tv.KdvliFiyat));
            }

            //Buzdolabi
            bd.SecilenAdet = Convert.ToInt32(nmrBuzdolabiSecilenAdet.Value);
            bd.KdvUygula();
            bd.StokAdedi -= bd.SecilenAdet;
            lblBuzdolabiStok.Text = Convert.ToString(bd.StokAdedi);
            sepet.SepeteUrunEkle(bd);
            if (bd.SecilenAdet != 0)
            {
                lstAdet.Items.Add(bd.SecilenAdet);
                lstUrun.Items.Add(bd.Ad);
                lstKdvliFiyat.Items.Add(String.Format("{0:0.00}", bd.KdvliFiyat));
            }            

            //Laptop
            lt.SecilenAdet = Convert.ToInt32(nmrLapTopSecilenAdet.Value);
            lt.KdvUygula();
            lt.StokAdedi -= lt.SecilenAdet;
            lblLapTopStok.Text = Convert.ToString(lt.StokAdedi);
            sepet.SepeteUrunEkle(lt);
            if (lt.SecilenAdet != 0)
            {
                lstAdet.Items.Add(lt.SecilenAdet);
                lstUrun.Items.Add(lt.Ad);
                lstKdvliFiyat.Items.Add(String.Format("{0:0.00}", lt.KdvliFiyat));
            }            

            //CepTel
            ct.SecilenAdet = Convert.ToInt32(nmrCepTelSecilenAdet.Value);
            ct.KdvUygula();
            ct.StokAdedi -= ct.SecilenAdet;
            lblCepTelStok.Text = Convert.ToString(ct.StokAdedi);
            sepet.SepeteUrunEkle(ct);
            if (ct.SecilenAdet != 0)
            {
                lstAdet.Items.Add(ct.SecilenAdet);
                lstUrun.Items.Add(ct.Ad);
                lstKdvliFiyat.Items.Add(String.Format("{0:0.00}", ct.KdvliFiyat));
            }
            

            double toplamFiyat = tv.KdvliFiyat + bd.KdvliFiyat + lt.KdvliFiyat + ct.KdvliFiyat;
            lblKdvliToplamFiyat.Text = Convert.ToString(toplamFiyat) + " TL";
        }

        private void btnSepetiTemizle_Click(object sender, EventArgs e)
        {          
          
            //LedTv
            tv.SecilenAdet = Convert.ToInt32(nmrLedTvSecilenAdet.Value);
            tv.StokAdedi += tv.SecilenAdet;
            lblLedTvStok.Text = Convert.ToString(tv.StokAdedi);

            //Buzdolabı
            bd.SecilenAdet = Convert.ToInt32(nmrBuzdolabiSecilenAdet.Value);
            bd.StokAdedi += bd.SecilenAdet;
            lblBuzdolabiStok.Text = Convert.ToString(bd.StokAdedi);

            //Laptop
            lt.SecilenAdet = Convert.ToInt32(nmrLapTopSecilenAdet.Value);
            lt.StokAdedi += lt.SecilenAdet;
            lblLapTopStok.Text = Convert.ToString(lt.StokAdedi);

            //CepTel
            ct.SecilenAdet = Convert.ToInt32(nmrCepTelSecilenAdet.Value);
            ct.StokAdedi += ct.SecilenAdet;
            lblCepTelStok.Text = Convert.ToString(ct.StokAdedi);

            lblKdvliToplamFiyat.Text = "0 TL";

            lstAdet.Items.Clear();
            lstKdvliFiyat.Items.Clear();
            lstUrun.Items.Clear();
            nmrBuzdolabiSecilenAdet.Value = 0;
            nmrCepTelSecilenAdet.Value = 0;
            nmrLapTopSecilenAdet.Value = 0;
            nmrLedTvSecilenAdet.Value = 0;
        }
    }
}
