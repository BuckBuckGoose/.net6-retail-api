using NUnit;
using NUnit.Framework;
using Retail.Domain;
using Retail.Domain.Exceptions;

namespace Retail.Domain.Tests
{
    public class ProductTests
    {
        private Product? product;

        [SetUp]
        public void SetUp()
        {
            product = new Product("Test", "Test desc.", 10, 10, true, 1);
        }

        [Test]
        public void AddStockPass()
        {
            //Arrange
            

            //Act
            product.AddStock(10);
            product.AddStock(0);

            //Assert
            Assert.That(product.Stock, Is.EqualTo(20));

        }

        [Test]
        public void AddStockFail_NegativeValue()
        {

            Assert.Throws<NegativeValueException>(() => product.AddStock(-10));

        }
    }
}