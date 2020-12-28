using System;
using System.Collections.Generic;
using System.Text;

namespace Odev_10
{
    class Program2
    {
        static void Main2(string[] args)
        {
            // Rakamları oku.
            // Rakamları küçükten büyüğe sırala.
            // Rakamları yazdır.
            Console.WriteLine("Rakamları giriniz:");
            int a = 0, b = 0, c = 0, d = 0, e = 0;

            string str = Console.ReadLine();
            char[] ayracKarakterler = { ' ', ',', '.', ':', '\t' };

            string[] strDizi = str.Split(ayracKarakterler);

            int[] dizi = new int[5];
            for (int k = 0; k < 5; k++)
            {
                dizi[k] = int.Parse(strDizi[k]);
            }

            int n = 5, i;
            Console.WriteLine("İlk sıralama: ");
            for (i = 0; i < n; i++)
            {
                Console.WriteLine(dizi[i] + " ");
            }
            DiziSiralama(dizi, 5);

            int m = dizi[0]; //-5
            int l = dizi[4]; // 15
            Console.WriteLine("Sıralı dizi: ");
            for (i = 0; i <= l - m; i++)
            {
                if (m + i == dizi[0] || m + i == dizi[1] || m + i == dizi[2] || m + i == dizi[3] || m + i == dizi[4])
                    Console.WriteLine("==>" + (m + i));
                else
                    Console.WriteLine("-->" + (m + i) + " ");

            }

        }

        static void SayilariSirala(int[] dizi, int n, int i)
        {
            int enbuyuk = i;
            int sol = 2 * i + 1;
            int sag = 2 * i + 2;
            if (sol < n && dizi[sol] > dizi[enbuyuk])
                enbuyuk = sol;
            if (sag < n && dizi[sag] > dizi[enbuyuk])
                enbuyuk = sag;

            if (enbuyuk != i)
            {
                int swap = dizi[i];
                dizi[i] = dizi[enbuyuk];
                dizi[enbuyuk] = swap;
                SayilariSirala(dizi, n, enbuyuk);
            }
        }

        static void DiziSiralama(int[] dizi, int n)
        {
            for (int i = n / 2 - 1; i >= 0; i--)
                SayilariSirala(dizi, n, i);

            for (int i = n - 1; i >= 0; i--)
            {
                int temp = dizi[0];
                dizi[0] = dizi[i];
                dizi[i] = temp;
                SayilariSirala(dizi, i, 0);
            }
        }
    }
}
