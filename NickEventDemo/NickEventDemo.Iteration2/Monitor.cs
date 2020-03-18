using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NickEventDemo.Iteration2
{
    /// <summary>
    /// 監控裝置
    /// </summary>
    public class Monitor
    {
        /// <summary>
        /// 監控裝置 - 顯示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ShowMsg(object sender, ProductFactory.CreatedEventArgs e)
            => Console.WriteLine($"Monitor.ShowMsg => 工廠:{((ProductFactory)sender).FactoryName}, 生產產品:{e.ProductName}");
    }
}
