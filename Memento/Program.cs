using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            // 大戰Boss前
            GameRole jy = new GameRole();
            jy.GetInitState();
            jy.StateDisplay();

            // 保存進度
            RoleStateCaretaker stateAdmin = new RoleStateCaretaker();
            stateAdmin.Memento = jy.SaveState();

            // 大戰Boss時，損耗嚴重
            jy.Fight();
            jy.StateDisplay();

            // 恢復之前狀態
            jy.RecoveryState(stateAdmin.Memento);
            jy.StateDisplay();

            Console.Read();
        }
    }
}
