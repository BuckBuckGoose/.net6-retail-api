using Microsoft.EntityFrameworkCore;
using Retail.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retail.Repository
{
    public class RetailRepo : IRetailRepo
    {
        //private readonly RetailDbContext _context;
        private readonly List<Product> _products;
        public RetailRepo() //RetailDbContext context)
        {
            //_context = context;
            _products = new List<Product>()
            {
                    new Product("iPhone 14 Pro", "The latest iPhone Pro", 10, 1000, true, 1),
                    new Product("iPhone 14", "The latest iPhone", 10, 900, true, 2),
                    new Product("iPhone 1", "The first iPhone", 1, 300, false, 3)
            };
        }

        public async Task<IEnumerable<Product>> GetProductsAsync()
        {
            return await Task.FromResult(_products);
            //return await _context.Products.ToListAsync();
        }

        public async Task<Product?> GetProductAsync(int? productId)
        {
            var result = _products.FirstOrDefault(p => p.Id == productId);
            return await Task.FromResult(result);
            //return await _context.Products.FirstOrDefaultAsync(p => p.Id == productId);
        }

        public async Task AddProduct(Product product)
        {
            _products.Add(product);
            await Task.CompletedTask;

            //await _context.Products.AddAsync(product);
            //await _context.SaveChangesAsync();
        }

        public async Task UpdateProduct(Product product)
        {
            var result = _products.FirstOrDefault(product => product.Id == product.Id);
            result = product;
            await Task.CompletedTask;

            //_context.Products.Update(product);
            //await _context.SaveChangesAsync();
        }

        public async Task DeleteProduct(Product product)
        {
            _products.Remove(product);
            await Task.CompletedTask;

            //_context.Products.Remove(product);
            //await _context.SaveChangesAsync();
        }
    }
}
