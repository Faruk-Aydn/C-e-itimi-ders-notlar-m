using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region if else

            //Console.WriteLine("lütfen şifreyi giriniz ");
            //String password = Console.ReadLine();

            //if (password == "faruk")
            //{
            //    Console.WriteLine("şifre doğru hoşgeldiniz");


            //}
            //else
            //{
            //    Console.WriteLine("şifre başarısız");
            //}
            //String capital, country;
            //Console.Write("lğtfen başkenti giriniz : ");
            //capital = Console.ReadLine();
            //Console.Write("lütfen ükjeyi giriniz : ");
            //country = Console.ReadLine();

            //if (capital == "ankara" & country == "türkiye")
            //{
            //    Console.WriteLine("veriler doğru ");
            //}
            //else
            //{
            //    Console.WriteLine("veriler yanlış");

            //}
            //int number;
            //Console.Write("lütfen sayiyi giriniz : ");
            //number = int.Parse(Console.ReadLine());

            //if (number == 10)
            //{
            //    Console.WriteLine("sayı doğru ");
            //}
            //else
            //{
            //    Console.WriteLine("sayi hatalı");
            //}

            //int exam1, exam2, exam3, average;
            //String result = "hata!";

            //Console.Write("1.sınıf notunu giriniz : ");
            //exam1 = int.Parse(Console.ReadLine());

            //Console.Write("2.sınıf notunu giriniz : ");
            //exam2 = int.Parse(Console.ReadLine());

            //Console.Write("3.sınıf notunu giriniz : ");
            //exam3 = int.Parse(Console.ReadLine());

            //average= (exam1 + exam2+ exam3) /3;
            //Console.WriteLine(" Sınavların ortalaması : " + average);

            //if (average > 0 & average <= 50)
            //{
            //    result = " sonuç vasat ";
            //}
            //if (average>50 & average<= 70) {
            //    result = "Sonuç vasatın üstü";
            //}
            //if (average > 70 & average <= 84) {
            //    result = "Sonuç idare eder";
            //}
            //Console.WriteLine(result);


            //String city;
            //Console.Write("lütfen şehir giriniz :");
            //city = Console.ReadLine();

            //if (city == "giresun" | city == "ordu" | city == "trabzon")
            //{
            //    Console.WriteLine(" şehir mevcut ");
            //}
            //else
            //{
            //    Console.WriteLine("şehir mevcut değil");
            //}

            //Console.Write("isminizi giriniz :");
            //String name = Console.ReadLine();

            //if (name == "faruk")
            //{
            //    Console.WriteLine("hoşgeldiniz");
            //}
            //else
            //{
            //    Console.WriteLine("hatalı giriş ");
            //}







            #endregion
            #region Mod İşlemleri 
            //int number = 22;
            //int result = number % 4;
            //Console.WriteLine(result);


            //int number1, number2;
            //Console.Write(" lütfen 1. sayiyi giriniz :");
            //number1 = int.Parse(Console.ReadLine());

            //Console.Write("lütfen 2. sayiyi giriniz : ");
            //number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;
            //Console.WriteLine ("1. sayiyinin 2. sayiya bölümünden kalan : "+ result);

            //Console.Write("lütfen sayiyi girinz :");

            //int number = int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.WriteLine(" sayi çift ");
            //}
            //else
            //{
            //    Console.WriteLine("sayi tek ");
            //}
            #endregion
            #region Char Değişkenler İle Karar Yapıları
            //char team;
            //Console.Write("lütfen takım sembolünü giriniz :");
            //team = char.Parse(Console.ReadLine());

            //if (team == 'g' | team =='G')
            //{
            //    Console.WriteLine("giresunSpor");
            //}
            //if (team == 'b' | team == 'B')
            //{
            //    Console.WriteLine("besiktaş");
            //}
            //if (team == 'f' | team == 'F')
            //{
            //    Console.WriteLine("FenarBahçe");
            //}


            #endregion
            #region Ornek proje Uugulaması  
            //Console.WriteLine("***** C # Eğitim Kampı Restoran *****");
            //Console.WriteLine();
            //Console.WriteLine("---------------------------------------");
            //Console.WriteLine("1- Ana Yemekler ");
            //Console.WriteLine("2- Çorbalar");
            //Console.WriteLine("3- Pizaalar");
            //Console.WriteLine("4- İçecekler ");
            //Console.WriteLine("5- Tatlılar ");
            //Console.WriteLine("---------------------------------------");
            //Console.WriteLine();

            //String menuItem;

            //Console.Write(" detayını görmek istediğiniz menüyğ seçiniz : ");
            //menuItem = Console.ReadLine();

            //if (menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------Ana Yemek----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Hamsi Tava");
            //    Console.WriteLine("2-Kavurma");
            //    Console.WriteLine("3-Kuzu İncik");
            //    Console.WriteLine();
            //    Console.WriteLine("----------Ana Yemek----------");
            //}
            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------Çorbalar----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Ezogelin");
            //    Console.WriteLine("2-mercimek");
            //    Console.WriteLine("3-Kelle Paça");
            //    Console.WriteLine();
            //    Console.WriteLine("----------Çorbalar----------");
            //}
            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------Pizza----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Margaritha Pizza");
            //    Console.WriteLine("2-Akdeniz Pizza");
            //    Console.WriteLine("3-Bol Malzeme Pizza");
            //    Console.WriteLine();
            //    Console.WriteLine("----------Pizza----------");
            //}
            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------İçecekler----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Kola");
            //    Console.WriteLine("2-Limonata");
            //    Console.WriteLine("3-Su");
            //    Console.WriteLine();
            //    Console.WriteLine("----------İçecekler----------");
            //}
            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------Tatlılar----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Sufle");
            //    Console.WriteLine("2-Künefe");
            //    Console.WriteLine("3-Sütlaç");
            //    Console.WriteLine();
            //    Console.WriteLine("----------Tatlılar----------");
            //}

            #endregion
            #region Switch Case
            //int monthNumber;

            //Console.Write(" lütfen ay girişi yapınız : ");
            //monthNumber = int.Parse(Console.ReadLine());

            //switch(monthNumber)
            //{
            //        case 1: Console.WriteLine("ocak");break;
            //        case 2: Console.WriteLine("şubat"); break;
            //        case 3: Console.WriteLine("mart");break;
            //        case 4: Console.WriteLine("nisan"); break;
            //        case 5: Console.WriteLine("mayıs"); break;
            //        case 6: Console.WriteLine("haziran"); break;
            //       case 7: Console.WriteLine("temmuz"); break;
            //        case 8: Console.WriteLine("ağustos"); break;
            //        case 9: Console.WriteLine("eylül"); break;
            //        case 10: Console.WriteLine("ekim"); break;
            //        case 11: Console.WriteLine("kasım"); break;
            //        case 12: Console.WriteLine("aralık"); break;
            //        default: Console.WriteLine("hatalı veri girişi");break;




            //}

            #endregion
            #region Switch Case HEsap Makinesi

           // int number1, number2, result;
           // char symbol;

           // Console.Write("Lütfen birinci sayıyı giriniz :");
           //number1 = int.Parse(Console.ReadLine());

           // Console.Write("Lütfen ikinci sayıyı giriniz :");
           // number2 = int.Parse(Console.ReadLine());

           // Console.Write("Lütfen işlem yapmak istediğiniz sembolü giriniz");
           // symbol = char.Parse(Console.ReadLine());

           //switch(symbol)
           // {
           //     case '+': 
           //         result = number1 + number2;
           //         Console.WriteLine("Toplam = " + result); break;
           //     case '-':
           //         result = number1 - number2;
           //         Console.WriteLine("sonuç = " + result); break;
           //     case '*':
           //         result = number1 * number2;
           //         Console.WriteLine("sonuç = " + result); break;
           //     case '/':
           //         result = number1 / number2;
           //         Console.WriteLine("Sonuç = " + result); break;
           // }




            #endregion

            Console.Read();

        }
    }
}
