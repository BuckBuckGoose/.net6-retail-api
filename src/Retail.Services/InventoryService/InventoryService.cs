using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retail.Services
{
    public class InventoryService : IInventoryService
    {
        public Task<int> AddItem(int id, string name, string description)
        {
            throw new NotImplementedException();
        }

        public Task<bool> CheckStock(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> CheckStock(int[] ids)
        {
            throw new NotImplementedException();
        }
    }
}
