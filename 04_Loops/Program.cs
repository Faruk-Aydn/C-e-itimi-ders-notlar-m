﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            #region For Döngüsü

            //for (int i = 1; i <= 5 ; i++)
            //{
            //    Console.WriteLine("C # EĞİTİM KAMPI ");
            //}
            //for (int i = 1; i < 20; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //for (int i = 3; i < 50; i+=3)
            //{
            //    Console.WriteLine(i);

            //}

            //Console.Write("lürfen ekrana yazılmasını istediğiniz adedi giriniz : ");
            //int finishValue = int.Parse(Console.ReadLine());

            //for (int i = 0; i < finishValue; i++)
            //{
            //    Console.WriteLine("Yaşasın Cumhuriyet");
            //}



            #endregion

            #region For Döngüsü İle Karar Yapıları

            //for (int i = 1; i <= 100; i++)
            //{
            //    if(i%5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //int totalValue = 0;

            //for (int i = 0; i <=10  ; i++)
            //{
            //    totalValue += i;
            //}
            //Console.WriteLine(totalValue);

            //int totalValue = 0;

            //for(int i =0; i < 20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        totalValue += i;
            //        Console.WriteLine(i);

            //    }

            //}
            //Console.WriteLine("----------");
            //Console.WriteLine(totalValue);

            //int count = 0;

            //for(int i = 1; i<=50; i++)
            //{
            //    if (i % 7 == 0)
            //    {
            //        count++;

            //    }
            //}
            //Console.WriteLine(count);

            //int bacterium = 1;

            //for (int i = 1; i <= 24; i++)
            //{
            //    bacterium *= 2;
            //    Console.WriteLine(i + ". saat sonunda bakteri sayısı : " + bacterium);
            //}

            #endregion

            #region While Döngüsü

            //int i = 0;
            //while (i <= 10)
            //{
            //    Console.WriteLine("Merhaba Faruk");
            //    i++;
            //}

            //int i = 1;
            //while (i <= 10)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}

            //int i = 1;
            //int sum = 0;
            //while (i <= 10)
            //{
            //    sum += i;
            //    i++;
            //}
            //Console.WriteLine(sum);

            #endregion

            #region Örnek Sınav Sorusu

            //3 basaklı sayının basamakları toplamı?

            Console.Write("Lütfen basamaklı bir sayı giriniz: ");
            int number = int.Parse(Console.ReadLine());
            int basToplam = 0;

            while(number >0)
            {
                basToplam += (number % 10);
                number /=10 ;
            }
            Console.WriteLine(basToplam);

            #endregion

            Console.Read();
        }
    }
}
