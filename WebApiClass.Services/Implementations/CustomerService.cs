using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiClass.Data.Interfaces;
using WebApiClass.Model.Entities;
using WebApiClass.Service.Interfaces;

namespace WebApiClass.Service.Implementations
{
    public class CustomerService : ICustomerService
    {
        private readonly IUnitofWork _unitofWork;
        private readonly IRepository<Customer> _customerRepo;

        public CustomerService(IUnitofWork unitofWork)
        {
            _unitofWork = unitofWork;
            _customerRepo = unitofWork.GetRepository<Customer>();
        }
        public async Task<Customer> GetCustomerByAccountNumber(string accountNumber)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Customer>> GetCustomersAsync()
        {
            return await _customerRepo.GetAllAsync();
        }

        public async Task<Customer> GetSingleCustomer(Guid id)
        {
            return await Task.FromResult(_customerRepo.GetSingleByCondition(x => x.Id == id));
        }
    }
}
