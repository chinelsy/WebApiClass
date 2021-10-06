using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiClass.Data.Interfaces;
using WebApiClass.Model.Dtos;
using WebApiClass.Model.Entities;
using WebApiClass.Service.Interfaces;

namespace WebApiClass.Service.Implementations
{
    public class CustomerService : ICustomerService
    {
        private readonly IUnitofWork _unitofWork;
        private readonly IServiceFactory _serviceFactory;
        private readonly IRepository<Customer> _customerRepo;
        

        public CustomerService(IUnitofWork unitofWork, IServiceFactory serviceFactory)
        {
            _unitofWork = unitofWork;
            _serviceFactory = serviceFactory;
            _customerRepo = unitofWork.GetRepository<Customer>();
        }
        public async Task<ViewAccountDto> GetCustomerByAccountNumber(string accountNumber)
        {
            IAccountService accountService = _serviceFactory.GetServices<IAccountService>();
            var accountDetail = await  accountService.GetByAccountNumber(accountNumber);

            return accountDetail;
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
