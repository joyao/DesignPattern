using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    // 抽象命令
    public abstract class Command
    {
        protected Barbecuer receiver;

        public Command(Barbecuer receiver)
        {
            this.receiver = receiver;
        }

        // 執行命令
        abstract public void ExcuteCommand();
    }

    // 烤羊肉串命令
    class BakeMuttonCommand : Command
    {
        public BakeMuttonCommand(Barbecuer receiver) : base(receiver) { }

        public override void ExcuteCommand()
        {
            receiver.BakeMutton();
        }
    }

    // 烤雞翅命令
    class BakeChickenWingCommand : Command
    {
        public BakeChickenWingCommand(Barbecuer receiver) : base(receiver) { }

        public override void ExcuteCommand()
        {
            receiver.BakeChickenWing();
        }
    }
}
