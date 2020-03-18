using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NickEventDemo.Iteration1
{
    /// <summary>
    /// 產品工廠
    /// </summary>
    public class ProductFactory
    {
        public string FactoryName { get; set; } = "1號工廠";

        public delegate void CreateHandler(string name);   //聲明委託
        public event CreateHandler CreateEvent;            //聲明事件

        /// <summary>
        /// 生產產品
        /// </summary>
        public void CreateProduct(string pdName)
        {
            var pd = new Product(pdName);

            //通知相關單位產品生產完成
            CreateEvent?.Invoke(pdName);

            Console.WriteLine();
        }
    }
}
