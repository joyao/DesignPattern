using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Operation oper;
            oper = OperationFactory.createOperation("+");
            oper.numberA = 1;
            oper.numberB = 5;
            double result = oper.GetResult();
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
