using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taskagitmakas
{
    public partial class Form1 : Form
    {
        int tur = 3;
        int turBasinaSure = 6;
        Boolean oyunDurum = false;
        String[] bilgisayarSecimList = { "tas", "kagit", "makas" };
        int sayi = 0;
        Random rnd = new Random();
        String bilgisayarSecim, oyuncuSecim;

        int oyuncuSkor, bilgisayarSkor;

        public Form1()
        {
            InitializeComponent();
            zamanSay.Enabled = true; //sayaç açıldı
            oyuncuSecim = "none";
            lblGeriSayac.Text = "5";
        }

        private void btnTas_Click(object sender, EventArgs e)
        {
            picOyuncu.Image = Properties.Resources.indir__1_;
            oyuncuSecim = "tas";
        }

        private void btnKagit_Click(object sender, EventArgs e)
        {
            picOyuncu.Image = Properties.Resources.images;
            oyuncuSecim = "kagit";
        }

        private void btnMakas_Click(object sender, EventArgs e)
        {
            picOyuncu.Image = Properties.Resources.indir;
            oyuncuSecim = "makas";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ZamanSayEvent(object sender, EventArgs e)
        {
            turBasinaSure -= 1;
            lblGeriSayac.Text = turBasinaSure.ToString();
            lblTur.Text = "Tur : " + tur;

            if (turBasinaSure < 1)
                zamanSay.Enabled = false;

            sayi= rnd.Next(0, bilgisayarSecimList.Length);
            bilgisayarSecim = bilgisayarSecimList[sayi];

            switch (bilgisayarSecim)
            {
                case "tas":
                    picBilgisayar.Image = Properties.Resources.indir__1_;
                    break;

                case "kagit":
                    picBilgisayar.Image = Properties.Resources.images;
                    break;

                case "makas":
                    picBilgisayar.Image = Properties.Resources.indir;
                    break;

            }

            if (tur > 0)
            {
                OyunKontrol();
            }
            else
            {
                if (oyuncuSkor > bilgisayarSkor)
                {
                    MessageBox.Show("Oyuncu Oyunu Kazandı");
                }
                else
                {
                    MessageBox.Show("Bilgisayar Oyunu Kazandı");
                }
            }        
        }

        private void btnTekrar_Click(object sender, EventArgs e)
        {
            oyuncuSkor = 0;
            bilgisayarSkor = 0;
            lblGeriSayac.Text = "5";
            int turBasinaSure = 6;
            tur = 3;

            lblSkor.Text = "Oyuncu : " + oyuncuSkor.ToString() + "-" + "Bilgisayar : " + bilgisayarSkor.ToString();
            oyuncuSecim = "none";
            zamanSay.Enabled = true;
            picOyuncu.Image = Properties.Resources.indir__2_;
            picBilgisayar.Image = Properties.Resources.indir__2_;
        }

        private void OyunKontrol()
        {
            //Bilgisayar
            if (oyuncuSecim=="tas" && bilgisayarSecim=="kagit")
            {
                bilgisayarSkor += 1;
                tur -= 1;
                MessageBox.Show("Bilgisayar Kazandı");
            }
            
            else if (oyuncuSecim == "kagit" && bilgisayarSecim == "makas")
            {
                bilgisayarSkor += 1;
                tur -= 1;
                MessageBox.Show("Bilgisayar Kazandı");
            }
            else if (oyuncuSecim == "makas" && bilgisayarSecim == "tas")
            {
                bilgisayarSkor += 1;
                tur -= 1;
                MessageBox.Show("Bilgisayar Kazandı");
            }

            //Oyuncu
            else if (oyuncuSecim == "kagit" && bilgisayarSecim == "tas")
            {
                oyuncuSkor += 1;
                tur -= 1;
                MessageBox.Show("Oyuncu Kazandı");
            }
            else if (oyuncuSecim == "makas" && bilgisayarSecim == "kagit")
            {
                oyuncuSkor += 1;
                tur -= 1;
                MessageBox.Show("Oyuncu Kazandı");
            }
            else if (oyuncuSecim == "tas" && bilgisayarSecim == "makas")
            {
                oyuncuSkor += 1;
                tur -= 1;
                MessageBox.Show("Oyuncu Kazandı");
            }
            else if (oyuncuSecim == "none")
            {
                MessageBox.Show("Seçim Yap");
            }
            else
            {
                MessageBox.Show("Berabere");
            }
            yeniTur();
        }

        private void yeniTur()
        {
            if (oyunDurum == true)
            {
                return;
                
            }
            lblSkor.Text = "Oyuncu  " + oyuncuSkor.ToString() + "-" +bilgisayarSkor.ToString()+" "+ "Bilgisayar";
            oyuncuSecim = "none";
            zamanSay.Enabled = true;
            picOyuncu.Image = Properties.Resources.indir__2_;
            picBilgisayar.Image = Properties.Resources.indir__2_;
        }
    }
}
