using System;

class SekilHesaplama
{
    // Bir karenin alanını hesaplar (kenar uzunluğu verilerek)
    public int AlanHesapla(int kenar)
    {
        return kenar * kenar;
    }

    // Bir dikdörtgenin alanını hesaplar (iki kenar uzunluğu verilerek)
    public int AlanHesapla(int uzunluk, int genislik)
    {
        return uzunluk * genislik;
    }

    // Bir dairenin alanını hesaplar (yarıçap verilerek)
    public double AlanHesapla(double yaricap)
    {
        return Math.PI * yaricap * yaricap;
    }
}

class Program
{
    static void Main()
    {
        SekilHesaplama hesaplama = new SekilHesaplama();

        // Kare alanı
        Console.WriteLine("Karenin Alanı: " + hesaplama.AlanHesapla(5)); // 5x5 = 25

        // Dikdörtgen alanı
        Console.WriteLine("Dikdörtgenin Alanı: " + hesaplama.AlanHesapla(4, 6)); // 4x6 = 24

        // Daire alanı
        Console.WriteLine("Dairenin Alanı: " + hesaplama.AlanHesapla(3.5)); // π * 3.5^2
    }
}

