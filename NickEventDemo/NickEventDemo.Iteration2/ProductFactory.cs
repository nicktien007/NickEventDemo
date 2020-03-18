using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NickEventDemo.Iteration2
{
    /// <summary>
    /// 產品工廠
    /// </summary>
    public class ProductFactory
    {
        public string FactoryName { get; set; } = "1號工廠";

        //非泛型，需定義 delegate
        //public delegate void CreatedEventHandler(object sender, CreatedEventArgs e);   //聲明委託
        //public event CreatedEventHandler Created;                                      //聲明事件

        //泛型 EventHandler
        public event EventHandler<CreatedEventArgs> Created;
        
        // 定義CreatedEventArgs類，傳遞給Observer所感興趣的信息
        public class CreatedEventArgs : EventArgs
        {
            public string ProductName { get; }
            public CreatedEventArgs(string name)
            {
                this.ProductName = name;
            }
        }

        /// <summary>
        /// 生產產品
        /// </summary>
        public void CreateProduct(string pdName)
        {
            var pd = new Product(pdName);

            //通知相關單位產品生產完成

            OnCreated(new CreatedEventArgs(pdName));

            Console.WriteLine();
        }

        protected void OnCreated(CreatedEventArgs e)
        {
            Created?.Invoke(this, e);
        }
    }
}
