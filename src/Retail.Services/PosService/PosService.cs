using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retail.Services
{
    public class PosService : IPosService
    {
        public async Task<bool> Buy(int orderId)
        {
            var result = await Task.FromResult(true);
            return result;
        }
    }
}
