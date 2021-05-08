using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tas_Kagıt_Makas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string O_Secim; //oyuncu seçimi
        string B_Secim; //bilgisayar seçimi
        int Oyncu_Puan; //oyuncu puanı
        int B_Puan; //bilgisayar puanı
        int rastgele;
        Random random = new Random();

        private void oyuncu_puanı_Click(object sender, EventArgs e)
        {

        }

        private void Tas_Click(object sender, EventArgs e)
        {
            Oyuncu.ImageLocation = "Resimler/tas.jpg"; //Picture Box'a taş resmini ekler
            O_Secim = "Taş";
        }

        private void Kagıt_Click(object sender, EventArgs e)
        {
            Oyuncu.ImageLocation = "Resimler/kagit.jpg";//Picture Box'a kağıt resmini ekler
            O_Secim = "Kağıt";
        }

        private void Makas_Click(object sender, EventArgs e)
        {
            Oyuncu.ImageLocation = "Resimler/makas.jpg"; //Picture Box'a makas resmini ekler
            O_Secim = "Makas";
        }

        private void Bilgisayar_Hamle()
        {
            //3 seçeneğimiz var Taş Kağıt Makas -> 1,2,3
            rastgele = random.Next(1, 4); 
            if(rastgele==1)
            {
                Bilgisayar.ImageLocation = "Resimler/tas.jpg";
                B_Secim = "Taş";
            }
            else if(rastgele==2)
            {
                Bilgisayar.ImageLocation = "Resimler/kagit.jpg";
                B_Secim = "Kağıt";
            }
            else if(rastgele==3)
            {
                Bilgisayar.ImageLocation = "Resimler/makas.jpg";
                B_Secim = "Makas";
            }
        }

        private void btn_oyun_Click(object sender, EventArgs e)
        {
            //Start butonuna tıkladığımızda oyuncu ve bilgisayar puanı sıfırsa herşeyin içini boşaltır.
            if(Oyncu_Puan==0 && B_Puan==0)
            {
                label5.Visible = false;
                label6.Visible = false;
                Oyuncu_Puanı.Text = "0";
                Bilgisayar_Puanı.Text = "0";
            }
            //oyuncu seçimi boşken bilgisayar hamle yapmaya çalışırsa uyarı alır.
            if(O_Secim==null)
            {
                MessageBox.Show("Hamle Şeçimi Yapmalısınız.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Bilgisayar_Hamle();
            }

            puanlama();
        }
        private void puanlama()
        {

            if(O_Secim == "Taş" && B_Secim == "Kağıt")
            {
                B_Puan++; //Taş kağıtı sarar.Bilgisayar puanı 1 artar.
                Bilgisayar_Puanı.Text = B_Puan.ToString(); // Ekrana puanı yazdırır.
            }
            else if(O_Secim == "Taş" && B_Secim == "Makas")
            {
                Oyncu_Puan++; //Taş makası kırar.Oyuncu puanı 1 artar.
                Oyuncu_Puanı.Text = Oyncu_Puan.ToString();
            }
            else if (O_Secim == "Kağıt" && B_Secim == "Taş")
            {
                Oyncu_Puan++; //kağıt taşı sarar.
                Oyuncu_Puanı.Text = Oyncu_Puan.ToString();
            }
            else if (O_Secim == "Kağıt" && B_Secim == "Makas")
            {
                B_Puan++; //makas kağıdı keser.
                Bilgisayar_Puanı.Text = B_Puan.ToString();
            }
            else if (O_Secim == "Makas" && B_Secim == "Taş")
            {
                B_Puan++; //taş makası kırar.
                Bilgisayar_Puanı.Text = B_Puan.ToString();
            }
            else if(O_Secim=="Makas" && B_Secim=="Kağıt")
            {
                Oyncu_Puan++; //makas kağıdı keser.
                Oyuncu_Puanı.Text = Oyncu_Puan.ToString();
            }

            //Bilgisayar puanı ve oyuncu puanı 10 olduğunda kazananı ekrana yazdırır.
            if(B_Puan==10 || Oyncu_Puan==10)
            {
                label5.Visible = true;
                label6.Visible = true;
                // kazanan ekrana yazdırıldıktan sonra tüm değerler sıfırlanır.
                if(B_Puan> Oyncu_Puan)
                {
                    label6.Text = "BİLGİSAYAR";
                    Oyncu_Puan = 0;
                    B_Puan = 0;
                    Bilgisayar.ImageLocation = null;
                    Oyuncu.ImageLocation = null;
                    B_Secim = null;
                    O_Secim = null;
                }
                else if (Oyncu_Puan> B_Puan)
                {
                    label6.Text = "OYUNCU";
                    Oyncu_Puan = 0;
                    B_Puan = 0;
                    Bilgisayar.ImageLocation = null;
                    Oyuncu.ImageLocation = null;
                    B_Secim = null;
                    O_Secim = null;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
