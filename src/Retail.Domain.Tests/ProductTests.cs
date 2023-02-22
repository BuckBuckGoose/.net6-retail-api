using Retail.Domain.Exceptions;
using Retail.Domain.Models;

namespace Retail.Domain.Tests
{
    public class ProductTests
    {
        private Product? product;

        [SetUp]
        public void SetUp()
        {
            product = new Product
            {
                Name = "Test",
                Description = "Test desc.",
                Price = 10,
                Stock = 10,
                ForSale = true,
                Id = 1
            };
        }

        [Test]
        public void AddStockPass()
        {
            product.AddStock(10);
            product.AddStock(0);

            Assert.That(product.Stock, Is.EqualTo(20));

        }

        [Test]
        public void AddStockFail_NegativeValue()
        {
            Assert.Throws<NegativeValueException>(() => product.AddStock(-10));

        }
    }
}