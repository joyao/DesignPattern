using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    // 聯合國機構
    abstract class UnitedNations
    {
        // 宣告
        public abstract void Declare(string message, Country colleague);
    }

    class UnitedNationsSecurityCouncil : UnitedNations
    {
        private USA colleague1;
        private Iraq colleague2;

        // 美國
        public USA Colleague1
        {
            set { colleague1 = value; }
        }

        // 伊拉克
        public Iraq Colleague2
        {
            set { colleague2 = value; }
        }

        // 宣告
        public override void Declare(string message, Country colleague)
        {
            if (colleague == colleague1)
            {
                colleague2.GetMessage(message);
            }
            else
            {
                colleague1.GetMessage(message);
            }
        }
    }
}
