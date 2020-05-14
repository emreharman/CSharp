using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje
{
    class AtikKutusu : IAtikKutusu
    {
        private string kategori;
        private int kapasite;
        private int doluHacim;
        private int dolulukOrani;
        private int bosaltmaPuani;

        public AtikKutusu(string kategori,int kapasite,int bosaltmaPuani)
        {
            this.DoluHacim = 0;
            this.DolulukOrani = 0;
            this.kategori = kategori;
            this.Kapasite = kapasite;
            this.bosaltmaPuani = bosaltmaPuani;
        }
        public string Kategori
        {
            get
            {
                return kategori;
            }
        }
        public int Kapasite { get { return kapasite; } set { kapasite = value; } }
        public int DoluHacim { get { return doluHacim; } set { doluHacim = value; } }
        public int DolulukOrani { 
            get { return dolulukOrani; } 
            set { dolulukOrani = value; } 
        }
        public int BosaltmaPuani { get { return bosaltmaPuani; } }
        public bool Ekle(Atik atik) {
            if (atik.Kategori == this.Kategori)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Bosalt() {
            if (this.DolulukOrani >= 75)
            {
                return true;
            }
            else
            {
                return false;
            } 
                
        }
    }
}
