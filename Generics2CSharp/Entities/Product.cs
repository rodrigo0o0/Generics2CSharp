﻿using System;
using System.Globalization;

namespace Generics2CSharp.Entities
{
    internal class Product : IComparable
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return Name + " Price : $" + Price.ToString("F2", CultureInfo.InvariantCulture);
        }

        public int CompareTo(object obj)
        {
            if(!(obj is Product))
            {
                throw new ArgumentNullException("This Product is null on CompareTO");
            }
            Product other = obj as Product;
            return Price.CompareTo(other.Price);
        }
    }
}
