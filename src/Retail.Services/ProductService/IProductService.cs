using Retail.Domain;
namespace Retail.Services.ProductService
{
    public interface IProductService
    {
        Task<Product> CreateProduct(Product product);
        Task<Product> GetById(int productId);
        Task<IEnumerable<Product>> GetAllAsync();
        Task UpdateProduct(Product product);
        Task<bool> ToggleForSale(Product product);

    }
}
