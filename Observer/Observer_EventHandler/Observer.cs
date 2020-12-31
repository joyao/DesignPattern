using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    interface Observer
    {
        void Update();
    }

    // 看股票的同事
    class StockObserver
    {
        private string name;
        private Subject sub;
        public StockObserver(string name, Subject sub)
        {
            this.name = name;
            this.sub = sub;
        }

        public void CloseStockMarket()
        {
            Console.WriteLine("{0} {1} 關閉股票行情，繼續工作!", sub.SubjectState, name);
        }
    }

    // 看NBA的同事
    class NBAObserver
    {
        private string name;
        private Subject sub;
        public NBAObserver(string name, Subject sub)
        {
            this.name = name;
            this.sub = sub;
        }

        public void CloseNBADirectSeeding()
        {
            Console.WriteLine("{0} {1} 關閉NBA直播，繼續工作!", sub.SubjectState, name);
        }
    }
}
