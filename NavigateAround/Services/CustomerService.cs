using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NavigateAround.Services
{
    public class CustomerService
    {
        private Customer[] _customers = new Customer[]
        {
            new Customer { CustomerId = 10000, CustomerName = "Marvin Klein" },
            new Customer { CustomerId = 20000, CustomerName = "John Doe" },
            new Customer { CustomerId = 30000, CustomerName = "Doe John" },
            new Customer { CustomerId = 40000, CustomerName = "Lorem Ipsum" },
            new Customer { CustomerId = 50000, CustomerName = "Dolor sit amet" },
        };
        public async Task<Customer?> GetCustomerAsync(int customerId)
        {

            var searchCustomer = _customers.Where(x => x.CustomerId == customerId).FirstOrDefault();
            // The customer will be loaded from a database which takes around 200ms. There are multiple queries here which get awaited.
            await Task.Delay(200);
            return searchCustomer;
        }
    }
}
