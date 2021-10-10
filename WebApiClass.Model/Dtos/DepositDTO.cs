using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiClass.Model.Dtos
{
    public class DepositDTO
    {
        public string AccountNumber { get; set; }
        public decimal Amount { get; set; }
    }
}
