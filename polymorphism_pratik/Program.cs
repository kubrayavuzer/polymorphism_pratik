using polymorphism_pratik;
using static polymorphism_pratik.BaseGeometrik;

class Program
{
    static void Main(string[] args)
    {
        //kare nesnesi oluşturup alan hesaplama
        Kare kare1 = new Kare();
        kare1.Genislik = 2;
        kare1.Yukseklik = 2;
        Console.WriteLine($"Kare Alanı: {kare1.AlanHesapla()}");

        // dikdörtgen nesnesi oluşturup alan hesaplama
        Dikdortgen dikdortgen1 = new Dikdortgen();
        dikdortgen1.Genislik = 5;
        dikdortgen1.Yukseklik = 10;
        Console.WriteLine($"Dikdörtgen Alanı: {dikdortgen1.AlanHesapla()}");

        //dik üçgen nesnesi oluşturup alan hesaplama
        DikUcgen dikUcgen1 = new DikUcgen();
        dikUcgen1.Genislik = 4;
        dikUcgen1.Yukseklik = 9;
        Console.WriteLine($"Dik Üçgen Alanı: {dikUcgen1.AlanHesapla()}");
    }
}