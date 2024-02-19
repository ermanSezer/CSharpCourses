using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //If bloklarıyla çalışmak| 
            var number = 20;
            //if (number == 10)         //Parantezin içi şart bloğudur. Mantıksal bir karşılaştırma için. | Mantıksal bir operatör kullanılmalı.
            //{
            //    Console.WriteLine("Number is 10");
            //}
            //else if(number==20)
            //{
            //    Console.WriteLine("Number is 20");
            //}
            //else
            //{
            //    Console.WriteLine("Number is not 10 or 20");
            //}

            //Single Line if ile calismak.

            Console.WriteLine(number==10 ? "Number is 10" : "Number is not 10");


            //Switch bloğu | Çok yoğun kullanılmıyor.
            //switch (number)
            //{
            //    case 10:
            //        Console.WriteLine("Number is 10");
            //    case 20:
            //        Console.WriteLine("Number is 20");
            //        break;
            //    default:
            //        Console.WriteLine("Number is not 10 or 20");
            //        break;    //Ctrl+K Ctrl+D Kodları düzenlemek için.
            //}

            //if (number >= 0 && number <= 100)
            //{
            //    Console.WriteLine("Number is between 0-100");
            //}
            //else if (number > 100 && number <= 200)
            //{
            //    Console.WriteLine("Number is between 101-200");
            //}
            //else if (number > 200 || number < 0) //Bu kareterin adı pipe(boru) imiş.
            //{
            //    Console.WriteLine("Number is less than 0 or greather than 200");
            //}

            if (number < 100)
            {
                if (number >= 90 && number < 95)
                {

                }
            }
            Console.ReadLine();
        }
    }
}
