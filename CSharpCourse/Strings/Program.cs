using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Metinsel verileri tutmak için kullanılan değişken tipidir.
            //Intro();//best practise şu şekilde yaparsan çok daha iyi olur.
            string sentence = "My name is Erman SEZER";
            
            var result = sentence.Length; //özellik, cumlenin kaç karakterden oluştugunu verir.
            var result2 = sentence.Clone(); //string değerin bir referansını daha oluşturmaya yarar.

            bool result3 = sentence.EndsWith("R"); //Bu cumle R ile bitiyor mu?
            bool result4 = sentence.StartsWith("My name");

            var result5 = sentence.IndexOf("name"); //Belli bir karakteri veya ifadeyi aramak için kullanılır. bulamazsa -1
            var result6 = sentence.IndexOf(" "); //Bulduğu ilk boşluğu sayar sonra devam etmez.
            var result7 = sentence.LastIndexOf(" "); //Aramaya sondan başlar.
            var result8 = sentence.Insert(0,"Hello, "); //Bir string ifadeye başka bir metni yerleştirmek için kullanılır.
            var result9 = sentence.Substring(3,4); //Metni parçalamak için kullanılır.
            var result10 = sentence.ToLower(); //Bütün karakterleri küçük harfe çevirmeye yarar.
            var result11 = sentence.ToUpper(); //Büyük harf yapar.
            var result12 = sentence.Replace(" ", "-"); //Bir metin içerisinde belli karakterleri değiştirmek için kulanılır.
            var result13 = sentence.Remove(2,5); //Belli bir indexten sonrasını atmak için kullanılır.


            Console.WriteLine(result);
            Console.ReadLine();

        }

        private static void Intro()
        {
            string city = "Ankara"; //Char Array
            //Console.WriteLine(city[0]);
            foreach (var item in city)
            {
                Console.WriteLine(item);
            }
            string city2 = "İstanbul";
            //string result = city + city2; //string toplamak mümkün birr suru deger olusturduk onun yerine <-- Bunu bellekte olusturmadan da devam edebilirdik.
                              //String classi  
            Console.WriteLine(String.Format("{0} {1}", city, city2));

            //Best practice yani kodlama yaparken su sekilde yaparsak daha iyi olur.
        }
    }
}
