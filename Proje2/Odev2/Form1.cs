/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2019-2020 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........: Ödev II
**				ÖĞRENCİ ADI............: Emre Harman
**				ÖĞRENCİ NUMARASI.......: B191210049
**              DERSİN ALINDIĞI GRUP...: 1B
****************************************************************************/


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Button btnArkadasMi = new Button() 
        {
            Text = "ARKADAŞ MI",
            Width = 100,
            Height = 30,
            Location = new Point(30, 150),
        };
        TextBox txtX = new TextBox() 
        {
            Location = new Point(60, 45),
            Width = 150
        };
        TextBox txtY = new TextBox() 
        {
            Location = new Point(60, 95),
            Width = 150
        };    
        private void btnArkadasMiTiklandi(object sender,EventArgs e)
        {
            this.Width = 600;
            this.Height = 400;
            btnArkadasMi.Enabled = false;
            
            Label lblX = new Label();
            lblX.Text = "X";
            lblX.Location = new Point(350, 30);
            lblX.AutoSize = true;
            this.Controls.Add(lblX);

            Label lblY = new Label();
            lblY.Text = "Y";
            lblY.Location = new Point(500, 30);
            lblY.AutoSize = true;
            this.Controls.Add(lblY);

            ListBox lstX = new ListBox();
            lstX.Height = 200;
            lstX.Location = new Point(300, 50);
            this.Controls.Add(lstX);

            ListBox lstY = new ListBox();
            lstY.Height = 200;
            lstY.Location = new Point(450, 50);
            this.Controls.Add(lstY);

            Label lblToplam = new Label();
            lblToplam.Text = "TOPLAMLAR";
            lblToplam.AutoSize = true;
            lblToplam.Location = new Point(200, 270);
            this.Controls.Add(lblToplam);

            TextBox txtXToplam = new TextBox();
            txtXToplam.Location = new Point(300, 265);
            txtXToplam.Width = lstX.Width;
            txtXToplam.Enabled = false;
            this.Controls.Add(txtXToplam);

            TextBox txtYToplam = new TextBox();
            txtYToplam.Location = new Point(450, 265);
            txtYToplam.Width = lstY.Width;
            txtYToplam.Enabled = false;
            this.Controls.Add(txtYToplam);

            int x = Convert.ToInt32(txtX.Text);
            int y = Convert.ToInt32(txtY.Text);
            int xBolenlerToplam=0;
            int yBolenlerToplam=0;

            int[] xBolenler = new int[100];
            int[] yBolenler = new int[100];
            int xIndex = 0;
            int yIndex = 0;

            //X değerinin bölenleri bir dizi içerisine alınıyor ve toplamları hesaplanıyor.
            for(int i = 1; i < x; i++)
            {
                if (x % i == 0)
                {
                    xBolenlerToplam = xBolenlerToplam + i;
                    xBolenler[xIndex] = i;
                    xIndex++;
                }
            }
            //Y değerinin bölenleri bir dizi içerisine alınıyor ve toplamları hesaplanıyor.
            for(int i = 1; i < y; i++)
            {
                if (y % i == 0)
                {
                    yBolenlerToplam = yBolenlerToplam + i;
                    yBolenler[yIndex] = i;
                    yIndex++;
                }
            }
            //X ve Y'nin dizi içerisine alınan bölenleri kendi listbox'larına ekleniyor.
            for(int i = 0; i < xIndex; i++)
            {
                lstX.Items.Add(xBolenler[i]);
            }
            for(int i = 0; i < yIndex; i++)
            {
                lstY.Items.Add(yBolenler[i]);
            }

            txtXToplam.Text = Convert.ToString(xBolenlerToplam);
            txtYToplam.Text = Convert.ToString(yBolenlerToplam);

            Label lblSonuc = new Label();
            lblSonuc.AutoSize = false;
            lblSonuc.Font = new Font(lblSonuc.Font.FontFamily, 12,FontStyle.Bold);
            lblSonuc.BackColor = Color.LimeGreen;
            lblSonuc.Location = new Point(150, 320);
            lblSonuc.BorderStyle = BorderStyle.FixedSingle;
            lblSonuc.Height = 30;
            lblSonuc.Width = 250;
            lblSonuc.TextAlign = ContentAlignment.MiddleCenter;
            this.Controls.Add(lblSonuc);

            if (x == yBolenlerToplam && y == xBolenlerToplam)
                lblSonuc.Text = "Sayılar Arkadaştır";
            else
                lblSonuc.Text = "Sayılar Arkadaş Değildir";
        }
        private void btnSonTiklandi(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "ARKADAŞ SAYILAR";
            this.Width = 300;
            this.Height = 300;

            Label lblX = new Label();
            lblX.Text = "X";
            lblX.Location = new Point(30, 50);
            lblX.AutoSize = true;
            this.Controls.Add(lblX);            
            
            this.Controls.Add(txtX);

            Label lblY = new Label();
            lblY.Text = "Y";
            lblY.Location = new Point(30, 100);
            lblY.AutoSize = true;
            this.Controls.Add(lblY);
            
            this.Controls.Add(txtY);
                        
            btnArkadasMi.Click += btnArkadasMiTiklandi;
            this.Controls.Add(btnArkadasMi);

            Button btnSon = new Button();
            btnSon.Text = "SON";
            btnSon.Width = 50;
            btnSon.Height = 30;
            btnSon.Font = new Font(btnSon.Font.FontFamily, 10);
            btnSon.Location = new Point(180, 150);
            btnSon.Click += btnSonTiklandi;
            this.Controls.Add(btnSon);
        }  
    }
}
