using System;

namespace Selection_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayi = new int [6] { 7, 10, 12, 9, 1, 5 };
            Console.WriteLine("Selection Sort");
            for (int i = 0; i < sayi.Length; i++)
            {
                Console.WriteLine(sayi[i]+ " ");
            }

            int a;
            int min;
            for (int i = 0; i < sayi.Length-1; i++)
            {
                min = i;
                ///Console.WriteLine(+b);
                for (int j = i + 1; j < sayi.Length; j++)
                {
                    if (sayi[j]<sayi[min])
                    {
                        min = j;
                    }
                }

                a = sayi[i];
                sayi[i] = sayi[min];
                sayi[min] = a;
            }

            Console.WriteLine("Sıralı Dizi: ");
            for (int i = 0; i < sayi.Length; i++)
            {
                Console.WriteLine(sayi[i]+" ");
            }
            
        }
    }
}
