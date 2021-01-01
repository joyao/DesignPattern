using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteAggregate a = new ConcreteAggregate();

            a[0] = "p1";
            a[1] = "p2";
            a[2] = "p3";
            a[3] = "p4";
            a[4] = "p5";
            a[5] = "p6";

            Iterator i = new ConcreteIterator(a);
            object item = i.First();
            while (!i.IsDone())
            {
                Console.WriteLine("{0} 請買車票!", i.CurrentItem());
                i.Next();
            }

            Console.Read();

            //IList<string> a = new List<string>();
            //a.Add("p1");
            //a.Add("p2");
            //a.Add("p3");
            //a.Add("p4");
            //a.Add("p5");
            //a.Add("p6");

            //foreach (string item in a)
            //{
            //    Console.WriteLine("{0} 請買車票!", item);
            //}

            //Console.Read();
        }
    }
}
