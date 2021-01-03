using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoR
{
    class Request
    {
        // 申請類別
        private string requestType;
        public string RequestType
        {
            get { return requestType; }
            set { requestType = value; }
        }

        // 申請內容
        private string requestContent;
        public string RequestContent
        {
            get { return requestContent; }
            set { requestContent = value; }
        }

        // 數量
        private int number;
        public int Number
        {
            get { return number; }
            set { number = value; }
        }
    }
}
