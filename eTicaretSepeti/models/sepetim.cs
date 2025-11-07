using System;
using System.Collections.Generic;
using System.Linq;

namespace ETicaretSepeti.Models
{
    public class Sepet
    {
        public Musteriler Musteri { get; set; }
        public List<Urunler> Urunler { get; set; } = new List<Urunler>();

        public void UrunEkle(Urunler urun)
        {
            if (urun.Stok > 0)
            {
                Urunler.Add(urun);
                Console.WriteLine($"{urun.Ad} sepete eklendi.");
            }
            else
            {
                Console.WriteLine($"{urun.Ad} stokta yok!");
            }
        }

        public void UrunKaldir(Urunler urun)
        {
            if (Urunler.Remove(urun))
                Console.WriteLine($"{urun.Ad} sepetten çıkarıldı.");
            else
                Console.WriteLine($"{urun.Ad} sepette bulunamadı.");
        }

        public decimal ToplamFiyatHesapla()
        {
            return Urunler.Sum(u => u.Fiyat);
        }

        public void SepetiListele()
        {
            Console.WriteLine("\n--- Sepetiniz ---");
            foreach (var urun in Urunler)
                Console.WriteLine(urun);
            Console.WriteLine($"Toplam Fiyat: {ToplamFiyatHesapla()} TL\n");
        }
    }
}
