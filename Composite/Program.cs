using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteCompany root = new ConcreteCompany("總公司");
            root.Add(new HRDepartment("總公司人力資源部"));
            root.Add(new FinanceDepartment("總公司財務部"));

            ConcreteCompany comp = new ConcreteCompany("分公司");
            comp.Add(new HRDepartment("分公司人力資源部"));
            comp.Add(new FinanceDepartment("分公司財務部"));
            root.Add(comp);

            ConcreteCompany comp2 = new ConcreteCompany("辦事處1");
            comp2.Add(new HRDepartment("辦事處1人力資源部"));
            comp2.Add(new FinanceDepartment("辦事處1財務部"));
            comp.Add(comp2);

            ConcreteCompany comp3 = new ConcreteCompany("辦事處2");
            comp3.Add(new HRDepartment("辦事處2人力資源部"));
            comp3.Add(new FinanceDepartment("辦事處2財務部"));
            comp.Add(comp3);

            Console.WriteLine("\n 結構圖：");
            root.Display(1);

            Console.WriteLine("\n 職責：");
            root.LineOfDuty();

            Console.Read();
        }
    }
}
