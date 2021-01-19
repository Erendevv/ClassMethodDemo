using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Musteri Eren = new Musteri();
            Eren.Id = 1;
            Eren.Ad = "Eren";
            Eren.Sehir = "Kastamonu";

            Musteri Berk = new Musteri();
            Berk.Id = 2;
            Berk.Ad = "Berk";
            Berk.Sehir = "Ordu";

            Musteri[] musteriler = new Musteri[] { Eren, Berk };

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriEkle(Berk);
            musteriManager.MusteriEkle(Eren);
            Console.WriteLine("**************************");
            musteriManager.MusteriSil(Berk);
            Console.WriteLine("**************************");
            musteriManager.MusteriListele(musteriler);
         
        }
    }
}
