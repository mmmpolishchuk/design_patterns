using System;
using Abstract_Factory.Bakeries;

namespace Abstract_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Traditional bakery: ");
            ClientCode(new Bakery(), Console.WriteLine);
            
            Console.WriteLine();

            Console.WriteLine("Healthy bakery: ");
            ClientCode(new HealthyBakery(), Console.WriteLine);
        }

        static void ClientCode(IBakery bakery, Action<string> result)
        {
            var bread = bakery.ProductBread();
            var cake = bakery.ProductCake();

            result(bread.Make());
            result(cake.Make());
        }
    }
}