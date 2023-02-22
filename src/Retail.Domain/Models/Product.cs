using Retail.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retail.Domain.Models
{
    public class Product
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public bool ForSale { get; set; }


        public void AddStock(int amount)
        {
            if (amount == 0) { return; }
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
