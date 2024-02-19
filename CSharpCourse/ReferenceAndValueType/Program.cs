using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceAndValueType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10;
            int number2 = 20;
            number2 = number1;
            number1 = 30;
            Console.WriteLine(number2);

            string[] cities1 = new string[] {"Ankara", "Adana", "Afyon" };//101
            string[] cities2 = new string[] { "Bursa", "Bolu", "Balıkesir" };//102
            cities2 = cities1; //102=>101
            //citites2 nin referansı eşittir cities1 in referansına.
            //cities1 için bellekte değişkenin kendisini tutan bir yer var, bir de onun referansını tutan bir yer var.
            //garbage collector dediğimiz çöp toplayıcı tutulmayan bir nesne olduğu için onu bellekten uçuracak.
            cities1[0] = "İstanbul";
            Console.WriteLine(cities2[0]);
            //DataTable nesnesi veri tabanından veriyi çekip doldurmak için kullanılır. class
            //DataTable dataTable = new DataTable(); //new lemek bellekteki en pahalı işlerden birisidir.
            DataTable dataTable; //Burada bir değeri oluşturdu.
            //dataTable.Load(new DataTableReader());
            DataTable dataTable2 = new DataTable();
            dataTable = dataTable2; //Sonra dediki dataTable ın referansı dataTable2

            Console.ReadLine();
            //Atamalar tamamen değeri üzerinden gerçekleşir.
        }
    }
    //integer, boolean, double, decimal değer tip.
    //class, string, interface, abstract bunlar referans tip. Array ler
}
