using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using WebApiClass.Model.Entities;

namespace WebApiClass.Model.DataSeeding
{
    public class AccountSeeding : IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> builder)
        {
            builder.HasData
                (
                new Account
                {
                    Id = new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"),
                    Number = "3071977856",
                    Balance = 1000000M,
                    CustomerId = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870")
                },
                new Account
                {
                    Id = new Guid("80abbca8-664d-4b20-b5de-024705497d4a"),
                    Number = "3071988856",
                    Balance = 2000000M,
                    CustomerId = new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3")
                },
                new Account
                {
                    Id = new Guid("87cdbca8-924d-43c0-e8de-024705846f7b"),
                    Number = "3079977856",
                    Balance = 5000000M,
                    CustomerId = new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811")
                }
               );
        }
    }
}
