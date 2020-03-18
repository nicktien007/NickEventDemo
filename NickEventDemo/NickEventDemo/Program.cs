using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NickEventDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var product = new Product(1, "Pd_99");
            var vw = new ViewModel();

            //註冊方法
            product.Updated += Display.ShowMsg;
            product.Updated += vw.Show;

            //也可註冊一個lambda 方法
            product.Updated += (sender, e) =>
            {
                Console.WriteLine($"Lambda =>Id:{((Product)sender).Id}, Name:{e.Name}\n");
            };

            for (int i = 0; i < 10; i++)
            {
                //模擬資料更新，會自動調用註冊過對象的方法
                product.Update($"Pd_{i}");
            }
        }
    }
}
