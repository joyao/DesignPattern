using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            double total = 0.0d;
            Console.WriteLine("請輸入單價：");
            string price = Console.ReadLine();
            Console.WriteLine("請輸入數量：");
            string num = Console.ReadLine();
            Console.WriteLine("請輸入計算方式(正常收費、滿300送100、打8折)：");
            string type = Console.ReadLine();

            // SimpleFactory
            // CashSuper csuper = CashFactory.createCashAccept(type.ToString());

            // Strategy + SimpleFactory
            CashContext csuper = new CashContext(type.ToString());

            double totalPrices = 0d;
            totalPrices = csuper.GetResult(Convert.ToDouble(price) * Convert.ToDouble(num));
            total = total + totalPrices;
            Console.WriteLine("單價：" + price + " 數量：" + num + " " + type + " 合計：" + totalPrices.ToString());
            Console.ReadLine();
        }
    }
}
