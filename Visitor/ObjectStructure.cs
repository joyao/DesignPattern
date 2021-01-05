using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    class ObjectStructure
    {
        private IList<Person> elements = new List<Person>();

        // 增加
        public void Attach(Person element)
        {
            elements.Add(element);
        }

        // 移除
        public void Dettach(Person element)
        {
            elements.Remove(element);
        }

        // 查看顯示
        public void Display(Action visitor)
        {
            foreach (Person e in elements)
            {
                e.Accept(visitor);
            }
        }
    }
}
