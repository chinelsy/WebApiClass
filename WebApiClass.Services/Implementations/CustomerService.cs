using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiClass.Model.Entities;
using WebApiClass.Services.Interfaces;

namespace WebApiClass.Services.Implementations
{
    public class CustomerService : ICustomerService
    {
        public async Task<Customer> GetCustomerByAccountNumber(string accountNumber)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Customer>> GetCustomersAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<Customer> GetSingleCustomer(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
