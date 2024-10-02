using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {


        static void Main(string[] args)
        {
            #region Yazdırma komutları
            //Console.WriteLine("***** YEMEK KATEGORİLERİ *****");
            //Console.WriteLine("");
            //Console.WriteLine("1-ÇORBALAR");
            //Console.WriteLine("2-ANA YEMEK ");
            //Console.WriteLine("3-SOĞUK BAŞLANGIÇ");
            //Console.WriteLine("4-SALATALAR");
            //Console.WriteLine("5-İÇECEKLER");
            //Console.WriteLine("6-TATLILAR");
            //Console.WriteLine("");
            //Console.WriteLine("***** YEMEK KATEGORİLERİ *****");
            #endregion

            #region String  Değişkenler

            //String costumerName;
            //String costumerSurname;
            //String costumerPhone;
            //String costumerEmail,district,city;

            //costumerName = "Ali";
            //costumerSurname = " Yılmaz";
            //costumerPhone = "0560 780 90 50";
            //costumerEmail = "dneme123@gmail.com";
            //district = " dereli";
            //city = "giresun ";


            //Console.WriteLine(" ***** MÜŞTERİ REZERVASYON KARTI*****");
            //Console.WriteLine("");
            //Console.WriteLine("------------------------------------");
            //Console.WriteLine("Müsteri: "+ costumerName+" "+ costumerSurname);
            //Console.WriteLine("İletişim: "+ costumerPhone);
            //Console.WriteLine("Email Adresi: " + costumerEmail);
            //Console.WriteLine("Adres: "+ district+ "/" + city);
            //Console.WriteLine("------------------------------------");

            //costumerName = "mine";
            //costumerSurname = " aydın";
            //costumerPhone = "0565 750 44 98";
            //costumerEmail = "dneme123@gmail.com";
            //district = " akçabat";
            //city = "trabzon ";


            //Console.WriteLine(" ***** MÜŞTERİ REZERVASYON KARTI*****");
            //Console.WriteLine("");
            //Console.WriteLine("------------------------------------");
            //Console.WriteLine("Müsteri: "+ costumerName+" "+ costumerSurname);
            //Console.WriteLine("İletişim: "+ costumerPhone);
            //Console.WriteLine("Email Adresi: " + costumerEmail);
            //Console.WriteLine("Adres: "+ district+ "/" + city);
            //Console.WriteLine("------------------------------------");

            #endregion


            #region Int Değişkenler

            int hamburgerPrice = 250;
            int cokePrice = 37;
            int waterPrice = 15;
            int chickenPrice = 60;
            int pizzaPrice = 200;
            int donutPrice = 30;

            Console.WriteLine("**** Restoran Menü Fiyatı ****");
            Console.WriteLine();
            Console.WriteLine("-----Hamburger: " + hamburgerPrice + " TL");
            Console.WriteLine("-----Pizza: " + pizzaPrice + " TL");
            Console.WriteLine("-----Kola: " + cokePrice + " TL");
            Console.WriteLine("-----Limonata: " + donutPrice + " TL");
            Console.WriteLine("-----Kızartma: " + chickenPrice + " TL");
            Console.WriteLine("-----Su: " + waterPrice + " TL");
            Console.WriteLine();
            Console.WriteLine("**** Restoran Menü Fiyatı ****");


            Console.WriteLine();

            int hamburgerCount;

            int cokeCount;
            int waterCount;


            int chickenCount;
            int pizzaCount;
            int donutCount;

            int totalHamgurgerPrice;
            int totalCokePrice;
            int totalWaterPrice;
            int totalChickenPrice;

            int totalPizzaPrice;
            int totalDonutPrice;

            hamburgerCount = 2;
            cokeCount = 2;
            waterCount = 3;
            chickenCount = 1;
            pizzaCount = 1;
            donutCount = 3;

            totalHamgurgerPrice = hamburgerCount * hamburgerPrice;
            totalCokePrice = cokeCount * cokePrice;
            totalWaterPrice = waterCount * waterPrice;
            totalDonutPrice = donutCount * donutPrice;
            totalChickenPrice = chickenCount * chickenPrice;
            totalPizzaPrice = pizzaCount * pizzaPrice;

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Hamburger Tutarı: " + totalHamgurgerPrice + " TL");
            Console.WriteLine("Pizza Tutarı: " + totalPizzaPrice + " TL");
            Console.WriteLine("Kızartma Tutarı: " + totalChickenPrice + " TL");
            Console.WriteLine("Kola Tutarı: " + totalCokePrice + " TL");
            Console.WriteLine("Limonata Tutarı: " + totalDonutPrice + " TL");
            Console.WriteLine("Su Tutarı: " + totalWaterPrice + " TL");

            Console.WriteLine();

            int totalPrice = totalCokePrice + totalWaterPrice + totalDonutPrice + totalHamgurgerPrice + totalPizzaPrice + totalChickenPrice;

            Console.WriteLine("Toplam Ödenecek Tutar: " + totalPrice + " TL");





            #endregion





            Console.Read();


        }
    }
}
