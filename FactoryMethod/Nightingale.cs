using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Nightingale
    {
        public void Sweep()
        {
            Console.WriteLine("sweep");
        }
        
        public void Wash()
        {
            Console.WriteLine("wash");
        }

        public void BuyRice()
        {
            Console.WriteLine("buy rice");
        }
    }

    class Undergraduate : Nightingale
    {

    }
    class Volunteer : Nightingale
    {

    }
}
