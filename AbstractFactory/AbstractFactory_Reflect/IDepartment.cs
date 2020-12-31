using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Department
    {
        private int _id;
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _deptName;
        public string DeptName
        {
            get { return _deptName; }
        }
    }

    interface IDepartment
    {
        void Insert(Department department);
        Department GetDepartment(int id);
    }

    class SqlserverDepartment : IDepartment
    {
        public void Insert(Department department)
        {
            Console.WriteLine("在SQL Server中給Department表增加一條紀錄");
        }
        public Department GetDepartment(int id)
        {
            Console.WriteLine("在SQL Server中根據ID得到Department表一條紀錄");
            return null;
        }
    }

    class AccessDepartment : IDepartment
    {
        public void Insert(Department department)
        {
            Console.WriteLine("在Access中給Department表增加一條紀錄");
        }
        public Department GetDepartment(int id)
        {
            Console.WriteLine("在Access中根據ID得到Department表一條紀錄");
            return null;
        }
    }
}
