using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class SimpleFactory
    {
        public static Nightingale CreateNightingale(string type)
        {
            Nightingale result = null;
            switch (type)
            {
                case "undergraduate":
                    result = new Undergraduate();
                    break;
                case "volunteer":
                    result = new Volunteer();
                    break;
            }
            return result;
        }
    }
}
