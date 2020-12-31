using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    abstract class Builder
    {
        public abstract void BuildPartA();
        public abstract void BuildPartB();
        public abstract Product GetResult();
    }

    class ConcreteBuilder1 : Builder
    {
        private Product product = new Product();

        public override void BuildPartA()
        {
            product.Add("零件A");
        }

        public override void BuildPartB()
        {
            product.Add("零件B");
        }

        public override Product GetResult()
        {
            return product;
        }
    }
    class ConcreteBuilder2 : Builder
    {
        private Product product = new Product();

        public override void BuildPartA()
        {
            product.Add("零件X");
        }

        public override void BuildPartB()
        {
            product.Add("零件Y");
        }

        public override Product GetResult()
        {
            return product;
        }
    }
}
