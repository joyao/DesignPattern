using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    interface IFactory
    {
        Nightingale CreateNightingale();
    }

    class UndergraduateFactory: IFactory
    {
        public Nightingale CreateNightingale()
        {
            return new Undergraduate();
        }
    }

    class VolunteerFactory : IFactory
    {
        public Nightingale CreateNightingale()
        {
            return new Volunteer();
        }
    }
}
