using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NickEventDemo.Iteration2
{
    /// <summary>
    /// 顯示器
    /// </summary>
    public class Screen
    {
        /// <summary>
        /// 顯示器 - 顯示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void Display(object sender, ProductFactory.CreatedEventArgs e)
            => Console.WriteLine($"Screen.Display => 工廠:{((ProductFactory)sender).FactoryName}, 生產產品:{e.ProductName}");
    }
}
