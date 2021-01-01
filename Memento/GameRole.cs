using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    class GameRole
    {
        // 生命力
        private int vit;
        public int Viltality
        {
            get { return vit; }
            set { vit = value; }
        }

        // 攻擊力
        private int atk;
        public int Attack
        {
            get { return atk; }
            set { atk = value; }
        }

        // 防禦力
        private int def;
        public int Defense
        {
            get { return def; }
            set { def = value; }
        }

        // 狀態顯示
        public void StateDisplay()
        {
            Console.WriteLine("角色當前狀態：");
            Console.WriteLine("體力：{0}", this.vit);
            Console.WriteLine("攻擊力：{0}", this.atk);
            Console.WriteLine("防禦力：{0}", this.def);
            Console.WriteLine("");
        }

        // 獲得初始狀態
        public void GetInitState()
        {
            this.vit = 100;
            this.atk = 100;
            this.def = 100;
        }

        // 戰鬥
        public void Fight()
        {
            this.vit = 0;
            this.atk = 0;
            this.def = 0;
        }

        // 保存角色狀態
        public RoleStateMemento SaveState()
        {
            return (new RoleStateMemento(vit, atk, def));
        }

        // 恢復角色狀態
        public void RecoveryState(RoleStateMemento memento)
        {
            this.vit = memento.Vitality;
            this.atk = memento.Attack;
            this.def = memento.Defense;
        }
    }
}
