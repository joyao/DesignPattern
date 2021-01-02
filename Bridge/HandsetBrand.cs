using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    abstract class HandsetBrand
    {
        protected HandsetSoft soft;

        // 設定手機軟體
        public void SetHandsetSoft(HandsetSoft soft)
        {
            this.soft = soft;
        }
        // 執行
        public abstract void Run();
    }

    // 手機品牌N
    class HandsetBrandN : HandsetBrand
    {
        public override void Run()
        {
            soft.Run();
        }
    }

    // 手機品牌M
    class HandsetBrandM : HandsetBrand
    {
        public override void Run()
        {
            soft.Run();
        }
    }
}
