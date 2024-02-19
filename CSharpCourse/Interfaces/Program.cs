using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //InterfacesIntro();
            //Bir interface hiç bir zaman new lenemez. Çünkü tek başına bir anlamı yoktur.
            //İnterfaceler böyle katmanlar arası geçişlerde kullanılıyor amaç uygulamanın bağımlılığını azaltmak.
            //Demo();

            ICustomerDal[] customerDals = new ICustomerDal[3]
            {
                new SqlServerCustomerDal(),
                new OracleCustomerDal(),
                new MySqlCustomerDal(),
            };
            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }
            Console.ReadLine();
        }

        private static void Demo()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new SqlServerCustomerDal());
        }

        private static void InterfacesIntro()
        {
            PersonManager manager = new PersonManager();
            //manager.Add(new Customer{Id = 1,FirstName = "Engin", LastName = "Demirog", Adress = "Ankara"});

            Customer customer = new Customer
            {
                Id = 1,
                FirstName = "Erman",
                LastName = "Sezer",
                Adress = "Kırklaeli"
            };
            Student student = new Student
            {
                Id = 1,
                FirstName = "Davut",
                LastName = "Güler",
                Departmant = "Home and Coffe",
            };
            manager.Add(student);

        }
    }
    interface IPerson //isimlendirme standarti Interface in "I" si ile baslar.
    {   //soyut nesne | Tek başına hiç bir anlam ifade etmez.
        //Kullanim amaci --> Temel operasyon(nesne) oluşturup bütün nesneleri ondan implemente etmektir.
        
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }

    }
    class Customer : IPerson //somut nesne, bize lazim olan bir musteri ya da ogrenci ile ilgili islemler yapmaktir.
    {                        //musteride bir kisidir ogrencide bir kisidir ortak ozellikleri var.
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Adress { get; set; }
    }
    class Student : IPerson //Iperson da tanımlanmış her şeyi bu sınıflarda görebiliriz anlamına gelir.
    {   // implement interface yaptik. interface in ozelliklerini onu implemente eden sinifin icinde yazmak zorundasin.
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Departmant { get; set; }
    }
    class Worker : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Departmant { get; set; }
    }
    class PersonManager //iş katmanı için kullanılır.
    {                       //Ben bir ekleme yapacagim  Parametre olarak bana bir müşteri nesnesi ver, diyorum (Customer customer) yaparak.
        //Eklemede --> Bana bir musteri tipinde parametre ver, bir nesne de parametre olabilir.

        //public void Add(Customer customer) //int string tipi gibi bana bir musteri tipi ver diyoruz.
        //{                                 //Bir kisiyi veri tabanina ekleyecek operasyon.
        //    Console.WriteLine(customer.FirstName);
        //}
                        //Ilk etapta burasi (Cuustomer customer) di ama manager.Add(student) yazamadik o sebeple (Iperson person) oldu.
        public void Add(IPerson person) //parametre verdiğinizde interfaceten gidebiliriz. Çok önemli kısım parametreler interface olmalı.
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
