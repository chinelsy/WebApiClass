using AutoMapper;
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
    public class AccountService : IAccountService
    {
        private readonly IUnitofWork _unitofWork;
        private readonly IRepository<Account> _accountRepo;
        public readonly IMapper _mapper;
        public AccountService(IUnitofWork unitofWork, IMapper mapper)
        {
            _unitofWork = unitofWork;
            _accountRepo = unitofWork.GetRepository<Account>();
            _mapper = mapper;
        }

        public async Task<bool> Deposit(string accountNumber, decimal amount)
        {
            throw new NotImplementedException();
        }

        public async Task<decimal> GetAccountBalance(string accountNumber)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Account>> GetAccounts()
        {
            throw new NotImplementedException();
        }

        public async Task<ViewAccountDto> GetByAccountNumber(string accountNumber)
        {
            Account customerAccount = _accountRepo.GetByCondition(x => x.Number == accountNumber,includeProperties: "Customers").FirstOrDefault();
            return _mapper.Map<ViewAccountDto>(customerAccount);
        }

        public async Task<decimal> Withdraw(string accountNumber, decimal amount)
        {
            throw new NotImplementedException();
        }
    }
}
