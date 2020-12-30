using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class TestPaper
    {
        public void TestQuestion1()
        {
            Console.WriteLine("Q1. ");
            Console.WriteLine("Answer：" + Answer1());
        }
        public void TestQuestion2()
        {
            Console.WriteLine("Q2. ");
            Console.WriteLine("Answer：" + Answer2());
        }
        public void TestQuestion3()
        {
            Console.WriteLine("Q3. ");
            Console.WriteLine("Answer：" + Answer3());
        }


        protected virtual string Answer1()
        {
            return "";
        }
        protected virtual string Answer2()
        {
            return "";
        }
        protected virtual string Answer3()
        {
            return "";
        }
    }

    class TestPaperA: TestPaper
    {
        protected override string Answer1()
        {
            return "b";
        }
        protected override string Answer2()
        {
            return "c";
        }
        protected override string Answer3()
        {
            return "a";
        }
    }

    class TestPaperB : TestPaper
    {
        protected override string Answer1()
        {
            return "c";
        }
        protected override string Answer2()
        {
            return "a";
        }
        protected override string Answer3()
        {
            return "a";
        }
    }
}
