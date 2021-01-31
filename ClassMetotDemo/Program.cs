using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.CustomerName = "M.Said";
            musteri1.CustomerLastName = "Gürbüz";
            musteri1.Gender = "Erkek";
            musteri1.TcId = "1234567890";
            musteri1.CustomerRating = 3;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.CustomerName = "Davud";
            musteri2.CustomerLastName = "Tokmak";
            musteri2.Gender = "Erkek";
            musteri2.TcId = "222222222";
            musteri2.CustomerRating = 5;


            Musteri[] musteris = new Musteri[] { musteri1, musteri2 };

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(musteri1);
            // Operasyon kod

            foreach (var musteri in musteris)
            {
                
                Console.WriteLine(musteri.CustomerName); // müşterileri döngüde yazdırma kodu

            }
        }
    }
}
