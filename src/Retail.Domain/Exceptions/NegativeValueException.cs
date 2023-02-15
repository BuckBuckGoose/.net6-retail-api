using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retail.Domain.Exceptions
{
    public class NegativeValueException : Exception
    {
        public NegativeValueException(int amount) : base($"The amount cannot be a negative value. Provided: {amount}.")
        {
        }
    }
}
