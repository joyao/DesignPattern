using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Stock1
    {
        public void Sell()
        {
            Console.WriteLine("Stock1 sold.");
        }

        public void Buy()
        {
            Console.WriteLine("Buy Stock1.");
        }
    }

    class Stock2
    {
        public void Sell()
        {
            Console.WriteLine("Stock2 sold.");
        }

        public void Buy()
        {
            Console.WriteLine("Buy Stock2.");
        }
    }

    class Stock3
    {
        public void Sell()
        {
            Console.WriteLine("Stock3 sold.");
        }

        public void Buy()
        {
            Console.WriteLine("Buy Stock3.");
        }
    }

    class NationalDebt1
    {
        public void Sell()
        {
            Console.WriteLine("NationalDebt1 sold.");
        }

        public void Buy()
        {
            Console.WriteLine("Buy NationalDebt1.");
        }
    }

    class Realty1
    {
        public void Sell()
        {
            Console.WriteLine("Realty1 sold.");
        }

        public void Buy()
        {
            Console.WriteLine("Buy Realty1.");
        }
    }
}
