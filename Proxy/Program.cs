using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            SchoolGirl yp = new SchoolGirl();
            yp.Name = "YP";

            Proxy JJ = new Proxy(yp);

            JJ.GiveDolls();
            JJ.GiveFlowers();
            JJ.GiveChocolatte();

            Console.Read();
        }
    }
}
