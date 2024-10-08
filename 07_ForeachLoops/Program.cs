using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü

            //string[] cities = { "giresun", "ordu", "samsun" };
            //foreach (string city in cities)
            //{
            //    Console.WriteLine(city);
            //}

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17 };

            //int total = 0;
            //foreach (int i in numbers)
            //{
            //    total += i;
            //}
            //Console.WriteLine(total);

            //List<int> numbers = new List<int>()
            //{
            //    1,2,3,4,5,6,7
            //};
            //foreach (int i in numbers) {
            //    Console.WriteLine(i);
            //}

            //string word = "MERHABA";

            //foreach (char s in word)
            //{
            //    Console.WriteLine(s);
            //}

            #endregion

            #region Örnek Sınav Uygulaması

            Console.WriteLine("*****C# EĞİTİM KAMPI SINAV UYGULAMASI***** ");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("-------------------");
            Console.Write("Sınıfınızdaki öğrenci sayısını giriniz : ");
            int studentCount = int.Parse(Console.ReadLine());
            Console.WriteLine("-------------------");

            string[] studentNames = new string[studentCount];
            double[] studentExamAvg = new double[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i + 1}  öğrencinin ismini giriniz : ");
                studentNames[i] = Console.ReadLine();

                double totalExamResult = 0;

                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentNames[i]} isimli öğrencinin {j + 1}. notunu giriniz : ");
                    double value = double.Parse(Console.ReadLine());
                    totalExamResult += value;
                }
                Console.WriteLine();
                studentExamAvg[i] = totalExamResult / 3;
            }

            for (int i = 0;i < studentCount;i++)
            {
                Console.WriteLine("------------------------------------");
                Console.WriteLine($"{studentNames[i]} isimli öğrencinin ortalaması : {studentExamAvg[i]}"  );
               


                if (studentExamAvg[i] > 50)
                {
                    Console.WriteLine($"{studentNames[i]} isimli öğrenci dersi geçti");
                }
                else
                {
                    Console.WriteLine($"{studentNames[i]} isimli öğrenci dersten kaldı");
                }
                Console.WriteLine("------------------------------------");
            }
                

            #endregion

            Console.Read();

        }
    }
}
