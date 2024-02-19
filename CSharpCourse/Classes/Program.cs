using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Yapmak istediğimiz işlemleri gruplara ayırmak.
            //O grup üzerinden işlemleri yapmak. Rahatlıkla bu gruba ulaşmak için kullanabiliriz.

            //Class ı kullanmak için onun bir örneğini oluşturmak gerekir. Bir referansini olusturduk da diyebiliriz.
            CustomerManager customerManager = new CustomerManager();

            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager(); //önce çağırıyoruz gibi düşün.
            productManager.Add();
            productManager.Update();

            //Customer nesnesi tanımlayacağımız zaman classı kullanabilmek için onu new lememiz gerekiyor.
            //Bir örneğini oluşturmamız gerekiyordu.
            Customer customer = new Customer();

            customer.City = "Ankara";
            customer.Id = 1;
            customer.FirstName = "Erman"; //set bloğu çalışır.
            customer.LastName = "Sezer";

            Customer customer2 = new Customer
            {
                //Ctrl + space tuşuna bas
                Id = 2, City="İstanbul", FirstName="Davut", LastName="Sezer"
            };
            Console.WriteLine(customer2.FirstName); //get bloğu çalışır properitydeki
            Console.ReadLine();
        }
    }
            //Class oluşturulurken PascalCase yani kelimelerin ilk harfleri büyük.
            //Örneği oluşturulduğunda camelCase e döner ilk harf küçük sonrakiler büyük.
            //Bir class içerisinde o class ile ilgili methodları barındırır. Olayı grupladırmış olduk.
            //Class larin bir diger ozelligi property dedigimiz nesneleri tutmaktir ozellikleri tutmak.
}
