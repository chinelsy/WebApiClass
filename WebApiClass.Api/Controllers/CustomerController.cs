using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiClass.Model.Entities;
using WebApiClass.Service.Interfaces;

namespace WebApiClass.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet("")]
        [ProducesResponseType(typeof(Customer),200)]
        public async Task<IActionResult> Customers()
        {
            return Ok(await _customerService.GetCustomersAsync());
        }

        [HttpGet("customerAccountDetail")]
        public async Task<IActionResult> AccountDetail(string accountNumber)
        {
            return Ok(await _customerService.GetCustomerByAccountNumber(accountNumber));
        }

    }
}
