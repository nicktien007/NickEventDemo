using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NickEventDemo.Iteration1
{
    /// <summary>
    /// 監控裝置
    /// </summary>
    public class Monitor
    {
        /// <summary>
        /// 監控裝置 - 顯示
        /// </summary>
        /// <param name="name"></param>
        public void ShowMsg(string name)
            => Console.WriteLine($"Monitor.ShowMsg => 生產產品:{name}");
    }
}
