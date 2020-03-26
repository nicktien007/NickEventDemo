using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NickEventDemo.Iteration2
{
    /// <summary>
    /// 顯示器
    /// </summary>
    public class Screen
    {
        public static Random Rm = new Random(DateTime.Now.Millisecond);

        /// <summary>
        /// 顯示器 - 顯示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void Display(object sender, ProductFactory.CreatedEventArgs e)
        {
            var foo = Rm.Next(500, 2000);
            var threadId = Thread.CurrentThread.ManagedThreadId;

            Console.WriteLine($"Screen.ThreadId:{threadId},Sleep {foo}");
            Thread.Sleep(Rm.Next(500, 2000));

            Console.WriteLine(
                $"Screen.Display =>ThreadId:{Thread.CurrentThread.ManagedThreadId}, 工廠:{((ProductFactory) sender).FactoryName}, 生產產品:{e.ProductName}");
        }
    }
}
