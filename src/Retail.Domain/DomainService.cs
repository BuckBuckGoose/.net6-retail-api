using Retail.Services;

namespace Retail.Domain
{
    public class DomainService : IDomainService
    {
        private readonly IOrderService _orderService;
        private readonly IInventoryService _inventoryService;
        private readonly IPosService _posService;

        public DomainService(IOrderService orderService, IInventoryService inventoryService, IPosService posService)
        {
            _orderService= orderService;
            _inventoryService= inventoryService;
            _posService= posService;
        }
        public bool DoWork(int number)
        {
            return number > 10 ? true : false;
        }

        public async Task<int> CreateOrder()
        {
            var result = await _orderService.CreateOrder(i);
            return Task.FromResult(result);
        }
    }
}