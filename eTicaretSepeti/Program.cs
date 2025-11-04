using System;
using ETicaretSepeti.Models;

namespace ETicaretSepeti
{
    class Program
    {
        static void Main(string[] args)
        {
            var musteri = new Musteriler { Id = 1, AdSoyad = "Kadir Yolcu", Eposta = "example@example.com" };

            var urun1 = new Urunler { Id = 1, Ad = "Kitap", Fiyat = 250, Stok = 5 };
            var urun2 = new Urunler { Id = 2, Ad = "Kalem", Fiyat = 80, Stok = 12 };
            var urun3 = new Urunler { Id = 3, Ad = "Defter", Fiyat = 100, Stok = 3 };

        }
    }
}
