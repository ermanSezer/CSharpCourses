using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Veri kümesini dolaşmak için döngülerden yararlanıyoruz.
            // Değişkeni hangi blokta tanımladıysanız sadece o blokta kullanılır.

            // sayaç-başlangıç değeri | şart: hangi şarta kadar döneceğim 100 den küçük eşit olduğu sürece | Bir sonraki dönüşte i yi 1 arttır.

            //for (int i = 1; i <= 100; i++)
            //{
            //    Console.WriteLine(i);

            //}
            // Başlangıç | Şart | Artış değeri
            // Console.WriteLine("Finished!");

            //ForLoop();

            //While döngüsünde belli bir şart sağlanana kadar döngü çalışır durur.

            //WhileLoop();

            //Şart sağlanmasa bile do döngüsü çalışır.
            //Mutlaka yapmak zorunda olduğum bir şey varsa kullanılır.

            //DoWhileLoop();

            //Dizilerde gezinmek istediğimizde |foreach| döngüsü kullanılır.

            string[] students = new string[3] { "Engin", "Erman", "Sezer" };
            //Veri tabanından tabloyu çektiğimizde datayı gezmek için kullanıyoruz.
            //Array odaklı dizi temelli datalarin dolasilmasi icin kullanilir.

            //ForEachLopp(students);

            if (IsPrimeNumber(6))  
            {
                Console.WriteLine("This is a prime number");
            }
            else
            {
                Console.WriteLine("This is not a prime number");
            }
            Console.ReadLine();
        }
        //Girilen bir sayının asal olup olmadığını bulan program.

        private static bool IsPrimeNumber(int number) //Program gereksiz yere çalışmamalıdır.
        {
            //boolean oldugu icin genelde Is ifadesi kullanilir.
            bool result = true;
            for (int i = 2; i < number-1; i++)
            {
                if (number%i==0)
                {
                    result = false;
                    i = number; //break continue gibi ifadeler kullanilabilir.
                    //sarta girmeyecegi icin dongu biter.
                }
            }
            return result; 
        }

        private static void ForEachLopp(string[] students)
        {
            foreach (var student in students) // students için bir döngü kuruyoruz.
            {
                //student takma ismi
                Console.WriteLine(student);
            }
        }

        private static void DoWhileLoop()
        {
            int number = 10;
            do
            {
                Console.WriteLine(number);
                number--;
            } while (number >= 0);
        }

        private static void WhileLoop()
        {
            int number = 100;
            while (number >= 0)
            {
                Console.WriteLine(number); // infinite loop | Sonsuz döngü
                number--; //1 1 azalt.
            }
            Console.WriteLine("Now number is {0}", number);
        }

        private static void ForLoop()
        {
            for (int i = 1; i <= 100; i += 2) // i=i+2
            {
                Console.WriteLine(i);

            }
            Console.WriteLine("Finished!");
        }
    }
}
