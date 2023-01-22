namespace Retail.Domain
{
    public interface IDomainService
    {
        bool DoWork(int number);
        Task<int> CreateOrder();
        Task AddItem
    }
}