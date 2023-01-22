namespace Retail.Services
{
    public interface IPosService
    {
        Task<bool> Buy(int orderId);
    }
}