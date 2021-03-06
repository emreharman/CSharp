﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Odev3
{
    class LapTop:Urun
    {
        public LapTop(string ad,string marka,string model,string ozellik,double hamFiyat,int secilenAdet,
            double ekranBoyutu,string ekranCozunurluk,int dahiliHafiza,int ramKapasitesi,int pilGucu)
        {
            this.Ad = ad;
            this.Marka = marka;
            this.Model = model;
            this.Ozellik = ozellik;
            this.HamFiyat = hamFiyat;
            this.SecilenAdet = secilenAdet;
            this.EkranBoyutu = ekranBoyutu;
            this.EkranCozunurluk = ekranCozunurluk;
            this.DahiliHafiza = dahiliHafiza;
            this.RamKapasitesi = ramKapasitesi;
            this.PilGucu = pilGucu;
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
        private string ekranCozunurluk;
        public string EkranCozunurluk
        {
            get { return ekranCozunurluk; }
            set { ekranCozunurluk = value; }
        }
        private int dahiliHafiza;
        public int DahiliHafiza
        {
            get { return dahiliHafiza; }
            set { dahiliHafiza = value; }
        }
        private int ramKapasitesi;
        public int RamKapasitesi
        {
            get { return ramKapasitesi; }
            set { ramKapasitesi = value; }
        }
        private int pilGucu;
        public int PilGucu
        {
            get { return pilGucu; }
            set { pilGucu = value; }
        }
        public void KdvUygula()
        {
            KdvliFiyat = HamFiyat * 1.15 * SecilenAdet;
        }
    }
}
