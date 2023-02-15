using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retail.Services
{
    public interface IOrderService
    {
        public Task<int> CreateOrder(int[] itemIds);
       
    }
}
