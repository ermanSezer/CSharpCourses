using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    internal class Program
    {
        static void Main(string[] args) //İnterface ler ile virtual methodların birleşimi
        {                               //Tamamen inheritance amacyıla kullanılır.
            Database database = new Oracle(); //Abstract class ları new leyemiyoruz. interfaceler gibi
            database.Add();
            database.Delete();

            Database database2 = new SqlServer(); 
            database2.Add();
            database2.Delete();
            Console.ReadLine();
            //Abstract class larda bir inheritance tır.

        }
    }
    abstract class Database
    {
        public void Add() //Ekleme her yerde aynı-Tamamlanmış method
        {
            Console.WriteLine("Added by default");
        }

        public abstract void Delete(); //silme işlemi bütün veri tabanlarında farklı-Tamamlan_mamış Methodlar
        
    }
    class SqlServer : Database
    {
        public override void Delete() //Abstract içi dolu olmayan virtual method
        {                              //Her ortamda farklı olduğu için herkesin onu ayrı ayrı implemente etmesi gerekir. 
            Console.WriteLine("Deleted by Sql");
        }
    }
    class Oracle : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by Oracle");
        }
    }
}
