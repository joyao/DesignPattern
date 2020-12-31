using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Boss JY = new Boss();

            // 看股票的同事
            StockObserver c1 = new StockObserver("同事1", JY);

            // 看NBA的同事
            NBAObserver c2 = new NBAObserver("同事2", JY);

            JY.Update += new EventHandler(c1.CloseStockMarket);
            JY.Update += new EventHandler(c2.CloseNBADirectSeeding);

            // 老闆回來
            JY.SubjectState = "JY回來了!";
            // 發出通知
            JY.Notify();

            Console.Read();
        }
    }
}
