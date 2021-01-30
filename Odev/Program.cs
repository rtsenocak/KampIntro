using System;

namespace Odev
{
    class Program
    {
        static void Main(string[] args)
        {

            Urun urun1 = new Urun();
            urun1.urunAdi = ("Mi 10T Pro");
            urun1.urunTuru = ("Telefon");
            urun1.urunFiyatı = (5000);

            Urun urun2 = new Urun();
            urun2.urunAdi = ("Mi 10T Lite");
            urun2.urunTuru = ("Telefon");
            urun2.urunFiyatı = (3800);

            Urun urun3 = new Urun();
            urun3.urunAdi = ("Mi 10T");
            urun3.urunTuru = ("Telefon");
            urun3.urunFiyatı = (4500);



            //Console.WriteLine(urun1.urunAdi+" "+ urun1.urunTuru+" : "+urun1.urunFiyatı );

            Urun[] urunler = new Urun[] {urun1, urun2, urun3};

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.urunAdi+" "+urun.urunTuru+" : "+urun.urunFiyatı);
            }

        }

        class Urun
        {
            public string urunAdi { get; set; }
            public string urunTuru { get; set; }
            public int urunFiyatı { get; set; }
        }
    }
}
