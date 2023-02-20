using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retail.Domain.Exceptions
{
    public class NotEnoughStockException : Exception
    {
        public NotEnoughStockException(int stock, int amount) : base($"Unable to remove {amount} when there is only {stock} item(s) left")
        {
        }
    }
}
