﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NickEventDemo.Iteration2
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductFactory factory1 = new ProductFactory();
            Monitor monitor = new Monitor();


            //註冊方法
            factory1.Created += monitor.ShowMsg;
            factory1.Created += Screen.Display;//靜態方法


            factory1.CreateProduct("PD_001");
            factory1.CreateProduct("PD_002");
            factory1.CreateProduct("PD_003");

            
            Console.ReadKey();
        }
    }
}
