using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    abstract class HandsetSoft
    {
        public abstract void Run();
    }

    // 手機遊戲
    class HandsetGame : HandsetSoft
    {
        public override void Run()
        {
            Console.WriteLine("執行手機遊戲");
        }
    }

    // 手機通訊錄
    class HandsetAddressList : HandsetSoft
    {
        public override void Run()
        {
            Console.WriteLine("執行手機通訊錄");
        }
    }
}
