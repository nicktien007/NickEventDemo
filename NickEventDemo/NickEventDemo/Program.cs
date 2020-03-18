namespace NickEventDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductFactory factory1 = new ProductFactory();

            factory1.CreateProduct("PD_001");
            factory1.CreateProduct("PD_002");
            factory1.CreateProduct("PD_003");
        }
    }
}
