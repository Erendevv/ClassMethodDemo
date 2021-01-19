using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    public class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {

            Console.WriteLine("Yeni Müşteri Eklendi :" + musteri.Ad);
        }

        public void MusteriSil(Musteri musteri)
        {

            Console.WriteLine(musteri.Ad + " isimli müşteri silindi.");
        }
        public void MusteriListele(Musteri[] musteriler)
        {
            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.Id + " numaralı müşteri : " + musteri.Ad);
            }
        }

    }
}
