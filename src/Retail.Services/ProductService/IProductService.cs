using Retail.Domain;
namespace Retail.Services.ProductService
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetProductsAsync() ;
        Task<Product?> GetProductAsync(int productId);
        Task AddProductAsync(Product product);
        Task UpdateProductAsync(Product product);
        Task DeleteProduct(int productId);

    }
}
