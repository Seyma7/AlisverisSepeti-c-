using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b191210029odv3ndp
{
    //Diğer sınıflar tarafından miras alınacak Urun sınıfı oluşturuldu.Özelliklerin veri tipleri belirtildi.
    abstract public class Urun
    {
        public string Ad;
        public string Marka;
        public string Model;
        public string Ozellik;
        public int StokAdedi;
        public int HamFiyat;
        public int SecilenAdet;
    }
    public class Buzdolabi : Urun
    {
        //Urun sınıfından kalıtım alındı.
        public double IcHacim;
        public string EnerjiSinifi;
        public Buzdolabi(string ad,string marka,string model,string ozellik,double icHacim, string enerjiSinifi)
        {
            Ad = ad;
            Marka = marka;
            Model = model;
            Ozellik = ozellik;
            IcHacim = icHacim;
            EnerjiSinifi = enerjiSinifi;
            //Rastgele 1-100 arasında stok adedi değeri atandı.
            Random rastgele = new Random(30);
            for (int i = 1; i < 100; i++)
            {
                    int sayi = rastgele.Next(1, 100);
                    StokAdedi = sayi;
            }
        }
        public double KdvUygula()
        {//Ham fiyat,seçilen adet ve kdv oranına göre kdvli fiyat hesaplandı.
            HamFiyat = 3500;
            double KdvliFiyat = HamFiyat * SecilenAdet * (1.05);
            return KdvliFiyat;   
        }
    }
    public class LedTv : Urun
    {
        public double EkranBoyutu;
        public double EkranCozunurlugu;
        public LedTv(string ad, string marka, string model, string ozellik,double ekranBoyutu, double ekranCozunurlugu)
        {
            Ad = ad;
            Marka = marka;
            Model = model;
            Ozellik = ozellik;
            EkranBoyutu = ekranBoyutu;
            EkranCozunurlugu = ekranCozunurlugu;
            //Rastgele 1-100 arasında stok adedi değeri atandı.
            Random rastgele = new Random(31);
            for (int i = 1; i < 100; i++)
            {
                int sayi = rastgele.Next(1, 100);
                StokAdedi = sayi;
            }
        }
        public double KdvUygula()
        {//Ham fiyat,seçilen adet ve kdv oranına göre kdvli fiyat hesaplandı.
            HamFiyat = 4000;
            double KdvliFiyat = HamFiyat * SecilenAdet * (1.18);
            return KdvliFiyat;
        }
    }
    public class CepTel : Urun
    {
        public double DahiliHafiza;
        public double RamKapasitesi;
        public double PilGucu;
        public CepTel(string ad, string marka, string model, string ozellik,double dahiliHafiza, double ramKapasitesi, double pilGucu)
        {
            Ad = ad;
            Marka = marka;
            Model = model;
            Ozellik = ozellik;
            DahiliHafiza = dahiliHafiza;
            RamKapasitesi = ramKapasitesi;
            PilGucu = pilGucu;
            //Rastgele 1-100 arasında stok adedi değeri atandı.
            Random rastgele = new Random(32);
            for (int i = 1; i < 100; i++)
            {
                int sayi = rastgele.Next(1, 100);
                StokAdedi = sayi;
            }
        }
        public double KdvUygula()
        {//Ham fiyat,seçilen adet ve kdv oranına göre kdvli fiyat hesaplandı.
            HamFiyat = 2500;
            double KdvliFiyat = HamFiyat * SecilenAdet * (1.2);
            return KdvliFiyat;
        }
    }

    public class Laptop : Urun
    { 
        public double EkranBoyutu;
        public double EkranCozunurlugu;
        public double DahiliHafiza;
        public double RamKapasitesi;
        public double PilGucu;
        public Laptop(string ad, string marka, string model, string ozellik,double ekranBoyutu, double ekranCozunurlugu, double dahiliHafiza, double ramKapasitesi, double pilGucu)
        {
            Ad = ad;
            Marka = marka;
            Model = model;
            Ozellik = ozellik;
            EkranBoyutu = ekranBoyutu;
            EkranCozunurlugu = ekranCozunurlugu;
            DahiliHafiza = dahiliHafiza;
            RamKapasitesi = ramKapasitesi;
            PilGucu = pilGucu;
            //Rastgele 1-100 arasında stok adedi değeri atandı.
            Random rastgele = new Random(40);
            for (int i = 1; i < 100; i++)
            {
                int sayi = rastgele.Next(1, 100);
                StokAdedi = sayi;
            }
        }
        public double KdvUygula()
        {//Ham fiyat,seçilen adet ve kdv oranına göre kdvli fiyat hesaplandı.
            HamFiyat = 6000;
            double KdvliFiyat = HamFiyat * SecilenAdet * (1.15);
            return KdvliFiyat;        }
    }
   

}
