using System.Collections.Generic;
using System.Threading.Tasks;
using WebApiClass.Model.Dtos;
using WebApiClass.Model.Entities;

namespace WebApiClass.Service.Interfaces
{
    public interface IAccountService
    {
        Task<IEnumerable<Account>> GetAccounts();
        Task<decimal> GetAccountBalance(string accountNumber);
        Task<bool> Deposit(string accountNumber, decimal amount);
        Task<decimal> Withdraw(string accountNumber, decimal amount);
        Task<ViewAccountDto> GetByAccountNumber(string accountNumber);

    }
}
