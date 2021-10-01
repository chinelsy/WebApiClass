using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiClass.Model.Entities;

namespace WebApiClass.Services.Interfaces
{
    public interface IAccountService
    {
        Task<IEnumerable<Account>> GetAccounts();
        Task<decimal> GetAccountBalance(string accountNumber);
        Task<bool> Deposit(string accountNumber, decimal amount);
        Task<decimal> Withdraw(string accountNumber, decimal amount);

    }
}
