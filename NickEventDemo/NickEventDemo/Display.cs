using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NickEventDemo
{
    public class Display
    {
        //靜態方法
        public static void ShowMsg(object sender, Product.UpdatedEventArgs e)
        {
            Product product = (Product)sender;

            Console.WriteLine("Display=>Id:{0}, Name:{1}: ", product.Id, e.Name);
            Console.WriteLine();
        }
    }
}
