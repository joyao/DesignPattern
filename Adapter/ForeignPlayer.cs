using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class ForeignCenter
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public void 進攻()
        {
            Console.WriteLine("外籍中鋒 {0} 進攻", name);
        }

        public void 防守()
        {
            Console.WriteLine("外籍中鋒 {0} 防守", name);
        }
    }

    class Translator : Player
    {
        private ForeignCenter foreigncenter = new ForeignCenter();
        public Translator(string name) : base(name)
        {
            foreigncenter.Name = name;
        }
        public override void Attack()
        {
            foreigncenter.進攻();
        }
        public override void Defense()
        {
            foreigncenter.防守();
        }
    }
}
