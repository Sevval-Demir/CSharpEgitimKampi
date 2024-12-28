using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region YazdırmaKomutları
            //Console.Write("Merhaba Dünya");
            //Console.WriteLine("Selam"); //alt satıra geçer

            Console.WriteLine("***** Yemek Kategorileri *****");
            Console.WriteLine();
            Console.WriteLine("1 -> Çorbalar");
            Console.WriteLine("2 -> Ana Yemekler");
            Console.WriteLine("3 -> Soğuk Başlangıçlar");
            Console.WriteLine("4 -> Salatalar");
            Console.WriteLine("5 -> Tatlılar");
            Console.WriteLine("6 -> İçecekler");
            Console.WriteLine();
            Console.WriteLine("***** Yemek Kategorileri *****");
            #endregion

            #region StringDegiskenler

            //string
            //Degişken_türü değişken adı;

            /*string name;
            name = "Sevval";
            Console.WriteLine(name);*/

            string customerName;
            string customerSurname, customerPhone, customerEmail, district, city;

            customerName = "Sevval";
            customerSurname = "Demir";
            customerPhone = "5555555555";
            customerEmail = "sevvaldemir@gmail.com";
            district = "Umraniye";
            city = "İstanbul";

            Console.WriteLine("***** Rezervasyon Kartı *****");
            Console.WriteLine();
            Console.WriteLine("***********************************************");
            Console.WriteLine();
            Console.WriteLine("Müşteri : " + customerName + " " + customerSurname);
            Console.WriteLine("İletişim : " + customerPhone);
            Console.WriteLine("Email : " + customerEmail);
            Console.WriteLine("Adres : " + district + "/" + city);
            Console.WriteLine();
            Console.WriteLine("***********************************************");

            customerName = "Ayşegül";
            customerSurname = "Kaya";
            customerPhone = "1111111111";
            customerEmail = "aysegul.kaya@gmail.com";
            district = "Üsküdar";
            city = "İstanbul";

            Console.WriteLine();
            Console.WriteLine("Müşteri : " + customerName + " " + customerSurname);
            Console.WriteLine("İletişim : " + customerPhone);
            Console.WriteLine("Email : " + customerEmail);
            Console.WriteLine("Adres : " + district + "/" + city);
            Console.WriteLine();
            Console.WriteLine("***********************************************");

            #endregion

            #region IntDegiskenler

            //int

            /*int number = 24;
            Console.WriteLine(number);*/

            int HamburgerPrice = 300;
            int CokePrice = 35;
            int WaterPrice = 10;
            int FriesPrice = 50;
            int PizzaPrice = 200;
            int LemonadePrice = 30;

            Console.WriteLine("----Hamburger:" + HamburgerPrice + " TL");
            Console.WriteLine("----Kola:" + CokePrice + " TL");
            Console.WriteLine("----Su:" + WaterPrice + " TL");
            Console.WriteLine("----Kızartma:" + FriesPrice + " TL");
            Console.WriteLine("----Pizza:" + PizzaPrice + " TL");
            Console.WriteLine("----Limonata:" + LemonadePrice + " TL");

            int totalHamburgerPrice = 300;
            int totalCokePrice = 35;
            int totalWaterPrice = 10;
            int totalFriesPrice = 50;
            int totalPizzaPrice = 200;
            int totalLemonadePrice = 30;

            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;

            hamburgerCount = 5;
            cokeCount = 5;
            waterCount = 3;
            friesCount = 3;
            pizzaCount = 2;
            lemonadeCount = 3;


            totalHamburgerPrice = HamburgerPrice * hamburgerCount;
            totalCokePrice = CokePrice * cokeCount;
            totalWaterPrice = WaterPrice * waterCount;
            totalFriesPrice = FriesPrice * friesCount;
            totalPizzaPrice = PizzaPrice * pizzaCount;
            totalLemonadePrice = LemonadePrice * lemonadeCount;



            Console.WriteLine("*** Restoran Menü Fiyatı ***");
            Console.WriteLine();
            Console.WriteLine("----Hamburger:" + totalHamburgerPrice + " TL");
            Console.WriteLine("----Kola:" + totalCokePrice + " TL");
            Console.WriteLine("----Su:" + totalWaterPrice + " TL");
            Console.WriteLine("----Kızartma:" + totalFriesPrice + " TL");
            Console.WriteLine("----Pizza:" + totalPizzaPrice + " TL");
            Console.WriteLine("----Limonata:" + totalLemonadePrice + " TL");
            Console.WriteLine();
            Console.WriteLine("*** Restoran Menü Fiyatı ***");

            Console.WriteLine();

            int totalPrice = totalHamburgerPrice + totalCokePrice + totalWaterPrice + totalFriesPrice + totalPizzaPrice + totalLemonadePrice;


            Console.WriteLine("Toplam Fiyat : " + totalPrice);

            #endregion


            Console.Read();
        }
    }
}

