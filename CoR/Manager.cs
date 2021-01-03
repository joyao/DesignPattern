using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoR
{
    abstract class Manager
    {
        protected string name;

        // 管理者的上級
        protected Manager superior;

        public Manager(string name)
        {
            this.name = name;
        }

        // 設定管理者的上級
        public void SetSuperior(Manager superior)
        {
            this.superior = superior;
        }

        // 申請請求
        abstract public void RequestApplications(Request request);
    }

    // 經理
    class CommonManager : Manager
    {
        public CommonManager(string name) : base(name) { }
        public override void RequestApplications(Request request)
        {
            if (request.RequestType == "請假" && request.Number <= 2)
            {
                Console.WriteLine("{0}:{1} 數量{2} 被批准", name, request.RequestContent, request.Number);
            }
            else
            {
                if (superior != null)
                {
                    superior.RequestApplications(request);
                }
            }
        }
    }

    // 總監
    class Majordomo : Manager
    {
        public Majordomo(string name) : base(name) { }
        public override void RequestApplications(Request request)
        {
            if (request.RequestType == "請假" && request.Number <= 5)
            {
                Console.WriteLine("{0}:{1} 數量{2} 被批准", name, request.RequestContent, request.Number);
            }
            else
            {
                if (superior != null)
                {
                    superior.RequestApplications(request);
                }
            }
        }
    }

    // 總經理
    class GeneralManager : Manager
    {
        public GeneralManager(string name) : base(name) { }
        public override void RequestApplications(Request request)
        {
            if (request.RequestType == "請假")
            {
                Console.WriteLine("{0}:{1} 數量{2} 被批准", name, request.RequestContent, request.Number);
            }
            else if (request.RequestType == "加薪" && request.Number <= 500)
            {
                Console.WriteLine("{0}:{1} 數量{2} 被批准", name, request.RequestContent, request.Number);
            }
            else if (request.RequestType == "加薪" && request.Number > 500)
            {
                Console.WriteLine("{0}:{1} 數量{2} 再說吧", name, request.RequestContent, request.Number);
            }
        }
    }
}
