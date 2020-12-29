using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Finery : Person
    {
        protected Person component;

        public void Decorate(Person component)
        {
            this.component = component;
        }

        public override void Show()
        {
            if(component != null)
            {
                component.Show();
            }
        }
    }

    class TShirts: Finery
    {
        public override void Show()
        {
            Console.Write("Big T-shirt ");
            base.Show();
        }
    }

    class BigTrouser : Finery
    {
        public override void Show()
        {
            Console.Write("Big Trouser ");
            base.Show();
        }
    }
    class Sneakers : Finery
    {
        public override void Show()
        {
            Console.Write("Old Sneakers ");
            base.Show();
        }
    }
    class Suit : Finery
    {
        public override void Show()
        {
            Console.Write("Suit ");
            base.Show();
        }
    }

    class Tie : Finery
    {
        public override void Show()
        {
            Console.Write("Tie ");
            base.Show();
        }
    }
    class LeatherShoes : Finery
    {
        public override void Show()
        {
            Console.Write("LeatherShoes ");
            base.Show();
        }
    }
}
