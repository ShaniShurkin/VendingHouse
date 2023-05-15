﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingHouse
{
    internal abstract class Product : Iedible
    {
        public string Name { get; set; }
        public int Amount { get; set; }
        public static int MinAmount { get; set; }
        public Supplier Supplier { get; set; }
        public double Price { get; set; }
        protected Product _Product { get; set; }
 

        public Product(string name, int amount, double price)
        {
            this.Name = name;
            this.Amount = amount;
            this.Price = price;
        }

        public Product(Product product):this(product.Name, product.Amount, product.Price)
        {
            
            _Product = product;
        }

        public abstract string GetProduct();

    }
}
