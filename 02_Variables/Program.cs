
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
            #region Double Degiskenler
            /*double number;
            number = 3.29;
            Console.WriteLine(number);*/

            /*Console.WriteLine("*** Fiyat Listesi ***");
            Console.WriteLine();

            double applePrice, orangePrice, strawPrice, potatoPrice, tomatoPrice;

            applePrice = 14.85;
            orangePrice = 20.95;
            strawPrice = 45;
            potatoPrice = 9.74;
            tomatoPrice = 6.88;

            Console.WriteLine("---- Elma Birim Fiyatı:" + applePrice + " TL");
            Console.WriteLine("---- Portakal Birim Fiyatı:" +orangePrice + " TL");
            Console.WriteLine("---- Çilek Birim Fiyatı:" + strawPrice + " TL");
            Console.WriteLine("---- Patates Birim Fiyatı:" + potatoPrice + " TL");
            Console.WriteLine("---- Domates Birim Fiyatı:" + tomatoPrice + " TL");

            Console.WriteLine();
            Console.WriteLine();

            double appleGram,orangeGram, strawGram, potatoGram, tomatoGram;
            appleGram = 1.245;
            orangeGram = 2.650;
            strawGram = 0.750;
            potatoGram = 4.859;
            tomatoGram = 3.745;

            double appleTotalPrice = appleGram * applePrice;
            double orangeTotalPrice=orangeGram * orangePrice;
            double strawTotalPrice = strawGram * strawPrice;
            double potatoTotalPrice = potatoGram * potatoPrice;
            double tomatoTotalPrice = tomatoPrice * tomatoPrice;

            Console.WriteLine("Alınan Ürün: Elma - " + "Birim fiyat: " + applePrice + " - Gramaj: " + appleGram + " - Toplam Tutar: " + appleTotalPrice);
            Console.WriteLine("Alınan Ürün: Portakal - " + "Birim fiyat: " + orangePrice + " - Gramaj: " + orangeGram + " - Toplam Tutar: " + orangeTotalPrice);
            Console.WriteLine("Alınan Ürün: Çilek - " + "Birim fiyat: " + strawPrice + " - Gramaj: " + strawGram + " - Toplam Tutar: " + strawTotalPrice);
            Console.WriteLine("Alınan Ürün: Patates - " + "Birim fiyat: " + potatoPrice + " - Gramaj: " + potatoGram + " - Toplam Tutar: " + potatoTotalPrice);
            Console.WriteLine("Alınan Ürün: Domates - " + "Birim fiyat: " + tomatoPrice + " - Gramaj: " + tomatoGram + " - Toplam Tutar: " + tomatoTotalPrice);

            double shoppingTotalPrice=appleTotalPrice+orangeTotalPrice+strawTotalPrice+potatoTotalPrice+tomatoTotalPrice;

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Alışveriş Toplam Tutar: " + shoppingTotalPrice + " TL");
            */
            #endregion

            #region Char Degiskenler

            //ABCDEFGH
            //DEF
            //TOPLANTI SAAT 20:00'DE
            // " '

            //char symbol;
            //symbol='a';
            //Console.WriteLine(symbol);

            #endregion

            #region Klavyeden Veri Girişleri String Değişkenler

            //Console.WriteLine("*** CSharp Hava Yolları Yolcu Bilgisi ***");
            //Console.WriteLine();

            /*string passengerName, passengerSurname, passengerDistrict, passengerCity,
                passengerAge, passengerIdentityNumber;

            Console.Write("Yolcu Adı : ");
            passengerName= Console.ReadLine();
            Console.WriteLine();
            Console.Write("Yolcu Soyadı : ");
            passengerSurname= Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("-----------------------");
            Console.Write("Yolcu İlçesi : ");
            passengerDistrict = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Yolcu İli : ");
            passengerCity = Console.ReadLine();
            Console.WriteLine("-----------------------");
            Console.WriteLine();
            Console.Write("Yolcu Yaşı : ");
            passengerAge = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Yolcu Kimlik Numarası : ");
            passengerIdentityNumber = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("-----------------------");

            Console.WriteLine("Yolcu : " + passengerName + " " + passengerSurname
                + " " + passengerDistrict + " " + passengerCity + " " + passengerAge + " " + passengerIdentityNumber);

            */

            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler

            /*int shoesPrice, computerPrice, chairPrice, tvPrice;
            shoesPrice = 1000;
            computerPrice = 20000;
            chairPrice = 5000;
            tvPrice = 40000;

            int shoesCount, computerCount, chairCount,  tvCount;
            Console.Write("Alınan ayakkabı sayısını giriniz : ");
            shoesCount=int.Parse(Console.ReadLine());
            Console.Write("Alınan bilgisayar sayısını giriniz : ");
            computerCount = int.Parse(Console.ReadLine());
            Console.Write("Alınan koltuk sayısını giriniz : ");
            chairCount = int.Parse(Console.ReadLine());
            Console.Write("Alınan televizyon sayısını giriniz : ");
            tvCount = int.Parse(Console.ReadLine());

            int totalPrice=shoesPrice*shoesCount+computerPrice*computerCount+
                chairPrice*chairCount+tvPrice*tvPrice;
            Console.WriteLine();
            Console.WriteLine("Toplam ödenmesi gereken tutar : " + totalPrice);

            */







            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri

            /*double exam1, exam2, exam3, result;

            Console.Write("1.Sınav Notunu Girin : ");
            exam1=double.Parse(Console.ReadLine());
            Console.Write("2.Sınav Notunu Girin : ");
            exam2 = double.Parse(Console.ReadLine());
            Console.Write("3.Sınav Notunu Girin : ");
            exam3 = double.Parse(Console.ReadLine());

            result = (exam1 + exam2 + exam3) / 3;
            Console.WriteLine();
            Console.WriteLine("Sınav Not Ortalaması : " + result);
            */

            #endregion

            #region Klavyeden Karakter Girişleri

            /*char gender;
            Console.Write("Lütfen cinsiyet seçiniz: ");
            gender=char.Parse(Console.ReadLine()); //1 karakter uzunluğu
            Console.Write("Seçilen Cinsiyet : " + gender);

            */
            #endregion


            Console.Read();

        }
    }
}
