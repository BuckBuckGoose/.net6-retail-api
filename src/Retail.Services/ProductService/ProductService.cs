using Retail.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retail.Services.ProductService
{
    public class ProductService : IProductService
    {
        public Task<Product> CreateProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            List<Product> products = new List<Product>()
            {
                    new Product("iPhone 14 Pro", "The latest iPhone", 10, 1000, true, 1),
                    new Product("iPhone 14", "The latest iPhone", 10, 900, true, 2)
            };
            return await Task.FromResult<IEnumerable<Product>>(products);
        }

        public Task<Product> GetById(int productId)
        {
            return Task.FromResult(new Product("iPhone 14 Pro", "The latest iPhone", 10, 1000, true, 1));
        }

        public Task<bool> ToggleForSale(Product product)
        {
            throw new NotImplementedException();
        }

        public Task UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
