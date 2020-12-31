using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Configuration;

namespace AbstractFactory
{
    class DataAccess
    {
        private static readonly string AssemblyName = "AbstractFactory";
        private static readonly string db = ConfigurationManager.AppSettings["DB"];

        public static IUser CreateUser()
        {
            string className = AssemblyName + "." + db + "User";
            return (IUser)Assembly.Load(AssemblyName).CreateInstance(className);
        }

        public static IDepartment CreateDepartment()
        {
            string className = AssemblyName + "." + db + "Department";
            return (IDepartment)Assembly.Load(AssemblyName).CreateInstance(className);
        }
    }
}
