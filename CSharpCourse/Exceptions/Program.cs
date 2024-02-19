using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hata olmasından endişe ettiğiniz bir kodunuz varsa:
            //try
            //{
            //    string[] students = new string[3] { "Erman", "Sezer", "Dilek" }; //upperbound 2 dir.

            //    students[3] = "Ahmet";
            //}      //tipi     ismi | Bir hata olduğunda hata bilgisi exception diye bir nesneye aktarılıyor.
            //catch (IndexOutOfRangeException exception)
            //{
            //    Console.WriteLine(exception.Message);
            //}
            //catch (DivideByZeroException exception)
            //{
            //    Console.WriteLine(exception.Message);
            //}
            //catch (Exception exception)   //Hatanın türüne göre davranış sergileyebiliriz.
            //{
            //    //Break point calisirken uygulamanizi orda durdurmak icin kullanilir.
            //    //Console.WriteLine("EXCEPTIONNNNN");

            //    Console.WriteLine(exception.Message); //Uygulama bir hata verdiğinde hatanın bilgisini son kullanıcıya göstermeyiz.

            //    //Hatanın sonucunu son kullanıcının görmesi sistem hakkında bilgi edinmesi demektir.
            //    //Veri tabanına veya başka bir yere loglarız.
            //    //Console.WriteLine(exception.InnerException); //Exception hakkında varsa daha detaylı bilgi verir.
            //}
            //string[] students = new string[3] { "Erman", "Sezer", "Dilek" }; //upperbound 2 dir.

            //students[3] = "Ahmet"; //yazılım güvenliği, Uygulamada hata çıkarabiliyorsanız ditek uygulama hakkında bilgi alabiliyorsunuz.
            //Hata yakalamayı niçim yaparız, hatanın ne olduğunu süzüp ona göre kullanıcıya daha farklı bilgi verme eğilimde oluruz.
            //Hata yakalama katmanlı mimarilerde yaklaşımı belli bir adım adım ilerlemenin sonucunda şekillenir.
            //Arayüz ortamında kullanıcıyı daha farklı bilgilendirmeyi hedefliyoruz.

            try
            {
                Find();
            }
            catch (RecordNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
                //throw; hatayi firlat demek
            }

            //Method|Parametre olarak method gondermek istiyoruz. Delege dedigimiz yapilarla gonderiyoruz.
            //Parametyresiz bir sey gondericem. kod blogu gondericem o kod blogunun karsiligida => lamda kod kumesi

            HandleExceptions(() =>
            {
                Find();
            });

            Console.ReadLine();
        }

        private static void HandleExceptions(Action action)
        {
            try
            {
                action.Invoke(); //wmethodu merkezi bir try catch icine gondermis olduk. 
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                
            }
        }

        private static void Find()
        {
            List<string> students = new List<string> { "Erman", "Sezer", "Davut" };
            //yoksa unlem.
            if (!students.Contains("Ahmet"))
            {
                throw new RecordNotFoundException("Record not found!"); //bir sinif ve exceptiondan turuyor exceptiondaki seyleri biz buraada ezebiliriz.
            }
            else
            {
                Console.WriteLine("Record Found!");
            }
        }
    }
}
