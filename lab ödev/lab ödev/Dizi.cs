using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace lab_ödev
{
    internal class Dizi
    {

        public int[,] dizim = new int[8, 8];
        public int[,] DiziAl()
        {
            int[,] dizi = new int[8, 8];

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Console.Write($"Lütfen [{i},{j}] elemanını girin: ");
                    // metni tam sayıya çevirmeye çalışır
                    if (int.TryParse(Console.ReadLine(), out int eleman))
                    {
                        dizi[i, j] = eleman;
                    }
                    else
                    {
                        Console.WriteLine("Geçersiz bir sayı girdiniz. Lütfen tekrar deneyin.");
                        j--;
                    }
                }
            }
            return dizi;
        }

        public void RandomDizi()
        {
            Random rdm = new Random();

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    dizim[i, j] = rdm.Next(0, 10);
                }
            }
        }



        // girilen diziyi istenen şekle çevirir (j. elemanı (j+1)-j şekline çevirir)
        public void DiziDuzenle(int[,] dizi)
        {
            for (int i = 0; i < 8; i++)
            {

                dizim[i, 0] = dizi[i, 0];

                //  elemanları (j+1)-j şekline çevir 
                for (int j = 1; j < 8; j++)
                {
                    dizim[i, j] = dizi[i, j] - dizi[i, j - 1];

                }

                //     Console.WriteLine();
            }
        }

        // parametre olarak girilen diziyi yazdırır
        public void DiziyiYazdir(int[,] arr)
        {
            Console.WriteLine("SIKIŞTIRILMIŞ DİZİ ------------");
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }

        }

        // girilen dizinin her satırındaki elemanları toplayıp binaty karşılığını yazdırır
        public void SıkıstırmaOranı(int[,] arr)
        {

            for (int i = 0; i < 8; i++)
            {
                string toplam = "";
                int deger = 0;

                for (int j = 0; j < 8; j++)
                {
                    deger += arr[i, j];
                    toplam = Convert.ToString(deger, 2); // deger değişkeninin binary karşılıpı bulunur

                }
                Console.WriteLine(i + 1 + ". satırın sıkıştırma oranı = " + toplam);
            }

        }
    }
}



