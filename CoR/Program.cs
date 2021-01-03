using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoR
{
    class Program
    {
        static void Main(string[] args)
        {
            CommonManager cm = new CommonManager("CM");
            Majordomo md = new Majordomo("MD");
            GeneralManager gm = new GeneralManager("GM");

            cm.SetSuperior(md);
            md.SetSuperior(gm);

            Request request = new Request();
            request.RequestType = "請假";
            request.RequestContent = "JY請假";
            request.Number = 1;
            cm.RequestApplications(request);

            Request request2 = new Request();
            request2.RequestType = "請假";
            request2.RequestContent = "JY請假";
            request2.Number = 4;
            cm.RequestApplications(request2);

            Request request3 = new Request();
            request3.RequestType = "加薪";
            request3.RequestContent = "JY請求加薪";
            request3.Number = 500;
            cm.RequestApplications(request3);

            Request request4 = new Request();
            request4.RequestType = "加薪";
            request4.RequestContent = "JY請求加薪";
            request4.Number = 1000;
            cm.RequestApplications(request4);

            Console.Read();
        }
    }
}
