using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retail.Domain.Exceptions
{
    public class ProductNotFoundException : Exception
    {
        public ProductNotFoundException(int id) 
            : base($"Could not find item with ID {id}") 
        {
            
        }
    }
}
