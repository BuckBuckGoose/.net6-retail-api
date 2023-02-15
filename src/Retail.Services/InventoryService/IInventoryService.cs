using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retail.Services
{
    public interface IInventoryService
    {
        Task<bool> CheckStock(int id);
        Task<bool> CheckStock(int[] ids);
        Task<int> AddItem(int id, string name, string description);
    }
}
