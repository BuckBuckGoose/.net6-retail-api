using Retail.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retail.Api.Test.Fixtures
{
    public static class ProductFixture
    {
        public static List<Product> GetTestProducts() =>

            new()
            {
                new Product
                {
                    Id = 1,
                    Name = "Apple",
                    Description = "Granny Smith",
                    Price = 1,
                    Stock = 30,
                    ForSale = true
                },
                new Product
                {
                    Id = 2,
                    Name = "Pasta",
                    Description = "Spaghetti",
                    Price = 5,
                    Stock = 10,
                    ForSale = true
                },
                new Product
                {
                    Id = 1,
                    Name = "Milk",
                    Description = "Skim",
                    Price = 3,
                    Stock = 25,
                    ForSale = true
                },
                new Product
                {
                    Id = 1,
                    Name = "Spoiled Apples",
                    Description = "Rotten",
                    Price = 0,
                    Stock = 25,
                    ForSale = false
                }
            };

        public static Product GetSingleProduct() => new Product
        {
            Id = 1,
            Name = "Apple",
            Description = "Granny Smith",
            Price = 1,
            Stock = 30,
            ForSale = true
        };
    }
}
