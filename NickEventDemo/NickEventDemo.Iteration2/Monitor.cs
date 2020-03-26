using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NickEventDemo.Iteration2
{
    /// <summary>
    /// 監控裝置
    /// </summary>
    public class Monitor
    {
        public static Random Rm = new Random(DateTime.Now.Millisecond);
        /// <summary>
        /// 監控裝置 - 顯示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ShowMsg(object sender, ProductFactory.CreatedEventArgs e)
        {
            var foo = Rm.Next(500, 2000);
            var threadId = Thread.CurrentThread.ManagedThreadId;

            Console.WriteLine($"Monitor.ThreadId:{threadId},Sleep {foo}");
            Thread.Sleep(Rm.Next(500, 2000));

            Console.WriteLine($"Monitor.ShowMsg =>ThreadId:{threadId}, 工廠:{((ProductFactory)sender).FactoryName}, 生產產品:{e.ProductName}");

        }
    }
}
