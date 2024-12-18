using System;

class Calculator
{
    // İki tam sayıyı toplar
    public int Topla(int a, int b)
    {
        return a + b;
    }

    // Üç tam sayıyı toplar
    public int Topla(int a, int b, int c)
    {
        return a + b + c;
    }

    // Bir dizi (array) tam sayıyı toplar
    public int Topla(int[] sayilar)
    {
        int toplam = 0;
        foreach (int sayi in sayilar)
        {
            toplam += sayi;
        }
        return toplam;
    }
}

class Program
{
    static void Main()
    {
        Calculator calc = new Calculator();

        // İki tam sayıyı toplama
        Console.WriteLine("İki tam sayının toplamı: " + calc.Topla(5, 10)); // Output: 15

        // Üç tam sayıyı toplama
        Console.WriteLine("Üç tam sayının toplamı: " + calc.Topla(5, 10, 15)); // Output: 30

        // Bir dizi tam sayıyı toplama
        int[] sayilar = { 5, 10, 15, 20 };
        Console.WriteLine("Dizi tam sayılarının toplamı: " + calc.Topla(sayilar)); // Output: 50
    }
}
