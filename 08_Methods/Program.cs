using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Metotlar


            //void CustomerList()
            //{
            //    Console.WriteLine("faruk");
            //    Console.WriteLine("aydın");
            //}
            //CustomerList();

            //void Sum()
            //{
            //    int i = 1;
            //    int j = 2;
            //    int k = i +j ; 
            //    Console.WriteLine(k);
            //        }
            //Sum();

            #endregion

            #region Geriye Değer Döndürmeyen parametli Metotlar

            //void WriteMethod(String customerName)
            //{
            //    Console.WriteLine(customerName);
            //}
            //WriteMethod("faruk");

            //void StudentCard(String name ,int studentNo)
            //{
            //    Console.WriteLine("öğrenci ismi : " +name + " numarası : " + studentNo);
            //}

            //StudentCard("faruk", 245);

            #endregion

            #region Geriye değer Döndürmeyen Int Paremetli Metotlar

            //void Sum(int a,int b, int c)
            //{
            //    int resul = a + b + c;
            //    Console.WriteLine(resul);
            //}
            //Sum(3, 4, 5);

            #endregion

            #region geriye değer döndüren metotlar

            //String CustomerName()
            //{
            //    return "faruk aydın ";
            //}
            //CustomerName();


            //string StudentCard ()
            //{
            //    string name = "faruk";
            //    string surName = "aydın";

            //    return name + " " + surName;

            //}
            //Console.WriteLine(StudentCard ());
            #endregion

            #region geriye değer döndüren string parametreli metotlar

            //string CountryCard(string CountryName, string capitalName,string flagColor)
            //       {
            //       string cardInfo = "ülke : " + CountryName + "-Başkent : " + capitalName + "- Bayrak rengi : " + flagColor;
            //       return cardInfo;
            //       }

            //       string x, y, z;

            //       Console.Write("Ülke adını giriniz :");
            //       x = Console.ReadLine();


            //       Console.Write("başkent adını giriniz :");
            //       y = Console.ReadLine();


            //       Console.Write("bYRk rengini giriniz :");
            //       z = Console.ReadLine();


            //           Console.WriteLine(CountryCard(x, y, z));

            #endregion

            #region geriye değer döndüren Int parametreli metotlar

            //int Sum(int number1, int number2)
            // {

            //     int result = number1 + number2;
            //     return result;
            // }

            // Console.WriteLine(Sum(1, 45));


            #endregion

            #region örnek uygulama

            string ExamResult(string student , int exam1, int exam2,int exam3)
            {
                int result = (exam1 + exam2 + exam3) / 3;
                if (result >= 50)
                {
                    return "öğrenci sınavı geçti";
                }
                else
                {
                    return "öğrenci başarısız";
                }
            }
            Console.WriteLine(ExamResult("faruk", 30, 70, 50));

            #endregion

            Console.Read();
        }
    }
}
