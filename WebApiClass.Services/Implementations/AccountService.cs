using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiClass.Model.Entities;
using WebApiClass.Services.Interfaces;

namespace WebApiClass.Services.Implementations
{
    public class AccountService : IAccountService
    {
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

        public async Task<decimal> Withdraw(string accountNumber, decimal amount)
        {
            throw new NotImplementedException();
        }
    }
}
