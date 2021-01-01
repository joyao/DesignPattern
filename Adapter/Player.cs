using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    abstract class Player
    {
        protected string name;
        public Player(string name)
        {
            this.name = name;
        }

        public abstract void Attack();
        public abstract void Defense();
    }

    // 前鋒
    class Forwards : Player
    {
        public Forwards(string name) : base(name) { }
        public override void Attack()
        {
            Console.WriteLine("前鋒 {0} 進攻", name);
        }

        public override void Defense()
        {
            Console.WriteLine("前鋒 {0} 防守", name);
        }
    }

    // 中鋒
    class Center : Player
    {
        public Center(string name) : base(name) { }
        public override void Attack()
        {
            Console.WriteLine("中鋒 {0} 進攻", name);
        }

        public override void Defense()
        {
            Console.WriteLine("中鋒 {0} 防守", name);
        }
    }

    // 後衛
    class Guards : Player
    {
        public Guards(string name) : base(name) { }
        public override void Attack()
        {
            Console.WriteLine("後衛 {0} 進攻", name);
        }

        public override void Defense()
        {
            Console.WriteLine("後衛 {0} 防守", name);
        }
    }
}
