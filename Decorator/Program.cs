using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Person jy = new Person("JY");
            Console.WriteLine("\n The first dress：");

            Sneakers sk = new Sneakers();
            BigTrouser bt = new BigTrouser();
            TShirts ts = new TShirts();

            sk.Decorate(jy);
            bt.Decorate(sk);
            ts.Decorate(bt);

            ts.Show();

            Console.WriteLine("\n The second dress：");

            LeatherShoes ls = new LeatherShoes();
            Tie tie = new Tie();
            Suit suit = new Suit();

            ls.Decorate(jy);
            tie.Decorate(ls);
            suit.Decorate(tie);
            suit.Show();

            Console.Read();
        }
    }
}
