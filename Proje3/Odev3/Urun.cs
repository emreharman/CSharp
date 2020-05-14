using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev3
{
    class Urun
    {
        private string ad;
        public string Ad
        {
            get { return ad; }
            set { ad = value; }
        }
        private string marka;
        public string Marka
        {
            get { return marka; }
            set { marka = value; }
        }
        private string model;
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        private string ozellik;
        public string Ozellik
        {
            get { return ozellik; }
            set { ozellik = value; }
        }
        private int stokAdedi;
        protected Random rastgele = new Random();
        public int StokAdedi
        {
            get { return stokAdedi; }
            set { stokAdedi = value; }
        }
        private double hamFiyat;
        public double HamFiyat
        {
            get { return hamFiyat; }
            set { hamFiyat = value; }
        }
        private int secilenAdet;
        public int SecilenAdet
        {
            get { return secilenAdet; }
            set { secilenAdet = value; }
        }
        private double kdvliFiyat;
        public double KdvliFiyat
        {
            get { return kdvliFiyat; }
            set { kdvliFiyat = value; }
        }
    }
}
