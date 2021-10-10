using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;

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
            var account = _accountRepo.GetSingleByCondition(x => x.Number == accountNumber);
            if (account == null) 
            {
                throw new Exception("Account Not Found");
            }
            else
            {
                account.Balance += amount;
                await _unitofWork.SaveChangesAsync();
                return true;
            }
           
        }// account.Balance = account.Balance + amount;

        public async Task<decimal> GetAccountBalance(string accountNumber)
        {
            var account = await Task.FromResult(_accountRepo.GetSingleByCondition(a => a.Number == accountNumber));
            if (account == null)
            {
                return  0;
            }
            else
            {
                return account.Balance;
            }
        } 

        public async Task<IEnumerable<Account>> GetAccounts()//somethig is missing
        {
            return await _accountRepo.GetAllAsync(); 
        }

        public async Task<ViewAccountDto> GetByAccountNumber(string accountNumber)
        {
            Account customerAccount = _accountRepo.GetByCondition(x => x.Number == accountNumber,includeProperties: "Customers").FirstOrDefault();
            return _mapper.Map<ViewAccountDto>(customerAccount);
        }

        public async Task<decimal> Withdraw(string accountNumber, decimal amount)
        {
            var account = _accountRepo.GetSingleByCondition(a => a.Number == accountNumber);
            if (account == null)
            {
                throw new Exception("account not found");
            }
            if(amount > account.Balance)
            {
                return -1; 
            }
            else
            {
                account.Balance -= amount;

                await _unitofWork.SaveChangesAsync();
                return amount;
            }
            
        }
    }
}
