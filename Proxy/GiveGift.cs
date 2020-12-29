using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    interface IGiveGift
    {
        void GiveDolls();
        void GiveFlowers();
        void GiveChocolatte();
    }

    class Pursuit: IGiveGift
    {
        SchoolGirl mm;
        public Pursuit(SchoolGirl mm)
        {
            this.mm = mm;
        }
        public void GiveDolls()
        {
            Console.WriteLine(mm.Name + ", these dolls are for u.");
        }
        public void GiveFlowers()
        {
            Console.WriteLine(mm.Name + ", these flowers are for u.");
        }
        public void GiveChocolatte()
        {
            Console.WriteLine(mm.Name + ", these chocolatte are for u.");
        }
    }

    class Proxy: IGiveGift
    {
        Pursuit gg;
        public Proxy(SchoolGirl mm)
        {
            gg = new Pursuit(mm);
        }
        public void GiveDolls()
        {
            gg.GiveDolls();
        }
        public void GiveFlowers()
        {
            gg.GiveFlowers();
        }
        public void GiveChocolatte()
        {
            gg.GiveChocolatte();
        }
    }
}
