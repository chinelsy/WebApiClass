using System;

namespace WebApiClass.Model.Entities
{
    public class Customer
    {
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
    }
}