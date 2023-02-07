using Retail.Domain;
using Retail.Domain.Exceptions;
using Retail.Repository;
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
        private readonly IRetailRepo _retailRepo;
        public ProductService(IRetailRepo retailRepo) 
        {
            _retailRepo = retailRepo;
        }
        public async Task<IEnumerable<Product>> GetProductsAsync()
        {
            var products = await _retailRepo.GetProductsAsync();
            var returnedProducts = products.Where(x => x.ForSale == true).ToList();
            return await Task.FromResult<IEnumerable<Product>>(returnedProducts);
        }
        public async Task<Product?> GetProductAsync(int productId)
        {
            //return await Task.FromResult(new Product("iPhone 14 Pro", "The latest iPhone", 10, 1000, true, 1));
            var result = await _retailRepo.GetProductAsync(productId);
            return result;
        }

        public async Task AddProductAsync(Product product)
        {
            await _retailRepo.AddProduct(product);
        }

        public async Task UpdateProductAsync(Product product)
        {
            if (product.Id == null)
            {
                throw new ArgumentNullException("Product Id is null");
            }
            var result = await _retailRepo.GetProductAsync(product.Id);
            await _retailRepo.UpdateProduct(product);
        }

        public async Task DeleteProduct(int productId)
        {
            var result = await _retailRepo.GetProductAsync(productId);
            if (result == null)
            {
                throw new ProductNotFoundException(productId);
            }
            await _retailRepo.DeleteProduct(result);
        }

    }
}
