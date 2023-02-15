using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retail.Services
{
    public class OrderService : IOrderService
    {
        public Task<int> CreateOrder(int[] itemIds)
        {
            throw new NotImplementedException();
        }
    }
}
