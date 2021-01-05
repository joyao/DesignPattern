using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    // 國家
    abstract class Country
    {
        protected UnitedNations mediator;
        public Country(UnitedNations mediator)
        {
            this.mediator = mediator;
        }
    }

    class USA : Country
    {
        public USA(UnitedNations mediator) : base(mediator) { }

        // 宣告
        public void Declare(string message)
        {
            mediator.Declare(message, this);
        }

        // 獲得消息
        public void GetMessage(string message)
        {
            Console.WriteLine("美國獲得對方資訊：" + message);
        }
    }

    // 伊拉克
    class Iraq : Country
    {
        public Iraq(UnitedNations mediator) : base(mediator) { }

        // 宣告
        public void Declare(string message)
        {
            mediator.Declare(message, this);
        }

        // 獲得消息
        public void GetMessage(string message)
        {
            Console.WriteLine("伊拉克獲得對方資訊：" + message);
        }
    }
}
