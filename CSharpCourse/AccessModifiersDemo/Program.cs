using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccessModifiers; //Başka bir projedeki sınıfı kullanmak istiyorsanız. 

namespace AccessModifiersDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Course course = new Course();
        }
    }
    //private sadece tanımladığı blokta geçerli.
    //protected private gibi kullanılıyor. İnheritance olan yerde de kullanılabilir.
    //İnternal sadece mevcut Assembly-projede kullanılabiliyor.
    //public ise referans verildiği zaman başka projelerde de kullanılabilir. Erişim kısıtı yok.
    //List privilege gibi bir şey-Yetki yükseltme
    //Bir şeyin neye ihtiyacı varsa minimumda o minimum tanımlanmalı daha fazlasına ihtiyacın olursa bir üst seviyeye çıkarırsın.
}
