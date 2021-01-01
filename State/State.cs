using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public abstract class State
    {
        public abstract void WriteProgram(Work w);
    }

    public class ForenoonState : State
    {
        public override void WriteProgram(Work w)
        {
            if (w.Hour < 12)
            {
                Console.WriteLine("當前時間：{0}點，上午工作，精神百倍。", w.Hour);
            }
            else
            {
                w.SetState(new NoonState());
                w.WriteProgram();
            }
        }
    }

    public class NoonState : State
    {
        public override void WriteProgram(Work w)
        {
            if (w.Hour < 13)
            {
                Console.WriteLine("當前時間：{0}點，餓了，午飯；覺得睏，午休。", w.Hour);
            }
            else
            {
                w.SetState(new AfternoonState());
                w.WriteProgram();
            }
        }
    }

    public class AfternoonState : State
    {
        public override void WriteProgram(Work w)
        {
            if (w.Hour < 17)
            {
                Console.WriteLine("當前時間：{0}點，下午狀態還不錯，繼續努力。", w.Hour);
            }
            else
            {
                w.SetState(new EveningState());
                w.WriteProgram();
            }
        }
    }

    public class EveningState : State
    {
        public override void WriteProgram(Work w)
        {
            if (w.Hour < 21)
            {
                Console.WriteLine("當前時間：{0}點，加班喔，疲累至極。", w.Hour);
            }
            else
            {
                w.SetState(new SleepingState());
                w.WriteProgram();
            }
        }
    }

    public class SleepingState : State
    {
        public override void WriteProgram(Work w)
        {
            Console.WriteLine("當前時間：{0}點，不行了，睡著了。", w.Hour);
        }
    }

    public class RestState : State
    {
        public override void WriteProgram(Work w)
        {
            Console.WriteLine("當前時間：{0}點，下班回家了。", w.Hour);
        }
    }
}
