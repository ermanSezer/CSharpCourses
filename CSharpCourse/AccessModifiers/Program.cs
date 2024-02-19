using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    internal class Program
    {               //Erişim bildirgeçleri
        static void Main(string[] args)
        {
        }
    }
    class Customer
    {
        private int Id { get; set; }
        //protected int Id { get; set; } //class seviyesinde.
        //private int id; //defaul private dır.
        public void Save()
        {
            //int id;

        }

        public void Delete()
        {
                        //Protected private ın bütün özelliklerini karşılıyor. Tanımlandığı blok içerisinde her yerde geçerli.
        }
    }                   //Private bir değişken sadece tanımlandığı **blok** içerisinde geçerlidir.


    class Student : Customer
    {
        public void Save2()
        {
            //Customer customer = new Customer();
            //Protected ın private ten farkı. protected özellikler inherit edildiği sınıflarda çalışabilir.
            //En düşük seviyeden private<protected<internal
            
        }
    }
    public class Course //Default u ne? internal
    {       //internal class ne demek: internal classı bağlı olduğu projede referans ihtiyacı olmadan kullanabilirsiniz.
        public string Name { get; set; }
        //private class NestedClass
        //{

        //}
    }
    //Üst seviyeli bir class private olamaz. Bir class ya internal olur ya da public olur.
    //İç içe classlarda private olur.
    //Bir classı farklı bir projedende kullanmak istersek ne yapacağız. O zamanonu public yapmanız gerek.
}
