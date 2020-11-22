using System;

namespace MergeSort
{
    class Program
    {
        static public void MainMerge(int[] sayilar, int sol, int orta, int sağ)
        {
            int[] gecici = new int[25];
            int i, x, num, y;
            x = (orta - 1);
            y = sol;
            num = (sağ - sol + 1);
            while ((sol <= x) && (orta <= sağ))
            {
                if (sayilar[sol] <= sayilar[orta])
                    gecici[y++] = sayilar[sol++];
                else
                    gecici[y++] = sayilar[orta++];
            }
            while (sol <= x)
                gecici[y++] = sayilar[sol++];
            while (orta <= sağ)
                gecici[y++] = sayilar[orta++];
            for (i = 0; i < num; i++)
            {
                sayilar[sağ] = gecici[sağ];
                sağ--;
            }
        }
        static public void SortMerge(int[] sayilar, int sol, int sağ)
        {
            int orta;
            if (sağ > sol)
            {
                orta = (sağ + sol) / 2;
                SortMerge(sayilar, sol, orta);
                SortMerge(sayilar, (orta + 1), sağ);
                MainMerge(sayilar, sol, (orta + 1), sağ);
            }

        }
        static void Main(string[] args)
        {
          
            Console.WriteLine("Dizinin Eleman sayısını girniz: ");
            int max = Convert.ToInt32(Console.ReadLine());
            int[] sayilar = new int[max];
            for (int i = 0; i < max; i++)
            {
                Console.Write("\n Gir [" + (i + 1).ToString() + "] eleman: ");
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Diziye Girildi : ");
            Console.Write("\n");
            for (int k = 0; k < max; k++)
            {
                Console.Write(sayilar[k] + " ");
                Console.Write("\n");
            }
            Console.WriteLine("Merge ile Sıralandı");
            SortMerge(sayilar, 0, max - 1);
            for (int i = 0; i < max; i++)
                Console.WriteLine(sayilar[i]);
            Console.ReadLine();
        }
    }
}
