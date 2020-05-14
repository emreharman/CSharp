using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje
{
    public partial class Form1 : Form
    {
        static int sure = 60;
        static int puan = 0;
        //Atıklar
        static Atik camSise = new Atik("Cam Şişe","cam", 600, Image.FromFile("sise.png"));
        static Atik bardak = new Atik("Bardak","cam", 250, Image.FromFile("bardak.png"));
        static Atik gazete = new Atik("Gazete","kagit", 250, Image.FromFile("gazete.png"));
        static Atik dergi = new Atik("Dergi","kagit", 200, Image.FromFile("dergi.png"));
        static Atik domates = new Atik("Domates","organik", 150, Image.FromFile("domates.png"));
        static Atik salatalik = new Atik("Salatalık","organik", 120, Image.FromFile("salatalik.png"));
        static Atik cola = new Atik("Cola Kutusu","metal", 350, Image.FromFile("cola.png"));
        static Atik salca = new Atik("Salça Kutusu","metal", 550, Image.FromFile("salca.png"));
        static Atik[] atiklarDizi = { camSise, bardak, gazete, dergi, domates, salatalik, cola, salca };
        static Random random = new Random();
        static int rastgele = random.Next(8);
        

        //Atık Kutuları
        AtikKutusu organik = new AtikKutusu("organik", 700, 0);
        AtikKutusu kagit = new AtikKutusu("kagit", 1200, 100);
        AtikKutusu cam = new AtikKutusu("cam", 2200, 600);
        AtikKutusu metal = new AtikKutusu("metal", 2300, 800);

        //Butonları disable etmek için metot
        public void BtnDisable()
        {
            btnOrganikAtik.Enabled = false;
            btnBosaltOrganikAtik.Enabled = false;
            btnKagitAtik.Enabled = false;
            btnBosaltKagitAtik.Enabled = false;
            btnCamAtik.Enabled = false;
            btnBosaltCamAtik.Enabled = false;
            btnMetalAtik.Enabled = false;
            btnBosaltMetalAtik.Enabled = false;
        }

        //Butonları enable etmek için metot
        public void BtnEnable()
        {
            btnOrganikAtik.Enabled = true;
            btnBosaltOrganikAtik.Enabled = true;
            btnKagitAtik.Enabled = true;
            btnBosaltKagitAtik.Enabled = true;
            btnCamAtik.Enabled = true;
            btnBosaltCamAtik.Enabled = true;
            btnMetalAtik.Enabled = true;
            btnBosaltMetalAtik.Enabled = true;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BtnDisable();


            picAtik.Image = atiklarDizi[rastgele].Image;
            
            lblSure.Text = Convert.ToString(sure);
        }

        private void btnYeniOyun_Click(object sender, EventArgs e)
        {
            sure = 60;
            puan = 0;
            BtnEnable();            
            timerSure.Start();
            organik.DolulukOrani = 0;
            organik.DoluHacim = 0;
            kagit.DolulukOrani = 0;
            kagit.DoluHacim = 0;
            cam.DolulukOrani = 0;
            cam.DoluHacim = 0;
            metal.DolulukOrani = 0;
            metal.DoluHacim = 0;
            pbarOrganikAtik.Value = organik.DoluHacim;
            pbarKagitAtik.Value = kagit.DoluHacim;
            pbarCamAtik.Value = cam.DoluHacim;
            pbarMetalAtik.Value = metal.DoluHacim;
            lstOrganikAtik.Items.Clear();
            lstKagitAtik.Items.Clear();
            lstCamAtik.Items.Clear();
            lstMetalAtik.Items.Clear();
            lblYuzdeOrganik.Text = "%"+Convert.ToString(organik.DolulukOrani);
            lblYuzdeKagit.Text = "%" + Convert.ToString(kagit.DolulukOrani);
            lblYuzdeCam.Text = "%" + Convert.ToString(cam.DolulukOrani);
            lblYuzdeMetal.Text = "%" + Convert.ToString(metal.DolulukOrani);
            lblPuan.Text = Convert.ToString(puan);
        }

        private void timerSure_Tick(object sender, EventArgs e)
        {
            if (sure == 0)
            {
                timerSure.Stop();
                BtnDisable();
            }
            lblSure.Text = Convert.ToString(sure);
            sure--;
        }

        private void btnOrganikAtik_Click(object sender, EventArgs e)
        {
            if (organik.Ekle(atiklarDizi[rastgele]))
            {
                if (organik.DolulukOrani <= 75)
                {
                    organik.DoluHacim += atiklarDizi[rastgele].Hacim;
                    organik.DolulukOrani = (organik.DoluHacim*100)/organik.Kapasite;
                    puan += atiklarDizi[rastgele].Hacim;
                    lstOrganikAtik.Items.Add(atiklarDizi[rastgele].Isim + " (" + Convert.ToString(atiklarDizi[rastgele].Hacim) + ")");
                    pbarOrganikAtik.Value = organik.DoluHacim;
                    lblPuan.Text = Convert.ToString(puan);
                    lblYuzdeOrganik.Text = "%" + Convert.ToString(organik.DolulukOrani);
                    rastgele = random.Next(8);
                    picAtik.Image = atiklarDizi[rastgele].Image;
                }
            } 
        }

        private void btnBosaltOrganikAtik_Click(object sender, EventArgs e)
        {
            if (organik.Bosalt())
            {
                organik.DoluHacim = 0;
                organik.DolulukOrani = 0;
                puan += organik.BosaltmaPuani;
                sure += 3;
                pbarOrganikAtik.Value = 0;
                lstOrganikAtik.Items.Clear();
                lblPuan.Text = Convert.ToString(puan);
                lblYuzdeOrganik.Text = "%" + Convert.ToString(organik.DolulukOrani);
            }
        }

        private void btnKagitAtik_Click(object sender, EventArgs e)
        {
            if (kagit.Ekle(atiklarDizi[rastgele]))
            {
                if (kagit.DolulukOrani <= 75)
                {
                    kagit.DoluHacim += atiklarDizi[rastgele].Hacim;
                    kagit.DolulukOrani = (kagit.DoluHacim*100 ) / kagit.Kapasite;
                    puan += atiklarDizi[rastgele].Hacim;
                    lstKagitAtik.Items.Add(atiklarDizi[rastgele].Isim + " (" + Convert.ToString(atiklarDizi[rastgele].Hacim) + ")");
                    pbarKagitAtik.Value = kagit.DoluHacim;
                    lblPuan.Text = Convert.ToString(puan);
                    lblYuzdeKagit.Text = "%" + Convert.ToString(kagit.DolulukOrani);
                    rastgele = random.Next(8);
                    picAtik.Image = atiklarDizi[rastgele].Image;
                }
            }
        }

        private void btnBosaltKagitAtik_Click(object sender, EventArgs e)
        {
            if (kagit.Bosalt())
            {
                kagit.DoluHacim = 0;
                kagit.DolulukOrani = 0;
                sure += 3;
                puan += kagit.BosaltmaPuani;
                pbarKagitAtik.Value = 0;
                lstKagitAtik.Items.Clear();
                lblPuan.Text = Convert.ToString(puan);
                lblYuzdeKagit.Text = "%" + Convert.ToString(kagit.DolulukOrani);
            }
        }

        private void btnCamAtik_Click(object sender, EventArgs e)
        {
            if (cam.Ekle(atiklarDizi[rastgele]))
            {
                if (cam.DolulukOrani <= 75)
                {
                    cam.DoluHacim += atiklarDizi[rastgele].Hacim;
                    cam.DolulukOrani = (cam.DoluHacim *100) / cam.Kapasite;
                    puan += atiklarDizi[rastgele].Hacim;
                    lstCamAtik.Items.Add(atiklarDizi[rastgele].Isim + " (" + Convert.ToString(atiklarDizi[rastgele].Hacim) + ")");
                    pbarCamAtik.Value = cam.DoluHacim;
                    lblPuan.Text = Convert.ToString(puan);
                    lblYuzdeCam.Text = "%" + Convert.ToString(cam.DolulukOrani);
                    rastgele = random.Next(8);
                    picAtik.Image = atiklarDizi[rastgele].Image;
                }
            }
        }

        private void btnBosaltCamAtik_Click(object sender, EventArgs e)
        {
            if (cam.Bosalt())
            {
                cam.DoluHacim = 0;
                cam.DolulukOrani = 0;
                puan += cam.BosaltmaPuani;
                sure += 3;
                pbarCamAtik.Value = 0;
                lstCamAtik.Items.Clear();
                lblPuan.Text = Convert.ToString(puan);
                lblYuzdeCam.Text = "%" + Convert.ToString(cam.DolulukOrani);
            }
        }

        private void btnMetalAtik_Click(object sender, EventArgs e)
        {
            if (metal.Ekle(atiklarDizi[rastgele]))
            {
                if (metal.DolulukOrani <= 75)
                {
                    metal.DoluHacim += atiklarDizi[rastgele].Hacim;
                    metal.DolulukOrani = (metal.DoluHacim *100) / metal.Kapasite;
                    puan += atiklarDizi[rastgele].Hacim;
                    lstMetalAtik.Items.Add(atiklarDizi[rastgele].Isim + " (" + Convert.ToString(atiklarDizi[rastgele].Hacim) + ")");
                    pbarMetalAtik.Value = metal.DoluHacim;
                    lblPuan.Text = Convert.ToString(puan);
                    lblYuzdeMetal.Text = "%" + Convert.ToString(metal.DolulukOrani);
                    rastgele = random.Next(8);
                    picAtik.Image = atiklarDizi[rastgele].Image;
                }
            }
        }

        private void btnBosaltMetalAtik_Click(object sender, EventArgs e)
        {
            if (metal.Bosalt())
            {
                metal.DoluHacim = 0;
                metal.DolulukOrani = 0;
                puan += metal.BosaltmaPuani;
                sure += 3;
                pbarMetalAtik.Value = 0;
                lstMetalAtik.Items.Clear();
                lblPuan.Text = Convert.ToString(puan);
                lblYuzdeMetal.Text = "%" + Convert.ToString(metal.DolulukOrani);
            }
        }
    }
}
