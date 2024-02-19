using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {   //Ayni tipteki degerleri, degiskenleri tek bir noktada tek bir degiskenle yonetme. Ona hizlica ulasma onu bir dongu ile gezme ihtiyacinda kullanilir.
            //Diziler | String referans tiptir.
            //Tek boyutlu dizi       Buradaki 3 eleman sayısı.
            string[] students = new string[3] { "Engin", "Erman", "Sezer" };
            //students[0] = "Engin";
            //students[1] = "Erman";
            //students[2] = "Sezer";
            //students[3] = "Davut";

            /* string[] students2 = new [] {"Engin","Erman","Sezer","Davut" }; */ //new olmadanda oluyor.
            string[] students2 = { "Engin", "Erman", "Sezer", "Davut" };
            //takma isim

            foreach (var student in students2) //Döngü
            {
                Console.WriteLine(student);
            }

            //Çok boyutlu diziler | Multi Dimensional
            //7 Satır - 3 Kolon (sutun)
            string[,] regions = new string[7, 3]
            {
                //region[0,0]="Istanbul";
                {"İstanbul","İzmit","Balıkesir" },
                {"Konya","Ankara","Kırıkkale" },
                {"Antalya","Adana","Mersin" },
                {"Rize","Trabzon","Samsun" },
                {"İzmir","Muğla","Aydın" },
                {"Ağrı","Van","Elazığ" },
                {"Diyarbakır","Urfa","Hakkari"}
            };

            for (int i = 0; i <= regions.GetUpperBound(0); i++) // satırlar 0. sütünlar 1. dimension
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i, j]);
                }
                Console.WriteLine("********");
            }
            //regions[0, 0] = "İstanbul";

            //Console.WriteLine();
            Console.ReadLine();
            //Aynı tipteki değerleri - değişkenleri tek bir noktada yönetip tek bir değişkenle yönetme ona hızlıca ulaşma, onu bir döngü ile gezme
            //Koleksiyonlar| Arraylerin daha geliştirilmiş hali.
        }
    }
}
