using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using WebApiClass.Model.Entities;

namespace WebApiClass.Model.DataSeeding
{
    public class CustomerSeeding : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasData
                 (
                 new Customer
                 {
                    Id = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                    FullName = "Chikki Dike",
                    Email = "chikki@gmail.domain",
                    DateOfBirth = new DateTime(1995, 07, 27),
                    Phone = "08036777722",
                    Address = "United State Of Abakpa",
                    AccountId = new Guid ("86dba8c0-d178-41e7-938c-ed49778fb52a")
                     
                 },
                 new Customer
                 {
                     Id = new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"),
                     FullName = "Lucy Dike",
                     Email = "lucy@gmail.domain",
                     DateOfBirth = new DateTime(1994, 07, 27),
                     Phone = "07036777722",
                     Address = "10 College Road",
                     AccountId = new Guid("80abbca8-664d-4b20-b5de-024705497d4a")
                 },
                 new Customer
                 {
                     Id = new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"),
                     FullName = "Nana Dike",
                     Email = "nana@gmail.domain",
                     DateOfBirth = new DateTime(1993, 07, 27),
                     Phone = "08136777722",
                     Address = "United State Of Olo",
                     AccountId = new Guid("87cdbca8-924d-43c0-e8de-024705846f7b")
                 }
                 );
        }
    }
}
