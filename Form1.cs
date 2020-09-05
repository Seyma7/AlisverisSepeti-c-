/************************************************************************************************************************************************
 * *************************************          SAKARYA ÜNİVERSİTESİ BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
 * ********************************       BİLGİSAYAR MÜHENDİSLİĞİ BAHAR DÖNEMİ NESNEYE DAYALI PROGRAMLAMA 3.ÖDEVİ 2019-2020
 * ***************************         
 * ***********************              ÖĞRENCİ: ŞEYMA GÖL
 * *********************                NUMARASI: B191210029
 * *********************                SINIFI: 1-C (1.ÖĞRETİM)
 * ***********************
 * *********************************
 * ***************************************
 * *************************************************************************************************************************************************/


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace b191210029odv3ndp
{
    public partial class Form1 : Form
    {
        //Sepet sınıfından bir nesne oluşturuldu.
        Sepet sepet;
        //Buzdolabı,Laptop,LedTv,CepTel sınıflarına ait nesneler oluşturuldu.
        Buzdolabi buzdolabi = new Buzdolabi("RT46K6000S8/TR A","Samsung", "468 lt", "No-Frost", (1860 * 760 * 737), "AA");
        Laptop laptop = new Laptop("Inspiron 5490","DELL","10110U", " Intel Core i3", (15.6), (1280 * 800), 16, 1, 6);
        LedTv ledTv = new LedTv("UE-43RU7100","Samsung", "LED", "Siyah", (50 * 126), (1920 * 1080));
        CepTel cepTel = new CepTel("GALAXY S8", "Samsung", "529", "8 Çekirdek", 8, 1, 1);

        private void Form1_Load(object sender, EventArgs e)
        {
        //Ürünlerin randomla atanan stok adetleri labellara yazdırıldı.
            label17.Text = buzdolabi.StokAdedi.ToString();
            label18.Text = laptop.StokAdedi.ToString();
            label19.Text = ledTv.StokAdedi.ToString();
            label20.Text = cepTel.StokAdedi.ToString();
        }

        public void clear()
        {
        //clear fonksiyonuyla listboxlar ve label25 temizlendi.
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            if (label25.Text != null)
            {
                label25.Text = " ";
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        int sayac;

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
        //numericUpDown1 değeri buzdolabının seçilen adedine atandı.
            buzdolabi.SecilenAdet = Convert.ToInt32(numericUpDown1.Value);
            sayac += buzdolabi.SecilenAdet;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
        //numericUpDown2 değeri laptobun seçilen adedine atandı.
            laptop.SecilenAdet = Convert.ToInt32(numericUpDown2.Value);
            sayac += laptop.SecilenAdet;
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
        //numericUpDown3 değeri ledTv'nin seçilen adedine atandı.
            ledTv.SecilenAdet = Convert.ToInt32(numericUpDown3.Value);
            sayac += ledTv.SecilenAdet;
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
         //numericUpDown4 değeri cepTel'in seçilen adedine atandı.
            cepTel.SecilenAdet = Convert.ToInt32(numericUpDown4.Value);
            sayac += cepTel.SecilenAdet;
        }

        public class Sepet
        {
        //Urun parametreli fonksiyonda seçilen ürün miktarı kadar stoktan düşüldü.
            public void sepeteUrunEkle(Urun urun)
            {
                for (int i = 0; i < urun.SecilenAdet; i++)
                {
                    urun.StokAdedi--;
                }
            }
        }
        public void sepeteEkle()
        {
        //Sepet sınıfından nesne oluşturuldu.
            sepet = new Sepet();
        //Kdvli fiyatların toplamı label25'e yazdırıldı.
            label25.Text = Convert.ToString(buzdolabi.KdvUygula() + cepTel.KdvUygula() + laptop.KdvUygula() + ledTv.KdvUygula());
        //ListBox1 boşsa yani ürün seçilmediyse şartı konuldu.
            if (listBox1.Items.Count == 0)
            {
                //Ürünlerin seçilen adedi listBox1'e,isimleri listBox2'ye,kdvli fiyatları listBox3'e yazdırıldı.
                //Sadece seçilmiş olan ürünlerin yazdırılması için,stok adedinden fazla seçilememesi için koşul konuldu.
                //sepeteUrunEkle fonksiyonu herbir ürün için çağırıldı.
                //labellara ürünlerin yeni stok adetleri yazdırıldı.
                if (buzdolabi.SecilenAdet != 0 && buzdolabi.StokAdedi >= buzdolabi.SecilenAdet)
                {
                    listBox1.Items.Add(numericUpDown1.Value.ToString() + "  ");
                    listBox2.Items.Add("Buzdolabı" + "  ");
                    listBox3.Items.Add(buzdolabi.KdvUygula());
                    sepet.sepeteUrunEkle(buzdolabi);
                    label17.Text = buzdolabi.StokAdedi.ToString();
                }
                if (laptop.SecilenAdet != 0 && laptop.StokAdedi >= laptop.SecilenAdet)
                {
                    listBox1.Items.Add(numericUpDown2.Value.ToString() + "  ");
                    listBox2.Items.Add("Laptop" + "  ");
                    listBox3.Items.Add(laptop.KdvUygula());
                    sepet.sepeteUrunEkle(laptop);
                    label18.Text = laptop.StokAdedi.ToString();
                }
                if (ledTv.SecilenAdet != 0 && ledTv.StokAdedi >= ledTv.SecilenAdet)
                {
                    listBox1.Items.Add(numericUpDown3.Value.ToString() + "  ");
                    listBox2.Items.Add("Led TV" + "  ");
                    listBox3.Items.Add(ledTv.KdvUygula());
                    sepet.sepeteUrunEkle(ledTv);
                    label19.Text = ledTv.StokAdedi.ToString();
                }
                if (cepTel.SecilenAdet != 0 && cepTel.StokAdedi >= cepTel.SecilenAdet)
                {
                    listBox1.Items.Add(numericUpDown4.Value.ToString() + "  ");
                    listBox2.Items.Add("Cep Telefonu" + "  ");
                    listBox3.Items.Add(cepTel.KdvUygula());
                    sepet.sepeteUrunEkle(cepTel);
                    label20.Text = cepTel.StokAdedi.ToString();
                }
            }
        }
        public void addstock()
        {
        //Ürün sepetten silindiğinde stoğa geri eklenmesi için koşullar oluşturuldu.
        //labellara yeni stok adedi yazdırıldı.
            if (buzdolabi.SecilenAdet != 0)
            {
                for (int i = 0; i < buzdolabi.SecilenAdet; i++)
                {
                    buzdolabi.StokAdedi++;
                }
            }
            label17.Text = buzdolabi.StokAdedi.ToString();

            if (laptop.SecilenAdet != 0)
            {
                for (int i = 0; i < laptop.SecilenAdet; i++)
                {
                    laptop.StokAdedi++;
                }
            }
            label18.Text = laptop.StokAdedi.ToString();

            if (ledTv.SecilenAdet != 0)
            {
                for (int i = 0; i < ledTv.SecilenAdet; i++)
                {
                    ledTv.StokAdedi++;
                }
            }
            label19.Text = ledTv.StokAdedi.ToString();

            if (cepTel.SecilenAdet != 0)
            {
                for (int i = 0; i < cepTel.SecilenAdet; i++)
                {
                    cepTel.StokAdedi++;
                }
            }
            label20.Text = cepTel.StokAdedi.ToString();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
        //Sepete Ekle butonuna tıklandığında sepeteEkle() fonksiyonu çağırıldı.
            sepeteEkle();
        }
        private void button2_Click(object sender, EventArgs e)
        {
        //Sepeti Temizle butonuna tıklandığında addstock,clear fonksiyonları çağırıldı,numericUpDownlar temizlendi.
            addstock();
            clear();
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            numericUpDown3.Value = 0;
            numericUpDown4.Value = 0;
        }
        private void label25_Click(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
