using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Temel Dizi Örnekleri

            /*string[] colors = new string[4];
            colors[0] = "Kırmızı";
            colors[1] = "Sarı";
            colors[2] = "Beyaz";
            colors[3] = "Mavi";

            Console.WriteLine(colors[2]);

            string[] cities = new string[5];
            cities[0] = "Milano";
            cities[1] = "Budapeşte";
            cities[2] = "Lyon";
            cities[3] = "Kahire";
            cities[4] = "Üsküp";

            Console.WriteLine(cities[4]);

            int[] numbers = new int[10];
            numbers[0] = 50;
            numbers[1] = 48;
            numbers[2] = 698;
            numbers[3] = 24;
            numbers[7] = 748;
            Console.WriteLine(numbers[5]);

            string[] citiess = { "Prag", "Roma", "Atina", "Floransa", "Madrid", "Barselona" };
            Console.WriteLine(citiess[0]);
            */
            #endregion

            #region Dizideki tüm elemanları listeleme

            //string[] colors = { "Sarı", "Kırmızı", "Mavi", "Mor", "Lacivert", "Bordo" };
            //for(int i=0;i<colors.Length;i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //int[] numbers = { 4, 85, 96, 75, 125, 635, 488, 522, 7456, 2365, 1120 };

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //char[] symbols = { 'a', 'b', 'c', '*', '/', '-' };
            //for (int i = 0; i < symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}

            #endregion

            #region Dizi İşlemleri

            //int[] myArray = { 1, 2, 3, 4, 5 };
            //int maxNumber = myArray[0];

            //for(int i=0;i<myArray.Length;i++)
            //{
            //    if (myArray[i]>maxNumber)
            //    {
            //        maxNumber= myArray[i];
            //    }
            //}

            //Console.WriteLine(maxNumber);

            //string[] persons = { "ali", "ahmet", "ayşe", "buse", "cem", "deniz" };
            //Console.Write(persons.Length);

            //küçükten büyüğe doğru sıralama
            //int[] numbers = { 45, 85, 52, 41, 86, 10, 22, 35 };
            //Array.Sort(numbers);
            //for(int i=0;i< numbers.Length;i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //diziyi tersten sıralar
            //int[] numbers = { 45, 85, 52, 41, 86, 10, 22, 35 };
            //Array.Reverse(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            #endregion

            #region Dizi Metotları

            //string[] customers = { "ali", "buse", "merve", "çınar", "veli", "selma" };
            //int index = Array.IndexOf(customers, "merve");
            //Console.WriteLine(index);

            //int[] numbers = { 45, 85, 96, 63, 74, 10, 25, 22, 36 };
            //Console.WriteLine("Dizinin en büyük elemanı : " + numbers.Max() + " Dizinin en küçük elemanı : " + numbers.Min());

            #endregion

            #region Kullanıcıdan Değer Alma

            //string[] cities = new string[5];

            //for(int i=0;i<cities.Length;i++)
            //{
            //    Console.Write($"Lütfen {i + 1}. Şehri Giriniz : ");
            //    cities[i] = Console.ReadLine();
            //}
            //Console.WriteLine();
            //Console.WriteLine("**********************");

            //for(int i=0;i<cities.Length;i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}

            //int[] numbers = new int[10];
            //int toplam = 0;
            //Console.WriteLine("Toplam için 10 adet sayı girin");

            //for(int i=0;i<numbers.Length;i++)
            //{
            //    numbers[i] = Console.Read();

            //}

            //for(int i=0;i<numbers.Length;i++)
            //{
            //    toplam += numbers[i];
            //}
            //Console.WriteLine();
            //Console.WriteLine("Toplam : "+toplam);

            #endregion

            int[] numbers = { 21, 42, 33, 54, 55, 66, 897, 748, 39, 220 };

            Console.WriteLine("Çift Sayılar");
            Console.WriteLine();

            for(int i=0;i<numbers.Length;i++)
            {
                if (numbers[i]%2==0)
                {
                    Console.WriteLine(numbers[i]);
                }
            }

            Console.WriteLine("------------");
            Console.WriteLine("Tek Sayılar");
            Console.WriteLine();

            for(int i=0;i<numbers.Length;i++)
            {
                if (numbers[i]%2==1)
                {
                    Console.WriteLine(numbers[i]);
                }
            }
            Console.Read();
        }
    }
}
