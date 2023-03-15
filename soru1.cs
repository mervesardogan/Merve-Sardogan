//soru1 
using System;

public class MaxBulmaAlgoritmalari
{
    static void Main(string[] args)
    {
        int[] dizi = new int[10000];
        Random rastgele = new Random();

        // Diziye rastgele sayılar ekleme
        for (int i = 0; i < dizi.Length; i++)
        {
            dizi[i] = rastgele.Next();
        }

        // Max Bulma Algoritması
        var baslangicZamani = DateTime.Now.Ticks;
        int max = MaxBulma(dizi);
        var bitisZamani = DateTime.Now.Ticks;
        var calismaSuresi = bitisZamani - baslangicZamani;

        Console.WriteLine("Max Bulma Algoritması çalışma süresi: " + calismaSuresi + " ticks.");
        // BruteForce Algoritması
        baslangicZamani = DateTime.Now.Ticks;
        int maxBrute = MaxBulmaBruteForce(dizi);
        bitisZamani = DateTime.Now.Ticks;
        calismaSuresi = bitisZamani - baslangicZamani;

        Console.WriteLine("BruteForce Algoritması çalışma süresi: " + calismaSuresi + " ticks.");
    }

    public static int MaxBulma(int[] dizi)
    {
        int max = int.MinValue;
        for (int i = 0; i < dizi.Length; i++)
        {
            if (dizi[i] > max)
            {
                max = dizi[i];
            }
        }
        return max;
    }

    public static int MaxBulmaBruteForce(int[] dizi)
    {
        int max = int.MinValue;
        for (int i = 0; i < dizi.Length; i++)
        {
            for (int j = i + 1; j < dizi.Length; j++)
            {
                if (dizi[j] > max)
                {
                    max = dizi[j];
                }
            }
        }
        return max;
    }
}
