using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] cities = new string [2] { "Ankara", "İstanbul" }; //new string dediğimde bu bellekten gitti.
            //cities = new string[3]; // Yeni referans oluştu.
            //Console.WriteLine(cities[0]);
            //Çalıştığımız nesnede eğer özellikle bir veri tipi yoksa buna type safe denir. Tip güvenli çalışma durumu yoksa O zaman ArrayList.
            //Genelde Type Safe tercih edilir. Tip güvenli ArrayList yerine koleksiyonlar kullanılır.
            //ArrayList();
            //Console.WriteLine(cities[2]);
            //cities[2] = "Adana";
            //Yeni eleman eklemeye çalıştığımızda problem oluyor.
            //3 elemana çıkmak için ne yapmak lazım.

            //Buna generic deniyor.
            //List<string> cities = new List<string>();
            ////Ben bir koleksiyon oluşturmak istiyorum. Fakat ben bu koleksiyonda sadece string ile çalışabilirim demek.
            //cities.Add("Ankara");
            //cities.Add("İstanbul");

            ////Console.WriteLine(cities.Contains("Ankara")); //Şehirlerin içerisinde Ankara değeri varsa True döner.
            //foreach (var city in cities)
            //{
            //    Console.WriteLine(city);
            //}
            ////List<Customer> customers = new List<Customer>(); //Profesyonel projelerde böyle olur. List of Customer
            ////customers.Add(new Customer { Id = 1, FirstName = "Erman" });
            ////customers.Add(new Customer { Id = 2, FirstName = "Davut" });

            //List<Customer> customers = new List<Customer>
            //{
            //    new Customer() {Id=1, FirstName="Erman"},
            //    new Customer() {Id=2, FirstName="Davut"}
            //};

            ////var count = customers.Count; //Eleman sayısını veren özellik.

            //var customer2 = new Customer
            //{
            //    Id = 3,
            //    FirstName = "Sezer"
            //};
            //customers.Add(customer2);

            //customers.AddRange(new Customer[2]
            //{
            //   new Customer{Id=4, FirstName="Güler"},
            //   new Customer{Id=5, FirstName="Dilek"}
            //});
            ////Direk bir eleman vermek yerine Array bazlı bir liste ver ben onları olduğu gibi customers ın içine ekleyeyim.

            ////customers.Clear(); //Listeyi temizleme

            ////customers.Contains() //Listede aradığımız değer var mı diye arama yapar.

            ////customers.Add(new Customer { }); //Yeni bir eleman ekleyebiliyoruz müşterilere.

            ////Console.WriteLine(customers.Contains(new Customer { Id = 1, FirstName = "Erman" })); | Bunu yaptığınızda hata alırsınız.
            ////Gerçekten referansı tutan bir şey göndermelisiniz.
            //Console.WriteLine(customers.Contains(customer2));
            ////new dediğin zaman yeni bir referans demek bu.

            //var index = customers.IndexOf(customer2);    //Listedeki elemanın listede kaçıncı sırada olduğunu verir.
            //Console.WriteLine("Index: {0}", index);

            //customers.Add(customer2);
            //var index2 = customers.LastIndexOf(customer2); //customer2 yi aramaya sondan başlayacaktır.
            //Console.WriteLine("Index2: {0}", index2);       //İndex numarası değişmez sadece arama yeri değişir.
            ////nereye koymak istyorsun, neyi koymak istiyorsun.
            //customers.Insert(0, customer2);     //Kaçıncı sıraya neyi eklemek istiyorsun. Add hep en sona ekliyor. Listenin başına eklemek isteyebilirsin.

            ////customers.Remove(customer2);    //Bulduğu ilk değeri uçurur. Bulduğu anda aramayı keser ve bitirir.
            //customers.RemoveAll(c=>c.FirstName=="Sezer");  //Burada bir predicate(yüklem,koşul)-delegate(temsilci seçme) göndermemiz gerekiyor.
                         

            //foreach (var customer in customers)
            //{
            //    Console.WriteLine(customer.FirstName); //Collections ın altındaki customer diye geldi.|
            //                                           //Ekrana direkt olarak customer yazdırmaya çalıştığımız için böyle oldu.
            //}
            ////Genellikle veri tabanı programlama yaptığımız için. 
            ////Veri tabanındaki tablolarınızın karşılığını nesne halinde tutarız.
            ////Müşteri bir tablo gibi düşünün, tabloun kayıtlarını da ıd, firsName, lastName, city gibi düşünelim.
            ////Veri tabanından veri çektiğimiz zaman biz onu listeye atarız. Onu kullanıcıya gösteririz. Direkt nesnelerle çalışmak önemli.
            //var count = customers.Count;
            //Console.WriteLine("Count: {0}", count);

            //Sözlük| Anahtar kelime vasıtasıyla onun değerine ulaşmayı hedeflediğimiz yapılardır.
            // Anahtar hangi türde değeri hangi türde
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
                            //key - value
            dictionary.Add("book", "kitap"); //Bir anahtar ile değere ulaşmayı hedeflediğimiz ortamlarda kullanıyoruz.
            dictionary.Add("table", "tablo");
            dictionary.Add("Computer", "Bilgisayar");

            //sözlüğün değerlerine ulaşmak için:
            //Console.WriteLine(dictionary["table"]);
            //Dictionary bir koleksiyondur.
            foreach (var item in dictionary)
            {
                Console.WriteLine(item.Key);
            }

            Console.WriteLine(dictionary.ContainsKey("glass")); //dictionary e özgü method
            Console.WriteLine(dictionary.ContainsKey("table"));
            //Bunu da if lerle değer varsa ona göre bir şey yap olarak yapılabilir.
            //Bir nesneyi tutup ona anahtar değeri üzerinden ulaşma şeklinde sıklıkla kullanılır.
            Console.ReadLine();
        }

        private static void ArrayList()
        {
            ArrayList cities = new ArrayList(); //Koleksiyon oluşturmak için en temellerinden bir tanesidir.
                                                //Sıfırdan bir nesne oluşturduk.-Referans oluşturduk.
            cities.Add("Ankara");
            cities.Add("Adana");
            cities.Add("İstanbul");
            cities.Add(1); //object value-Bütün tiplerin base i yani temeli objedir.
            cities.Add('A');

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }
        }
    }

    class Customer // nesne tanımladık.
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
    }
}
