using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel dizi örnekleri


            //string[] Color = new string[4];
            //Color[0] = "sarı";
            //Color[1] = "kırmızı";
            //Color[2] = " mavi";
            //Color[3] = "lacivert";

            //Console.WriteLine(Color[2]);

            //String[] cities = new string[5];
            //cities[0] = "milano";
            //cities[1] = "ankara";
            //cities[2] = "barcelona";
            //cities[3] = "newyork";
            //cities[4] = "kahire";

            //Console.WriteLine(cities[4]);


            //int[] number = new int[10];

            //number[0] = 4;
            //number[1] = 5;
            //number[2] = 6;
            //number[7] = 7;
            //Console.WriteLine(number[5]);


            //string[] cities = { "prag " ,"roma ","ankara", "giresun"};
            //Console.WriteLine(cities[3]);

            #endregion

            #region Dizideki tüm elemanları listeleme

            //string[] color = { "sarı", "kırmızı", "mavi", "mor" ,"lacivert"};

            //for (int i = 0; i < color.Length; i++)
            //{
            //    Console.WriteLine(color[i]);
            //}

            //int[] number = { 19, 67, 90, 81, 22, 18 };
            //for (int i = 0; i < number.Length; i++)
            //{
            //    if (number[i] % 3 == 0)
            //    {
            //        Console.WriteLine(number[i]);
            //    }
            //}

            //char[] chars = { 'a', 'b', 'c', };
            //for (int i = 0; i < chars.Length; i++)
            //{
            //    Console.WriteLine(chars[i]);
            //}

            //    int[] myArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, };
            //    int maxNumber = myArray[0];

            //    for (int i = 1; i < myArray.Length; i++)
            //    {
            //        if (myArray[i] > maxNumber) { 
            //            maxNumber = myArray[i];
            //    }
            //}

            //Console.WriteLine(maxNumber);


            //string[] person = { "ali", "veli", "ahmet" ,"mehmet"};
            //Console.WriteLine(person.Length);


            //int[] number = { 40, 23, 222, 8, 956, 88, 45 };
            //Array.Sort(number);
            //for (int i = 0; i < number.Length; i++)
            //{
            //    Console.WriteLine(number[i]);
            //}


            //int[] number = { 40, 23, 222, 8, 956, 88, 45 };
            //Array.Reverse(number);
            //for (int i = 0; i < number.Length; i++)
            //{
            //    Console.WriteLine(number[i]);
            //}



            #endregion

            #region Dizi Metotları

            //string[] customers = { "ali", "veli ", "ahmet" ,"mehmet"};
            //int index = Array.IndexOf(customers, "ali");
            //Console.WriteLine(index);

            //int[] number = { 30, 20, 15, 90, 76, 65 };
            //Console.WriteLine("Dizinin en büyük elemanı : " + number.Max()+ " dizinin en küçük elemanı : " + number.Min());

            #endregion

            #region Kullanıcadan Değer alma
            //string[] cities = new string[5];

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine($"lütfen {i + 1}. şehri giriniz : ");
            //    cities[i] = Console.ReadLine();
            //}
            //Console.WriteLine();
            //Console.WriteLine("--------------");
            //foreach (string s in cities) {
            //    Console.WriteLine(s);
            //}


            //int[] numbers = { 10, 20, 30, 40, 50, 60, 70 };

            //int sum = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}
            //Console.WriteLine(sum);

            Console.WriteLine("Çift sayilar");
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 ,10,11,12,13,14};
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {

                    Console.WriteLine(numbers[i]);
                }
            }
            Console.WriteLine("Tek sayilar");
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 != 0)
                {

                    Console.WriteLine(numbers[i]);
                }
            }


            #endregion
            Console.Read();
        }
    }
}
