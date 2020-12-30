using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Resume a = new Resume("JY");
            a.SetPersonalInfo("Female", "24");
            a.SetWorkExperience("2012-2016", "NCCU");

            Resume b = (Resume)a.Clone();
            b.SetWorkExperience("2016-2018", "NTU");

            Resume c = (Resume)a.Clone();
            c.SetPersonalInfo("Female", "26");
            c.SetWorkExperience("2016-2018", "NTU");

            a.Display();
            b.Display();
            c.Display();

            Console.Read();
        }
    }
}
