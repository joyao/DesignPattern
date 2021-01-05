using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    abstract class Person
    {
        public abstract void Accept(Action visitor);
    }

    class Man : Person
    {
        public override void Accept(Action visitor)
        {
            visitor.GetManConclusion(this);
        }
    }

    class Woman : Person
    {
        public override void Accept(Action visitor)
        {
            visitor.GetWomanConclusion(this);
        }
    }
}
