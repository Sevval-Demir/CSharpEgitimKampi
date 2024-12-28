using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region For Döngüsü

            //int i;
            //for(i=0;i<5;i++)
            //{
            //    Console.WriteLine(i); 
            //}

            //int i;
            //for(i=0;i<=50;i+=3)
            //{
            //    Console.WriteLine(i);
            //}

            //int finishValue;
            //Console.WriteLine("Döngünün sonlanması gereken değeri yazınız.");
            //finishValue = int.Parse(Console.ReadLine());
            //for(int i=0;i<=finishValue;i++)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion

            #region For Döngüsü ile Karar Yapıları

            //for(int i=0;i<100;i++)
            //{
            //    if(i%5==0)
            //    {
            //        Console.WriteLine(i);     
            //}

            //int totalValue = 0;
            //int number;
            //Console.WriteLine("Hangi sayıya kadar ardışık toplam yapmak istersiniz");
            //number = int.Parse(Console.ReadLine());

            //for(int i=0;i<=number;i++)
            //{
            //    totalValue += i;
            //}
            //Console.WriteLine("Ardışık toplam : " + totalValue);


            //int totalValue = 0;
            //for(int i=1;i<20;i++)
            //{
            //    if(i%2==0)
            //    {
            //        totalValue += i;
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.WriteLine("------------");
            //Console.WriteLine(totalValue);

            //int count = 0;
            //for (int i = 1; i <= 50; i++)
            //{
            //    if (i % 7 ==0)
            //    {
            //        count++;
            //    }
            //}

            //Console.WriteLine(count);

            //int bacterium = 1;
            //int result = 0;
            //for(int i=1;i<=24;i++)
            //{
            //    bacterium *= 2;
            //    Console.WriteLine(i + ".Saat sonunda: " + bacterium);
            //    result+=bacterium;
            //}
            //Console.WriteLine("Toplam bakteri sayısı : " + result);


            #endregion

            #region While Döngüsü

            //int i = 1;
            //while(i<=10)
            //{
            //    Console.WriteLine("Hello World");
            //    i++;
            //}

            //int i = 1;
            //while (i<=10)
            //{
            //    if(i%3==0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}

            //int i = 1;
            //int sum = 0;
            //while(i<=10)
            //{
            //    sum += i;
            //    i++;
            //}
            //Console.WriteLine(sum);


            #endregion

            #region Örnek Sınav Sorusu

            //Klavyeden girilen 3 basamaklı sayının basamakları toplamını hesaplayan kodu yazın

            int number;
            int yuzler, onlar, birler;
            Console.WriteLine("3 basamaklı bir sayı girin : ");
            number = int.Parse(Console.ReadLine());
            int sum;

            if (number > 99 & number < 1000)
            {
                yuzler = number / 100;
                onlar = (number / 10) % 10;
                birler = number % 10;
                sum = yuzler + onlar + birler;
                Console.WriteLine("Girilen 3 basamaklı sayının basamakları toplamı : " + sum);
            }
            else
            {
                Console.WriteLine("Girilen sayı 3 basamaklı değildir");
            }






            #endregion
            Console.Read();
        }
    }
}
