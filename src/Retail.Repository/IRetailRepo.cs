namespace Retail.Repository
{
    public interface IRetailRepo
    {
        Task<bool> CheckStock(int id);
        Task<int> AddItem(int id, string name, string description);
    }
}