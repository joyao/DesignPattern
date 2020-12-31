using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    interface Subject
    {
        void Notify();
        string SubjectState
        {
            get;
            set;
        }
    }

    delegate void EventHandler();
    class Boss : Subject
    {
        public event EventHandler Update;
        private string action;

        // 通知
        public void Notify()
        {
            Update();
        }

        // 老闆狀態
        public string SubjectState
        {
            get { return action; }
            set { action = value; }
        }
    }
}
