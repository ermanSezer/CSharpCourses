using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance // Kalıtım veya miras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Customer customer = new Customer();
            Person[] persons = new Person[3]
            {
                new Customer{FirstName="Erman"}, new Student{FirstName="Sezer"}, new Person{FirstName="Davut"}
            };
            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName);
            }
            Console.ReadLine();
        }
        //Abstract sınıflar inheritance anlamında bizim için çok önemli.
        //Ne zaman interface ne zaman inheritance?
        //Eğer interface kullanabiliyorsanız inheritance gerek yok bu benim fikrim.
       
        class Person
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }
        //class Person2 //Bir kişinin bir tane babası olur. İnterface kullanımından farkı
        //{               //Bir nesneyi sadece bir kere inheritance alabilirsiniz ama birden fazla implementation yapabilirsiniz.
        //                //İnheritance önce yazılır sonra interfaceler yazılır kaç tane varsa.
        //}
        //class ların tek başına bir anlamı vardır ama interface lerin tek başına bir anlamı yoktur.

        class Customer : Person //Customer ın ebeveyni Person dır. Customer, Person dan dünyaya gelmiş bir nesne.
        {
            public string City { get; set; }
        }
        class Student : Person
        {
            public string Department { get; set; }
        }
    }
}
