using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    class Operation
    {
        private double _numberA = 0;
        private double _numberB = 0;

        public double numberA
        {
            get { return _numberA; }
            set { _numberA = value; }
        }
        public double numberB
        {
            get { return _numberB; }
            set { _numberB = value; }
        }

        public virtual double GetResult()
        {
            double result = 0;
            return result;
        }
    }

    class OperationAdd: Operation
    {
        public override double GetResult()
        {
            double result = 0;
            result = numberA + numberB;
            return result;
        }
    }

    class OperationSub : Operation
    {
        public override double GetResult()
        {
            double result = 0;
            result = numberA - numberB;
            return result;
        }
    }

    class OperationMul : Operation
    {
        public override double GetResult()
        {
            double result = 0;
            result = numberA * numberB;
            return result;
        }
    }

    class OperationDiv : Operation
    {
        public override double GetResult()
        {
            double result = 0;
            if (numberB == 0)
            {
                throw new Exception("除數不能為0。");
            }
            result = numberA / numberB;
            return result;
        }
    }
}
