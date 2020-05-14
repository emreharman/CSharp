using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Odev3
{
    class Buzdolabi:Urun
    {
        public Buzdolabi(string ad, string marka, string model, string ozellik, double hamFiyat, int secilenAdet,
            int icHacim,string enerjiSinifi)
        {
            this.Ad = ad;
            this.Marka = marka;
            this.Model = model;
            this.Ozellik = ozellik;
            this.HamFiyat = hamFiyat;
            this.SecilenAdet = secilenAdet;
            this.IcHacim = icHacim;
            this.EnerjiSinifi = enerjiSinifi;
            //Her ürünün stok adedinin farklı gelmesi için
            Thread.Sleep(10);            
            this.StokAdedi = rastgele.Next(1, 100);
        }

        private int icHacim;
        public int IcHacim
        {
            get { return icHacim; }
            set { icHacim = value; }
        }
        private string enerjiSinifi;
        public string EnerjiSinifi
        {
            get { return enerjiSinifi; }
            set { enerjiSinifi = value; }
        }
        public void KdvUygula()
        {
            KdvliFiyat = HamFiyat * 1.05 * SecilenAdet;
        }
    }
}
