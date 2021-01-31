using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Add(Musteri musteri)
        {
            Console.WriteLine("Kayıt Gerçekleşti. " + musteri.CustomerName);

        }
        public void Delete(Musteri musteri)
        {
            Console.WriteLine("Hesabınız Silindi. " + musteri.CustomerName);
        }
        public void List(Musteri musteri)
        {
            Console.WriteLine(musteri.Id);
        }
    }
}
