using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkenler

            //double number;
            //number = 3.27;
            //Console.WriteLine(number);
            //Console.WriteLine("***** Fiyat Listesi *****");
            //double applePirece, orrangePirece, bananaPirece, limePirece;
            //applePirece = 23.56;
            //orrangePirece = 15.44;
            //bananaPirece = 10;
            //limePirece = 12.9;

            //Console.WriteLine("");
            //Console.WriteLine("----- Elma Birim Fiyatı : " + applePirece + " tl") ;
            //Console.WriteLine("----- Portakal Birim Fiyatı : " +  orrangePirece + " tl");
            //Console.WriteLine("----- muz Birim Fiyatı : " +  bananaPirece + " tl");
            //Console.WriteLine("----- lime Birim Fiyatı : " + limePirece + " tl");
            //Console.WriteLine();

            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine();

            //double appelGram,orrangeGram,bananaGram, limeGram;
            //appelGram = 1.333;
            //orrangeGram = 2.234;
            //bananaGram = 4.124;
            //limeGram = 3.98;

            //double totalAppelPrice = applePirece * appelGram;
            //double totalOrrangePrice = orrangePirece* orrangeGram;
            //double totalBananaPrice = bananaPirece* orrangeGram;
            //double totalLimePrice = limeGram* orrangeGram;

            //Console.WriteLine("Elmanın Toplam Fiyatı : " + totalAppelPrice);
            //Console.WriteLine("Portakalın Toplam Fiyatı : " + totalOrrangePrice);
            //Console.WriteLine("Muzun Toplam Fiyatı : " + totalBananaPrice);
            //Console.WriteLine("Lime Toplam Fiyatı : " + totalLimePrice);
            //double shoppingTotalPrice = totalAppelPrice + totalBananaPrice + totalLimePrice + totalOrrangePrice;
            //Console.WriteLine("");
            //Console.WriteLine();
            //Console.WriteLine("Alışveriş Toplam Tutar : " + shoppingTotalPrice +"tl");




            #endregion

            #region Char Değişkenler

            //char symbol = 'a';
            //Console.WriteLine(symbol);

            #endregion
            #region Klavyeden Veri Girişi String Değişkenler

            //Console.WriteLine("***** Faruk Hava Yolları Yolcu Bilgisi *****");
            //Console.WriteLine();

            //String passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentiyNumber;
            //Console.Write("yolcu adı :");
            //passengerName = Console.ReadLine();

            //Console.Write("yolcu soyismi :");
            //passengerSurname = Console.ReadLine();

            //Console.Write("ilçe bilgisi :");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("şehir bilgisi :");
            //passengerCity = Console.ReadLine();

            //Console.Write("yolcu yaş:");
            //passengerAge = Console.ReadLine();

            //Console.Write("yolcu kimlik no : ");
            //passengerIdentiyNumber = Console.ReadLine();

            //Console.WriteLine();
            //Console.WriteLine("-------------------------------");
            //Console.WriteLine("Yolcu TC kimlik no : " + passengerIdentiyNumber +" yolcu adı  :" + passengerName + 
            //    " " + passengerSurname +   " " + passengerDistrict + "/" + passengerCity +" "  + passengerAge);








            #endregion
            #region Kavyeden Veri Girişi ve Dönüşümler

            // int jeanPrice, smartphonePrice, leptopPrice, tabelPrice;

            // jeanPrice = 100;
            // smartphonePrice = 2000;
            // leptopPrice = 10000;
            // tabelPrice = 500;

            // int jeanCount , smartphoneCount , leptopCount , tabelCount ;

            // Console.Write(" lütfen aldığınız telefon adetini giriniz :");
            // smartphoneCount = int.Parse(Console.ReadLine());

            // Console.Write(" lütfen aldığınızleptop adetini giriniz :");
            // leptopCount = int.Parse(Console.ReadLine());

            // Console.Write(" lütfen aldığınız masa adetini giriniz :");
            // tabelCount = int.Parse(Console.ReadLine());

            // Console.Write(" lütfen aldığınız kot adetini giriniz :");
            //jeanCount = int.Parse(Console.ReadLine());

            // int totalPrice = jeanPrice*jeanCount + smartphonePrice*smartphoneCount + leptopPrice*leptopCount + tabelCount*tabelPrice;

            // Console.WriteLine();
            // Console.WriteLine(" toplam ödemeniz gereken tutar : " + totalPrice);


            #endregion
            #region Klavyeden Ondalıklı Sayı İşlemleri

            //double exam1 , exam2 , exam3 ,result ;
            //Console.WriteLine("Lütfen 1. sınavınızın notunu giriniz :");
            //exam1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen 2. sınavınızın notunu giriniz :");
            //exam2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen 3. sınavınızın notunu giriniz :");
            //exam3 = int.Parse(Console.ReadLine());

            //result = (exam1+exam2+exam3)/3;
            //Console.WriteLine();
            //Console.WriteLine(" sınav ortalamanız :" + result);


            #endregion
            #region Klavyeden Karakter Girişleri

            //char gender;
            //Console.WriteLine("lütfen cinsiyetinizi giriniz :");
            //gender = char.Parse(Console.ReadLine());

            //Console.WriteLine("seçtiğiniz cinsiyet : " + gender);

            #endregion

            Console.Read();

        }
    }
}
