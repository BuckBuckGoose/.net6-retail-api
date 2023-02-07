using Retail.Domain;
using Retail.Domain.Exceptions;

namespace Retail.Domain.Tests
{
    public class ProductTests
    {
        [Fact]
        async public Task AddStockPass()
        {
            //Arrange
            Product product = new Product("Test", "Test desc.", 10, 10, true, 1);

            //Act
            product.AddStock(10);
            product.AddStock(0);

            //Assert
            Assert.Equal(20, product.Stock);

        }

        [Fact]
        async public Task AddStockFail_NegativeValue()
        {
            Product product = new Product("Test", "Test desc.", 10, 10, true, 1);

            Assert.Throws<NegativeValueException>(() => product.AddStock(-10));

        }
    }
}