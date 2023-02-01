using Retail.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retail.Domain
{
    public class Product
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public bool ForSale { get; set; }

        public Product(string name, string description, int stock, decimal price, bool forSale, int? id = null)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Description = description ?? string.Empty;
            Stock = stock;
            Price = price;
            ForSale = forSale;
            Id = id;
        }

        public void AddStock(int amount)
        {
            if ( amount == 0) { return; }
            if (amount < 0) { throw new NegativeValueException(amount); }
            Stock += amount;
        }

        public void RemoveStock(int amount)
        {
            if (amount == 0) { return; }
            if (amount < 0) { throw new NegativeValueException(amount); }
            if (amount < Stock) { throw new NotEnoughStockException(Stock, amount); }
            Stock -= amount;
        }


    }
}
