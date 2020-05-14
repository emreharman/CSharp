using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje
{
    public class Atik : IAtik
    {
        private string isim;
        private string kategori;
        private int hacim;
        private System.Drawing.Image image;
        public Atik(string isim,string kategori,int hacim, System.Drawing.Image Image)
        {
            this.isim = isim;
            this.kategori = kategori;
            this.hacim = hacim;
            this.image = Image;
        }
        public string Isim
        {
            get { return isim; }
        }
        public string Kategori
        {
            get
            {
                return kategori;
            }
        }
        public int Hacim
        {
            get { return hacim; }
        } 

        public System.Drawing.Image Image {
            get
            {
                return image;
            } 
        }
    }
}
