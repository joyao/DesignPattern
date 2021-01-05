using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            WebSiteFactory f = new WebSiteFactory();

            WebSite fx = f.GetWebSiteCategory("產品展示");
            fx.Use(new User("p1"));

            WebSite fy = f.GetWebSiteCategory("產品展示");
            fy.Use(new User("p2"));

            WebSite fz = f.GetWebSiteCategory("產品展示");
            fz.Use(new User("p3"));

            WebSite fl = f.GetWebSiteCategory("部落格");
            fl.Use(new User("p4"));

            WebSite fm = f.GetWebSiteCategory("部落格");
            fm.Use(new User("p5"));

            WebSite fn = f.GetWebSiteCategory("部落格");
            fn.Use(new User("p6"));

            Console.WriteLine("得到網站分類總數為 {0}", f.GetWebSiteCount());

            Console.Read();
        }
    }
}
