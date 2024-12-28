using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Else

            /*Console.Write("Lütfen şifreyi girimiz : ");
            string password;
            password = Console.ReadLine();
            if(password=="abcd")
            {
                Console.WriteLine("Şifre doğru!");
            }
            else
            {

                Console.WriteLine("Şifre yanlış");
            }*/

            //string capital, country;
            //Console.Write("Başkenti giriniz : ");
            //capital = Console.ReadLine();
            //Console.WriteLine("Ülkeyi giriniz : ");
            //country = Console.ReadLine();

            //if (capital == "ankara" & country == "türkiye")
            //{
            //    Console.Write("Veriler doğrulandı");
            //}
            //else
            //{
            //    Console.Write("Hatalı bilgi");
            //}

            /*int number;
            Console.WriteLine("Sayıyı giriniz : ");
            number = int.Parse(Console.ReadLine());
            */
            //if(number==5)
            //{
            //    Console.WriteLine("Sayı doğru!");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı yanlış");
            //}

            //int exam1, exam2, exam3, average;
            //string result="Hata!";

            //Console.WriteLine("Sınav 1: ");
            //exam1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Sınav 2 :");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Sınav 3: ");
            //exam3=int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Sınavların Ortalaması : "+average);

            //if(average>0 & average<=50)
            //{
            //    result = "Sonuç vasat";
            //}
            //if(average>50 & average<=70)
            //{
            //    result = "Sonuç orta";
            //}
            //if(average>70 & average<=84)
            //{
            //    result = "Sonuç iyi";
            //}
            //if(average>84)
            //{
            //    result = "Sonuç çok iyi";
            //}
            //Console.WriteLine(result);

            //string city;
            //Console.Write("Lütfen şehir girişi yapınız : ");
            //city = Console.ReadLine();

            //if(city=="adana" | city=="ankara" | city=="bursa" |city=="trabzon")
            //{
            //    Console.WriteLine("şehir mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("şehir mevcut değil");
            //}





            #endregion

            #region Mod İşlemleri

            //int number = 26;
            //int result = number % 5;
            //Console.WriteLine(number);

            //int number1, number2;
            //Console.WriteLine("İlk sayıyı girin : ");
            //number1=int.Parse(Console.ReadLine());
            //Console.WriteLine("İkinci sayiyi girin : ");
            //number2=int.Parse(Console.ReadLine());

            //int result = number1 % number2;
            //Console.WriteLine("1.sayının 2.sayıya bölümünden kalan :" + result);

            //int number;
            //Console.WriteLine("Bir sayı girin : ");
            //number = int.Parse(Console.ReadLine());

            //if(number%2==0)
            //{
            //    Console.WriteLine("Girilen sayı tektir");
            //}
            //else
            //{
            //    Console.WriteLine("Girilen sayı çifttir");
            //}

            #endregion

            #region Char Değişkenler ile Karar Yapısı

            //char team;
            //Console.WriteLine("Lütfen takım sembolünü girin : ");
            //team = char.Parse(Console.ReadLine());
            //if(team=='g' | team=='G')
            //{
            //    Console.WriteLine("Takımınız : Galatasaray");
            //}
            //else if(team=='f' |team =='F')
            //{
            //    Console.WriteLine("Takımınız : Fenerbahçe");
            //}
            //else if(team=='b' | team=='B')
            //{
            //    Console.WriteLine("Takımınız : Beşiktaş");
            //}
            //else
            //{
            //    Console.WriteLine("Takımınız üç büyük takım değil");
            //}



            #endregion

            #region Örnek Proje Uygulaması

            //Console.WriteLine("***** C# Eğitim Kampı Restoran *****");
            //Console.WriteLine();
            //Console.WriteLine("-----------------------------");
            //Console.WriteLine("1-Ana Yemekler");
            //Console.WriteLine("2-Çorbalar");
            //Console.WriteLine("3-Pizzalar");
            //Console.WriteLine("4-İçecekler");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("-----------------------------");
            //Console.WriteLine();

            //string menuItem;
            //Console.Write("Detayını görmek istediğiniz menü seçimi: ");
            //menuItem = Console.ReadLine();

            //if(menuItem=="1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-------------------Ana Yemekler-----------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Köri Soslu Tavuk");
            //    Console.WriteLine("2-Kızartma Tabağı");
            //    Console.WriteLine("3-Fasulye Pilav");
            //    Console.WriteLine("4-Fırında Somon");
            //    Console.WriteLine("5-Patlıcan Musakka");
            //    Console.WriteLine("-------------------Ana Yemekler-----------------");

            //    Console.WriteLine();
            //}

            //if(menuItem=="2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-------------------Çorbalar-----------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Mercimek Çorbası");
            //    Console.WriteLine("2-Ezogelin Çorba");
            //    Console.WriteLine("-------------------Çorbalar-----------------");

            //    Console.WriteLine();
            //}

            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-------------------Pizzalar-----------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Akdeniz Pizza");
            //    Console.WriteLine("2-Margaritha Pizza");
            //    Console.WriteLine("3-Tavuklu Pizza");
            //    Console.WriteLine("-------------------Pizzalar-----------------");

            //    Console.WriteLine();
            //}

            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-------------------İçecekler-----------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Kola");
            //    Console.WriteLine("2-Ayran");
            //    Console.WriteLine("3-Su");
            //    Console.WriteLine("-------------------Tatlılar-----------------");

            //    Console.WriteLine();
            //}


            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-------------------Tatlılar-----------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Trileçe");
            //    Console.WriteLine("2-Kazandibi");
            //    Console.WriteLine("3-Sütlaç");
            //    Console.WriteLine("-------------------Tatlılar-----------------");

            //    Console.WriteLine();
            //}

            #endregion

            #region Switch Case

            //int monthNumber;
            //Console.WriteLine("Lütfen ay numarası girin : ");
            //monthNumber = int.Parse(Console.ReadLine());

            //switch(monthNumber)
            //{
            //    case 1:Console.WriteLine("Ocak");
            //        break;
            //    case 2:Console.WriteLine("Şubat");
            //        break;
            //    case 3:
            //        Console.WriteLine("Mart");
            //        break;
            //    case 4:
            //        Console.WriteLine("Nisan");
            //        break;
            //    case 5:
            //        Console.WriteLine("Mayıs");
            //        break;
            //    case 6:
            //        Console.WriteLine("Haziran");
            //        break;
            //    case 7:
            //        Console.WriteLine("Temmuz");
            //        break;
            //    case 8:
            //        Console.WriteLine("Ağustos");
            //        break;
            //    case 9:
            //        Console.WriteLine("Eylül");
            //        break;
            //    case 10:
            //        Console.WriteLine("Ekim");
            //        break;
            //    case 11:
            //        Console.WriteLine("Kasım");
            //        break;
            //    case 12:
            //        Console.WriteLine("Aralık");
            //        break;

            //}



            #endregion

            #region Hesap Makinesi

            int number1, number2;
            Console.WriteLine("Birinci sayıyı girin : ");
            number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("İkinci sayıyı girin : ");
            number2 = int.Parse(Console.ReadLine());
            int secim;
            Console.WriteLine("Yapmak istediğiniz işlemi girin : ");
            Console.WriteLine("1-Toplama \t 2-Çıkarma \t 3-Çarpma \t 4-Bölme");
            secim = int.Parse(Console.ReadLine());

            double result;

            switch (secim)
            {
                case 1:
                    result = number1 + number2;
                    Console.WriteLine(number1 + " + " + number2 + " = " + result);
                    break;
                case 2:
                    result = number1 - number2;
                    Console.WriteLine(number1 + " - " + number2 + " = " + result);
                    break;
                case 3:
                    result = number1 * number2;
                    Console.WriteLine(number1 + " * " + number2 + " = " + result);
                    break;
                case 4:
                    if (number2 == 0)
                    {
                        Console.WriteLine("Payda 0 olamaz!");
                        break;
                    }
                    else
                    {
                        result = number1 / number2;
                        Console.WriteLine(number1 + " / " + number2 + " = " + result);
                        break;
                    }
                default:
                    Console.WriteLine("Geçersiz işlem yaptınız!");
                    break;


            }



            #endregion
            Console.Read();

        }
    }
}
