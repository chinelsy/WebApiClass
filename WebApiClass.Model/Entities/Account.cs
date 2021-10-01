using System;
using System.ComponentModel.DataAnnotations;

namespace WebApiClass.Model.Entities
{
    public class Account
    {
        public Guid Id { get; set; }
       
        public string Number { get; set; }
        [DataType(DataType.Currency)]
        public decimal Balance { get; set; }
        public Guid CustomerId { get; set; }

        public virtual Customer Customer{ get; set; }
    }
}