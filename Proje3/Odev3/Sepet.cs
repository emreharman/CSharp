using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev3
{
    class Sepet
    {
        public Sepet()
        {
            UrunSayisi = 0;
        }
        private Urun[] urunler = new Urun[100];
        private int urunSayisi;
        public int UrunSayisi
        {
            get { return urunSayisi; }
            set { urunSayisi = value; }
        }
        public void SepeteUrunEkle(Urun urun)
        {
            for(int i = 0; i < urun.SecilenAdet; i++)
            {
                urunler[UrunSayisi] = urun;
                UrunSayisi++;
            }
        }    
    }
}
