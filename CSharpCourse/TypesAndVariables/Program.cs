using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Nabüün len"); //Yaşam döngüsü
            //İnteger veri tipi | Tam sayı | Değer tiplerinden biridir.| Value Types
            //Enum--> Temel amaç programlamada magic string denilen değerler tutmak yerine.
            double  number5 = 10.4 ;  //Ondalıklı sayıları tutabiliriz. 64 bitlik yer kaplar. Virgülden sonra 15-16 karakter tutabilir.
            decimal number6 = 10.4m; //Decimal virgülden sonra 28-29 tane değer tutabilir.
            char character = 'a'; 
            bool condition = false;
            byte number4 = 0; //1 bayt 8 Bit yer kaplar. 0 - 255 arasında değer tutar.
            short number3 = -32768; //short 16 bitlik yer kaplar
            int number1 = 2147483647;  //variable sınır 2 milyar.
            long number2 = -9223372036854775808; //long kapsar integer | Bellekte iki katı yer kaplar statik olarak.
                                                 //19 karakterden oluşuyor. long sınırları.int 32 bit long 64 bit yer kaplar.
            var number7 = 10; //ilk atamamiz integer oldugu icin bundan sonra her sey integer olarak kabul edilir.
            number7 = 'A';
            
            Console.WriteLine("Number1 is {0}",number1); //virgülden sonraki ilk değerdir {0} bunlara index denir indexler sıfırdan başlar.
            Console.WriteLine("Number2 is {0}", number2);
            Console.WriteLine("Number3 is {0}", number3);
            Console.WriteLine("Number4 is {0}", number4);
            Console.WriteLine("Number5 is {0}", number5);
            Console.WriteLine("Number7 is {0}", number7);
            Console.WriteLine("Character is {0}", (int)character); //ASCII
            Console.WriteLine((int)Days.Friday);
            Console.ReadLine(); //Ekranda bir şey görmek istiyorsam.
            
            
        }
    }
    enum Days //Bunlari string gibi tek tek bir daha bir daha yazmamizi engelliyor.
    {   //Enum sabitleri
        Monday =10, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
    }
}
