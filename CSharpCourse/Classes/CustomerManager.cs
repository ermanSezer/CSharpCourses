using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class CustomerManager //Bir class ve içinde iki tane method oluşturduk. CRUD(Create Read Update Delete)
    {                       //Manager--> katmanli mimaride is kodlarina karsilik gelir.
        public void Add()
        {
            Console.WriteLine("Customer Added!");
        }
        public void Update()
        {
            Console.WriteLine("Customer Updated!");
        }
    }
}
