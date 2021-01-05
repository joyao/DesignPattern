using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    abstract class Action
    {
        // 得到男人結論或反應
        public abstract void GetManConclusion(Man concreteElementA);
        // 得到女人結論或反應
        public abstract void GetWomanConclusion(Woman concreteElementB);
    }

    // 成功
    class Success : Action
    {
        public override void GetManConclusion(Man concreteElementA)
        {
            Console.WriteLine("{0}{1}時，背後多半有一個偉大的女人。", concreteElementA.GetType().Name, this.GetType().Name);
        }

        public override void GetWomanConclusion(Woman concreteElementB)
        {
            Console.WriteLine("{0}{1}時，背後大多有一個不成功的男人。", concreteElementB.GetType().Name, this.GetType().Name);
        }
    }

    // 失敗
    class Failing : Action
    {
        public override void GetManConclusion(Man concreteElementA)
        {
            Console.WriteLine("{0}{1}時，悶頭喝酒，誰也不用勸。", concreteElementA.GetType().Name, this.GetType().Name);
        }

        public override void GetWomanConclusion(Woman concreteElementB)
        {
            Console.WriteLine("{0}{1}時，淚眼汪汪，誰也勸不了。", concreteElementB.GetType().Name, this.GetType().Name);
        }
    }

    // 戀愛
    class Amativeness : Action
    {
        public override void GetManConclusion(Man concreteElementA)
        {
            Console.WriteLine("{0}{1}時，凡是不懂也要裝懂。", concreteElementA.GetType().Name, this.GetType().Name);
        }

        public override void GetWomanConclusion(Woman concreteElementB)
        {
            Console.WriteLine("{0}{1}時，遇事懂也裝作不懂。", concreteElementB.GetType().Name, this.GetType().Name);
        }
    }

    // 結婚
    class Marriage : Action
    {
        public override void GetManConclusion(Man concreteElementA)
        {
            Console.WriteLine("{0}{1}時，感慨道：戀愛遊戲終結時，'有妻徒刑' 遙無期。", concreteElementA.GetType().Name, this.GetType().Name);
        }

        public override void GetWomanConclusion(Woman concreteElementB)
        {
            Console.WriteLine("{0}{1}時，欣慰曰：愛情長跑路漫漫，婚姻保險保平安。", concreteElementB.GetType().Name, this.GetType().Name);
        }
    }
}
