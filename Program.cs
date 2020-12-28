using System;

namespace Odev_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("5 Sayılı Dizi Sıralama ve Aralarındaki Sayıları Bulma");
            int min;
            int max;
            // int[] dizi = { 13, 19, -5, 89, 70 }; // Aşağıda kullanıcıdan alıyoruz.
            try
            {
                Console.WriteLine("Sayıları giriniz:");
                string str = Console.ReadLine();
                char[] ayracKarakterler = { ' ', ',', '.', ':', '\t' };

                string[] stringDizi = str.Split(ayracKarakterler);
                int[] dizi = new int[5];

                for (int k = 0; k < 5; k++)
                {
                    dizi[k] = int.Parse(stringDizi[k]);
                }
                DiziYazdir(dizi); // Önce diziyi yazdırıyoruz.
                Sirala(dizi, out min, out max); // Diziyi sıralıyoruz
                DiziYazdir(dizi);
                DiziYazdir(dizi, min, max);
                Console.WriteLine($"{dizi} --> {min} - {max}");
            }
            catch(Exception e)
            {
                throw new ArgumentException();
            }
        }

        static void Sirala(int[] dizi, out int sayiMinimum, out int sayiMaksimum)
        {
            // Bubble Sort algoritması kullanarak, dizi, küçükten büyüğe doğru sıralandı.
            int sayac = dizi.Length;
            for (int i = 0; i < sayac - 1; i++)
            {
                for (int j = 0; j < sayac - i - 1; j++)
                {
                    if (dizi[j] > dizi[j + 1])
                    {
                        int geciciSayi = dizi[j];
                        dizi[j] = dizi[j + 1];
                        dizi[j + 1] = geciciSayi;
                    }     
                }
            }
            sayiMinimum = dizi[0];
            sayiMaksimum = dizi[dizi.Length-1];
        }

        static void DiziYazdir(int[] dizi)
        {
            foreach(var item in dizi)
                Console.WriteLine($"-> {item}");
        }
        static void DiziYazdir(int[] dizi, int min, int max)
        {
            for (int i = 0; i <= (max - min); i++)
            {
                if(min+i==dizi[0]|| min + i == dizi[1] || min + i == dizi[2] || min + i == dizi[3] || min + i == dizi[4])
                    Console.WriteLine($"===> {min + i}"); // Dizide yer alan veriler '===>' işareti ile yazdırılır.
                else
                    Console.WriteLine($"---> {min + i}"); // Arada yer alan sayılar '--->' işareti ile yazdırılır.
            }
        }

    }
}

