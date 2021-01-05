using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    class PlayContext
    {
        // 演奏文字
        private string text;
        public string PlayText
        {
            get { return text; }
            set { text = value; }
        }
    }
}
