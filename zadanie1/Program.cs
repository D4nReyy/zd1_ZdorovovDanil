using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie1
{
    class Program
    {
        static void Main (string[] args)
        {
            Cat murzik = new Cat("Мурзик");
            Cat barsik = new Cat("Барсик");
            murzik.Meow();
            barsik.Meow();
            barsik.Name = "Барсик";
            barsik.Meow();
            barsik.Name = "1234";
            barsik.Meow();
            barsik.Ves = 1;
            murzik.Ves = 5.0;
            barsik.Kot();
            murzik.Kot();
            Console.ReadKey();
        }
    }
}
