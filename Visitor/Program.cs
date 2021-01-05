using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            ObjectStructure o = new ObjectStructure();
            o.Attach(new Man());
            o.Attach(new Woman());

            // 成功時的反應
            Success v1 = new Success();
            o.Display(v1);

            // 失敗時的反應
            Failing v2 = new Failing();
            o.Display(v2);

            // 戀愛時的反應
            Amativeness v3 = new Amativeness();
            o.Display(v3);

            // 結婚時的反應
            Marriage v4 = new Marriage();
            o.Display(v4);

            Console.Read();
        }
    }
}
