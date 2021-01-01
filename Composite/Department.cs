using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    // 人力資源部
    class HRDepartment : Company
    {
        public HRDepartment(string name) : base(name) { }

        public override void Add(Company c) { }

        public override void Remove(Company c) { }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + name);
        }

        public override void LineOfDuty()
        {
            Console.WriteLine("{0} 員工朝聘教育訓練管理", name);
        }
    }

    // 財務部
    class FinanceDepartment : Company
    {
        public FinanceDepartment(string name) : base(name) { }

        public override void Add(Company c) { }

        public override void Remove(Company c) { }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + name);
        }

        public override void LineOfDuty()
        {
            Console.WriteLine("{0} 公司財務收支管理", name);
        }
    }
}
