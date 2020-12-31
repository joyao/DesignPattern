using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    abstract class Observer
    {
        protected string name;
        protected Subject sub;

        public Observer(string name, Subject sub)
        {
            this.name = name;
            this.sub = sub;
        }

        public abstract void Update();
    }

    // 看股票的同事
    class StockObserver : Observer
    {
        public StockObserver(string name, Subject sub) : base(name, sub)
        {
        }

        public override void Update()
        {
            Console.WriteLine("{0} {1} 關閉股票行情，繼續工作!", sub.SubjectState, name);
        }
    }

    // 看NBA的同事
    class NBAObserver : Observer
    {
        public NBAObserver(string name, Subject sub) : base(name, sub)
        {
        }

        public override void Update()
        {
            Console.WriteLine("{0} {1} 關閉NBA直播，繼續工作!", sub.SubjectState, name);
        }
    }
}
