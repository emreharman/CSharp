using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Odev3
{
    class LedTv:Urun
    {
        public LedTv(string ad, string marka, string model, string ozellik, double hamFiyat, int secilenAdet,
            double ekranBoyutu,string ekranCozunurlugu)
        {
            this.Ad = ad;
            this.Marka = marka;
            this.Model = model;
            this.Ozellik = ozellik;
            this.HamFiyat = hamFiyat;
            this.SecilenAdet = secilenAdet;
            this.EkranBoyutu = ekranBoyutu;
            this.EkranCozunurlugu = ekranCozunurlugu;
            //Her ürünün stok adedinin farklı gelmesi için
            Thread.Sleep(10);
            this.StokAdedi = rastgele.Next(1, 100);
        }

        private double ekranBoyutu;
        public double EkranBoyutu
        {
            get { return ekranBoyutu; }
            set { ekranBoyutu = value; }
        }
        private string ekranCozunurlugu;
        public string EkranCozunurlugu
        {
            get { return ekranCozunurlugu; }
            set { ekranCozunurlugu = value; }
        }
        public void KdvUygula()
        {
            KdvliFiyat = HamFiyat * 1.18 * SecilenAdet;
        }

    }
}
