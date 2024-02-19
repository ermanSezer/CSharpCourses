using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapDemo2
{
    internal class Program
    {   //İnterface i tercih etmemizin nedeni: Database de loglama ayrı kodlanır. File da loglamanın kodu tamamen farklıdır.
        //Yani kullanan herkesin ayrı ayrı implementasyon yapması gerektiği için interface kullandık.
        //Database ile file kodları aynı olsaydı; sadece sms de değişiyor olsaydı onu virtual yapardık.
        //Abstract içinde geçerli; bir tane operasyonu herkes değiştirecek ama bir tane operasyonun her yerde aynı o zaman abstract.
        //Dip not: 
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(); 
            customerManager.Logger = new DatabaseLogger(); //interface e somutu atadınız. Stratejimizin ne olacağını set ettik.
            customerManager.Add(); //Sonra Add i çağırdık.
            Console.ReadLine();
        }
    }
    class CustomerManager
    {
        //public property ile ILogger türünde bir Logger ürettik.
        public ILogger Logger { get; set; } //interface| Bu property injection ile değil de constructure ile yapılması daha doğru.
        public void Add()
        {
            Logger.Log();
            //DatabaseLogger logger = new DatabaseLogger();
            //logger.Log();
            Console.WriteLine("Customer added!");
        }
    }
    class DatabaseLogger:ILogger //Class ın base i olmalı.-çıplak kod gördün mü tehlikeli
    {
        public void Log()
        {
            Console.WriteLine("Logged!");
        }
    }
    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to file!");
        }
    }
    class SmsLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to sms!");
        }
    }
    interface ILogger 
    {
        void Log();
    }
}
