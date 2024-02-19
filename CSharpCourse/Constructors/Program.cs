using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //constructors: Bir sınıf new lendiğinde çalışacak kod bloğudur.
            CustomerManager customerManager = new CustomerManager(10); //() o sınıfın parametresiz bir şekilde çalıştırılması anlamına gelir.
            customerManager.List();

            Product product = new Product { Id = 1, Name = "Laptop" };
            Product product1 = new Product(2,"Computer");

            EmployeeManager employeeManager = new EmployeeManager(new DatabaseLogger());
            //employeeManager.Logger = new DatabaseLogger(); //Database i mi file lama
            employeeManager.Add();
            PersonManager personManager = new PersonManager("Product"); //Entity ini söyle diyor.
            personManager.Add();//Sonra personManager ın herhangi bir methodunu çalıştırabiliriz.

            //Static Bir Nesneyi Nasıl Kullanıyoruz? Herhangi bir instance üretmeden.
            Teacher.Number = 10; //Herkes için aynı sonucu verir. Belleğin hafızasında durduğu için.
            //Static nesneler ortak nesnelerdir ve herkes onları kullanabilir.
            //Genellikle static nesnelerden uzak durmaya çalışırız.
            //Teacher teacher = new Teacher(); Static nesne olduğundan olmadı.

            Utilities.Validate();
            Manager.DoSomething(); //static i direk sınıfın isminden açğırıyoruz.
            Manager manager = new Manager(); //static olmayanı ise instance üzerinden çağırabiliyoruz.
            manager.DoSomething2(); //Static bir sınıfın her şeyi static olmalı.
            Console.ReadLine();
        }
    }
    //Bu sınıfın ihtiyaç duyduğu farklı parametreler varsa.
    //Bu parametreler kullanıma göre değişkenlik gösteriyorsa o zaman constructor dan yararlanırız.
    //Sınıfın ihtiyaç duyduğu parametreyi constructor ile set edersiniz.
    //Onu da new ledeikten sonra parantezin içinde gönderirsiniz
    //overload ta edilebilir constructorlar.
    class CustomerManager
    {
        private int _count = 15; //Bir field. o yüzden "_" ile başlatılır. İsimlendirme standartı.

        public CustomerManager(int count) //constructor oluşturmak için *ctor* yazdık.| Method halinde ise "_" kullanılmaz.
        {
            _count = count; //Best practice    
        }
        public CustomerManager()
        {
            
        }
        public void List() //method| Syntax odaklı gidiyoruz şuan.
        {
            Console.WriteLine("Listed {0} items", _count);
        }
        public void Add()
        {
            Console.WriteLine("Added!");
        }
    }
    class Product
    {
        //Böyle değerleri hızlıca set etmek için constructor kullanılabilir.
        public Product()
        {
            
        }
        private int _id;
        private string _name;
        public Product(int id, string name)
        {
            _id = id;

            _name = name;

        }
        public int Id { get; set; }
        public string Name { get; set; }
    }
    interface ILogger
    {
        void Log();
    }
    class DatabaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to database");
        }
    }
    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to file");
        }
    }
    class EmployeeManager
    {
        private ILogger _logger;
        //public ILogger Logger { get; set; } //Daha önce loglamayı prop ile yapmıştık.
        public EmployeeManager(ILogger logger) //Daha doğru versiyon. Değişim odaklı yazılımlar için temeldir.
        {
            _logger = logger; //sen new lenirken bana loglama için hangi yöntemi kullanacağını söyle
        }
        public void Add()
        {
            _logger.Log(); //Aynı zamanda Loglamayı çağırmak istiyoruz.
            Console.WriteLine("Added!");
        }
    }

    //Base sınıfa parametre göndermek.
    class BaseClass
    {
        //Kullancağımız bütün class lardaki ortak özelliği barındıracak.
        private string _entity; //varlık.
        //bunu constructor ile set ediyoruz.
        public BaseClass(String entity)
        {
            _entity = entity;
        }
        public void Messsage() //Bütün sınıflarda-Manager larda mesaj gösterecek bir işlem yapmak istiyoruz.
        {
            Console.WriteLine("{0} message", _entity); //Yani sıfırın yerine _entity gelecek. Girilen parametre geliyor.
        }
    }

    class PersonManager:BaseClass //inherite
    {
        //Constructor verdiğim için baseclass ı new leyip onun içerisindeki bir nesneyi örneğin message i çağırmaya çalışacağım ama
        //Senin bana bir şey göndermen lazım.(entity)
        public PersonManager(string entity):base(entity) //constructor
        {
            //base sınıfa bir değer göndermek istiyorsan. parametredeki değeri(string entity) base entitye yollayabilirsin.
        }
        public void Add()
        {
            Console.WriteLine("Added!");
            Messsage();
        }
    }
    //Örneğin sizin bir tane souyt sınıfınız var abstract sınıfınız var.
    //Abstract sınıfın içerisinde her şey standart sadece bir parametre değişkenlik gösteriyor.
    //Mesela connectionString, oracle connectionString ile mySql connectionString farklıdır.
    //connectionString base e parametre olarak gönderirsiniz. Geriye kalan bütün işlemleri abstract sınıf yapar.

    //STATİC CLASS VE METODLAR

    static class Teacher
    {
        //Static nesnelerde bir nesnenin hiç bir zaman instance ını (new) oluşturamazsınız.
        //Static bir nesne ile çalıştığınızda paylaşılan bir kaynak olup olmadığından emin olmalısınız.
        public static int Number { get; set; } //Static nesnenin bütün özelliklerinin static bildirgesine sahip olması gerekiyor.

    }

    static class Utilities // Amaç ne? Bir iş yap ve bitir.
    {
        static Utilities() //Static bir nesnede mutlaka çalışmasını istediğiniz bir kod bloğu varsa.
        {

        }
        //Sıklıkla kullandığınız operasyonlarınız varsa.
        //validasyon doğrulama için.
        public static void Validate() //Buna da parametre verirsiniz.
        {
            //Web sitesine üye olurken, şifre minimum 6 karakter olması gerekir gibi.
            Console.WriteLine("Validation is done"); //normalde validasyon kodu yazılır.
        }
    }
    //Class ı static yapmayıp özelliklerini static yapabilirsiniz peki bundan kasıt nedir?
    class Manager
    {
        public static void DoSomething() //method
        {
            
            Console.WriteLine("Done"); 
        }
        public void DoSomething2()
        {
            Console.WriteLine("Done 2");
        }
    }
    //Aynı işlemi static constructorlar için de gerçekleştirebiliyoruz.


}
