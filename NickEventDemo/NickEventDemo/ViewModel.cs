using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NickEventDemo
{
    public class ViewModel
    {
        public void Show(object sender, Product.UpdatedEventArgs e)
        {
            Product product = (Product)sender;

            Console.WriteLine("ViewModel=>Id:{0}, Name:{1}: ", product.Id, e.Name);
            Console.WriteLine();
        }
    }
}
