using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Fund
    {
        Stock1 st1;
        Stock2 st2;
        Stock3 st3;

        NationalDebt1 nd1;
        Realty1 rt1;

        public Fund()
        {
            st1 = new Stock1();
            st2 = new Stock2();
            st3 = new Stock3();
            nd1 = new NationalDebt1();
            rt1 = new Realty1();
        }
        public void BuyFund()
        {
            st1.Buy();
            st2.Buy();
            st3.Buy();
            nd1.Buy();
            rt1.Buy();
        }

        public void SellFund()
        {
            st1.Sell();
            st2.Sell();
            st3.Sell();
            nd1.Sell();
            rt1.Sell();
        }
    }
}
