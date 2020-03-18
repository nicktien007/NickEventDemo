using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NickEventDemo.Iteration1
{
    /// <summary>
    /// 顯示器
    /// </summary>
    public class Screen
    {
        /// <summary>
        ///  顯示器 - 顯示
        /// </summary>
        /// <param name="name"></param>
        public static void Display(string name)
            => Console.WriteLine($"Screen.Display => 生產產品:{name}");
    }
}
