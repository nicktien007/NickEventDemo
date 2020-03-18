using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NickEventDemo
{
    /// <summary>
    /// 產品工廠
    /// </summary>
    public class ProductFactory
    {
        public string FactoryName { get; set; } = "1號工廠";

        /// <summary>
        /// 生產產品
        /// </summary>
        public void CreateProduct(string pdName)
        {
            var pd = new Product(pdName);

            //通知相關單位產品生產完成
            Display(pdName);
            ShowMsg(pdName);
            Console.WriteLine();
        }

        /// <summary>
        ///  顯示器 - 顯示
        /// </summary>
        /// <param name="name"></param>
        public void Display(string name)
            => Console.WriteLine($"Display => {FactoryName}生產產品:{name}");

        /// <summary>
        /// 監控裝置 - 顯示
        /// </summary>
        /// <param name="name"></param>
        public void ShowMsg(string name)
            => Console.WriteLine($"ShowMsg => {FactoryName}生產產品:{name}");
    }
}
