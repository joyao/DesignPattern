using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            // 開店前的準備
            Barbecuer b = new Barbecuer();
            Command bakeMuttonCommand1 = new BakeMuttonCommand(b);
            Command bakeMuttonCommand2 = new BakeMuttonCommand(b);
            Command bakeChickenWingCommand1 = new BakeChickenWingCommand(b);
            Waiter g = new Waiter();

            // 開門營業 顧客點菜
            g.SetOrder(bakeMuttonCommand1);
            g.SetOrder(bakeMuttonCommand2);
            g.SetOrder(bakeChickenWingCommand1);

            // 點菜完畢，通知廚房
            g.Notify();

            Console.Read();
        }
    }
}
