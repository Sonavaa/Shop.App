﻿
namespace Shop.Core.Models
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }
        public int StockCount { get; set; }
        public Product(string name, double price, string category, int stockCount)
        {
            this.Name = name;
            this.Price = price;
            this.Category = category;
            this.StockCount = stockCount;
        }
        public string GetFullInfo()
        {
          return $"Name: {Name}, Price: {Price}, Category: {Category}, StockCount: {StockCount}";
        }
    }
}
