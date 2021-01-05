using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    abstract class WebSite
    {
        public abstract void Use(User user);
    }

    class ConcreteWebSite : WebSite
    {
        private string name = "";
        public ConcreteWebSite(string name)
        {
            this.name = name;
        }

        public override void Use(User user)
        {
            Console.WriteLine("網站分類：" + name + " 用戶" + user.Name);
        }
    }
}
