using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Customer
    {
        //public string FirstName; //field bir alan tanımlamak.
        //Property
        public int Id { get; set; } //Bir müşterinin özelliklerini tutmak için kullandığımız nesne | Prop tutmak.
        //Genellikle veri tabanlarindaki kolonlarin karsiliklarini burada bir class icin tutabiliriz.
        public string FirstName { get; set; } // Otoproperty

        //ENCAPSULATION--> implementation detayinin gizlenmesi deniyor.
        //Biz bir kural getiriyoruz eger ki kullanici FirstName i set ederse ona bir deger girerse
        //FirstName in basina baska bir karakter getir diyebiliriz.
        //Bir field uzerinde get veya set ederken yani degeri verirken ya da okurken baska bir sey yapmak isterseniz.

        //private string _firstName;
        //public string FirstName
        //{
        //    get
        //    {
        //        return "Mr." + _firstName;
        //    }
        //    set
        //    {
        //        _firstName = value;  //value set etmeye çalıştığımız değere karşılık gelir.
        //    }
        //}
        

        public string LastName { get; set; } // Propertysini eşitlediğiniz (customr.LastName="Erman"; gibi) zaman sizin için propertydeki set bloğu çalışır.
                                             // Set ediyoruz, kuruyorsunuz, degeri veriyorsunuz.
        public string City { get; set; }    //Console.WriteLine(customer2.FistName) de ise customer2 nin first name ini al kelime olarak ta get.
                                            //Burada get blogu calisir.
    }
}
