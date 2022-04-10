using Generics2CSharp.Entities;
using Generics2CSharp.Services;
using System;
using System.Collections.Generic;
using System.Globalization;


namespace Generics2CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                string [] vect = Console.ReadLine().Split(',');
                string name = vect[0];
                double price = double.Parse(vect[1], CultureInfo.InvariantCulture);
                products.Add(new Product(name, price));

            }
            CalculationService cs = new CalculationService();

            Console.Write("Max : ");
            Product p = cs.Max(products); // <Product> is optional
            Console.Write(p);
            Console.ReadKey();
        }
    }
}
