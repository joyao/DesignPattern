using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    interface Subject
    {
        void Attach(Observer observer);
        void Detach(Observer observer);
        void Notify();
        string SubjectState
        {
            get;
            set;
        }
    }

    class Boss : Subject
    {
        // 同事列表
        private IList<Observer> observers = new List<Observer>();
        private string action;

        // 增加
        public void Attach(Observer observer)
        {
            observers.Add(observer);
        }

        // 減少
        public void Detach(Observer observer)
        {
            observers.Remove(observer);
        }

        // 通知
        public void Notify()
        {
            foreach (Observer o in observers)
            {
                o.Update();
            }
        }

        // 老闆狀態
        public string SubjectState
        {
            get { return action; }
            set { action = value; }
        }
    }
}
