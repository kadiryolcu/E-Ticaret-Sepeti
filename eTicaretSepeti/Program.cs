using System;
using System.Collections.Generic;
using ETicaretSepeti.Models;

namespace ETicaretSepeti
{
    class Program
    {
        static void Main(string[] args)
        {
            // Müşteri oluştur
            var musteri = new Musteriler { Id = 1, AdSoyad = "Kadir Yolcu", Eposta = "kadir@example.com" };

            // Ürünler oluştur
            var urunler = new List<Urunler>
            {
                new Urunler { Id = 1, Ad = "Projeksiyon", Fiyat = 25000, Stok = 8 },
                new Urunler { Id = 2, Ad = "HDML Kablo", Fiyat = 900, Stok = 7 },
                new Urunler { Id = 3, Ad = "Kumanda", Fiyat = 400, Stok = 3 },
                new Urunler { Id = 4, Ad = "Pil", Fiyat = 100, Stok = 2 }
            };

            var sepet = new Sepet { Musteri = musteri };

            bool devam = true;
            while (devam)
            {
                Console.WriteLine("\n----- E-Ticaret Sepeti Menü -----");
                Console.WriteLine("1. Sepeti Listele");
                Console.WriteLine("2. Ürün Ekle");
                Console.WriteLine("3. Ürün Kaldır");
                Console.WriteLine("4. Toplam Fiyatı Göster");
                Console.WriteLine("5. Çıkış");
                Console.Write("Seçim: ");
                string secim = Console.ReadLine();

                switch (secim)
                {
                    case "1":
                        sepet.SepetiListele();
                        break;

                    case "2":
                        Console.WriteLine("\nEklenebilecek Ürünler:");
                        foreach (var u in urunler)
                            Console.WriteLine($"{u.Id}. {u.Ad} - Fiyat: {u.Fiyat} - Stok: {u.Stok}");
                        Console.Write("Eklemek istediğiniz ürün ID'si: ");
                        if (int.TryParse(Console.ReadLine(), out int ekleId))
                        {
                            var urunEkle = urunler.Find(u => u.Id == ekleId);
                            if (urunEkle != null)
                                sepet.UrunEkle(urunEkle);
                            else
                                Console.WriteLine("Ürün bulunamadı!");
                        }
                        break;

                    case "3":
                        if (sepet.Urunler.Count == 0)
                        {
                            Console.WriteLine("Sepet boş, çıkarılacak ürün yok!");
                            break;
                        }
                        Console.WriteLine("\nSepetinizdeki Ürünler:");
                        foreach (var u in sepet.Urunler)
                            Console.WriteLine($"{u.Id}. {u.Ad} - Fiyat: {u.Fiyat}");
                        Console.Write("Sepetten çıkarmak istediğiniz ürün numarası: ");
                        if (int.TryParse(Console.ReadLine(), out int cikarId))
                        {
                            var urunCikar = sepet.Urunler.Find(u => u.Id == cikarId);
                            if (urunCikar != null)
                                sepet.UrunKaldir(urunCikar);
                            else
                                Console.WriteLine("Ürün sepette bulunamadı!");
                        }
                        break;

                    case "4":
                        Console.WriteLine($"Toplam Fiyat: {sepet.ToplamFiyatHesapla()} TL");
                        break;

                    case "5":
                        devam = false;
                        break;

                    default:
                        Console.WriteLine("Geçersiz seçim!");
                        break;
                }
            }

            Console.WriteLine("Programdan çıkılıyor...");
        }
    }
}
