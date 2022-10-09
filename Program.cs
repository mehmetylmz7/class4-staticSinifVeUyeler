using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classlar4_staticSinifVeUyeler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calisan Sayisi: {0}",Calisan.CalisanSayisi);

            Calisan calisan = new Calisan("Ayse", "Yilmaz", "IK");
            Console.WriteLine("Calisan Sayisi: {0}",Calisan.CalisanSayisi);

            Calisan calisan1 = new Calisan("Didier","Drogba","Futbol Maneger");
            Calisan calisan2 = new Calisan("Arda","Turkmen","Ascı");
            Console.WriteLine("Calisan Sayisi: "+ Calisan.CalisanSayisi);

            /* // static bir class oldugundan bu sekilde erisemeyiz 

               Islemler islemler=new Islemler()
                  islemler.*/

            Console.WriteLine("toplama islemi sonucu: " + Islemler.Toplama(200, 100));
            Console.WriteLine("cıkarma islemi sonucu: "+Islemler.Cikarma(100,31));


            Console.ReadLine();
        }
    }

    class Calisan
    {
        private static int calisanSayisi;

        public static int CalisanSayisi { get => calisanSayisi;}

        private string Isim;

        private string Soyisim;

        private string Departman;

        static Calisan()
        {
            calisanSayisi = 0;

        }

        public Calisan(string ısim, string soyisim, string departman)
        {
            this.Isim = ısim;
            this.Soyisim = soyisim;
            this.Departman = departman;
            calisanSayisi++;
        }
    }

    static class Islemler
    {
        public static long Toplama(int sayi1,int sayi2)
        {
            return sayi1 + sayi2;
        }

        public static long Cikarma(int sayi1,int sayi2)
        {
            return sayi1 - sayi2;
        }
    }
}
