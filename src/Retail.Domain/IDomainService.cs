namespace Retail.Domain
{
    public interface IDomain
    {
        bool DoWork(int number);
        Task<int> CreateOrder();
    }
}