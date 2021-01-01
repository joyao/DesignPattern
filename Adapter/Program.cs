using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Player p1 = new Forwards("P1");
            p1.Attack();

            Player p2 = new Guards("P2");
            p2.Attack();

            Player fp1 = new Translator("FP1");
            fp1.Attack();
            fp1.Defense();

            Console.Read();
        }
    }
}
