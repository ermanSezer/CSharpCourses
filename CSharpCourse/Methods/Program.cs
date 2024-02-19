using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Add();
            //var result = Add2(20);
            //Console.WriteLine(result);
            //int number1 = 20;
            //int number2 = 100;
            //var result2 = Add3(ref number1, number2); 
            //int number1; out olunca deger vermeye gerek yok.
            //var result2 = Add4(out number1, number2); | Once method calisti.
            //Console.WriteLine(result2);
            //Console.WriteLine(number1);

            Console.WriteLine(Multiply(2, 4));
            Console.WriteLine(Multiply(2, 4, 5));

            Console.WriteLine(Add5(2,3,4,5,6));
            Console.ReadLine();
        }
        //Methodları | Veri tabanına kullanıcıların verilerini kaydetme ihtiyacınız var.
        //Bir işlemi bir daha kullanacağımız zaman aynı methodu tek merkezde kontrol edebilme imkanı buluyoruz.
        //Dont repeat yourself | Kenidini tekrarlamamak icin yapilir.

        static void Add()
        {
            Console.WriteLine("Added!");
        }

        //void git şunu yap demek. Bir işlem yap demek. Bir sey yaz bir yere kayit yap demek.
        //void yerine ne tipte veri dondurmek istiyorsak o tipi yaziyoruz.
        static int Add2(int number1, int number2 = 30)  //number2 verilmezse default değer olarak 30 kullan.
        {   //Default değer her zaman sonda olmalı.
            //Sonuç vermesi için. Ne tipte veri döndürmek istiyorsak onu yazıyoruz => int
            var result = number1 + number2; //return number1 + number2;
            return result;
        }

        static int Add3(ref int number1, int number2 = 30)  //ref key word
        {   //methodun icindeki number1 degisince main(en ustteki) deki nummber1 in  de degismesini istiyorum diyorsan.
            //deger tiplerin referans tip gibi kullanilmasini saglar.
            number1 = 30;
            return number1 + number2;
        }

        static int Add4(out int number1, int number2 = 30) 
        {   //out keyword ile ref arasındaki fark => ref te değer set etmek gerekiyor.(number1 in bir degeri olmasi gerekiyor.) out ta gerek yok.
            //out taki sikinti out icin bir deger gonderdiginde mutlaka method icinde set edilmesi gerekiyor. 
            number1 = 30;
            return number1 + number2;
        }

        //Method Overloading
        //tipi integer olan ismi Multiply olan parametreleri de parantez içinde olanlar.
        static int Multiply(int number1, int number2) //Methodun imzası
        {
            return number1 * number2;
        }

        static int Multiply(int number1, int number2, int number3) //3 sayiyi carmak istedigimde degisken ismini degistirmeden method overloading yapiyorum.
        {
            return number1 * number2 * number3;
        }

        //Params Keyword İle Çalışmak | Methoda aynı tipte istediğimiz kadar parametre gönderebiliriz.
        static int Add5(params int[] numbers) //params notasyonuyla dizi formatinda istedigimiz kadar parametre yollayabiliriz demek.
        {
            return numbers.Sum(); //sum fonksiyonu hazir methodlardan biri.
        }
    }
}
