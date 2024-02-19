using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethods
{
    internal class Program
    {    //|Virtual Methodlar|
        static void Main(string[] args)
        {
            SqlServer sqlServer = new SqlServer();
            sqlServer.Add();
            MySql mySql = new MySql();
            mySql.Add();
            Console.ReadLine();
        }
    }
    class Database
    {
        public virtual void Add()
        {
            Console.WriteLine("Added by default!");
        }
        public virtual void Delete()
        {
            Console.WriteLine("Deleted by default!");
        }
    }
    class SqlServer:Database //SqlServer için Database in Add ini ve Delete ini kullanabiliriz.
    {
        public override void Add() //override boşluk yap!
        {
            Console.WriteLine("Added by Sql Code"); //Genel bir operasyon-Ezmek!
            //base.Add();
        }
    }

    class MySql:Database
    {

    }
}
