using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P110_ConsoleDemo
{
    public abstract class ReadableItem
    {
        public string Name { get; set; }
        public string ISBN { get; set; }
        public string Genre { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }
        public int Count { get; set; }
        public bool HasDiscount { get; set; }
        public float DiscountPercent { get; set; }
        public decimal ActualPrice {
            get
            {
                return HasDiscount ? Price * (decimal)(1 - DiscountPercent) : Price;
            }
        }

        public override string ToString()
        {
            return $"ISBN: {ISBN}; Name: {Name}; Genre: {Genre}; Author: {Author}";
        }
    }

}
