using System;

class ZamanFarkiHesaplama
{
    // İlk sürüm: Gün cinsinden farkı döndürür
    public int ZamanFarkiniHesapla(DateTime baslangicTarihi, DateTime bitisTarihi)
    {
        return (bitisTarihi - baslangicTarihi).Days;
    }

    // İkinci sürüm: Saat cinsinden farkı döndürür
    public int ZamanFarkiniHesapla(DateTime baslangicTarihi, DateTime bitisTarihi, string birim)
    {
        if (birim.ToLower() == "saat")
        {
            return (int)(bitisTarihi - baslangicTarihi).TotalHours;
        }
        else
        {
            return 0; // Eğer birim saat değilse 0 döndürüyoruz.
        }
    }

    // Üçüncü sürüm: Yıl, ay ve gün cinsinden farkı döndürür
    public void ZamanFarkiniHesapla(DateTime baslangicTarihi, DateTime bitisTarihi)
    {
        int yil = bitisTarihi.Year - baslangicTarihi.Year;
        int ay = bitisTarihi.Month - baslangicTarihi.Month;
        int gun = bitisTarihi.Day - baslangicTarihi.Day;

        if (gun < 0)
        {
            ay--;
            gun += DateTime.DaysInMonth(bitisTarihi.Year, bitisTarihi.Month);
        }

        if (ay < 0)
        {
            yil--;
            ay += 12;
        }

        Console.WriteLine($"Zaman farkı: {yil} yıl, {ay} ay, {gun} gün.");
    }
}

class Program
{
    static void Main()
    {
        ZamanFarkiHesaplama hesaplama = new ZamanFarkiHesaplama();
        DateTime baslangicTarihi = new DateTime(2022, 5, 15);
        DateTime bitisTarihi = new DateTime(2024, 8, 10);

        // Gün cinsinden fark
        Console.WriteLine("Gün cinsinden fark: " + hesaplama.ZamanFarkiniHesapla(baslangicTarihi, bitisTarihi));

        // Saat cinsinden fark
        Console.WriteLine("Saat cinsinden fark: " + hesaplama.ZamanFarkiniHesapla(baslangicTarihi, bitisTarihi, "saat"));

        // Yıl, ay ve gün cinsinden fark
        hesaplama.ZamanFarkiniHesapla(baslangicTarihi, bitisTarihi);
    }
}
