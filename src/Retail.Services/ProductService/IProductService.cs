using Retail.Domain.Models;

namespace Retail.Services
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetAllProductsAsync() ;
        Task<Product?> GetProductAsync(int productId);
        Task AddProductAsync(Product product);
        Task UpdateProductAsync(Product product);
        Task DeleteProduct(int productId);

    }
}
