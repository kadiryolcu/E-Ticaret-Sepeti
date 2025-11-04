namespace ETicaretSepeti.Models
{
    public class Urunler
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public decimal Fiyat { get; set; }
        public int Stok { get; set; }

        public override string ToString()
        {
            return $"{Ad} - Fiyat: {Fiyat} - Stok: {Stok}";
        }
    }
}
