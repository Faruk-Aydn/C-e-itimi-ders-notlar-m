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
            Console.WriteLine("***** Fiyat Listesi *****");
            double applePirece, orrangePirece, bananaPirece, limePirece;
            applePirece = 23.56;
            orrangePirece = 15.44;
            bananaPirece = 10;
            limePirece = 12.9;

            Console.WriteLine("");
            Console.WriteLine("----- Elma Birim Fiyatı : " + applePirece + " tl") ;
            Console.WriteLine("----- Portakal Birim Fiyatı : " +  orrangePirece + " tl");
            Console.WriteLine("----- muz Birim Fiyatı : " +  bananaPirece + " tl");
            Console.WriteLine("----- lime Birim Fiyatı : " + limePirece + " tl");
            Console.WriteLine();

            Console.WriteLine("***** Fiyat Listesi *****");
            Console.WriteLine();

            double appelGram,orrangeGram,bananaGram, limeGram;
            appelGram = 1.333;
            orrangeGram = 2.234;
            bananaGram = 4.124;
            limeGram = 3.98;

            double totalAppelPrice = applePirece * appelGram;
            double totalOrrangePrice = orrangePirece* orrangeGram;
            double totalBananaPrice = bananaPirece* orrangeGram;
            double totalLimePrice = limeGram* orrangeGram;

            Console.WriteLine("Elmanın Toplam Fiyatı : " + totalAppelPrice);
            Console.WriteLine("Portakalın Toplam Fiyatı : " + totalOrrangePrice);
            Console.WriteLine("Muzun Toplam Fiyatı : " + totalBananaPrice);
            Console.WriteLine("Lime Toplam Fiyatı : " + totalLimePrice);
            double shoppingTotalPrice = totalAppelPrice + totalBananaPrice + totalLimePrice + totalOrrangePrice;
            Console.WriteLine("");
            Console.WriteLine();
            Console.WriteLine("Alışveriş Toplam Tutar : " + shoppingTotalPrice +"tl");

          
        





            #endregion

            Console.Read();

        }
    }
}
