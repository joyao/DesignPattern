using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    class RoleStateMemento
    {
        private int vit;
        private int atk;
        private int def;
        public RoleStateMemento(int vit, int atk, int def)
        {
            this.vit = vit;
            this.atk = atk;
            this.def = def;
        }

        // 生命力
        public int Vitality
        {
            get { return vit; }
            set { vit = value; }
        }

        // 攻擊力
        public int Attack
        {
            get { return atk; }
            set { atk = value; }
        }

        // 防禦力
        public int Defense
        {
            get { return def; }
            set { def = value; }
        }
    }
}
