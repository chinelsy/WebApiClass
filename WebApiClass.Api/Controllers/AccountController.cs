using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiClass.Model.Dtos;
using WebApiClass.Service.Interfaces;

namespace WebApiClass.Api.Controllers
{
    [Route("api/accounts")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpPost("/Deposit")]
        public async Task<IActionResult> Deposit(DepositDTO depositDTO)
        {
            if (depositDTO == null)
            {
                return BadRequest("Not Found");
            }
            else
            {
                var amountDposited = await _accountService.Deposit(depositDTO.AccountNumber, depositDTO.Amount);
                return Ok(amountDposited); 
            }

        }
        [HttpPost("/Withdraw")]
        public async Task<IActionResult> Withdraw(WithdrawalDTO withdrawalDTO)
        {
            if(withdrawalDTO == null)
            {
                return BadRequest("Not found");
            }
            else
            {
                var amountWithdrawn = await _accountService.Withdraw(withdrawalDTO.AccountNumber, withdrawalDTO.Amount);
                return Ok(amountWithdrawn);
            }
        }
        [HttpGet]
        public async Task<IActionResult> GetAcccounts()
        {
            var account = _accountService.GetAccounts();
            return Ok(await account);
        }
        [HttpGet("AccountNumber/{accountNumber}")]
        public async Task<IActionResult> GetAccountBalance(string accountNumber)
        {
            return Ok(await _accountService.GetAccountBalance(accountNumber));
        }
    }
}
