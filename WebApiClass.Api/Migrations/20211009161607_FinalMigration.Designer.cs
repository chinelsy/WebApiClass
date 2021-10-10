﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApiClass.Model.Entities;

namespace WebApiClass.Api.Migrations
{
    [DbContext(typeof(WebApiContext))]
    [Migration("20211009161607_FinalMigration")]
    partial class FinalMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApiClass.Model.Entities.Account", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Balance")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Number")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Accounts");

                    b.HasData(
                        new
                        {
                            Id = new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"),
                            Balance = 1000000m,
                            CustomerId = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                            Number = "3071977856"
                        },
                        new
                        {
                            Id = new Guid("80abbca8-664d-4b20-b5de-024705497d4a"),
                            Balance = 2000000m,
                            CustomerId = new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"),
                            Number = "3071988856"
                        },
                        new
                        {
                            Id = new Guid("87cdbca8-924d-43c0-e8de-024705846f7b"),
                            Balance = 5000000m,
                            CustomerId = new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"),
                            Number = "3079977856"
                        });
                });

            modelBuilder.Entity("WebApiClass.Model.Entities.Customer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AccountId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AccountId")
                        .IsUnique();

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            Id = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                            AccountId = new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"),
                            Address = "United State Of Abakpa",
                            DateOfBirth = new DateTime(1995, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "chikki@gmail.domain",
                            FullName = "Chikki Dike",
                            Phone = "08036777722"
                        },
                        new
                        {
                            Id = new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"),
                            AccountId = new Guid("80abbca8-664d-4b20-b5de-024705497d4a"),
                            Address = "10 College Road",
                            DateOfBirth = new DateTime(1994, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "lucy@gmail.domain",
                            FullName = "Lucy Dike",
                            Phone = "07036777722"
                        },
                        new
                        {
                            Id = new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"),
                            AccountId = new Guid("87cdbca8-924d-43c0-e8de-024705846f7b"),
                            Address = "United State Of Olo",
                            DateOfBirth = new DateTime(1993, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "nana@gmail.domain",
                            FullName = "Nana Dike",
                            Phone = "08136777722"
                        });
                });

            modelBuilder.Entity("WebApiClass.Model.Entities.Customer", b =>
                {
                    b.HasOne("WebApiClass.Model.Entities.Account", "Account")
                        .WithOne("Customer")
                        .HasForeignKey("WebApiClass.Model.Entities.Customer", "AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");
                });

            modelBuilder.Entity("WebApiClass.Model.Entities.Account", b =>
                {
                    b.Navigation("Customer");
                });
#pragma warning restore 612, 618
        }
    }
}
