using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            IFactory factory = new UndergraduateFactory();
            Nightingale student = factory.CreateNightingale();

            student.BuyRice();
            student.Sweep();
            student.Wash();

            Console.Read();
        }
    }
}
