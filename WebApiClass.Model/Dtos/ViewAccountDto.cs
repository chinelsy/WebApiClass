using System;

namespace WebApiClass.Model.Dtos
{
    public class ViewAccountDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string AccountNumber { get; set; }
        public decimal AccountBalance { get; set; }
    }
}
