using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class User
    {
        private int _id;
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
    }

    interface IUser
    {
        void Insert(User user);
        User GetUser(int id);
    }

    class SqlserverUser : IUser
    {
        public void Insert(User user)
        {
            Console.WriteLine("在SQL Server中給User表增加一條紀錄");
        }

        public User GetUser(int id)
        {
            Console.WriteLine("在SQL Server中根據ID得到User表一條紀錄");
            return null;
        }
    }
    class AccessUser : IUser
    {
        public void Insert(User user)
        {
            Console.WriteLine("在Access中給User表增加一條紀錄");
        }

        public User GetUser(int id)
        {
            Console.WriteLine("在Access中根據ID得到User表一條紀錄");
            return null;
        }
    }
}
